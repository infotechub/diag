using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using NovoDiagnosis.Data;
using NovoDiagnosis.Models;

namespace NovoDiagnosis.Controllers
{

    [Authorize]
    public class DiagnosisDetailsController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;

        public DiagnosisDetailsController(ApplicationDbContext context, SignInManager<ApplicationUser> signInManager,
            UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
            _context = context;
           
        }
        
        public IActionResult Index(string userProfile)
        {
            var username = _userManager.GetUserName(HttpContext.User);

            var diagnos = _context.DiagnosisDetails.Where(x => x.UserName == username);
            if (diagnos== null)
            {
                return NotFound();
            }
            return View(diagnos);
        } 


        // GET: DiagnosisDetails
        public async Task<IActionResult> AdminView()
        {
            return View(await _context.DiagnosisDetails.ToListAsync());
        }

        // GET: DiagnosisDetails/Details/5
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

        // GET: DiagnosisDetails/Create
        public IActionResult Profile()
        {
           
            return View();
        }

        // GET: DiagnosisDetails/Create
        public IActionResult Create()
        {
            ViewBag.Provider = new SelectList(_context.Providers, "Id", "Name");
            return View();
        }

        // POST: DiagnosisDetails/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,FullName,StaffId,Provider,State,Email,AppointmentDate,AppointmentTime,PhoneNumber,UserName")] DiagnosisDetails diagnosisDetails)
        {
            if (ModelState.IsValid)
            {
                _context.Add(diagnosisDetails);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewBag.Provider = new SelectList(_context.Providers, "Id", "Name", diagnosisDetails.Id);
            return View(diagnosisDetails);
        }

        // GET: DiagnosisDetails/Edit/5
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

            ViewBag.ProviderId = new SelectList(_context.Providers, "Id", "Name", diagnosisDetails.Id);
            return View(diagnosisDetails);
        }

        // POST: DiagnosisDetails/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,FullName,StaffId,Provider,State,Email,PhoneNumber,CompletedAnnualMedical,Approve,Reject,CreatedOn,UpdatedOn,AuthorizationCode,Recommendation")] DiagnosisDetails diagnosisDetails)
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
            ViewBag.ProviderId = new SelectList(_context.Providers, "Id", "lName", diagnosisDetails.Id);
            return View(diagnosisDetails);
        }

        // GET: DiagnosisDetails/Delete/5
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

        // POST: DiagnosisDetails/Delete/5
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
