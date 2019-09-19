using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using NovoDiagnosis.Models;

namespace NovoDiagnosis.Areas.Identity.Pages.Account
{
    [AllowAnonymous]
    public class RegisterModel : PageModel
    {
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly ILogger<RegisterModel> _logger;
        private readonly IEmailSender _emailSender;
        private readonly RoleManager<ApplicationRole> _roleManager;

        public RegisterModel(
            UserManager<ApplicationUser> userManager,
            SignInManager<ApplicationUser> signInManager,
            ILogger<RegisterModel> logger,
            IEmailSender emailSender,
            RoleManager<ApplicationRole> roleManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _logger = logger;
            _emailSender = emailSender;
            _roleManager = roleManager;
        }

        [BindProperty]
        public InputModel Input { get; set; }

        public string ReturnUrl { get; set; }

        public class InputModel
        {
            [Required]
            [DataType(DataType.Text)]
            [StringLength(50, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 2)]
            [Display(Name = "Full Name")]
            public string FullName { get; set; }

            [Required]
            [DataType(DataType.PhoneNumber)]
            [MaxLength(50)]
            public string PhoneNumber { get; set; }

            [Required]
            [DataType(DataType.EmailAddress)]
            [MaxLength(50)]
            public string Email { get; set; }

            [Required]
            [DataType(DataType.Password)]
            [MaxLength(50)]
            public string Password { get; set; }

            [Required]
            [DataType(DataType.Password)]
            [MaxLength(50)]
            [Display(Name = "Confirm Password")]
            public string ConfirmPassword { get; set; }

            [Required]
            [DataType(DataType.Text)]
            [MaxLength(50)]
            [Display(Name = "Staff Id")]
            public string StaffId { get; set; }

            [Required]
            [DataType(DataType.Text)]
            [MaxLength(50)]
            [Display(Name = "Contact Address")]
            public string Street { get; set; }

            [Required]
            [DataType(DataType.Text)]
            [MaxLength(50)]
            public string City { get; set; }

            [Required]
            [DataType(DataType.Text)]
            [MaxLength(50)]
            public string State { get; set; }

            [DataType(DataType.Text)]
            [MaxLength(35)]
            public string Country { get; set; }
        }

        public void OnGet(string returnUrl = null)
        {
            ReturnUrl = returnUrl;
        }

        public async Task<IActionResult> OnPostAsync(string returnUrl = null)
        {
            returnUrl = returnUrl ?? Url.Content("~/");
            if (ModelState.IsValid)
            {
                var user = new ApplicationUser
                {
                    UserName = Input.StaffId,
                    Email = Input.Email,
                    PhoneNumber = Input.PhoneNumber,
                    PasswordHash = Input.Password,
                    FullName = Input.FullName,
                    StaffId = Input.StaffId,
                    Street = Input.Street,
                    City = Input.City,
                    State = Input.State,
                    Country = Input.Country
                };
                var result = await _userManager.CreateAsync(user, Input.Password);
                if (result.Succeeded)
                {

                    string role = Request.Form["rdUserRole"].ToString();

                    if (role == SD.Admin)
                    {
                        await _userManager.AddToRoleAsync(user, SD.Admin);
                    }

                  
                    else
                    {
                        if (role == SD.User)
                        {
                            await _userManager.AddToRoleAsync(user, SD.User);

                        }
                    }
                    _logger.LogInformation("User created a new account with password.");

                    var code = await _userManager.GenerateEmailConfirmationTokenAsync(user);
                    var callbackUrl = Url.Page(
                        "/Account/ConfirmEmail",
                        pageHandler: null,
                        values: new { userId = user.Id, code = code },
                        protocol: Request.Scheme);

                    await _emailSender.SendEmailAsync(Input.Email, "Confirm your email",
                        $"Please confirm your account by <a href='{HtmlEncoder.Default.Encode(callbackUrl)}'>clicking here</a>.");

                    await _signInManager.SignInAsync(user, isPersistent: false);
                    return LocalRedirect(returnUrl);
                }
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
            }

            // If we got this far, something failed, redisplay form
            return Page();
        }
    }
}
