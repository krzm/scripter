using Scripter.Data.Helper;

namespace Scripter.Data;

public class TimcoRetailData 
    : CodeData
{
    protected override void SetAllData()
    {
        var lastUpd = new DateOnly(2022, 6, 29);
        Set(
            "timco-retail"
            , "TRMDesktopUI"
            , isApp: true
            , isWpf: true
            , lastUpd);
        Set(
            "timco-retail"
            , "TRMApi"
            , isApp: true
            , lastUpd);
        Set(
            "timco-retail"
            , "Portal"
            , isApp: true
            , lastUpd);
    }
}