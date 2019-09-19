using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace NovoDiagnosis.Models
{
    [Table("Provider")]
    public partial class Provider
    {


        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int StateId { get; set; }

        
    }
}
