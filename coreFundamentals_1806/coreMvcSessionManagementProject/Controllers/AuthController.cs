using Microsoft.AspNetCore.Mvc;

namespace coreMvcSessionManagementProject.Controllers
{
    public class AuthController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(string username, string password)
        {
            if(username == null || password == null)
            {
                ViewBag.Error = "Enter Your Credentails";
                return View();
            }
            else
            {
                if (username == "admin" && password == "admin")
                {
                    HttpContext.Session.SetString("username", username);
                    return RedirectToAction("Dashboard", "Home");
                }
                else
                {
                    ViewBag.Error = "Invalid Credentails";
                    return View();

                }
            }
        }

        [HttpPost]
        public IActionResult Logout()
        {
            /*HttpContext.Session.Remove("username");*/
            HttpContext.Session.Clear();
            return RedirectToAction("Index", "Home");
        }
    }
}
