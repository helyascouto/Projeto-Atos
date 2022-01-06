﻿#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SistemaClinica.Context;
using SistemaClinica.Models;

namespace SistemaClinica.Controllers
{
    [Authorize]
    public class PatientsController : Controller
    {
        private readonly ContextoSql _context;

        public PatientsController(ContextoSql context)
        {
            _context = context;
        }

        // GET: Patients
        public async Task<IActionResult> Index()
        {
            var contextoSql = _context.patients.Include(p => p.Company).Include(p => p.HealthPlan);
            return View(await contextoSql.ToListAsync());
        }

        // GET: Patients/Details/5
        
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var patientModel = await _context.patients
                .Include(p => p.Company)
                .Include(p => p.HealthPlan)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (patientModel == null)
            {
                return NotFound();
            }

            return View(patientModel);
        }

        // GET: Patients/Create

        public IActionResult Create()
        {
            ViewData["IdCompany"] = new SelectList(_context.companies, "Id", "City");
            ViewData["IdHealthPlan"] = new SelectList(_context.healthPlans, "Id", "City");
            return View();
        }

        // POST: Patients/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CPF,FistName,LastName,DateBirth,IdHealthPlan,IdCompany,Telephone,Email,ZipCod,Number,District,City,State,Id")] PatientModel patientModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(patientModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdCompany"] = new SelectList(_context.companies, "Id", "City", patientModel.IdCompany);
            ViewData["IdHealthPlan"] = new SelectList(_context.healthPlans, "Id", "City", patientModel.IdHealthPlan);
            return View(patientModel);
        }

        // GET: Patients/Edit/5
         public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var patientModel = await _context.patients.FindAsync(id);
            if (patientModel == null)
            {
                return NotFound();
            }
            ViewData["IdCompany"] = new SelectList(_context.companies, "Id", "City", patientModel.IdCompany);
            ViewData["IdHealthPlan"] = new SelectList(_context.healthPlans, "Id", "City", patientModel.IdHealthPlan);
            return View(patientModel);
        }

        // POST: Patients/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("CPF,FistName,LastName,DateBirth,IdHealthPlan,IdCompany,Telephone,Email,ZipCod,Number,District,City,State,Id")] PatientModel patientModel)
        {
            if (id != patientModel.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(patientModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PatientModelExists(patientModel.Id))
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
            ViewData["IdCompany"] = new SelectList(_context.companies, "Id", "City", patientModel.IdCompany);
            ViewData["IdHealthPlan"] = new SelectList(_context.healthPlans, "Id", "City", patientModel.IdHealthPlan);
            return View(patientModel);
        }

        // GET: Patients/Delete/5
            public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var patientModel = await _context.patients
                .Include(p => p.Company)
                .Include(p => p.HealthPlan)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (patientModel == null)
            {
                return NotFound();
            }

            return View(patientModel);
        }

        // POST: Patients/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var patientModel = await _context.patients.FindAsync(id);
            _context.patients.Remove(patientModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PatientModelExists(int id)
        {
            return _context.patients.Any(e => e.Id == id);
        }
    }
}