namespace Scripter;

public interface IModernLogBuild
{
    ProjectDTO App { get; }
    List<ProjectDTO> Libs { get; }
}
