using ClassLibrary1;
using EFSTMansouraD01.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace EFSTMansouraD01.Context
{
    public class CompanyContext : DbContext
    {
        //EF RunTime
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //applicable only on EF Core
            optionsBuilder.UseSqlServer("Server = .;Database = MnsG5DB ; Trusted_Connection = True ;Encrypt=False");
            //applicable for EF Core and Framework
           // optionsBuilder.UseSqlServer("Data Source = .; Initial Catalog = MnsG5DB; Integrated Security = True;  Encrypt = False; Trust Server Certificate = False; ");

            base.OnConfiguring(optionsBuilder);

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            //Fluent API
          //  modelBuilder.Entity<Emp>().HasKey(e => e.Id);
            //Extrnal Config
            base.OnModelCreating(modelBuilder);
        }

        public virtual DbSet<Employee> Employees{ get; set; }
        public virtual DbSet<Department> Departments { get; set; }

    }
}
