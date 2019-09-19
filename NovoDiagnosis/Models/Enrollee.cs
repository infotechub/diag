using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace NovoDiagnosis.Models
{
    [Table("Enrollee")]
    public partial class Enrollee
    {
        public int Id { get; set; }
        public int? Parentid { get; set; }
        public int? Parentrelationship { get; set; }
        public string Policynumber { get; set; }
        public string Title { get; set; }
        public string Surname { get; set; }
        public string Othernames { get; set; }
        public DateTime? Dob { get; set; }
        public int? Age { get; set; }
        public int? Maritalstatus { get; set; }
        public string Occupation { get; set; }
        public int? Sex { get; set; }
        public string Residentialaddress { get; set; }
        public int? Stateid { get; set; }
        public int? Lgaid { get; set; }
        public string Mobilenumber { get; set; }
        public string Emailaddress { get; set; }
        public int? Sponsorshiptype { get; set; }
        public string Sponsorshiptypeothername { get; set; }
        public string Preexistingmedicalhistory { get; set; }
        public string Sponsorshiptypenote { get; set; }
        public int? Companyid { get; set; }
        public int? Subscriptionplanid { get; set; }
        public bool? Hasdependents { get; set; }
        public string Specialidcardfield1 { get; set; }
        public string Specialidcardfield2 { get; set; }
        public string Specialidcardfield3 { get; set; }
        public int? Staffprofileid { get; set; }
        public int? Primaryprovider { get; set; }
        public int? Status { get; set; }
        public bool? Hasactivesubscription { get; set; }
        public bool? Isexpundged { get; set; }
        public string ExpungeNote { get; set; }
        public int? Expungedby { get; set; }
        public DateTime? Dateexpunged { get; set; }
        public int? Createdby { get; set; }
        public DateTime? Datereceived { get; set; }
        public Guid Guid { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public bool? IsDeleted { get; set; }
        public int? EnrolleePassportId { get; set; }
        public bool? IdCardPrinted { get; set; }
        public string RefPolicynumber { get; set; }
        public bool? HasRefPolicyNumber { get; set; }
        public string Mobilenumber2 { get; set; }
        public int? LastyearBirthdaymsgsent { get; set; }
        public int? Bulkjobid { get; set; }
        public int? Passphrase { get; set; }
        public Staff staff { get; set; }
    }
}
