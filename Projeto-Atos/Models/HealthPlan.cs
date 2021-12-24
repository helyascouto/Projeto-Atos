
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Projeto_Atos.Models
{
    [Table("HealthPlan")]
    public class HealthPlan : Company
    {
        [DataType(DataType.Date, ErrorMessage = "Data em formato inválido!")]
        public DateTime DateRegister { get; set; }


        [Required(ErrorMessage = "O Nome do Empresa é Obrigatório!")]
        [Display(Name = "Empresa")]
        public virtual Company Company { get; set; }
    }
}
