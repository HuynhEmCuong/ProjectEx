using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web_API.Models
{
    public class PDCMapperDto
    {
        private int check = 0;
        public int PDCID { get; set; }
        public string PDCCode { get; set; }
        public string PDCNameTest { get; set; }

        public int Ra1
        {
            get
            {
                return check;
            }
            set
            {
                //if (Ra2)
                check = value;
                Ratting = value;
            }
        }
        public int Ratting { get; set; }

    }
}
