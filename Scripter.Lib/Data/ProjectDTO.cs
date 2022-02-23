namespace Scripter;

public record ProjectDTO(
    string RepoFolder
    , string AppProjFolder
    , List<ProjectDTO>? Dependencies = default);