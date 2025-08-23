using ASP.CoreQuerystring.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASP.CoreQuerystring.Controllers
{
    public class TeacherController : Controller
    {
       //Added list techers without database for checking list
        private static List<Techer> teachers = new List<Techer>
        {
        new Techer { Id = 1, Name = "Mr. Smith" },
        new Techer { Id = 2, Name = "Mrs. Johnson" }
       };


        public IActionResult Index()
        {
            return View(teachers);
        }
    }
}
