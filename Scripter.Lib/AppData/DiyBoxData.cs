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
        diyBoxCore = Set(
            "diy-box"
            , "DiyBox.Core"
            , new DateOnly(2022, 4, 5)
            , CLIFramework);
        ArgumentNullException.ThrowIfNull(DIHelper);
        ArgumentNullException.ThrowIfNull(ConfigWrapper);
        ArgumentNullException.ThrowIfNull(SerilogWrapper);
        diyBoxCLIApp = Set(
            "diy-box"
            , "DiyBox.ConsoleApp"
            , true
            , new DateOnly(2022, 4, 5)
            , DIHelper
            , ConfigWrapper
            , SerilogWrapper
            , CLIFramework);
    }
}