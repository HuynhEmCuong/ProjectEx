using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web_API.Dtos
{
    public class PDCDto
    {
        public int PDCID { get; set; }

        public string PDCName { get; set; }

        public string PDCCode { get; set; }

        public bool? Visible { get; set; }

        public string NameCode { get; set; }

    }
}
