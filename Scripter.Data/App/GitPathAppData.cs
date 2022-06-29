namespace Scripter.Data;

public class GitPathAppData 
    : ManyRefLibData
{
    protected override void SetAllData()
    {
        var lastUpd = new DateOnly(2022, 6, 29);
        ArgumentNullException.ThrowIfNull(DIHelper);
        SetProjectDepsAndTests(
            "git-path"
            , "GitPath.ConsoleApp"
            , isApp: true
            , lastUpd
            , SetTests("GitPath.Tests")
            , DIHelper);
    }
}