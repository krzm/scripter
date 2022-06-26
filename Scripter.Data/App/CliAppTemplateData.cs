namespace Scripter.Data;

public class CliAppTemplateData 
    : ManyRefLibData
{
    protected override void SetAllData()
    {
        base.SetAllData();
        ArgumentNullException.ThrowIfNull(DIHelper);
        ArgumentNullException.ThrowIfNull(ConfigWrapper);
        ArgumentNullException.ThrowIfNull(CommandDotNetHelper);
        ArgumentNullException.ThrowIfNull(CommandDotNetIoCUnity);
        ArgumentNullException.ThrowIfNull(CommandDotNetUnityHelper);
        ArgumentNullException.ThrowIfNull(SerilogWrapper);
        Set(
            "modern-cli-app-template"
            , "CLI.App.Template"
            , new DateOnly(2022, 6, 26)
            , DIHelper
            , ConfigWrapper
            , CommandDotNetHelper
            , CommandDotNetUnityHelper
            , SerilogWrapper
            );
    }
}