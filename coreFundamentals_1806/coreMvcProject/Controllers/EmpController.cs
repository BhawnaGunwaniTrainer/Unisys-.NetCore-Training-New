using coreMvcProject.Models;
using Microsoft.AspNetCore.Mvc;

namespace coreMvcProject.Controllers
{
    public class EmpController : Controller
    {
        private static List<Employee> employees = new List<Employee>()
        {
            new Employee() { Id = 1, Name = "King Kochhar", Salary = 12000 },
            new Employee() { Id = 2, Name = "Sarah Bowling", Salary = 32000 },
            new Employee() { Id = 3, Name = "Shreya Ghoshal", Salary = 45000 }
        };

        public IActionResult Index()
        {
            return View(employees);
        }

        public IActionResult Details(int id)
        {
            var employee = employees.Where(e => e.Id == id).FirstOrDefault();
            return View(employee); 
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Employee employee)
        {
            if (ModelState.IsValid)
            {
                employee.Id = employees.Count + 1;
                employees.Add(employee);
                return RedirectToAction("Index");
            }
            return View(employee);
        }

        public IActionResult Delete(int id)
        {
            return View();
        }

        public IActionResult Edit(int id)
        {
            return View();
        }
    }
}
