using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Class13IntroToEFCore.Data;
using Class13IntroToEFCore.Models;

namespace Class13IntroToEFCore.Controllers
{
    public class CourseEnrollmentsController : Controller
    {
        private readonly StudentEnrollmentDbContext _context;

        public CourseEnrollmentsController(StudentEnrollmentDbContext context)
        {
            _context = context;
        }

        // GET: CourseEnrollments
        public async Task<IActionResult> Index()
        {
            var studentEnrollmentDbContext = _context.CourseEnrollments
                .Include(p => p.Course)
                .Include(c => c.Student);
            return View(await studentEnrollmentDbContext.ToListAsync());
        }

        // GET: CourseEnrollments/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var courseEnrollments = await _context.CourseEnrollments
                .Include(c => c.Course)
                .Include(c => c.Student)
                .FirstOrDefaultAsync(m => m.CourseID == id);
            if (courseEnrollments == null)
            {
                return NotFound();
            }

            return View(courseEnrollments);
        }

        // GET: CourseEnrollments/Create
        public IActionResult Create()
        {
            ViewData["CourseID"] = new SelectList(_context.Courses, "ID", "Name");
            ViewData["StudentID"] = new SelectList(_context.Students, "ID", "FullName");
            return View();
        }

        // POST: CourseEnrollments/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("StudentID,CourseID")] CourseEnrollments courseEnrollments)
        {
            if (ModelState.IsValid)
            {
                _context.Add(courseEnrollments);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CourseID"] = new SelectList(_context.Courses, "ID", "Name", courseEnrollments.CourseID);
            ViewData["StudentID"] = new SelectList(_context.Students, "ID", "FullName", courseEnrollments.StudentID);
            return View(courseEnrollments);
        }

        // GET: CourseEnrollments/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var courseEnrollments = await _context.CourseEnrollments.FindAsync(id);
            if (courseEnrollments == null)
            {
                return NotFound();
            }
            ViewData["CourseID"] = new SelectList(_context.Courses, "ID", "Name", courseEnrollments.CourseID);
            ViewData["StudentID"] = new SelectList(_context.Students, "ID", "FullName", courseEnrollments.StudentID);
            return View(courseEnrollments);
        }

        // POST: CourseEnrollments/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("StudentID,CourseID")] CourseEnrollments courseEnrollments)
        {
            if (id != courseEnrollments.CourseID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(courseEnrollments);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CourseEnrollmentsExists(courseEnrollments.CourseID))
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
            ViewData["CourseID"] = new SelectList(_context.Courses, "ID", "ID", courseEnrollments.CourseID);
            ViewData["StudentID"] = new SelectList(_context.Students, "ID", "ID", courseEnrollments.StudentID);
            return View(courseEnrollments);
        }

        // GET: CourseEnrollments/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var courseEnrollments = await _context.CourseEnrollments
                .Include(c => c.Course)
                .Include(c => c.Student)
                .FirstOrDefaultAsync(m => m.CourseID == id);
            if (courseEnrollments == null)
            {
                return NotFound();
            }

            return View(courseEnrollments);
        }

        // POST: CourseEnrollments/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var courseEnrollments = await _context.CourseEnrollments.FindAsync(id);
            _context.CourseEnrollments.Remove(courseEnrollments);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CourseEnrollmentsExists(int id)
        {
            return _context.CourseEnrollments.Any(e => e.CourseID == id);
        }
    }
}
