namespace Scripter;

public class BuildAllScript 
    : BuildAllBase
{
    private readonly List<ICodeData> codedata;

    public BuildAllScript(List<ICodeData> codedata)
    {
        this.codedata = codedata;
    }

    public override string File => "BuildAll.ps1";

    public override string[] GetScript()
    {
        Script = new List<string>();
        foreach (var data in codedata)
        {
            foreach (var projData in data.Values)
            {
                SelectScript(projData);
            }
        }
        return Script.ToArray();
    }
}