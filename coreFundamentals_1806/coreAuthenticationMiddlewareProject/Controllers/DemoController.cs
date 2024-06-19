using coreAuthenticationMiddlewareProject.Helpers;
using Microsoft.AspNetCore.Mvc;

namespace coreAuthenticationMiddlewareProject.Controllers
{
    [CustomAuthorization]
    public class DemoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
