namespace Business.Requests.Car;

public class UpdateCarRequest
{
    public string Name { get; set; }
    public UpdateCarRequest(string name)
    {
        Name = name;
    }
}