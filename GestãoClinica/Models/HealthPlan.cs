
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace GestãoClinica.Models
{
    [Table("HealthPlan")]
    public class HealthPlan : Company
    {
        //[ForeignKey("Company")]
        //public int IdCompany { get; set; }

        [Required(ErrorMessage = "O Nome do Empresa é Obrigatório!")]
        [Display(Name = "Empresa")]
        public virtual Company Company { get; set; }
    }
}
