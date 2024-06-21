using System.ComponentModel;

namespace coreWebAPIAuthenticationProject.Model
{
    public class AuthenticateRequest
    {
        [DefaultValue("System")]
        public required string Username { get; set; }

        [DefaultValue("Password")]
        public required string Password { get; set; }

    }
}
