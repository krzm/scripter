namespace Scripter;

public class AppData : LibData
{
    protected override void SetApps()
    {
        SetScripter();
        SetModernInventory();
        SetAppStarter();
        SetDiyBox();
    }

    private void SetScripter()
    {
        Scripter = Set(
            "scripter", "Scripter"
            , DataToTable, CommandDotNetUnity, DIHelper, CommandDotNetHelper);
    }

    private void SetModernInventory()
    {
        InventoryData = Set(
            "inventory-data", "Inventory.Data"
            , ModelHelper, EFCoreHelper);
        InventoryModernLib = Set(
            "inventory-modern-lib", "Inventory.Modern.Lib"
            , ModelHelper, EFCoreHelper, DotNetExtension, CLIHelper
            , DataToTable, CRUDCommandHelper, InventoryData);
        InventoryModernConsoleApp = Set(
            "inventory-modern-consoleapp", "Inventory.Modern.ConsoleApp"
            , ModelHelper, EFCoreHelper, DataToTable, DIHelper
            , CommandDotNetHelper, CRUDCommandHelper, InventoryData, InventoryModernLib);
    }  

    private void SetAppStarter()
    {
        AppStarterData = Set(
            "app-starter", "AppStarter.Data"
            , ModelHelper, EFCoreHelper);
        AppStarterModernLib = Set(
            "app-starter", "AppStarter.Lib"
            , ModelHelper, EFCoreHelper, DotNetExtension, CLIHelper
            , CLIReader, DotNetTool, DIHelper, DataToTable
            , CommandDotNetHelper, CRUDCommandHelper, CLIFramework, AppStarterData);
        AppStarterConsoleApp = Set(
            "app-starter", "AppStarter.ConsoleApp"
            , ModelHelper, EFCoreHelper, DotNetExtension, CLIHelper
            , CLIReader, DotNetTool, DIHelper, DataToTable
            , CommandDotNetHelper, CRUDCommandHelper, CLIFramework, AppStarterData
            , AppStarterModernLib);
    }  

    private void SetDiyBox()
    {
        DiyBoxCore = Set(
            "diy-box", "DiyBox.Core"
            , CLIFramework);
        DiyBoxConsoleApp = Set(
            "diy-box", "DiyBox.ConsoleApp"
            , DIHelper, CommandDotNetHelper, CLIFramework);
    }  
}