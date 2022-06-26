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
            , isApp: true
            , new DateOnly(2022, 6, 26));
    }
}