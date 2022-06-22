namespace Scripter.Data.Helper;

public record ProjectDTO(
    string RepoFolder
    , string ProjFolder
    , List<ProjectDTO>? Dependencies = default
    , bool IsApp = false
    , bool IsWpf = false
    , DateOnly LastCheck = default
    , List<ProjectDTO>? Tests = default);