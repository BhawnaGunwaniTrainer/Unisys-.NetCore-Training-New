using coreMvcProject.Models;
using Microsoft.AspNetCore.Mvc;

namespace coreMvcProject.Controllers
{
    public class EmployeeController : Controller
    {
        private List<Employee> employees = new List<Employee>()
        {
            new Employee() { Id = 101, Name = "King Kochhar", Salary = 12000 },
            new Employee() { Id = 102, Name = "Sarah Bowling", Salary = 32000 },
            new Employee() { Id = 103, Name = "Shreya Ghoshal", Salary = 45000 },
        };

        public IActionResult Index()
        {
            ViewBag.Message = "Emploees List";
            ViewBag.EmployeeCount = employees.Count;
            ViewBag.Employees = employees;
            return View();
        }

        public IActionResult Details() 
        {
            ViewData["Message"] = "Employee List";
            ViewData["EmployeeCount"] = employees.Count;
            ViewData["Employees"] = employees;
            // ViewBag.Message = "List of Employees";
            return View(); 
        }

        public IActionResult MoreDetails()
        {
            TempData["Message"] = "Employee List";
            TempData["EmployeeCount"] = employees.Count;
            TempData["Employees"] = employees;
            return View();
        }

        public IActionResult Check()
        {
            if (TempData["Message"] != null)
            {
                ViewBag.Msg = "Message has value.";
                return View();
            }
            ViewBag.Msg = "Message is null or empty";
            return View();
        }

        public IActionResult CheckAgain()
        {
            if (TempData["Message"] != null)
            {
                ViewBag.Msg = "Message is still there..";
                return View();
            }
            ViewBag.Msg = "Message is null or empty.";
            return View();
        }
    }
}
