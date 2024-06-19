namespace coreMvcSessionManagementProject.Models
{
    public interface IUserRepository
    {
        User Authenticate(string username, string password);
    }
}
