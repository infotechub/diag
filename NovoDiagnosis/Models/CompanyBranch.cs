using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NovoDiagnosis.Models
{
    public class CompanyBranch
    {
        public int Id { get; set; }
        public int? Statecode { get; set; }
        public string Branch { get; set; }
        public Guid Guid { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public bool? IsDeleted { get; set; }
        public int? CompanyId { get; set; }
        public int? SiteId { get; set; }

        public Company Company { get; set; }
    }
}
