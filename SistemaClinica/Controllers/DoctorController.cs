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
    public class DoctorController : Controller
    {
        private readonly ContextoSql _context;

        public DoctorController(ContextoSql context)
        {
            _context = context;
        }

        // GET: Doctor
        public async Task<IActionResult> Index()
        {
            return View(await _context.doctors.ToListAsync());
        }

        // GET: Doctor/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var doctorModel = await _context.doctors
                .FirstOrDefaultAsync(m => m.Id == id);
            if (doctorModel == null)
            {
                return NotFound();
            }

            return View(doctorModel);
        }

        // GET: Doctor/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Doctor/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CRM,CPF,FistName,LastName,DateBirth,Telephone,Email,ZipCod,City,District,Street,Number,State,Id")] DoctorModel doctorModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(doctorModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(doctorModel);
        }

        // GET: Doctor/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var doctorModel = await _context.doctors.FindAsync(id);
            if (doctorModel == null)
            {
                return NotFound();
            }
            return View(doctorModel);
        }

        // POST: Doctor/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("CRM,CPF,FistName,LastName,DateBirth,Telephone,Email,ZipCod,City,District,Street,Number,State,Id")] DoctorModel doctorModel)
        {
            if (id != doctorModel.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(doctorModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DoctorModelExists(doctorModel.Id))
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
            return View(doctorModel);
        }

        // GET: Doctor/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var doctorModel = await _context.doctors
                .FirstOrDefaultAsync(m => m.Id == id);
            if (doctorModel == null)
            {
                return NotFound();
            }

            return View(doctorModel);
        }

        // POST: Doctor/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var doctorModel = await _context.doctors.FindAsync(id);
            _context.doctors.Remove(doctorModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DoctorModelExists(int id)
        {
            return _context.doctors.Any(e => e.Id == id);
        }
    }
}
