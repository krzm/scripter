namespace Scripter;

public class LibAData 
    : CodeData
{
    protected ProjectDTO? EFCoreHelper;
    protected ProjectDTO? DIHelper;
    protected ProjectDTO? DotNetExtension;
    protected ProjectDTO? DotNetTool;
    protected ProjectDTO? ModelHelper;
    
    protected override void SetAllData()
    {
        EFCoreHelper = Set(
            "efcore-helper"
            , "EFCoreHelper"
            , new DateOnly(2022, 03, 16));
        DIHelper = Set(
            "di-helper"
            , "DIHelper"
            , new DateOnly(2022, 03, 16));
        DotNetExtension = Set(
            "dotnet-extension"
            , "DotNetExtension"
            , new DateOnly(2022, 03, 16));
        DotNetTool = Set(
            "dotnet-tool"
            , "DotNetTool"
            , new DateOnly(2022, 03, 16));
        ModelHelper = Set(
            "model-helper"
            , "ModelHelper"
            , new DateOnly(2022, 03, 16));
    }
}