namespace Scripter;

public record ProjectDTO(
    string RepoFolder
    , string ProjFolder
    , List<ProjectDTO>? Dependencies = default
    , bool IsApp = false);