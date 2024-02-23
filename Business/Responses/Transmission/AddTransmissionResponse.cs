namespace Business.Responses.Transmission;

public class AddTransmissionResponse
{
    public int Id { get; set; }
    public string Name { get; set; }
    public DateTime CreatedDate { get; set; }

    public AddTransmissionResponse()
    {

    }
    public AddTransmissionResponse(int id, string name, DateTime createdDate)
    {
        Id = id;
        Name = name;
        CreatedDate = createdDate;
    }
}