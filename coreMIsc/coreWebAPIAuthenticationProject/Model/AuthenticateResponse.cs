﻿namespace coreWebAPIAuthenticationProject.Model
{
    public class AuthenticateResponse
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Username { get; set; }
        public string? Token { get; set; }

        public AuthenticateResponse(User user, string token)
        {
            this.Id = user.Id;
            this.FirstName = user.FirstName;
            this.LastName = user.LastName;
            this.Username = user.Username;
            this.Token = token;
        }
    }
}
