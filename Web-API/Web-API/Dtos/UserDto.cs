using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Web_API.Dtos
{
    public class UserDto
    {
        public int UserID { get; set; }

        [StringLength(20)]
        public string UserName { get; set; }

        [StringLength(100)]
        public string HashPass { get; set; }

        [StringLength(200)]
        public string HashImage { get; set; }

        [StringLength(100)]
        public string EmailAddress { get; set; }

        public bool? Visible { get; set; }

        public DateTime? UpdateDate { get; set; }

        [StringLength(20)]
        public string UpdateBy { get; set; }

        [StringLength(50)]
        public string EmpName { get; set; }

        [StringLength(5)]
        public string Roles { get; set; }
    }
}
