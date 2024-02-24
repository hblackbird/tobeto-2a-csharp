using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Roles : Entity<int>
    {
        public string RoleName { get; set; }
        public ICollection<UserRole> UserRoles { get; set; }

        public Roles()
        {
        }

        public Roles(string roleName)
        {
            RoleName = roleName;

        }

    }
}
