namespace Scripter;

public abstract class ProjBuildAllScript 
    : BuildAllBase
        , IProjBuildAll
{
    private readonly ICodeData appData;

    public abstract string Project { get; }

    public ProjBuildAllScript(ICodeData appData)
    {
        this.appData = appData;
    }

    public override string[] GetScript()
    {
        Script = new List<string>();
        var project = appData[Project];
        if (project == null) 
            throw new ArgumentException($"{project} not found");
        SelectScript(project);
        return Script.ToArray();
    }
}