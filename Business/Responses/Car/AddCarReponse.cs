namespace Business.Responses.Car;

public class AddCarResponse
{ // Dto
    public int Id { get; set; }
    public DateTime CreatedAt { get; set; }


    public AddCarResponse() { }
    public AddCarResponse(int id, DateTime createdAt)
    {
        Id = id;
        CreatedAt = createdAt;
    }
}
