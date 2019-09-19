using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace NovoDiagnosis.Models
{
    [Table("User")]
    public class User
    {

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
        public string CurrentEncryption { get; set; }
        public string Email { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? LastLoginDate { get; set; }
        public int? LoginAttempts { get; set; }
        public Guid? ResetPasswordGuid { get; set; }
        public DateTime? ResetPasswordExpiry { get; set; }
        public bool? DisableNotifications { get; set; }
        public DateTime? LastNotificationReadDate { get; set; }
        public string Uiculture { get; set; }
        public string Mobilephone { get; set; }
        public string CugMobilephone { get; set; }
        public string Dob { get; set; }
        public Guid Guid { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public bool? IsDeleted { get; set; }


    }
}
