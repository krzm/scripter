using System.Windows.Input;
using DIHelper.Unity;
using Scripter.Lib;
using Unity;
using Unity.Injection;

namespace Scripter;

public class AppCommands 
    : UnityDependencySet
{
    public AppCommands(
        IUnityContainer container) 
        : base(container)
    {
    }

    public override void Register()
    {
        SetJoinable();
        SetProjectBuildAll();
        SetLogBuildAll();
        SetInventoryBuildAll();
        Container.RegisterSingleton<IBuildAll, BuildAllScript>(
            new InjectionConstructor(
                Container.Resolve<IProjectList>()
                , new BuildAllDTO("BuildAll.ps1")));
        Container.RegisterSingleton<ICommand, ScriptCommand>();
    }

    private void SetJoinable()
    {
        Container.RegisterSingleton<IScriptParam, ScriptParam>();

        Container.RegisterSingleton<IScript, CompileScript>(nameof(CompileScript));
        Container.RegisterSingleton<IScript, VersionScript>(nameof(VersionScript));
        Container.RegisterSingleton<IScript, CopyScript>(nameof(CopyScript));
        Container.RegisterSingleton<IScript, CopyAppScript>(nameof(CopyAppScript));
        Container.RegisterSingleton<IScript, BuildScript>(nameof(BuildScript));
    }

    private void SetProjectBuildAll()
    {
        RegisterProjBuildAll<ScripterData>(
            "Scripter.BuildAll.ps1"
            , "Scripter");
        RegisterProjBuildAll<AppStarterData>(
            "AppStarter.BuildAll.ps1"
            , "AppStarter.ConsoleApp");
        RegisterProjBuildAll<DiyBoxData>(
            "DiyBox.BuildAll.ps1"
            , "DiyBox.ConsoleApp");
        RegisterProjBuildAll<GameData>(
            "GameData.BuildAll.ps1"
            , "GameData.ConsoleApp");
    }

    private void RegisterProjBuildAll<TData>(
        string scriptfileName
        , string project)
            where TData : ICodeData
    {
        Container.RegisterSingleton<IProjBuildAll, ProjBuildAllScript>(
            $"{project}BuildAllScript"
            , new InjectionConstructor(
                Container.Resolve<IProjectExtractor>()
                , Container.Resolve<ICodeData>(typeof(TData).Name)
                , new ProjBuildAllDTO(scriptfileName, project)));
    }

    private void SetLogBuildAll()
    {
        RegisterProjBuildAll<ConsoleLogData>(
            "ConsoleLibLog.BuildAll.ps1"
            , "Log.ConsoleApp");
        RegisterProjBuildAll<ModernMDILogData>(
            "ModernMDILog.BuildAll.ps1"
            , "Log.Modern.MDI.ConsoleApp");
        RegisterProjBuildAll<ModernWizardLogData>(
            "ModernLogWizard.BuildAll.ps1"
            , "Log.Modern.Wizard.ConsoleApp");
        RegisterProjBuildAll<ModernLogData>(
            "ModernLog.BuildAll.ps1"
            , "Log.Modern.ConsoleApp");
    }

    private void SetInventoryBuildAll()
    {
        RegisterProjBuildAll<ConsoleInventoryData>(
            "ConsoleLibInventory.BuildAll.ps1"
            , "Inventory.ConsoleLib.ConsoleApp");
        RegisterProjBuildAll<ModernInventoryData>(
            "ModernInventory.BuildAll.ps1"
            , "Inventory.Modern.ConsoleApp");
    }   
}