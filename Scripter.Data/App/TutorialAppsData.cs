using Scripter.Data.Helper;

namespace Scripter.Data;

public class TutorialAppsData 
    : CodeData
{
    protected override void SetAllData()
    {
        var lastUpd = new DateOnly(2022, 6, 30);
        SetTimCoreyTutorials(lastUpd);
        SetLesJacksonTutorials(lastUpd);
    }

    private void SetTimCoreyTutorials(DateOnly lastUpd)
    {
        Set(
            "timco-retail"
            , "TRMApi"
            , isApp: true
            , lastUpd);
        Set(
            "timco-retail"
            , "TRMDesktopUI"
            , isApp: true
            , isWpf: true
            , lastUpd);
        Set(
            "timco-retail"
            , "Portal"
            , isApp: true
            , lastUpd);
        Set(
            "timco-suggestion-site-app"
            , "SuggestionAppUI"
            , isApp: true
            , lastUpd);
    }

    private void SetLesJacksonTutorials(DateOnly lastUpd)
    {
        Set(
            "docker-api"
            , "DockerAPI"
            , isApp: true
            , lastUpd);
        Set(
            "commander"
            , "Commander"
            , isApp: true
            , new DateOnly(2022, 6, 26));
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