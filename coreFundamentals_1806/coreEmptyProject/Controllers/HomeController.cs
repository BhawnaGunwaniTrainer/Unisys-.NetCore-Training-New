using Microsoft.AspNetCore.Mvc;

namespace coreEmptyProject.Controllers
{
    public class HomeController : Controller
    {
        public string Index()
        {
            return "Index - Home Controller";
        }
    }
}
