using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace NovoDiagnosis.Models
{
    [Table("DiagnosisDetails")]
    public class DiagnosisDetails
    {
        public int Id { get; set; }
        [Required]
        [Display(Name = "Full Name")]
        public string FullName { get; set; }
        [Required]
        [Display(Name = "Staff Id")]
        public string StaffId { get; set; }

        [Required]
        [Display(Name = "Provider")]
        public string Provider { get; set; }
        public string State { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "Email Address")]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.PhoneNumber)]
        [Display(Name = "Phone Number")]
        public string PhoneNumber { get; set; }
       
        [DataType(DataType.Date)]
        [Display(Name = "Appointment Date")]
        public string AppointmentDate { get; set; }

       
        [DataType(DataType.Time)]
        [Display(Name = "Appointment Time")]
        public string AppointmentTime { get; set; }


        [Display(Name = "Completed Annual Diagnosis?")]
        public bool CompletedAnnualMedical { get; set; }
        public bool Approve { get; set; }
        public bool Reject { get; set; }
        [Display(Name = "Added On")]
        public DateTime _createdon = DateTime.Now;
        public DateTime CreatedOn { get { return _createdon; } set { _createdon = value; } }
        [Display(Name = "Updated On")]
        public DateTime _updatedon = DateTime.Now;
        public DateTime UpdatedOn { get { return _updatedon; } set { _updatedon = value; } }
        [Display(Name = "Authorization Code")]
        public string AuthorizationCode { get; set; }
        public string Recommendation { get; set; }
        [Display(Name = "Username")]
        public string UserName { get; set; }
        [DisplayName("Appointment Status")]
        public string Status { get; set; }
        [DisplayName("Examination")]
        [DataType(DataType.MultilineText)]
        public string History { get; set; }
        [DisplayName("Presenting Complain")]
        [DataType(DataType.MultilineText)]
        public string PresentingComplain { get; set; }
        [DataType(DataType.MultilineText)]
        public string Diagnosis { get; set; }
        [DisplayName("Plan Test")]
        [DataType(DataType.MultilineText)]
        public string PlanTest { get; set; }
    }
}



                                                                                                                                  
                                        