namespace Scripter.Lib.Tests;

public record ParamsMockData
(
    string RepoFolder = "cli-helper"
    , string AppProjFolder = "CLIHelper"
    , string VersionFileName = "Version.xml"
    , string RootPath = @"C:\kmazanek@gmail.com"
    , string CodeFolder = "Code"
    , string CodePath = @"C:\kmazanek@gmail.com\Code"
    , string BuildPath = @"C:\kmazanek@gmail.com\Build"
    , string RepoPath = @"C:\kmazanek@gmail.com\Code\cli-helper"
    , string ScriptPath = @"C:\kmazanek@gmail.com\Build.Script"
    , bool IsApp = false
);