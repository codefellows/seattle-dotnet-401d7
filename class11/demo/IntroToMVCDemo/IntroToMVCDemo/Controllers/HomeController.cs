using IntroToMVCDemo.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace IntroToMVCDemo.Controllers
{
    public class HomeController : Controller
    {
        //public string Index(string name, int age)
        //{
        //    return $"{name} is the {age} years old!";
        //}

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(string firstName, string lastName, int age)
        {
            Student student = new Student();
            student.FirstName = firstName;
            student.LastName = lastName;
            student.Age = age;

            return RedirectToAction("StudentCreated", student);
        }

        [HttpGet]
        public IActionResult StudentCreated(Student student)
        {
            Student student2 = new Student();
            student2.FirstName = "Jane";
            student2.LastName = "Austin";
            student2.Age = 33;

            Student student3 = new Student();
            student3.FirstName = "Minnie";
            student3.LastName = "Mouse";
            student3.Age = 88;

            Student student4 = new Student();
            student4.FirstName = "Daisy";
            student4.LastName = "Duck";
            student4.Age = 25;

            List<Student> students = new List<Student> { student, student2, student3, student4 };


            return View(students);
        }
    }
}
