using coreMvcProject.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace coreMvcProject.Controllers
{
    public class ManageEmployeeController : Controller
    {
        private static List<Employee> employees = new List<Employee>()
        {
            new Employee() { Id = 1, Name = "King Kochhar", Salary = 12000 },
            new Employee() { Id = 2, Name = "Sarah Bowling", Salary = 32000 },
            new Employee() { Id = 3, Name = "Shreya Ghoshal", Salary = 45000 }
        };
        // GET: ManageEmployeeController
        public ActionResult Index()
        {
            return View(employees);
        }

        // GET: ManageEmployeeController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ManageEmployeeController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ManageEmployeeController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ManageEmployeeController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ManageEmployeeController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ManageEmployeeController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ManageEmployeeController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
