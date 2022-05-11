using Scripter.Data.Helper;

namespace Scripter.Lib;

public interface IProjDataValidatorBase
{
    bool Validate(ProjectDTO project);
}