using Scripter.Data.Helper;

namespace Scripter.Data;

public class TutorialAppsData 
    : CodeData
{
    protected override void SetAllData()
    {
        var lastUpd = new DateOnly(2022, 6, 29);
        Set(
            "timco-suggestion-site-app"
            , "SuggestionAppUI"
            , isApp: true
            , lastUpd);
        Set(
            "docker-api"
            , "DockerAPI"
            , isApp: true
            , lastUpd);
    }
}