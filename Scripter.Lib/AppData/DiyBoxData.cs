namespace Scripter;

public class DiyBoxData 
    : ManyRefLibData
{
    private ProjectDTO? diyBoxCore;
    private ProjectDTO? diyBoxCLIApp;

    protected override void SetAllData()
    {
        base.SetAllData();
        SetDiyBox();
    }
    
    private void SetDiyBox()
    {
        ArgumentNullException.ThrowIfNull(CLIFramework);
        ArgumentNullException.ThrowIfNull(DIHelper);
        ArgumentNullException.ThrowIfNull(CommandDotNetUnityHelper);
        diyBoxCore = Set(
            "diy-box"
            , "DiyBox.Core"
            , new DateOnly()
            , CLIFramework);

        diyBoxCLIApp = Set(
            "diy-box"
            , "DiyBox.ConsoleApp"
            , true
            , new DateOnly()
            , DIHelper
            , CommandDotNetUnityHelper
            , CLIFramework);
    }
}
