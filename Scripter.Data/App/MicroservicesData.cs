using Scripter.Data.Helper;

namespace Scripter.Data;

public class MicroservicesData 
    : CodeData
{
    protected override void SetAllData()
    {
        var lastUpd = new DateOnly(2022, 6, 26);
        Set(
            "microservices"
            , "CommandsService"
            , isApp: true
            , lastUpd);
         Set(
            "microservices"
            , "PlatformService"
            , isApp: true
            , lastUpd);
    }
}