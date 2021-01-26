using System;
using System.Collections.Generic;
using System.Text;

namespace CarRentalSystem.Application.Features.Identity
{
   public  class UserInputModel
    {
        public UserInputModel(string email, string password) 
        {
            this.Email = email;
            this.Password = password;
        }

        public string Email { get; private set; }

        public string Password { get; private set; }
    }
}
