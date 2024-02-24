using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class User : Entity<int>
    {

        public string Email { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
        public bool Approved { get; set; }
        public int? RoleId {  get; set; }
        public ICollection<UserRole> UserRoles { get; set; }
        public User()
        {
        }

        public User(string email, byte[] passwordHash, byte[] passwordSalt, bool approved)
        {
            Email = email;
            PasswordHash = passwordHash;
            PasswordSalt = passwordSalt;
            Approved = approved;
        }
    }
}
