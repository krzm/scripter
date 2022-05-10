using System.Collections.Generic;

namespace Scripter.Lib.Tests;

public class CopyScriptData
{
    private const string RootPath = @"C:\kmazanek@gmail.com";
    private const string BuildPath = @$"{RootPath}\Build";
    private const string CodePath = @$"{RootPath}\Code";
    private const string RepoFolder = "cli-helper";
    private const string RepoBuildPath = @$"{BuildPath}\{RepoFolder}";
    private const string AppProjFolder = "CLIHelper";
    private const string AppBuildPath = $@"{RepoBuildPath}\{AppProjFolder}";  
    private const string SourcePath = @$"{CodePath}\{RepoFolder}\{AppProjFolder}\bin\Release\net6.0\publish\*";

    public static IEnumerable<object[]> Data =>
        new List<object[]>
        {
            new object[] { 0, $"$path = \"{RepoBuildPath}\"" }
            , new object[] { 1, "if (-not (Test-Path $path))" }
            , new object[] { 2, "{" }
            , new object[] { 3, $"New-Item -Path \"{BuildPath}\" -Name \"{RepoFolder}\" -ItemType \"directory\"" }
            , new object[] { 4, "}" }
            , new object[] { 5, $"$path = \"{AppBuildPath}\"" }
            , new object[] { 6, "if (-not (Test-Path $path))" }
            , new object[] { 7, "{" }
            , new object[] { 8, $"New-Item -Path \"{RepoBuildPath}\" -Name \"{AppProjFolder}\" -ItemType \"directory\"" }
            , new object[] { 9, "}" }
            , new object[] { 10, "else" }
            , new object[] { 11, "{" }
            , new object[] { 12, $"Remove-Item \"{AppBuildPath}\\*\" -Recurse" }
            , new object[] { 13, "}" }
            , new object[] { 14, $"Copy-Item -Path \"{SourcePath}\" -Destination \"{AppBuildPath}\" -Recurse" }
        };
}