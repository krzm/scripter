namespace Scripter;

public class ScriptParam 
    : IScriptParam
{
    private const string RootPath = @"C:\kmazanek@gmail.com";
    private const string CodeFolder = "Code";
    private const string VersionFile = "Version.xml";

    public ProjectDTO? Project { get; set; }

    public string VersionFileName => VersionFile;

    public string CodePath => Path.Combine(RootPath, CodeFolder);

    public string BuildPath => @"C:\kmazanek@gmail.com\Build";

    public string RepoPath
    {
        get
        {
            ArgumentNullException.ThrowIfNull(Project);
            return Path.Combine(
                RootPath
                , CodeFolder
                , Project.RepoFolder);
        }
    }

    public string ScriptPath => @"C:\kmazanek@gmail.com\Build.Script";

    public string CloneUrlStart => @"https://github.com/krzm/";
    
    public string CloneUrlEnd => ".git";
    
    public string CloneUrl
    {
        get
        {
            ArgumentNullException.ThrowIfNull(Project);
            return Path.Combine(
                CloneUrlStart
                , Project.RepoFolder + CloneUrlEnd);
        }
    }
}