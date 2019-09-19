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
    public class EnrolleesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public EnrolleesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Enrollees
        public async Task<IActionResult> Index()
        {
            return View(await _context.Enrollees.ToListAsync());
        }

        // GET: Enrollees/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var enrollee = await _context.Enrollees
                .FirstOrDefaultAsync(m => m.Id == id);
            if (enrollee == null)
            {
                return NotFound();
            }

            return View(enrollee);
        }

        // GET: Enrollees/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Enrollees/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Parentid,Parentrelationship,Policynumber,Title,Surname,Othernames,Dob,Age,Maritalstatus,Occupation,Sex,Residentialaddress,Stateid,Lgaid,Mobilenumber,Emailaddress,Sponsorshiptype,Sponsorshiptypeothername,Preexistingmedicalhistory,Sponsorshiptypenote,Companyid,Subscriptionplanid,Hasdependents,Specialidcardfield1,Specialidcardfield2,Specialidcardfield3,Staffprofileid,Primaryprovider,Status,Hasactivesubscription,Isexpundged,ExpungeNote,Expungedby,Dateexpunged,Createdby,Datereceived,Guid,CreatedOn,UpdatedOn,IsDeleted,EnrolleePassportId,IdCardPrinted,RefPolicynumber,HasRefPolicyNumber,Mobilenumber2,LastyearBirthdaymsgsent,Bulkjobid,Passphrase")] Enrollee enrollee)
        {
            if (ModelState.IsValid)
            {
                _context.Add(enrollee);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(enrollee);
        }

        // GET: Enrollees/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var enrollee = await _context.Enrollees.FindAsync(id);
            if (enrollee == null)
            {
                return NotFound();
            }
            return View(enrollee);
        }

        // POST: Enrollees/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Parentid,Parentrelationship,Policynumber,Title,Surname,Othernames,Dob,Age,Maritalstatus,Occupation,Sex,Residentialaddress,Stateid,Lgaid,Mobilenumber,Emailaddress,Sponsorshiptype,Sponsorshiptypeothername,Preexistingmedicalhistory,Sponsorshiptypenote,Companyid,Subscriptionplanid,Hasdependents,Specialidcardfield1,Specialidcardfield2,Specialidcardfield3,Staffprofileid,Primaryprovider,Status,Hasactivesubscription,Isexpundged,ExpungeNote,Expungedby,Dateexpunged,Createdby,Datereceived,Guid,CreatedOn,UpdatedOn,IsDeleted,EnrolleePassportId,IdCardPrinted,RefPolicynumber,HasRefPolicyNumber,Mobilenumber2,LastyearBirthdaymsgsent,Bulkjobid,Passphrase")] Enrollee enrollee)
        {
            if (id != enrollee.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(enrollee);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EnrolleeExists(enrollee.Id))
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
            return View(enrollee);
        }

        // GET: Enrollees/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var enrollee = await _context.Enrollees
                .FirstOrDefaultAsync(m => m.Id == id);
            if (enrollee == null)
            {
                return NotFound();
            }

            return View(enrollee);
        }

        // POST: Enrollees/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var enrollee = await _context.Enrollees.FindAsync(id);
            _context.Enrollees.Remove(enrollee);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EnrolleeExists(int id)
        {
            return _context.Enrollees.Any(e => e.Id == id);
        }
    }
}
