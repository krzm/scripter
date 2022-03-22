namespace Scripter;

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