using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace NTTH1721050500.Models
{
    public class Student : Person
    {
        [StringLength(50)]
        [Display(Name = " Trường Đại Học")]
        public string University { get; set; }

        [StringLength(50)]
        [Display(Name = " Địa Chỉ Nhà")]
        public string Address { get; set; }
    }
}