
using System;
using System.Collections.Generic;
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

        public Patient(long cPF, string fistName, string lastName, DateTime dateBirth, int idHealthPlan, HealthPlan healthPlan, int idCompany, Company company)
        {
            CPF = cPF;
            FistName = fistName;
            LastName = lastName;
            DateBirth = dateBirth;
            IdHealthPlan = idHealthPlan;
            HealthPlan = healthPlan;
            IdCompany = idCompany;
            Company = company;
        }



        //[Required(ErrorMessage = "O CPF é Obrigatório!")]
        [Display(Name = "CPF")]
        //        [RegularExpression(
        //@"([0-9]{2}[\.]?[0-9]{3}[\.]?[0-9]{3}[\/]?[0-9]{4}[-]?[0-9]{2})|([0-9]{3}[\.]?[0-9]{3}[\.]?[0-9]{3}[-]?[0-9]{2})",
        //ErrorMessage = "Informe um CPF válido!")]
        public Int64 CPF { get; set; }

        //[Required(ErrorMessage = "O Nome é Obrigatório!")]
        [Display(Name = "Nome")]
        //[StringLength(20, MinimumLength = 3, ErrorMessage = "Entre 3 a 20 Caracteres")]
        //[RegularExpression(@"^[a-zA-Z''-'\s]{1,40}$", ErrorMessage =
        //    "Números e caracteres especiais não são permitidos no nome.")]
        public string FistName { get; set; }

        //[Required(ErrorMessage = "O Nome é Obrigatório!")]
        [Display(Name = "Sobrenome")]
        [StringLength(40, MinimumLength = 3, ErrorMessage = "Entre 3 a 40 Caracteres")]
        //[RegularExpression(@"^[a-zA-Z''-'\s]{1,40}$", ErrorMessage =
        //    "Números e caracteres especiais não são permitidos no Sobrenome.")]
        public string LastName { get; set; }

        //[Required(ErrorMessage = "O Data de Nascimento é Obrigatório!")]
        [Display(Name = "Data de Nascimento")]
        public DateTime DateBirth { get; set; }

        [Display(Name = "Plano de Saude")]
        public int IdHealthPlan { get; set; }

        //[Required(ErrorMessage = "O Nome do Plano é Obrigatório!")]
        [ForeignKey("IdHealthPlan")]
        public virtual HealthPlan HealthPlan { get; set; }

        [Display(Name = "Empresa")]
        public int IdCompany { get; set; }

        // [Required(ErrorMessage = "A Empresa é Obrigatório!")]
        [ForeignKey("IdCompany")]
        public virtual Company Company { get; set; }


        public string NomeCompleto()
        {
            return FistName + " " + LastName;
        }
    }
}