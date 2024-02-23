namespace Business.Responses.Users;

public class AddUserResponse
{
    public int Id { get; set; }
    public string Email { get; set; }
    public DateTime CreatedDate { get; set; }

    public AddUserResponse()
    {

    }
    public AddUserResponse(int id, DateTime createdDate, string email)
    {
        Id = id;
        CreatedDate = createdDate;
        Email = email;
    }
}