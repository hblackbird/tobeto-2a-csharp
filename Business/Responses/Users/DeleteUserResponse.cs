namespace Business.Responses.Users;

public class DeleteUserResponse
{
    public int Id { get; set; }
    public string Email { get; set; }
    public DateTime DeletedAt { get; set; }

    public DeleteUserResponse(int id, DateTime deletedAt,string email)
    {
        Id = id;
        Email = email;
        DeletedAt = deletedAt;
    }
}