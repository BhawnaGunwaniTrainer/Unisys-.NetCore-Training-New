using Microsoft.AspNetCore.Mvc;

namespace coreMvcSetupProject.Controllers
{
    public class HomeController : Controller
    {
        public string Index()
        {
            return "Index - Home Controller";
        }

        public string Message()
        {
            return "Message - Home Controller";
        }
    }
}
