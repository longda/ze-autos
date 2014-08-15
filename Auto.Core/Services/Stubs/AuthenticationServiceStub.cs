using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Auto.Core.Enums;
using Auto.Core.Models;
using Auto.Core.Services.Interfaces;

namespace Auto.Core.Services.Stubs
{
    public class AuthenticationServiceStub : IAuthenticationService
    {
        public User Login(string username, string password)
        {
            if (username == "auto")
            {
                return new User() 
                { 
                    Id = 1, 
                    Name = "Admin Dude",
                    Password = "rosebud", 
                    Username = "auto", 
                    UserType = UserType.Standard 
                };
            }

            return new User()
            {
                Id = 23,
                Name = "Standard Guy",
                Password = "sunshine",
                Username = "std",
                UserType = UserType.Standard
            };
        }
    }
}
