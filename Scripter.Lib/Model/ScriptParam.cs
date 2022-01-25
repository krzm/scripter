namespace Scripter;

public class ScriptParam : IScriptParam
{
    private const string RootPath = @"C:\kmazanek@gmail.com";

    private const string AppsFolder = "Apps";

    private const string CodeFolder = "Code";

    private const string PowerShellFolder = "PowerShell";

    private const string BuildFolder = "Build";

    private const string VersionFileNameConst = "Version.xml";

    public ProjectDTO? Project { get; set; }

    public string VersionFileName => VersionFileNameConst;

    public string ScriptPath => Path.Combine(RootPath, CodeFolder, PowerShellFolder, BuildFolder);

    public string BuildPath => Path.Combine(RootPath, AppsFolder);

    public string RepoPath => Path.Combine(RootPath, CodeFolder, Project.RepoFolder);
}