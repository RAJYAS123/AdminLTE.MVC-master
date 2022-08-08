using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AdminLTE.MVCDemo.Models
{
    public class tblemployees1 :tblemployee
    {
       
        public string gname { get; set; }
      
        public string cname { get; set; }
       
        public string sname { get; set; }
    }
}
