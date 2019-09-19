using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NovoDiagnosis.Models
{
    public class CompanyBenefit
    {
        public int Id { get; set; }
        public int? Companyid { get; set; }
        public int? CompanyPlanid { get; set; }
        public int? BenefitId { get; set; }
        public string BenefitLimit { get; set; }
        public Guid Guid { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public bool? IsDeleted { get; set; }
        public int? SiteId { get; set; }
    }
}
