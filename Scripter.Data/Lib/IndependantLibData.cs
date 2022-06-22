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
    protected ProjectDTO? XmlGenerator;
    
    protected override void SetAllData()
    {
        EFCoreHelper = Set(
            "efcore-helper"
            , "EFCore.Helper"
            , new DateOnly(2022, 5, 26));
        DIHelper = SetProjAndTests(
            "di-helper"
            , "DIHelper"
            , new DateOnly(2022, 3, 16)
            , SetTest("DIHelper.Tests"));
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
        XmlGenerator = Set(
            "xml-generator"
            , "Xml.Generator"
            , new DateOnly(2022, 5, 14));
    }
}