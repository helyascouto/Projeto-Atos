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
    public class HealthPlansController : Controller
    {
        private readonly Contexo _context;

        public HealthPlansController(Contexo context)
        {
            _context = context;
        }

        // GET: HealthPlans
        public async Task<IActionResult> Index()
        {
            return View(await _context.healthPlans.ToListAsync());
        }

        // GET: HealthPlans/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var healthPlan = await _context.healthPlans
                .FirstOrDefaultAsync(m => m.Id == id);
            if (healthPlan == null)
            {
                return NotFound();
            }

            return View(healthPlan);
        }

        // GET: HealthPlans/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: HealthPlans/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("NameCompany,CNPJ,Telephone,Email,ZipCod,Number,District,City,State,Id,SetAtivo,SetDateRegister")] HealthPlan healthPlan)
        {
            if (ModelState.IsValid)
            {
                _context.Add(healthPlan);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(healthPlan);
        }

        // GET: HealthPlans/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var healthPlan = await _context.healthPlans.FindAsync(id);
            if (healthPlan == null)
            {
                return NotFound();
            }
            return View(healthPlan);
        }

        // POST: HealthPlans/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("NameCompany,CNPJ,Telephone,Email,ZipCod,Number,District,City,State,Id,SetAtivo,SetDateRegister")] HealthPlan healthPlan)
        {
            if (id != healthPlan.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(healthPlan);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!HealthPlanExists(healthPlan.Id))
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
            return View(healthPlan);
        }

        // GET: HealthPlans/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var healthPlan = await _context.healthPlans
                .FirstOrDefaultAsync(m => m.Id == id);
            if (healthPlan == null)
            {
                return NotFound();
            }

            return View(healthPlan);
        }

        // POST: HealthPlans/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var healthPlan = await _context.healthPlans.FindAsync(id);
            _context.healthPlans.Remove(healthPlan);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool HealthPlanExists(int id)
        {
            return _context.healthPlans.Any(e => e.Id == id);
        }
    }
}
