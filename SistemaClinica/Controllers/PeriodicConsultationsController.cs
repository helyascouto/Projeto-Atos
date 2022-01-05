#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SistemaClinica.Data;
using SistemaClinica.Models;

namespace SistemaClinica.Controllers
{
    [Authorize]
    public class PeriodicConsultationsController : Controller
    {
        private readonly ContextoSql _context;

        public PeriodicConsultationsController(ContextoSql context)
        {
            _context = context;
        }

        // GET: PeriodicConsultations
        [AllowAnonymous]
        public async Task<IActionResult> Index()
        {
            var contextoSql = _context.periodicConsultations.Include(p => p.Company).Include(p => p.Doctor).Include(p => p.Exams).Include(p => p.Patient);
            return View(await contextoSql.ToListAsync());
        }

        // GET: PeriodicConsultations/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var periodicConsultationModel = await _context.periodicConsultations
                .Include(p => p.Company)
                .Include(p => p.Doctor)
                .Include(p => p.Exams)
                .Include(p => p.Patient)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (periodicConsultationModel == null)
            {
                return NotFound();
            }

            return View(periodicConsultationModel);
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
        public async Task<IActionResult> Create([Bind("IdPatient,IdDoctor,IdCompany,IdExams,DateQuery,Ativo,Id")] PeriodicConsultationModel periodicConsultationModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(periodicConsultationModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdCompany"] = new SelectList(_context.companies, "Id", "City", periodicConsultationModel.IdCompany);
            ViewData["IdDoctor"] = new SelectList(_context.doctors, "Id", "City", periodicConsultationModel.IdDoctor);
            ViewData["IdExams"] = new SelectList(_context.exams, "Id", "NameExams", periodicConsultationModel.IdExams);
            ViewData["IdPatient"] = new SelectList(_context.patients, "Id", "City", periodicConsultationModel.IdPatient);
            return View(periodicConsultationModel);
        }

        // GET: PeriodicConsultations/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var periodicConsultationModel = await _context.periodicConsultations.FindAsync(id);
            if (periodicConsultationModel == null)
            {
                return NotFound();
            }
            ViewData["IdCompany"] = new SelectList(_context.companies, "Id", "City", periodicConsultationModel.IdCompany);
            ViewData["IdDoctor"] = new SelectList(_context.doctors, "Id", "City", periodicConsultationModel.IdDoctor);
            ViewData["IdExams"] = new SelectList(_context.exams, "Id", "NameExams", periodicConsultationModel.IdExams);
            ViewData["IdPatient"] = new SelectList(_context.patients, "Id", "City", periodicConsultationModel.IdPatient);
            return View(periodicConsultationModel);
        }

        // POST: PeriodicConsultations/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdPatient,IdDoctor,IdCompany,IdExams,DateQuery,Ativo,Id")] PeriodicConsultationModel periodicConsultationModel)
        {
            if (id != periodicConsultationModel.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(periodicConsultationModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PeriodicConsultationModelExists(periodicConsultationModel.Id))
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
            ViewData["IdCompany"] = new SelectList(_context.companies, "Id", "City", periodicConsultationModel.IdCompany);
            ViewData["IdDoctor"] = new SelectList(_context.doctors, "Id", "City", periodicConsultationModel.IdDoctor);
            ViewData["IdExams"] = new SelectList(_context.exams, "Id", "NameExams", periodicConsultationModel.IdExams);
            ViewData["IdPatient"] = new SelectList(_context.patients, "Id", "City", periodicConsultationModel.IdPatient);
            return View(periodicConsultationModel);
        }

        // GET: PeriodicConsultations/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var periodicConsultationModel = await _context.periodicConsultations
                .Include(p => p.Company)
                .Include(p => p.Doctor)
                .Include(p => p.Exams)
                .Include(p => p.Patient)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (periodicConsultationModel == null)
            {
                return NotFound();
            }

            return View(periodicConsultationModel);
        }

        // POST: PeriodicConsultations/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var periodicConsultationModel = await _context.periodicConsultations.FindAsync(id);
            _context.periodicConsultations.Remove(periodicConsultationModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PeriodicConsultationModelExists(int id)
        {
            return _context.periodicConsultations.Any(e => e.Id == id);
        }
    }
}
