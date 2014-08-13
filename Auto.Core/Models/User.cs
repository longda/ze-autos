using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Auto.Core.Enums;

namespace Auto.Core.Models
{
    // NOTE: This is for illustrative purposes only.  In a real project, I'd use encryption
    // or OAuth or something off nuget.  Keeping it simple for now.
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Username { get; set; }
        // Passwords should definitely be encrypted at the application boundry, at the very least,
        // if not again at the database tier.
        public string Password { get; set; }
        public UserType UserType { get; set; }
        public bool IsAdmin { get { return UserType == UserType.Admin; } }

        public User()
        {
        }
    }


}
