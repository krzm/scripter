namespace Scripter;

public interface IScriptVariables
{
    string ProjectName { get; }

    string VersionFileName { get; }

    string BuildPath { get; }

    string RepoPath { get; }
        
    string ScriptPath { get; }
}