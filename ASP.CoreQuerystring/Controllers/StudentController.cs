using Microsoft.AspNetCore.Mvc;
using ASP.CoreQuerystring.Models;

namespace ASP.CoreQuerystring.Controllers
{
    public class StudentController : Controller
    {
        private static List<Student> students = new List<Student>
    {
        new Student { Id = 1, Name = "John", TeacherId = 1 },
        new Student { Id = 2, Name = "Alice", TeacherId = 1 },
        new Student { Id = 3, Name = "Bob", TeacherId = 2 }
    };

        // This action receives TeacherId from TeacherController
        

        public IActionResult RedirectToStudent(int id)
        {
            TempData["TeacherId"] = id;
            return RedirectToAction("ListByTeacher", "Student");
        }

        [HttpPost]
        public IActionResult ListByTeacher(int teacherId)
        {
            var result = students.Where(s => s.TeacherId == teacherId).ToList();
            return View(result);
        }

      
    }
}

