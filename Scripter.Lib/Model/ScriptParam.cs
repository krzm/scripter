namespace Scripter;

public class ScriptParam : IScriptParam
{
    public string? ProjectName { get; set; }

    public string VersionFileName => "Version.xml";

    public string ScriptPath => @$"{PowerShell}\Build";

    public string BuildPath => @$"{Root}\Apps";

    public string RepoPath => @$"{Code}\{ProjectName}";

    private static string PowerShell => @$"{Code}\PowerShell";

    private static string Code => @$"{Root}\Code";

    private static string Root => @"C:\kmazanek@gmail.com";
}