using Microsoft.AspNetCore.Mvc;
using W01.Models;

namespace W01.Controllers
{
    public class RegistrationsController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View(StudentsDbTable.OrderBy(p=>p.Id).ToList());
        }

        public static List<Student> StudentsDbTable = new List<Student>()
        {
             new Student
                {
                    Id = 1,
                    FirstName = "AliCan",
                    LastName = "Cesur",
                    Department = "Math Engineering",
                
                },
           new Student
                {
                    Id = 2,
                    FirstName = "Murtaza",
                    LastName = "Kızıl",
                    Department = "Math Engineering",
                }
                /*
                ViewBag.id = id;
                ViewBag.firstName = "Murtaza";
                ViewBag.lastName = "Kızıl";
                ViewBag.department = "Math Engineering";
                */
           
    /*
    ViewBag.id = -1;
    ViewBag.firstName = "No Data Found";
    ViewBag.lastName = "No Data Found";
    ViewBag.department = "No Data Found";
    */
        };

        [HttpGet]
        public IActionResult About(int id)
        {

            Student student= StudentsDbTable.FirstOrDefault(x => x.Id == id);

            return View(student);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Student student)
        {
            StudentsDbTable.Add(student);


            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            Student student = StudentsDbTable.FirstOrDefault(student => student.Id == id);


            return View(student);
        }

        [HttpPost]
        public IActionResult Edit(Student student)
        {
            Student studentold = StudentsDbTable.FirstOrDefault(student => student.Id == student.Id);
            
            StudentsDbTable.Remove(studentold);

            StudentsDbTable.Add(student);

            return RedirectToAction("Index");
        }
        [HttpGet]

        public IActionResult Delete(int id)
        {
            Student student = StudentsDbTable.FirstOrDefault(student => student.Id == id);
            StudentsDbTable.Remove(student);

            return RedirectToAction("Index");
        }




    }
}
