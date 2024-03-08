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
            var students = SchoolDB.Students.OrderBy(p=>p.Id).ToList();
            return View(students);
        }
        [HttpGet]
        public IActionResult Create()
        {
            var students = SchoolDB.Students;
            return View();
        }
        [HttpPost]
        public IActionResult Create(Student student)
        {
            var maxId = SchoolDB.Students.Max(p => p.Id) + 1;
            student.Id = maxId;

            if(ModelState.IsValid)
            {
                SchoolDB.Students.Add(student);

                return RedirectToAction("Index");

            }
            return View(student);
        }

        [HttpGet]
        public IActionResult Edit(int studentId)
        {
            var students = SchoolDB.Students.FirstOrDefault(p => p.Id == studentId);
            return View(students);
        }
        [HttpPost]
        public IActionResult Edit(Student student)
        {
           

            if (ModelState.IsValid)
            {
                var toBeRemoved = SchoolDB.Students.FirstOrDefault(p => p.Id == student.Id);

                SchoolDB.Students.Remove(toBeRemoved);

                SchoolDB.Students.Add(student);

                return RedirectToAction("Index");

            }
            return View(student);
        }

        [HttpGet]
        public IActionResult Delete(int studentId)
        {
            var students = SchoolDB.Students.FirstOrDefault(p => p.Id == studentId);
            SchoolDB.Students.Remove(students);
            return RedirectToAction("Index");
        }
    }
}
