namespace Business.Responses.Users;

public class UpdateUserResponse
{
    public int Id { get; set; }
    public string Email { get; set; }
    public DateTime UpdatedAt { get; set; }

    public UpdateUserResponse(int id, DateTime updatedAt, string email)
    {
        Id = id;
        UpdatedAt = updatedAt;
        Email = email;
    }
    public UpdateUserResponse() { }
}