namespace Scripter;

public interface IScriptParam
{
    string? ProjectName { get; set; }

    string VersionFileName { get; }

    string BuildPath { get; }

    string RepoPath { get; }
        
    string ScriptPath { get; }
}