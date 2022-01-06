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
            var contextoSql = _context.listExams.Include(l => l.ExamsModel).Include(l => l.PatientModel);
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
                .Include(l => l.ExamsModel)
                .Include(l => l.PatientModel)
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
            ViewData["IdPatient"] = new SelectList(_context.patients, "Id", "City");
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
            ViewData["IdPatient"] = new SelectList(_context.patients, "Id", "City", listExamsModel.IdPatient);
            return View(listExamsModel);
        }

      
    }
}
