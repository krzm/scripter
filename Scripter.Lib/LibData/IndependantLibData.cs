namespace Scripter;

public class IndependantLibData 
    : CodeData
{
    protected ProjectDTO? EFCoreHelper;
    protected ProjectDTO? DIHelper;
    protected ProjectDTO? DotNetExtension;
    protected ProjectDTO? DotNetTool;
    
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
    }
}