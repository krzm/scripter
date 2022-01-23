using System;

namespace Scripter.Lib.Tests;

public abstract class ScriptParamTestBase
{
    public abstract void TestScriptParamContent(
        string propName
        , string expected);

    protected IScriptParam GetSut()
    {
        return new ScriptParam
        {
            ProjectName = "Log.Modern.ConsoleApp"
        };
    }

    protected string SelectProp(
        IScriptParam scriptParam
        , string name)
    {
        switch(name)
        {
            case nameof(ScriptParam.ProjectName):
                return scriptParam.ProjectName;
            case nameof(ScriptParam.BuildPath):
                return scriptParam.BuildPath;
            case nameof(ScriptParam.RepoPath):
                return scriptParam.RepoPath;
            case nameof(ScriptParam.ScriptPath):
                return scriptParam.ScriptPath;
            case nameof(ScriptParam.VersionFileName):
                return scriptParam.VersionFileName;
        }
        throw new Exception($"{nameof(SelectProp)} problem");
    }
}