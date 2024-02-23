namespace Business.Dtos.Car;

public class CarListItemDto // Dto: Data Transfer Object
{
    public int Id { get; set; }
    public string CarState { get; set; }
    public int Kilometer { get; set; }
    public string Plate { get; set; }
}