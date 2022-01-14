#nullable disable
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SistemaClinica.Context;
using SistemaClinica.Models;

namespace SistemaClinica.Controllers
{
    [Authorize]
    public class ListExamsController : Controller
    {
        private readonly ContextoSql _context;

        public ListExamsController(ContextoSql context)
        {
            _context = context;
        }

        // GET: ListExams
        public async Task<IActionResult> Index()
        {
            var contextoSql = _context.listExams.Include(l => l.Exams).Include(l => l.Patient);
            return View(await contextoSql.ToListAsync());
        }

        // GET: ListExams/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var listExamsModel = await _context.listExams
                .Include(l => l.Exams)
                .Include(l => l.Patient)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (listExamsModel == null)
            {
                return NotFound();
            }

            return View(listExamsModel);
        }

        // GET: ListExams/Create
        public IActionResult Create()
        {
            ViewData["IdExams"] = new SelectList(_context.exams, "Id", "NameExams");
            ViewData["IdPatient"] = new SelectList(_context.patients, "Id", "FistName");
            return View();
        }

        // POST: ListExams/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdPatient,IdExams,Id")] ListExamsModel listExamsModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(listExamsModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdExams"] = new SelectList(_context.exams, "Id", "NameExams", listExamsModel.IdExams);
            ViewData["IdPatient"] = new SelectList(_context.patients, "Id", "FistName", listExamsModel.IdPatient);
            return View(listExamsModel);
        }

        // GET: ListExams/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var listExamsModel = await _context.listExams.FindAsync(id);
            if (listExamsModel == null)
            {
                return NotFound();
            }
            ViewData["IdExams"] = new SelectList(_context.exams, "Id", "NameExams", listExamsModel.IdExams);
            ViewData["IdPatient"] = new SelectList(_context.patients, "Id", "FistName", listExamsModel.IdPatient);
            return View(listExamsModel);
        }

        // POST: ListExams/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdPatient,IdExams,Id")] ListExamsModel listExamsModel)
        {
            if (id != listExamsModel.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(listExamsModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ListExamsModelExists(listExamsModel.Id))
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
            ViewData["IdExams"] = new SelectList(_context.exams, "Id", "NameExams", listExamsModel.IdExams);
            ViewData["IdPatient"] = new SelectList(_context.patients, "Id", "FistName", listExamsModel.IdPatient);
            return View(listExamsModel);
        }

        // GET: ListExams/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var listExamsModel = await _context.listExams
                .Include(l => l.Exams)
                .Include(l => l.Patient)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (listExamsModel == null)
            {
                return NotFound();
            }

            return View(listExamsModel);
        }

        // POST: ListExams/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var listExamsModel = await _context.listExams.FindAsync(id);
            _context.listExams.Remove(listExamsModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ListExamsModelExists(int id)
        {
            return _context.listExams.Any(e => e.Id == id);
        }
    }
}
