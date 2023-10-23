using BasicLearning.Models;
using Microsoft.AspNetCore.Mvc;

namespace BasicLearning.Controllers
{
    public class TestController : Controller
    {
        
        public IActionResult Index()
        {
            string name = "sohel";
            return View("Index",name);
        }

        //public IActionResult StudentDetails()
        //{
        //    Student std = new Student();
        //   std.ID = 1;
        //    std.Age = 23;
        //    std.Marks = 80;
        //    std.STD = 10;
        //    std.Name = "sohel";

        //    return View(std);
        //}

        public IActionResult StudentDetails()
        {
            List<Student> std = new List<Student>();
            std.Add(new Student() { ID = 1, Name = "sohel", Age = 24, Marks = 90, STD = 10 });
            std.Add(new Student() { ID = 2, Name = "raju", Age = 27, Marks = 90, STD = 10 });
            std.Add(new Student() { ID = 3, Name = "asad", Age = 23, Marks = 90, STD = 10 });

            return View(std);
        }

    }
}
