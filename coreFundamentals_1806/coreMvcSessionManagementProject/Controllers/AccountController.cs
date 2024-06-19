using coreMvcSessionManagementProject.Models;
using Microsoft.AspNetCore.Mvc;

namespace coreMvcSessionManagementProject.Controllers
{
    public class AccountController : Controller
    {
        private readonly IUserRepository _userRepository;
        public AccountController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(string username, string password)
        {
            var user = _userRepository.Authenticate(username, password);
            if (user == null)
            {
                ViewBag.Error = "Invalid Username or password.";
                return View();
            }
            HttpContext.Session.SetString("username", user.Username);
            return RedirectToAction("Dashboard", "Home");
        }
    }
}
