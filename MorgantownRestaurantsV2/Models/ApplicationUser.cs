using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MorgantownRestaurantsV2.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public ApplicationUser(string firstName, string lastName, string email, string phoneNumber, string password)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Email = email;
            this.PhoneNumber = phoneNumber;
            this.UserName = email;



            PasswordHasher<ApplicationUser> passwordHasher
                = new PasswordHasher<ApplicationUser>();
            this.PasswordHash =
                passwordHasher.HashPassword(this, password);

            this.SecurityStamp = Guid.NewGuid().ToString();

        }

        public ApplicationUser()
        {

        }


    }
}
