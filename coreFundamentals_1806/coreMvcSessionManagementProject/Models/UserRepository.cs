namespace coreMvcSessionManagementProject.Models
{
    public class UserRepository : IUserRepository
    {
        private List<User> _users;
        public UserRepository() 
        {
            _users = new List<User>()
            {
                new User() { Id = 1, Username = "king", Password = "password" },
                new User() { Id = 2, Username = "john", Password = "password" },
                new User() { Id = 3, Username = "shreya", Password = "password" }
            };
        }

        public User Authenticate(string username, string password)
        {
            return _users.Find(u => u.Username == username && u.Password == password);
        }
    }
}
