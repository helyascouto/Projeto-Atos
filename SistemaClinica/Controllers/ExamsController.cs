#nullable disable
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SistemaClinica.Context;
using SistemaClinica.Models;

namespace SistemaClinica.Controllers
{
    [Authorize]
    public class ExamsController : Controller
    {
        private readonly ContextoSql _context;

        public ExamsController(ContextoSql context)
        {
            _context = context;
        }

        // GET: Exams
        public async Task<IActionResult> Index()
        {
            return View(await _context.exams.ToListAsync());
        }

        // GET: Exams/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var examsModel = await _context.exams
                .FirstOrDefaultAsync(m => m.Id == id);
            if (examsModel == null)
            {
                return NotFound();
            }

            return View(examsModel);
        }

        // GET: Exams/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Exams/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("NameExams,Id")] ExamsModel examsModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(examsModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(examsModel);
        }

        // GET: Exams/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var examsModel = await _context.exams.FindAsync(id);
            if (examsModel == null)
            {
                return NotFound();
            }
            return View(examsModel);
        }

        // POST: Exams/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("NameExams,Id")] ExamsModel examsModel)
        {
            if (id != examsModel.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(examsModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ExamsModelExists(examsModel.Id))
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
            return View(examsModel);
        }

        // GET: Exams/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var examsModel = await _context.exams
                .FirstOrDefaultAsync(m => m.Id == id);
            if (examsModel == null)
            {
                return NotFound();
            }

            return View(examsModel);
        }

        // POST: Exams/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var examsModel = await _context.exams.FindAsync(id);
            _context.exams.Remove(examsModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ExamsModelExists(int id)
        {
            return _context.exams.Any(e => e.Id == id);
        }
    }
}
