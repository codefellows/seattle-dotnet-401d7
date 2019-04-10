using Class13IntroToEFCore.Models;
using Class13IntroToEFCore.Models.Interfaces;
using Class13IntroToEFCore.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace Class13IntroToEFCore.Controllers
{
    public class StudentsController : Controller
    {
        private readonly IStudentManager _context;

        public StudentsController(IStudentManager context)
        {
            _context = context;
        }

        // GET: Students
        public async Task<IActionResult> Index()
        {
            return View(await _context.GetStudents());
        }

        // GET: Students/Details/5
        public async Task<IActionResult> Details(int id)
        {
            if (id <= 0)
            {
                return NotFound();
            }

            var student = await _context.GetStudent(id);
            if (student == null)
            {
                return NotFound();
            }

            return View(student);
        }

        // GET: Students/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Students/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,FirstName,LastName,Age")] Student student)
        {
            if (ModelState.IsValid)
            {
                await _context.CreateStudent(student);
                return RedirectToAction(nameof(Index));
            }
            return View(student);
        }

        // GET: Students/Edit/5
        public async Task<IActionResult> Edit(int id)
        {
            if (id <= 0)
            {
                return NotFound();
            }

            var student = await _context.GetStudent(id);
            if (student == null)
            {
                return NotFound();
            }
            return View(student);
        }

        // POST: Students/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,FirstName,LastName,Age")] Student student)
        {
            if (id != student.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.UpdateStudent(id, student);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!StudentExists(student.ID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(student);
        }

        // GET: Students/Delete/5
        public async Task<IActionResult> Delete(int id)
        {
            if (id <= 0)
            {
                return NotFound();
            }

            var student = await _context.GetStudent(id);
            if (student == null)
            {
                return NotFound();
            }

            return View(student);
        }

        private bool StudentExists(int id)
        {
            return _context.StudentExists(id);
        }


        public async Task<IActionResult> GetNumber(int id)
        {
            var student = await _context.GetStudent(id);
            int number = student.Transcripts.Count();

            NumberViewModel nvm = new NumberViewModel();
            nvm.Number = number;
            nvm.Student = student;

            return View("Average", nvm);

        }
    }
}