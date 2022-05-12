using Scripter.Data.Helper;

namespace Scripter.Data;

public class ShapeEngineData 
    : IndependantLibData
{
    private ProjectDTO? simCore;
    private ProjectDTO? shapeModel;

    protected override void SetAllData()
    {
        base.SetAllData();
        ArgumentNullException.ThrowIfNull(Vector2);
        simCore = Set(
            repo: "sim-core"
            , project:  "Sim.Core"
            , isApp: false
            , isWpf: true
            , lastCheck: new DateOnly(2022, 5, 12)
            , libs: Vector2
            );
        shapeModel = Set(
            repo: "shape-model"
            , project:  "Shape.Model"
            , isApp: false
            , isWpf: true
            , lastCheck: new DateOnly(2022, 5, 9)
            , Vector2
            , simCore
            );
    }
}