using Scripter.Data.Helper;

namespace Scripter.Lib;

public abstract class ProjDataValidatorBase
    : IProjDataValidatorBase
{
    public abstract bool Validate(ProjectDTO project);
}