namespace Scripter;

public class LibAData 
    : CodeData
{
    protected ProjectDTO? ModelHelper;
    protected ProjectDTO? EFCoreHelper;
    protected ProjectDTO? DotNetExtension;
    protected ProjectDTO? DotNetTool;
    
    protected override void SetAllData()
    {
        ModelHelper = Set(
            "model-helper"
            , "ModelHelper");
        EFCoreHelper = Set(
            "efcore-helper"
            , "EFCoreHelper");
        DotNetExtension = Set(
            "dotnet-extension"
            , "DotNetExtension");
        DotNetTool = Set(
            "dotnet-tool"
            , "DotNetTool");
    }
}