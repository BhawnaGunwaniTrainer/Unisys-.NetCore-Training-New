using coreMvcProject.Models;
using Microsoft.AspNetCore.Mvc;

namespace coreMvcProject.Controllers
{
    public class PersonController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Person p)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Index");
            }
            return View(p);
        }
        
    }
}
