using Scripter.Data.Helper;

namespace Scripter.Data;

public class ShapeEngineData 
    : IndependantLibData
{
    private ProjectDTO? shapeModel;

    protected override void SetAllData()
    {
        base.SetAllData();
        ArgumentNullException.ThrowIfNull(Vector2);
        shapeModel = Set(
            repo: "shape-model"
            , project:  "Shape.Model"
            , isApp: true
            , isWpf: true
            , lastCheck: new DateOnly(2022, 5, 9)
            , libs: Vector2
            );
    }
}