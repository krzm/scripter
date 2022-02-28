namespace Scripter;

public abstract class ProjBuildAllScript 
    : BuildAllBase
        , IProjBuildAll
{
    private readonly IProjectExtractor projectExtractor;
    private readonly ICodeData codeData;

    public abstract string Project { get; }

    public ProjBuildAllScript(
        IProjectExtractor projectExtractor
        , ICodeData codeData)
    {
        this.projectExtractor = projectExtractor;
        this.codeData = codeData;
    }

    public override string[] GetScript()
    {
        Script = new List<string>();
        var app = codeData[Project];
        if (app == null) 
            throw new ArgumentException($"{app} not found");
        projectExtractor.ExtractProjects(app);
        foreach (var project in projectExtractor.Projects)
        {
            AddLine(project);    
        }
        return Script.ToArray();
    }
}