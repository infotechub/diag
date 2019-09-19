using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using NovoDiagnosis.Data;
using NovoDiagnosis.Models;

namespace NovoDiagnosis.Controllers
{

    [Authorize]
    public class AdminDiagnosisController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AdminDiagnosisController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: DiagnosisDetails2
        public async Task<IActionResult> Index()
        {
            return View(await _context.DiagnosisDetails.ToListAsync());
        }

        // GET: DiagnosisDetails2/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var diagnosisDetails = await _context.DiagnosisDetails
                .FirstOrDefaultAsync(m => m.Id == id);
            if (diagnosisDetails == null)
            {
                return NotFound();
            }

            return View(diagnosisDetails);
        }

        // GET: DiagnosisDetails2/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: DiagnosisDetails2/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,FullName,StaffId,Provider,State,Email,PhoneNumber,AppointmentDate,AppointmentTime,CompletedAnnualMedical,Approve,Reject,CreatedOn,UpdatedOn,AuthorizationCode,Recommendation,UserName,Status,History,PresentingComplain,Diagnosis,PlanTest")] DiagnosisDetails diagnosisDetails)
        {
            if (ModelState.IsValid)
            {
                _context.Add(diagnosisDetails);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(diagnosisDetails);
        }

        // GET: DiagnosisDetails2/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var diagnosisDetails = await _context.DiagnosisDetails.FindAsync(id);
            if (diagnosisDetails == null)
            {
                return NotFound();
            }
            return View(diagnosisDetails);
        }

        // POST: DiagnosisDetails2/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,FullName,StaffId,Provider,State,Email,PhoneNumber,AppointmentDate,AppointmentTime,CompletedAnnualMedical,Approve,Reject,CreatedOn,UpdatedOn,AuthorizationCode,Recommendation,UserName,Status,History,PresentingComplain,Diagnosis,PlanTest")] DiagnosisDetails diagnosisDetails)
        {
            if (id != diagnosisDetails.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(diagnosisDetails);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DiagnosisDetailsExists(diagnosisDetails.Id))
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
            return View(diagnosisDetails);
        }

        // GET: DiagnosisDetails2/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var diagnosisDetails = await _context.DiagnosisDetails
                .FirstOrDefaultAsync(m => m.Id == id);
            if (diagnosisDetails == null)
            {
                return NotFound();
            }

            return View(diagnosisDetails);
        }

        // POST: DiagnosisDetails2/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var diagnosisDetails = await _context.DiagnosisDetails.FindAsync(id);
            _context.DiagnosisDetails.Remove(diagnosisDetails);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DiagnosisDetailsExists(int id)
        {
            return _context.DiagnosisDetails.Any(e => e.Id == id);
        }
    }
}
