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
            return View(await _context.periodicConsultations.ToListAsync());
        }

        // GET: PeriodicConsultations/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var periodicConsultation = await _context.periodicConsultations
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
            return View();
        }

        // POST: PeriodicConsultations/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Diagnosis,Description,DateQuery,NextPeriodic,Id,Ativo,DateRegister")] PeriodicConsultation periodicConsultation)
        {
            if (ModelState.IsValid)
            {
                _context.Add(periodicConsultation);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
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
            return View(periodicConsultation);
        }

        // POST: PeriodicConsultations/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Diagnosis,Description,DateQuery,NextPeriodic,Id,Ativo,DateRegister")] PeriodicConsultation periodicConsultation)
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
