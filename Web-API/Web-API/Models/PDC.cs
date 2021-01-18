using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Web_API.Models
{
    public class PDC
    {
        public int PDCID { get; set; }

        [StringLength(50)]
        public string PDCName { get; set; }

        [StringLength(50)]
        public string PDCCode { get; set; }

        public bool? Visible { get; set; }
    }
}
