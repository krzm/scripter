namespace Scripter.Inventory;

public class ModernAppData 
    : ModernLibData
{
    private ProjectDTO? modernCLIApp;

    protected override void SetAllData()
    {
        base.SetAllData();
        SetModern();
    }

    private void SetModern()
    {
        ArgumentNullException.ThrowIfNull(EFCoreHelper);
        ArgumentNullException.ThrowIfNull(DIHelper);
        ArgumentNullException.ThrowIfNull(CLIHelper);
        ArgumentNullException.ThrowIfNull(DotNetExtension);
        ArgumentNullException.ThrowIfNull(ConfigWrapper);
        ArgumentNullException.ThrowIfNull(ModelHelper);
        ArgumentNullException.ThrowIfNull(DataToTable);
        ArgumentNullException.ThrowIfNull(CommandDotNetHelper);
        ArgumentNullException.ThrowIfNull(CommandDotNetIoCUnity);
        ArgumentNullException.ThrowIfNull(CommandDotNetUnityHelper);
        ArgumentNullException.ThrowIfNull(SerilogWrapper);
        ArgumentNullException.ThrowIfNull(CRUDCommandHelper);
        ArgumentNullException.ThrowIfNull(DataLib);
        ArgumentNullException.ThrowIfNull(TableLib);
        ArgumentNullException.ThrowIfNull(ModernLib);
        modernCLIApp = Set(
            "inventory-modern-consoleapp"
            , "Inventory.Modern.ConsoleApp"
            , true
            , new DateOnly(2022, 4, 9)
            , EFCoreHelper
            , DIHelper
            , CLIHelper
            , DotNetExtension
            , ConfigWrapper
            , ModelHelper
            , DataToTable
            , CommandDotNetHelper
            , CommandDotNetIoCUnity
            , CommandDotNetUnityHelper
            , SerilogWrapper
            , CRUDCommandHelper
            , DataLib
            , TableLib
            , ModernLib
            );
    }
}