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
        SetData();
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

    private void SetData()
    {
        Container.RegisterSingleton<ICodeData, LibData>(nameof(LibData));
        Container.RegisterSingleton<ICodeData, AppData>(nameof(AppData));
        Container.RegisterSingleton<ICodeData, LogData>(nameof(LogData));
        Container.RegisterSingleton<ICodeData, InventoryData>(nameof(InventoryData));

        Container.RegisterType<IProjectExtractor, ProjectExtractor>();
        
        Container.RegisterSingleton<IProjectList, ProjectList>();
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
        RegisterProjBuildAll<AppData>(
            "Scripter.BuildAll.ps1"
            , "Scripter");
        RegisterProjBuildAll<AppData>(
            "AppStarter.BuildAll.ps1"
            , "AppStarter.ConsoleApp");
        RegisterProjBuildAll<AppData>(
            "DiyBox.BuildAll.ps1"
            , "DiyBox.ConsoleApp");
        RegisterProjBuildAll<AppData>(
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
        RegisterProjBuildAll<LogData>(
            "ConsoleLibLog.BuildAll.ps1"
            , "Log.ConsoleApp");
        RegisterProjBuildAll<LogData>(
            "ModernMDILog.BuildAll.ps1"
            , "Log.Modern.MDI.ConsoleApp");
        RegisterProjBuildAll<LogData>(
            "ModernLogWizard.BuildAll.ps1"
            , "Log.Modern.Wizard.ConsoleApp");
        RegisterProjBuildAll<LogData>(
            "ModernLog.BuildAll.ps1"
            , "Log.Modern.ConsoleApp");
    }

    private void SetInventoryBuildAll()
    {
        RegisterProjBuildAll<InventoryData>(
            "ConsoleLibInventory.BuildAll.ps1"
            , "Inventory.ConsoleLib.ConsoleApp");
        RegisterProjBuildAll<InventoryData>(
            "ModernInventory.BuildAll.ps1"
            , "Inventory.Modern.ConsoleApp");
    }   
}