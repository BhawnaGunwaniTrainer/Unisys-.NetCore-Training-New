using coreMvcSetupProject.Models;
using Microsoft.AspNetCore.Mvc;

namespace coreMvcSetupProject.Controllers
{
    public class EmployeeController : Controller
    {
        // public List<string> employees = new List<string>() { "Kartik", "Shreya", "Gautam" };

        public List<Employee> employees = new List<Employee>()
        {
            new Employee() { Id = 101, Name = "Kartik Sharma", Salary = 12000 },
            new Employee() { Id = 102, Name = "Shreya Gupta", Salary = 30000 },
            new Employee() { Id = 103, Name = "Gautam Bhalla", Salary = 42000 }
        };

        public ViewResult Index()
        {
            ViewBag.Message = "Employee List";
            ViewBag.EmployeeCount = employees.Count();
            ViewBag.Employees = employees;
            return View();
        }

        public ViewResult Details()
        { 
            return View();
        }

        public ViewResult Success()
        {
            return View();
        }

        public ViewResult Privacy()
        {
            return View();
        }
    }
}
