namespace Business.Requests.Car;

public class AddCarRequest
{ // Dto
    public string CarState {  get; set; }
    public int Kilometer { get; set; }
    public string Plate { get; set; }


    public AddCarRequest(string carState, int kilometer, string plate)
    {
        CarState = carState;
        Kilometer = kilometer;
        Plate = plate;
    }
}
