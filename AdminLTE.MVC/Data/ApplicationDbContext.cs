using System;
using System.Collections.Generic;
using System.Text;
using AdminLTE.MVCDemo.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AdminLTE.MVC.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }

        public DbSet<tblemployee> tblemployees { get; set; }
        public DbSet<tblgender> tblgenders { get; set; }
        public DbSet<tblcountry> tblcountries { get; set; }
        public DbSet<tblstate> tblstates { get; set; }
      
    }
}
