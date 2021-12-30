using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using GestãoClinica.Models;

namespace GestãoClinica.Controllers
{
    public class PeriodicConsultationsController : Controller
    {
        private readonly Contexo _context;

        public PeriodicConsultationsController(Contexo context)
        {
            _context = context;
        }

        // GET: PeriodicConsultations
        public async Task<IActionResult> Index()
        {
            var contexo = _context.periodicConsultations.Include(p => p.Company).Include(p => p.Doctor).Include(p => p.Exams).Include(p => p.Patient);
            return View(await contexo.ToListAsync());
        }

        // GET: PeriodicConsultations/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var periodicConsultation = await _context.periodicConsultations
                .Include(p => p.Company)
                .Include(p => p.Doctor)
                .Include(p => p.Exams)
                .Include(p => p.Patient)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (periodicConsultation == null)
            {
                return NotFound();
            }

            return View(periodicConsultation);
        }

        // GET: PeriodicConsultations/Create
        public IActionResult Create()
        {
            ViewData["IdCompany"] = new SelectList(_context.companies, "Id", "City");
            ViewData["IdDoctor"] = new SelectList(_context.doctors, "Id", "City");
            ViewData["IdExams"] = new SelectList(_context.exams, "Id", "NameExams");
            ViewData["IdPatient"] = new SelectList(_context.patients, "Id", "City");
            return View();
        }

        // POST: PeriodicConsultations/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdPatient,IdDoctor,IdCompany,IdExams,DateQuery,Ativo,Id")] PeriodicConsultation periodicConsultation)
        {
            if (ModelState.IsValid)
            {
                _context.Add(periodicConsultation);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdCompany"] = new SelectList(_context.companies, "Id", "City", periodicConsultation.IdCompany);
            ViewData["IdDoctor"] = new SelectList(_context.doctors, "Id", "City", periodicConsultation.IdDoctor);
            ViewData["IdExams"] = new SelectList(_context.exams, "Id", "NameExams", periodicConsultation.IdExams);
            ViewData["IdPatient"] = new SelectList(_context.patients, "Id", "City", periodicConsultation.IdPatient);
            return View(periodicConsultation);
        }

        // GET: PeriodicConsultations/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var periodicConsultation = await _context.periodicConsultations.FindAsync(id);
            if (periodicConsultation == null)
            {
                return NotFound();
            }
            ViewData["IdCompany"] = new SelectList(_context.companies, "Id", "City", periodicConsultation.IdCompany);
            ViewData["IdDoctor"] = new SelectList(_context.doctors, "Id", "City", periodicConsultation.IdDoctor);
            ViewData["IdExams"] = new SelectList(_context.exams, "Id", "NameExams", periodicConsultation.IdExams);
            ViewData["IdPatient"] = new SelectList(_context.patients, "Id", "City", periodicConsultation.IdPatient);
            return View(periodicConsultation);
        }

        // POST: PeriodicConsultations/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdPatient,IdDoctor,IdCompany,IdExams,DateQuery,Ativo,Id")] PeriodicConsultation periodicConsultation)
        {
            if (id != periodicConsultation.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(periodicConsultation);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PeriodicConsultationExists(periodicConsultation.Id))
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
            ViewData["IdCompany"] = new SelectList(_context.companies, "Id", "City", periodicConsultation.IdCompany);
            ViewData["IdDoctor"] = new SelectList(_context.doctors, "Id", "City", periodicConsultation.IdDoctor);
            ViewData["IdExams"] = new SelectList(_context.exams, "Id", "NameExams", periodicConsultation.IdExams);
            ViewData["IdPatient"] = new SelectList(_context.patients, "Id", "City", periodicConsultation.IdPatient);
            return View(periodicConsultation);
        }

        // GET: PeriodicConsultations/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var periodicConsultation = await _context.periodicConsultations
                .Include(p => p.Company)
                .Include(p => p.Doctor)
                .Include(p => p.Exams)
                .Include(p => p.Patient)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (periodicConsultation == null)
            {
                return NotFound();
            }

            return View(periodicConsultation);
        }

        // POST: PeriodicConsultations/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var periodicConsultation = await _context.periodicConsultations.FindAsync(id);
            _context.periodicConsultations.Remove(periodicConsultation);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PeriodicConsultationExists(int id)
        {
            return _context.periodicConsultations.Any(e => e.Id == id);
        }
    }
}
