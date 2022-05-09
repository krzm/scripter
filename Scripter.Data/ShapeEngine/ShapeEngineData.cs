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
            "shape-model"
            , "Shape.Model"
            , true
            , new DateOnly(2022, 5, 9)
            , Vector2
            );
    }
}