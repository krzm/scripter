namespace Scripter;

public interface IScriptParam
{
    ProjectDTO? Project { get; set; }

    string VersionFileName { get; }

    string BuildPath { get; }

    string RepoPath { get; }
        
    string ScriptPath { get; }
}