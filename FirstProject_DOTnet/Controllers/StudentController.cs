using FirstProject_DOTnet.Models;
using Microsoft.AspNetCore.Mvc;

namespace FirstProject_DOTnet.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            List<Student> _students = new()
            {
            new Student { Id = 1, Name = "Mehemmed", Point = 55 },
            new Student { Id = 2, Name = "Shahin", Point = 80 },
            new Student { Id = 3, Name = "Huseyn", Point = 69 },
            new Student { Id = 4, Name = "Orxan", Point = 90 }
            };
            return View(_students);
        }
    }
}
