using Scripter.Data.Helper;

namespace Scripter.Data;

public class IndependantLibData 
    : CodeData
{
    protected ProjectDTO? EFCoreHelper;
    protected ProjectDTO? DIHelper;
    protected ProjectDTO? DotNetExtension;
    protected ProjectDTO? DotNetTool;
    protected ProjectDTO? Vector2;
    
    protected override void SetAllData()
    {
        EFCoreHelper = Set(
            "efcore-helper"
            , "EFCoreHelper"
            , new DateOnly(2022, 3, 16));
        DIHelper = Set(
            "di-helper"
            , "DIHelper"
            , new DateOnly(2022, 3, 16));
        DotNetExtension = Set(
            "dotnet-extension"
            , "DotNetExtension"
            , new DateOnly(2022, 3, 16));
        DotNetTool = Set(
            "dotnet-tool"
            , "DotNetTool"
            , new DateOnly(2022, 3, 16));
        Vector2 = Set(
            "vector-lib"
            , "Vector.Lib"
            , new DateOnly(2022, 5, 7));
    }
}