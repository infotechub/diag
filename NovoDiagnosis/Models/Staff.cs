using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace NovoDiagnosis.Models
{
    [Table("Staff")]
    public partial class Staff
    {
        public int Id { get; set; }
        public string CompanyId { get; set; }
        public int? CompanySubsidiary { get; set; }
        public string StaffFullname { get; set; }
        public int? StaffPlanid { get; set; }
        public bool? HasProfile { get; set; }
        public int? Profileid { get; set; }
        public int? Createdby { get; set; }
        public Guid Guid { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public bool? IsDeleted { get; set; }
        public bool? IsExpunged { get; set; }
        public string StaffId { get; set; }
        public int? NewStaffId { get; set; }
        public DateTime? StafflinkDate { get; set; }
        public int? StafflinkUser { get; set; }
        public int? StaffJobId { get; set; }
    }
}