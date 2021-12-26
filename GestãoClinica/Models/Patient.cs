
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace GestãoClinica.Models
{
    [Table("Patients")]
    public class Patient : EntityBase
    {
        [Required(ErrorMessage = "O CPF é Obrigatório!")]
        [Display(Name = "CPF")]
        [RegularExpression(
@"([0-9]{2}[\.]?[0-9]{3}[\.]?[0-9]{3}[\/]?[0-9]{4}[-]?[0-9]{2})|([0-9]{3}[\.]?[0-9]{3}[\.]?[0-9]{3}[-]?[0-9]{2})",
ErrorMessage = "Informe um CPF válido!")]
        public Int64 CPF { get; set; }

        [Required(ErrorMessage = "O Nome é Obrigatório!")]
        [Display(Name = "Nome")]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "Entre 3 a 20 Caracteres")]
        [RegularExpression(@"^[a-zA-Z''-'\s]{1,40}$", ErrorMessage =
            "Números e caracteres especiais não são permitidos no nome.")]
        public string FistName { get; set; }

        [Required(ErrorMessage = "O Nome é Obrigatório!")]
        [Display(Name = "Sobrenome")]
        [StringLength(40, MinimumLength = 3, ErrorMessage = "Entre 3 a 40 Caracteres")]
        [RegularExpression(@"^[a-zA-Z''-'\s]{1,40}$", ErrorMessage =
            "Números e caracteres especiais não são permitidos no nome.")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "O Data de Nascimento é Obrigatório!")]
        [Display(Name = "Data de Nascimento")]
        public DateTime DateBirth { get; set; }

        [ForeignKey("HealthPlan")]
        [Required(ErrorMessage = "O Nome do Plano é Obrigatório!")]
        [Display(Name = "Plano de Saude")]
        public virtual HealthPlan? healthPlan { get; set; }


        [ForeignKey("Address")]
        [Required(ErrorMessage = "Endereço é Obrigatório!")]
        [Display(Name = "Endereço")]
        public virtual Address? address { get; set; }

        [ForeignKey("Company")]
        [Required(ErrorMessage = "O nome é Obrigatório!")]
        [Display(Name = "Empresa")]
        public virtual Company? companies { get; set; }
    }
}