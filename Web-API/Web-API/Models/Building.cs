using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Web_API.Models
{
    public class Building
    {
        [Key]
        public int BuildingID { get; set; }
        [StringLength(50)]
        public string BuildingCode { get; set; }
        [StringLength(50)]
        public string BuildingName { get; set; }
        public bool? Visible { get; set; }
    }
}
