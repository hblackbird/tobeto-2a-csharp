namespace Business.Requests.Users;

public class UpdateUserRequest
{
    public int Id { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }

    public UpdateUserRequest(int id, string email, string password)
    {
        Id = id;
        Email = email;
        Password = password;
    }
}