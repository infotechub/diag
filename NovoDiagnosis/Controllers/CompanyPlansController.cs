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
    public class CompanyPlansController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CompanyPlansController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: CompanyPlans
        public async Task<IActionResult> Index()
        {
            return View(await _context.CompanyPlans.ToListAsync());
        }

        // GET: CompanyPlans/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var companyPlan = await _context.CompanyPlans
                .FirstOrDefaultAsync(m => m.Id == id);
            if (companyPlan == null)
            {
                return NotFound();
            }

            return View(companyPlan);
        }

        // GET: CompanyPlans/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: CompanyPlans/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Companyid,Planid,Planfriendlyname,AnnualPremium,Discountlump,Discountperenrollee,Createdby,Description,AuthorizationStatus,AuthorizationNote,AllowChildEnrollee,DisapprovalNote,AuthorizedBy,DisapprovedBy,AuthorizedDate,DisapprovalDate,Status,Guid,CreatedOn,UpdatedOn,IsDeleted,SiteId,MaxNoOfDependant,ProviderConsession")] CompanyPlan companyPlan)
        {
            if (ModelState.IsValid)
            {
                _context.Add(companyPlan);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(companyPlan);
        }

        // GET: CompanyPlans/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var companyPlan = await _context.CompanyPlans.FindAsync(id);
            if (companyPlan == null)
            {
                return NotFound();
            }
            return View(companyPlan);
        }

        // POST: CompanyPlans/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Companyid,Planid,Planfriendlyname,AnnualPremium,Discountlump,Discountperenrollee,Createdby,Description,AuthorizationStatus,AuthorizationNote,AllowChildEnrollee,DisapprovalNote,AuthorizedBy,DisapprovedBy,AuthorizedDate,DisapprovalDate,Status,Guid,CreatedOn,UpdatedOn,IsDeleted,SiteId,MaxNoOfDependant,ProviderConsession")] CompanyPlan companyPlan)
        {
            if (id != companyPlan.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(companyPlan);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CompanyPlanExists(companyPlan.Id))
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
            return View(companyPlan);
        }

        // GET: CompanyPlans/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var companyPlan = await _context.CompanyPlans
                .FirstOrDefaultAsync(m => m.Id == id);
            if (companyPlan == null)
            {
                return NotFound();
            }

            return View(companyPlan);
        }

        // POST: CompanyPlans/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var companyPlan = await _context.CompanyPlans.FindAsync(id);
            _context.CompanyPlans.Remove(companyPlan);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CompanyPlanExists(int id)
        {
            return _context.CompanyPlans.Any(e => e.Id == id);
        }
    }
}
