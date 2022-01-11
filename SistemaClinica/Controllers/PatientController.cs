#nullable disable
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
    public class PatientController : Controller
    {
        private readonly ContextoSql _context;

        public PatientController(ContextoSql context)
        {
            _context = context;
        }

        // GET: Patient
        public async Task<IActionResult> Index()
        {
            var contextoSql = _context.patients.Include(p => p.Company).Include(p => p.HealthPlan);
            return View(await contextoSql.ToListAsync());
        }

        // GET: Patient/Details/5
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

        // GET: Patient/Create
        public IActionResult Create()
        {
            ViewData["IdCompany"] = new SelectList(_context.companies, "Id", "City");
            ViewData["IdHealthPlan"] = new SelectList(_context.healthPlans, "Id", "City");
            return View();
        }

        // POST: Patient/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CPF,FistName,LastName,DateBirth,IdHealthPlan,IdCompany,Telephone,Email,ZipCod,City,District,Street,Number,State,Id")] PatientModel patientModel)
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



        //Colocar esse metodo na tela de cadstro!
        public IActionResult CreateNewExams()
        {
            ViewData["IdExams"] = new SelectList(_context.exams, "Id", "NameExams");
            ViewData["IdPatient"] = new SelectList(_context.patients, "Id", "FistName");
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateNewExams([Bind("IdPatient,IdExams,Id")] ListExamsModel listExamsModel)
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


        // GET: Patient/Edit/5
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

        // POST: Patient/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("CPF,FistName,LastName,DateBirth,IdHealthPlan,IdCompany,Telephone,Email,ZipCod,City,District,Street,Number,State,Id")] PatientModel patientModel)
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

        // GET: Patient/Delete/5
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

        // POST: Patient/Delete/5
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
