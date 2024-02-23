using Core.Entities;

namespace Entities.Concrete;

public class Car : Entity<int>
{
    public string Name { get; set; }
    public int ColorId {  get; set; }
    public int ModelId { get; set; }
    public string CarState {  get; set; }
    public int Kilometer {  get; set; }
    public string Plate {  get; set; }
    public Car()
    {
    }
    public Car(string name, int colorId, int modelId, string carState, int kilometer, string plate)
    {
        Name = name;
        ColorId = colorId;
        ModelId = modelId;
        CarState = carState;
        Kilometer = kilometer;
        Plate = plate;
    }
}
