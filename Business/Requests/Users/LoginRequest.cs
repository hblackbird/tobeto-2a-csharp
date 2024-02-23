using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Requests.Users
{
    public class LoginRequest
    {
        public string Email { get; set; }
        public string Password { get; set; }

        public LoginRequest(string email, string password)
        {
            Email = email;
            Password = password;
        }
        public LoginRequest()
        {
        }
    }
    
}
