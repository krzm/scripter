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
        var lastUpd = new DateOnly(2022, 6, 29);
        EFCoreHelper = Set(
            "efcore-helper"
            , "EFCore.Helper"
            , lastUpd);
        DIHelper = SetProjAndTests(
            "di-helper"
            , "DIHelper"
            , lastUpd
            , SetTest("DIHelper.Tests"));
        DotNetExtension = SetProjAndTests(
            "dotnet-extension"
            , "DotNetExtension"
            , lastUpd
            , SetTest("DotNetExtension.Tests"));
        DotNetTool = Set(
            "dotnet-tool"
            , "DotNetTool"
            , lastUpd);
        Vector2 = SetProjAndTests(
            "vector-lib"
            , "Vector.Lib"
            , lastUpd
            , SetTest("Vector.Lib.Tests"));
        XmlGenerator = SetProjAndTests(
            "xml-generator"
            , "Xml.Generator"
            , lastUpd
            , SetTest("Xml.Generator.Tests"));
        var wpfHelper = Set(
            "wpf-helper"
            , "WpfHelper"
            , isApp: false
            , isWpf: true
            , lastUpd);
        var unityTests = SetProjAndTests(
            "unitycontainer-examples"
            , "UnityContainer.Tests"
            , lastUpd
            , SetTest("UnityContainer.Tests"));
        var pattern = Set(
            "pattern"
            , "Pattern"
            , lastUpd);
        var netExamples = SetProjAndTests(
            "dotnet-examples"
            , "Net.Examples"
            , lastUpd
            , SetTest("Net.Tests"));
    }
}