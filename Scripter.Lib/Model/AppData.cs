namespace Scripter;

public class AppData : LibData
{
    protected override void SetApps()
    {
        SetScripter();
        SetModernLog();
    }

    private void SetScripter()
    {
        Scripter = Set(
            "scripter", "Scripter"
            , DataToTable, CommandDotNetUnity, DIHelper, CommandDotNetHelper);
    }

    private void SetModernLog()
    {
        LogData = Set(
            "log-data", "Log.Data"
            , ModelHelper, EFCoreHelper);
        LogModernLib = Set(
            "log-modern-lib", "Log.Modern.Lib"
            , ModelHelper, EFCoreHelper, DotNetExtension, CliHelper
            , DataToTable, CrudCommandHelper, LogData);
        LogModernConsoleApp = Set(
            "log-modern-consoleapp", "Log.Modern.ConsoleApp"
            , ModelHelper, EFCoreHelper, DataToTable, DIHelper
            , CommandDotNetHelper, CrudCommandHelper, LogData, LogModernLib);
    }  
}