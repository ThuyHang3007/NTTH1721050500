using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NTTH1721050500.Models
{
    public class Lecture : Person
    {
        [StringLength(50)]
        [Display(Name = "Tên khoa")]
        public string Faculty { get; set; }
        [StringLength(50)]
        [Display(Name = "Tên phòng ban")]
        public string Department { get; set; }
    }
}