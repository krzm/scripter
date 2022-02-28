namespace Scripter;

public class BuildAllScript 
    : BuildAllBase
{
    private readonly IProjectList projectList;

    public BuildAllScript(
        IProjectList projectList)
    {
        this.projectList = projectList;
    }

    public override string File => "BuildAll.ps1";

    public override string[] GetScript()
    {
        Script = new List<string>();
        foreach (var project in projectList.Projects)
        {
            AddLine(project);
        }
        return Script.ToArray();
    }
}