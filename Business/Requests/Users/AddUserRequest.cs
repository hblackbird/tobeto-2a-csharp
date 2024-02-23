namespace Business.Requests.Users;

public class AddUserRequest
{
    public string Email { get; set; }
    public string Password { get; set; }

    public AddUserRequest(string email, string password)
    {
        Email = email;
        Password = password;
    }
}