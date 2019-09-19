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
using MailKit.Net.Smtp;
using MimeKit;
using MimeKit.Text;
using Microsoft.AspNetCore.Identity;

namespace NovoDiagnosis.Controllers
{

    [Authorize]
    public class AdminDiagnosisController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly UserManager<ApplicationUser> _userManager;


        public AdminDiagnosisController(ApplicationDbContext context, SignInManager<ApplicationUser> signInManager, UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
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
        public async Task<IActionResult> Edit(int id, string Email, string AppointmentDate, string AuthorizationCode, string Provider, [Bind("Id,FullName,StaffId,Provider,State,Email,PhoneNumber,AppointmentDate,AppointmentTime,CompletedAnnualMedical,Approve,Reject,CreatedOn,UpdatedOn,AuthorizationCode,Recommendation,UserName,Status,History,PresentingComplain,Diagnosis,PlanTest")] DiagnosisDetails diagnosisDetails)
        {

            var user = await _userManager.GetUserAsync(User);
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

                try
                {
                    //instantiate a new MimeMessage
                    var message = new MimeMessage();
                    //Setting the To e-mail address
                    message.To.Add(new MailboxAddress(Email));
                    //Setting the From e-mail address
                    message.From.Add(new MailboxAddress("E-mail From Name", "akinbamidelet@outlook.com"));
                    //E-mail subject 
                    message.Subject = "Appointment Successfully Created";
                    //E-mail message body
                    message.Body = new TextPart(TextFormat.Html)
                    {
                        Text = "<p>Dear esteemed client,</p><br/><p>your annual medical checkup have been scheduled at" + Provider + "for" + AppointmentDate + "</p><p>Your Authorization Code is" + AuthorizationCode +". Kindly go to the Hospital with this code.</p><br><br/><p>Thank you for choosing Novo Health Africa</p>"
                    };

                    //Configure the e-mail
                    using (var emailClient = new SmtpClient())
                    {
                        emailClient.Connect("smtp.outlook.com", 587, false);
                        emailClient.Authenticate("akinbamidelet@outlook.com", "Btrizapi1978@");
                        emailClient.Send(message);
                        emailClient.Disconnect(true);
                    }
                }
                catch (Exception ex)
                {
                    ModelState.Clear();
                    ViewBag.Message = $" Oops! We have a problem here {ex.Message}";
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
