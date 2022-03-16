using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication5.Models
{
    public class StudentData
    {
        public int empid { get; set; }
        [Required]
        public string ename { get; set; }
        [Required]
        public Nullable<decimal> mobile { get; set; }
        [Required]
        public string email { get; set; }
        [Required]
        public string city { get; set; }
    }
}