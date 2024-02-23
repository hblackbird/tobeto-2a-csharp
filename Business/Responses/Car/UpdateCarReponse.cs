namespace Business.Responses.Car;

public class UpdateCarResponse
{
    public int Id { get; set; }
    public string Name { get; set; }
    public DateTime UpdatedAt { get; set; }

    public UpdateCarResponse(int id, string name, DateTime updatedAt)
    {
        Id = id;
        Name = name;
        UpdatedAt = updatedAt;
    }
    public UpdateCarResponse() { }

}
