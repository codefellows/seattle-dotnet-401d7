using Class13IntroToEFCore.Models;
using Class13IntroToEFCore.Models.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Threading.Tasks;

namespace Class13IntroToEFCore.Controllers
{
    public class TranscriptsController : Controller
    {
        private readonly IStudentManager _students;
        private readonly ICourseManager _courses;


        public TranscriptsController(IStudentManager students, ICourseManager courses)
        {
            _students = students;
            _courses = courses;

        }

        // GET: Transcripts/Create
        public async Task<IActionResult> Create()
        {

            ViewData["CourseID"] = new SelectList(await _courses.GetCourses(), "ID", "Name");
            ViewData["StudentID"] = new SelectList(await _students.GetStudents(), "ID", "FullName");
            return View();
        }

        // POST: Transcripts/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,StudentID,CourseID,Grade,Pass")] Transcript transcript)
        {
            if (ModelState.IsValid)
            {
                if (transcript.ID <= 0)
                {
                    await _students.AddTranscript(transcript);
                }
                else
                {
                    var trnscrpt = await _students.GetTranscript(transcript.ID);
                }


                return RedirectToAction("Index", "Students");
            }
            ViewData["CourseID"] = new SelectList(await _courses.GetCourses(), "ID", "Name", transcript.CourseID);
            ViewData["StudentID"] = new SelectList(await _students.GetStudents(), "ID", "FullName", transcript.StudentID);
            return View(transcript);
        }


        // GET: CourseEnrollments/Details/5
        public async Task<IActionResult> Details(int studentId, int courseID)
        {
            if (studentId <= 0 || courseID <= 0)
            {
                return NotFound();
            }

            var transcripts = await _students.GetTranscripts(studentId);
            if (transcripts == null)
            {
                return NotFound();
            }

            return View(transcripts);
        }

        // GET: Transcripts/Edit/5
        public async Task<IActionResult> Edit(int id)
        {
            if (id <= 0)
            {
                return NotFound();
            }

            var transcript = await _students.GetTranscript(id);
            if (transcript == null)
            {
                return NotFound();
            }
            ViewData["CourseID"] = new SelectList(await _courses.GetCourses(), "ID", "Name", transcript.CourseID);
            ViewData["StudentID"] = new SelectList(await _students.GetStudents(), "ID", "FullName", transcript.StudentID);
            return View(transcript);
        }

        // POST: Transcripts/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,StudentID,CourseID,Grade,Pass")] Transcript transcript)
        {
            if (id != transcript.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {

                await _students.UpdateTranscipt(transcript);


                return RedirectToAction("Index", "Students");
            }
            ViewData["CourseID"] = new SelectList(await _courses.GetCourses(), "ID", "Name", transcript.CourseID);
            ViewData["StudentID"] = new SelectList(await _students.GetStudents(), "ID", "FullName", transcript.StudentID);
            return View(transcript);
        }

        // GET: Transcripts/Delete/5
        public async Task<IActionResult> Delete(int id)
        {
            if (id <= 0)
            {
                return NotFound();
            }

            var transcript = await _students.GetTranscripts(id);
            if (transcript == null)
            {
                return NotFound();
            }

            return View(transcript);
        }


        // POST: Transcripts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            await _students.DeleteTranscript(id);
            return RedirectToAction("Details", "Students", id);
        }
    }
}
