namespace Scripter;

public class MicroservicesData 
    : CodeData
{
    protected override void SetAllData()
    {
        Set(
            "microservices"
            , "CommandsService"
            , true
            , new DateOnly(2022, 4, 16));
         Set(
            "microservices"
            , "PlatformService"
            , true
            , new DateOnly(2022, 4, 16));
    }
}