using ASP.CoreQuerystring.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASP.CoreQuerystring.Controllers
{
    public class PagingController : Controller
    {
        private List<Student> GetStudents()
        {
            return Enumerable.Range(1, 50).Select(i => new Student
            {
                Id = i,
                Name = "Student " + i
            }).ToList();
        }

        public IActionResult Index(int page = 1, int pageSize = 5)
        {
            var students = GetStudents();

            // Paging logic
            var totalCount = students.Count;
            var totalPages = (int)Math.Ceiling(totalCount / (double)pageSize);

            var data = students
                        .Skip((page - 1) * pageSize)
                        .Take(pageSize)
                        .ToList();

            ViewBag.CurrentPage = page;
            ViewBag.TotalPages = totalPages;

            return View(data);
        }
    }
}

