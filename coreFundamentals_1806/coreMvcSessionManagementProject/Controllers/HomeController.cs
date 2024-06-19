using coreMvcSessionManagementProject.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace coreMvcSessionManagementProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult Dashboard()
        {
            var username = HttpContext.Session.GetString("username");
            if (username == null)
            {
                // Not Authenticated..
                // Redirect to Login or take approriate action
                return RedirectToAction("Login", "Auth");
            }
            return View();
        }
    }
}
