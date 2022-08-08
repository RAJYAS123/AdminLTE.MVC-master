using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AdminLTE.MVCDemo.Models
{
    public class tblemployee
    {
        [Key]
        public int id { get; set; }

        [Display(Name = "Name")]
        public string name { get; set; }
        [Display(Name = "Age")]
        public int Age { get; set; }
        [Display(Name = "Address")]
        public string address { get; set; }
        [Display(Name = "Gender")]
        public int gender { get; set; }
        [Display(Name = "Country")]
        public int country { get; set; }
        [Display(Name = "State")]
        public int state { get; set; }
        [Display(Name = "Salary")]
        public int Salary { get; set; }
    }
}
