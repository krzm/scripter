namespace Scripter;

public class ScriptVariables : IScriptVariables
{
    private readonly string projectName;

    public ScriptVariables(string projectName)
    {
        if (string.IsNullOrWhiteSpace(projectName))
            throw new ArgumentNullException(nameof(projectName));

        this.projectName = projectName;
    }

    public string ProjectName => projectName;

    public string VersionFileName => "Version.xml";

    public string ScriptPath => @$"{PowerShell}\{projectName}";

    public string BuildPath => @$"{Root}\Apps";

    public string RepoPath => @$"{Code}\{projectName}";

    private static string PowerShell => @$"{Code}\PowerShell";

    private static string Code => @$"{Root}\Code";

    private static string Root => @"C:\kmazanek@gmail.com";
}