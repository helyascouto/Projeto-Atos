using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestãoClinica.Models;

namespace GestãoClinica.Models
{
   public class Contexo : DbContext
    {
        public Contexo()
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=localhost; initial Catalog=Db_GestaoClinica; User ID=usuario;password=senha;language=Portuguese;Trusted_Connection=True");
            optionsBuilder.UseLazyLoadingProxies();
        }


        public DbSet<Address> addresses { get; set; }
        public DbSet<Company> companies { get; set; }
        public DbSet<Doctor> doctors { get; set; }
        public DbSet<Exams> exams { get; set; }
        public DbSet<HealthPlan> healthPlans { get; set; }
        public DbSet<PeriodicConsultation> periodicConsultations { get; set; }
        public DbSet<Patient> patients { get; set; }
        public DbSet<ListExams> listExams { get; set; }
    }
}

