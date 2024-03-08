using Microsoft.AspNetCore.Mvc;
using W02.Models;

namespace W02.Controllers
{
    public class StudentsController : Controller
    {

        public StudentsController()
        {
            SchoolDB.InitializeDb(50);
        }

        public IActionResult Index()
        {
            var students = SchoolDB.Students;
            return View();
        }
    }
}
