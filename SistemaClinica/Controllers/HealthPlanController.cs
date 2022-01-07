#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SistemaClinica.Context;
using SistemaClinica.Models;

namespace SistemaClinica.Controllers
{
    public class HealthPlanController : Controller
    {
        private readonly ContextoSql _context;

        public HealthPlanController(ContextoSql context)
        {
            _context = context;
        }

        // GET: HealthPlan
        public async Task<IActionResult> Index()
        {
            return View(await _context.healthPlans.ToListAsync());
        }

        // GET: HealthPlan/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var healthPlanModel = await _context.healthPlans
                .FirstOrDefaultAsync(m => m.Id == id);
            if (healthPlanModel == null)
            {
                return NotFound();
            }

            return View(healthPlanModel);
        }

        // GET: HealthPlan/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: HealthPlan/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("NameCompany,CNPJ,Telephone,Email,ZipCod,Street,Number,District,City,State,Id")] HealthPlanModel healthPlanModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(healthPlanModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(healthPlanModel);
        }

        // GET: HealthPlan/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var healthPlanModel = await _context.healthPlans.FindAsync(id);
            if (healthPlanModel == null)
            {
                return NotFound();
            }
            return View(healthPlanModel);
        }

        // POST: HealthPlan/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("NameCompany,CNPJ,Telephone,Email,ZipCod,Street,Number,District,City,State,Id")] HealthPlanModel healthPlanModel)
        {
            if (id != healthPlanModel.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(healthPlanModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!HealthPlanModelExists(healthPlanModel.Id))
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
            return View(healthPlanModel);
        }

        // GET: HealthPlan/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var healthPlanModel = await _context.healthPlans
                .FirstOrDefaultAsync(m => m.Id == id);
            if (healthPlanModel == null)
            {
                return NotFound();
            }

            return View(healthPlanModel);
        }

        // POST: HealthPlan/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var healthPlanModel = await _context.healthPlans.FindAsync(id);
            _context.healthPlans.Remove(healthPlanModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool HealthPlanModelExists(int id)
        {
            return _context.healthPlans.Any(e => e.Id == id);
        }
    }
}
