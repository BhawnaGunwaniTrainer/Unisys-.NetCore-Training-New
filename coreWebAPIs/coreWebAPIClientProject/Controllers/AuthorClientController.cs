using coreWebAPIClientProject.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace coreWebAPIClientProject.Controllers
{
    public class AuthorClientController : Controller
    {
        public async Task<IActionResult> Index()
        {

            List<Author> authorList = new List<Author>();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("http://localhost:5021/api/Authors"))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    authorList = JsonConvert.DeserializeObject<List<Author>>(apiResponse);
                }
            }
            return View(authorList);
        }

        public async Task<IActionResult> Details(int id)
        {
            Author author = new Author();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("http://localhost:5021/api/Authors/" + id))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        string apiResponse = await response.Content.ReadAsStringAsync();
                        author = JsonConvert.DeserializeObject<Author>(apiResponse);
                    }
                }
            }
            return View(author);
        }
    }
}
