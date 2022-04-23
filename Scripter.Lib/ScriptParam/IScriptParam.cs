namespace Scripter;

public interface IScriptParam
{
    ProjectDTO? Project { get; set; }

    string VersionFileName { get; }

    string CodePath { get; }

    string BuildPath { get; }

    string RepoPath { get; }
        
    string ScriptPath { get; }

    string CloneUrlStart { get; }

    string CloneUrlEnd { get; }

    string CloneUrl { get; }
}