#nullable disable
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SistemaClinica.Context;
using SistemaClinica.Models;

namespace SistemaClinica.Controllers
{
    [Authorize]
    public class CompanyController : Controller
    {
        private readonly ContextoSql _context;

        public CompanyController(ContextoSql context)
        {
            _context = context;
        }

        // GET: Company
        public async Task<IActionResult> Index()
        {
            return View(await _context.companies.ToListAsync());
        }

        // GET: Company/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var companyModel = await _context.companies
                .FirstOrDefaultAsync(m => m.Id == id);
            if (companyModel == null)
            {
                return NotFound();
            }

            return View(companyModel);
        }

        // GET: Company/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Company/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("NameCompany,CNPJ,Telephone,Email,ZipCod,City,District,Street,Number,State,Id")] CompanyModel companyModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(companyModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(companyModel);
        }

        // GET: Company/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var companyModel = await _context.companies.FindAsync(id);
            if (companyModel == null)
            {
                return NotFound();
            }
            return View(companyModel);
        }

        // POST: Company/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("NameCompany,CNPJ,Telephone,Email,ZipCod,City,District,Street,Number,State,Id")] CompanyModel companyModel)
        {
            if (id != companyModel.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(companyModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CompanyModelExists(companyModel.Id))
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
            return View(companyModel);
        }

        // GET: Company/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var companyModel = await _context.companies
                .FirstOrDefaultAsync(m => m.Id == id);
            if (companyModel == null)
            {
                return NotFound();
            }

            return View(companyModel);
        }

        // POST: Company/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var companyModel = await _context.companies.FindAsync(id);
            _context.companies.Remove(companyModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CompanyModelExists(int id)
        {
            return _context.companies.Any(e => e.Id == id);
        }
    }
}
