using Scripter.Data.Helper;

namespace Scripter.Data;

public class CommanderData 
    : CodeData
{
    protected override void SetAllData()
    {
        Set(
            "commander"
            , "Commander"
            , true
            , new DateOnly(2022, 3, 21));
    }
}