using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SistemaClinica.Models;

namespace SistemaClinica.Context
{
    public class ContextoSql : IdentityDbContext
    {

        public ContextoSql(DbContextOptions<ContextoSql> options) : base(options)
        {
        }


        public ContextoSql()

        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseLazyLoadingProxies();
        }


        public DbSet<AddressModel> addresses { get; set; }
        public DbSet<CompanyModel> companies { get; set; }
        public DbSet<DoctorModel> doctors { get; set; }
        public DbSet<ExamsModel> exams { get; set; }
        public DbSet<HealthPlanModel> healthPlans { get; set; }
        public DbSet<PeriodicConsultationModel> periodicConsultations { get; set; }
        public DbSet<PatientModel> patients { get; set; }
        public DbSet<ListExamsModel> listExams { get; set; }


        //Atualiza o banco de dado com as tabelas necessárias para o Identity
        //dotnet ef migrations add v1 --context ContextoSql --project SistemaClinica
        //dotnet ef database update --context ContextoSql --project SistemaClinica

        //dotnet ef database update --context ApplicationDbContext --project SistemaClinica

    }
}