using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web_API.Dtos
{
    public class BuildingDto
    {
        public int BuildingID { get; set; }
        public string BuildingCode { get; set; }
        public string BuildingName { get; set; }
        public bool? Visible { get; set; }
    }
}
