using CRUDOperation.Models;
using Microsoft.AspNetCore.Mvc;

namespace CRUDOperation.Controllers
{
    public class StudentController : Controller
    {
        private readonly ApplicationDbContext _context;

        public StudentController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var data = _context.Students.ToList();

            return View(data);
        }

        [HttpGet]
        public IActionResult Create() 
        {
            return View();
        }


        [HttpPost]
        public IActionResult Create(Student std)
        {
            _context.Students.Add(std);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var data = _context.Students.Find(id);
            return View(data);
        }

        [HttpPost]
        public IActionResult Edit(Student std)
        {
            _context.Students.Update(std);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var data = _context.Students.Find(id);
            return View(data);
        }

        [HttpPost]
        public IActionResult Delete(Student std)
        {
            _context.Students.Remove(std);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
