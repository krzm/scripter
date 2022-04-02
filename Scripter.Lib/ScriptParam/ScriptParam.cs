namespace Scripter;

public class ScriptParam : IScriptParam
{
    private const string RootPath = @"C:\kmazanek@gmail.com";

    private const string CodeFolder = "Code";

    private const string VersionFile = "Version.xml";

    public ProjectDTO? Project { get; set; }

    public string VersionFileName => VersionFile;

    public string ScriptPath => @"C:\kmazanek@gmail.com\Build.Script";

    public string BuildPath => @"C:\kmazanek@gmail.com\Build";

    public string RepoPath
    {
        get
        {
            ArgumentNullException.ThrowIfNull(Project);
            return Path.Combine(RootPath, CodeFolder, Project.RepoFolder);
        }
    }
}