using Microsoft.AspNetCore.Identity;

namespace coreMvcAuthenticationProject.Models
{
    public class MyUser: IdentityUser
    {
        public MyUser() { }

        public string? FirstName { get; set; }
        public string? LastName { get; set; }

    }
}
