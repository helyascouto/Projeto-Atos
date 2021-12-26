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
            optionsBuilder.UseSqlServer(@"Data Source=localhost; initial Catalog=Db_AcademiaDotNet; User ID=usuario;password=senha;language=Portuguese;Trusted_Connection=True");
            optionsBuilder.UseLazyLoadingProxies();
        }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Email>()
        //        .HasOne(e => e.pessoa)// relação 1 para 1
        //        .WithMany(p => p.emails) //relação 1 para muitos
        //        .OnDelete(DeleteBehavior.ClientCascade);
        //}

        public DbSet<Address> addresses { get; set; }
        public DbSet<Company> companies { get; set; }
        public DbSet<Doctor> doctors { get; set; }
        public DbSet<Exams> exams { get; set; }
        public DbSet<HealthPlan> healthPlans { get; set; }
        public DbSet<PeriodicConsultation> periodicConsultations { get; set; }
        public DbSet<GestãoClinica.Models.Patient> Patient { get; set; }



        //EntityFrameworkCore\Add-Migration Inicial
        //EntityFrameworkCore\Update-Database
    }
}

