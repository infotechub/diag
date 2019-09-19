using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NovoDiagnosis.Models
{
    public class CompanyPlan
    {

        public int Id { get; set; }
        public int? Companyid { get; set; }
        public int? Planid { get; set; }
        public string Planfriendlyname { get; set; }
        public decimal? AnnualPremium { get; set; }
        public decimal? Discountlump { get; set; }
        public decimal? Discountperenrollee { get; set; }
        public int? Createdby { get; set; }
        public string Description { get; set; }
        public int? AuthorizationStatus { get; set; }
        public string AuthorizationNote { get; set; }
        public bool? AllowChildEnrollee { get; set; }
        public string DisapprovalNote { get; set; }
        public int? AuthorizedBy { get; set; }
        public int? DisapprovedBy { get; set; }
        public DateTime? AuthorizedDate { get; set; }
        public DateTime? DisapprovalDate { get; set; }
        public bool? Status { get; set; }
        public Guid Guid { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public bool? IsDeleted { get; set; }
        public int? SiteId { get; set; }
        public int? MaxNoOfDependant { get; set; }
        public string ProviderConsession { get; set; }
    }
}
