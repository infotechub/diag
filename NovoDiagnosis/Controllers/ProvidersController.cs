﻿using System;
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
    public class ProvidersController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ProvidersController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Providers
        public async Task<IActionResult> Index()
        {
            return View(await _context.Providers.ToListAsync());
        }

        // GET: Providers/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var provider = await _context.Providers
                .FirstOrDefaultAsync(m => m.Id == id);
            if (provider == null)
            {
                return NotFound();
            }

            return View(provider);
        }

        // GET: Providers/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Providers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Code,SubCode,Email,Phone,Phone2,Website,Address,Assignee,Providergpscordinate,Providerservices,Providerplans,CreatedBy,AuthorizationStatus,AuthorizationNote,DisapprovalNote,AuthorizedBy,DisapprovedBy,AuthorizedDate,DisapprovalDate,Parentid,Status,Guid,CreatedOn,UpdatedOn,IsDeleted,StateId,LgaId,ProvideraccountId,SiteId,ProviderListPageId,ProviderApprovalPageId,DeletionNote,TariffPageId,TariffContentPageId,ProviderTariffs,Area,Provideraccount2Id,PaymentEmail1,PaymentEmail2,ProviderloginId,Category,IsDelisted,DelistNote,Delisteddate,DelistedBy,DelistedProviderPageId,CompanyConsession")] Provider provider)
        {
            if (ModelState.IsValid)
            {
                _context.Add(provider);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(provider);
        }

        // GET: Providers/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var provider = await _context.Providers.FindAsync(id);
            if (provider == null)
            {
                return NotFound();
            }
            return View(provider);
        }

        // POST: Providers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Code,SubCode,Email,Phone,Phone2,Website,Address,Assignee,Providergpscordinate,Providerservices,Providerplans,CreatedBy,AuthorizationStatus,AuthorizationNote,DisapprovalNote,AuthorizedBy,DisapprovedBy,AuthorizedDate,DisapprovalDate,Parentid,Status,Guid,CreatedOn,UpdatedOn,IsDeleted,StateId,LgaId,ProvideraccountId,SiteId,ProviderListPageId,ProviderApprovalPageId,DeletionNote,TariffPageId,TariffContentPageId,ProviderTariffs,Area,Provideraccount2Id,PaymentEmail1,PaymentEmail2,ProviderloginId,Category,IsDelisted,DelistNote,Delisteddate,DelistedBy,DelistedProviderPageId,CompanyConsession")] Provider provider)
        {
            if (id != provider.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(provider);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProviderExists(provider.Id))
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
            return View(provider);
        }

        // GET: Providers/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var provider = await _context.Providers
                .FirstOrDefaultAsync(m => m.Id == id);
            if (provider == null)
            {
                return NotFound();
            }

            return View(provider);
        }

        // POST: Providers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var provider = await _context.Providers.FindAsync(id);
            _context.Providers.Remove(provider);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProviderExists(int id)
        {
            return _context.Providers.Any(e => e.Id == id);
        }
    }
}
