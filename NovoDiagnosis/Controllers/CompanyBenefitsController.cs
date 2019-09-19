using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using NovoDiagnosis.Data;
using NovoDiagnosis.Models;

namespace NovoDiagnosis.Controllers
{
    public class CompanyBenefitsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CompanyBenefitsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: CompanyBenefits
        public async Task<IActionResult> Index()
        {
            return View(await _context.CompanyBenefit.ToListAsync());
        }

        // GET: CompanyBenefits/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var companyBenefit = await _context.CompanyBenefit
                .FirstOrDefaultAsync(m => m.Id == id);
            if (companyBenefit == null)
            {
                return NotFound();
            }

            return View(companyBenefit);
        }

        // GET: CompanyBenefits/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: CompanyBenefits/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Companyid,CompanyPlanid,BenefitId,BenefitLimit,Guid,CreatedOn,UpdatedOn,IsDeleted,SiteId")] CompanyBenefit companyBenefit)
        {
            if (ModelState.IsValid)
            {
                _context.Add(companyBenefit);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(companyBenefit);
        }

        // GET: CompanyBenefits/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var companyBenefit = await _context.CompanyBenefit.FindAsync(id);
            if (companyBenefit == null)
            {
                return NotFound();
            }
            return View(companyBenefit);
        }

        // POST: CompanyBenefits/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Companyid,CompanyPlanid,BenefitId,BenefitLimit,Guid,CreatedOn,UpdatedOn,IsDeleted,SiteId")] CompanyBenefit companyBenefit)
        {
            if (id != companyBenefit.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(companyBenefit);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CompanyBenefitExists(companyBenefit.Id))
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
            return View(companyBenefit);
        }

        // GET: CompanyBenefits/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var companyBenefit = await _context.CompanyBenefit
                .FirstOrDefaultAsync(m => m.Id == id);
            if (companyBenefit == null)
            {
                return NotFound();
            }

            return View(companyBenefit);
        }

        // POST: CompanyBenefits/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var companyBenefit = await _context.CompanyBenefit.FindAsync(id);
            _context.CompanyBenefit.Remove(companyBenefit);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CompanyBenefitExists(int id)
        {
            return _context.CompanyBenefit.Any(e => e.Id == id);
        }
    }
}
