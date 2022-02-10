namespace Scripter;

public class ModernLogData 
    : List<ProjectDTO>
        , IModernLogData
{
    private readonly ICodeData codeData;

    public ModernLogData(ICodeData codeData)
    {
        this.codeData = codeData;
        Add(codeData["Log.Data"]);
        Add(codeData["Log.Modern.Lib"]);
        Add(codeData["Log.Modern.ConsoleApp"]);
    }
}