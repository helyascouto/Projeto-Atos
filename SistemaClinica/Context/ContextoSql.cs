using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SistemaClinica.Models;

namespace SistemaClinica.Context
{
    public class ContextoSql : IdentityDbContext
    {

#pragma warning disable CS8618 // O propriedade não anulável 'periodicConsultations' precisa conter um valor não nulo ao sair do construtor. Considere declarar o propriedade como anulável.
#pragma warning disable CS8618 // O propriedade não anulável 'patients' precisa conter um valor não nulo ao sair do construtor. Considere declarar o propriedade como anulável.
#pragma warning disable CS8618 // O propriedade não anulável 'doctors' precisa conter um valor não nulo ao sair do construtor. Considere declarar o propriedade como anulável.
#pragma warning disable CS8618 // O propriedade não anulável 'addresses' precisa conter um valor não nulo ao sair do construtor. Considere declarar o propriedade como anulável.
#pragma warning disable CS8618 // O propriedade não anulável 'healthPlans' precisa conter um valor não nulo ao sair do construtor. Considere declarar o propriedade como anulável.
#pragma warning disable CS8618 // O propriedade não anulável 'listExams' precisa conter um valor não nulo ao sair do construtor. Considere declarar o propriedade como anulável.
#pragma warning disable CS8618 // O propriedade não anulável 'exams' precisa conter um valor não nulo ao sair do construtor. Considere declarar o propriedade como anulável.
#pragma warning disable CS8618 // O propriedade não anulável 'companies' precisa conter um valor não nulo ao sair do construtor. Considere declarar o propriedade como anulável.
        public ContextoSql(DbContextOptions<ContextoSql> options)
#pragma warning restore CS8618 // O propriedade não anulável 'companies' precisa conter um valor não nulo ao sair do construtor. Considere declarar o propriedade como anulável.
#pragma warning restore CS8618 // O propriedade não anulável 'exams' precisa conter um valor não nulo ao sair do construtor. Considere declarar o propriedade como anulável.
#pragma warning restore CS8618 // O propriedade não anulável 'listExams' precisa conter um valor não nulo ao sair do construtor. Considere declarar o propriedade como anulável.
#pragma warning restore CS8618 // O propriedade não anulável 'healthPlans' precisa conter um valor não nulo ao sair do construtor. Considere declarar o propriedade como anulável.
#pragma warning restore CS8618 // O propriedade não anulável 'addresses' precisa conter um valor não nulo ao sair do construtor. Considere declarar o propriedade como anulável.
#pragma warning restore CS8618 // O propriedade não anulável 'doctors' precisa conter um valor não nulo ao sair do construtor. Considere declarar o propriedade como anulável.
#pragma warning restore CS8618 // O propriedade não anulável 'patients' precisa conter um valor não nulo ao sair do construtor. Considere declarar o propriedade como anulável.
#pragma warning restore CS8618 // O propriedade não anulável 'periodicConsultations' precisa conter um valor não nulo ao sair do construtor. Considere declarar o propriedade como anulável.
           : base(options)
        {
        }

#pragma warning disable CS8618 // O propriedade não anulável 'doctors' precisa conter um valor não nulo ao sair do construtor. Considere declarar o propriedade como anulável.
#pragma warning disable CS8618 // O propriedade não anulável 'addresses' precisa conter um valor não nulo ao sair do construtor. Considere declarar o propriedade como anulável.
#pragma warning disable CS8618 // O propriedade não anulável 'healthPlans' precisa conter um valor não nulo ao sair do construtor. Considere declarar o propriedade como anulável.
#pragma warning disable CS8618 // O propriedade não anulável 'listExams' precisa conter um valor não nulo ao sair do construtor. Considere declarar o propriedade como anulável.
#pragma warning disable CS8618 // O propriedade não anulável 'exams' precisa conter um valor não nulo ao sair do construtor. Considere declarar o propriedade como anulável.
#pragma warning disable CS8618 // O propriedade não anulável 'companies' precisa conter um valor não nulo ao sair do construtor. Considere declarar o propriedade como anulável.
#pragma warning disable CS8618 // O propriedade não anulável 'periodicConsultations' precisa conter um valor não nulo ao sair do construtor. Considere declarar o propriedade como anulável.
#pragma warning disable CS8618 // O propriedade não anulável 'patients' precisa conter um valor não nulo ao sair do construtor. Considere declarar o propriedade como anulável.
        public ContextoSql()
#pragma warning restore CS8618 // O propriedade não anulável 'patients' precisa conter um valor não nulo ao sair do construtor. Considere declarar o propriedade como anulável.
#pragma warning restore CS8618 // O propriedade não anulável 'periodicConsultations' precisa conter um valor não nulo ao sair do construtor. Considere declarar o propriedade como anulável.
#pragma warning restore CS8618 // O propriedade não anulável 'companies' precisa conter um valor não nulo ao sair do construtor. Considere declarar o propriedade como anulável.
#pragma warning restore CS8618 // O propriedade não anulável 'exams' precisa conter um valor não nulo ao sair do construtor. Considere declarar o propriedade como anulável.
#pragma warning restore CS8618 // O propriedade não anulável 'listExams' precisa conter um valor não nulo ao sair do construtor. Considere declarar o propriedade como anulável.
#pragma warning restore CS8618 // O propriedade não anulável 'healthPlans' precisa conter um valor não nulo ao sair do construtor. Considere declarar o propriedade como anulável.
#pragma warning restore CS8618 // O propriedade não anulável 'addresses' precisa conter um valor não nulo ao sair do construtor. Considere declarar o propriedade como anulável.
#pragma warning restore CS8618 // O propriedade não anulável 'doctors' precisa conter um valor não nulo ao sair do construtor. Considere declarar o propriedade como anulável.
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer(@"Data Source=localhost; initial Catalog=Db_GestaoClinica; User ID=usuario;password=senha;language=Portuguese;Trusted_Connection=True");
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