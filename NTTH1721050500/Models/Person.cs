using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NTTH1721050500.Models
{
    public class Person
    {
        [Key]
        [StringLength(20)]
        [Display(Name = "Mã")]
        public string PersonID { get; set; }

        [StringLength(50)]
        [Display(Name = "Họ và Tên")]
        public string PersonName { get; set; }
    }
}