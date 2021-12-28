
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace GestãoClinica.Models
{
    [Table("Patients")]
    public class Patient : Address
    {
        public Patient()
        {

        }
        public Patient(long? cpf, string fistName, string lastName, DateTime dateBirth, int idHealthPlan, HealthPlan healthPlan, int idCompany, Company companies)
        {
            CPF = cpf;
            FistName = fistName;
            LastName = lastName;
            DateBirth = dateBirth;
            IdHealthPlan = idHealthPlan;
            HealthPlan = healthPlan;
            IdCompany = idCompany;
            Companies = companies;
        }

        //[Required(ErrorMessage = "O CPF é Obrigatório!")]
        [Display(Name = "CPF")]
        //        [RegularExpression(
        //@"([0-9]{2}[\.]?[0-9]{3}[\.]?[0-9]{3}[\/]?[0-9]{4}[-]?[0-9]{2})|([0-9]{3}[\.]?[0-9]{3}[\.]?[0-9]{3}[-]?[0-9]{2})",
        //ErrorMessage = "Informe um CPF válido!")]
        public Int64? CPF { get; set; }

        [Required(ErrorMessage = "O Nome é Obrigatório!")]
        [Display(Name = "Nome")]
        //[StringLength(20, MinimumLength = 3, ErrorMessage = "Entre 3 a 20 Caracteres")]
        //[RegularExpression(@"^[a-zA-Z''-'\s]{1,40}$", ErrorMessage =
        //    "Números e caracteres especiais não são permitidos no nome.")]
        public string FistName { get; set; }

        [Required(ErrorMessage = "O Nome é Obrigatório!")]
        [Display(Name = "Sobrenome")]
        [StringLength(40, MinimumLength = 3, ErrorMessage = "Entre 3 a 40 Caracteres")]
        //[RegularExpression(@"^[a-zA-Z''-'\s]{1,40}$", ErrorMessage =
        //    "Números e caracteres especiais não são permitidos no Sobrenome.")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "O Data de Nascimento é Obrigatório!")]
        [Display(Name = "Data de Nascimento")]
        public DateTime DateBirth { get; set; }

        [ForeignKey("HealthPlan")]
        public int IdHealthPlan { get; set; }

        //  [Required(ErrorMessage = "O Nome do Plano é Obrigatório!")]
        [Display(Name = "Plano de Saude")]
        public virtual HealthPlan? HealthPlan { get; set; }

        [ForeignKey("Company")]
        public int IdCompany { get; set; }

        //   [Required(ErrorMessage = "O nome da empresa é Obrigatório!")]
        [Display(Name = "Empresa")]
        public virtual Company? Companies { get; set; }
    }
}