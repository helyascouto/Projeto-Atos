
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Projeto_Atos.Models
{
    [Table("Exams")]
    public class Exams : EntityBase
    {

        [Required(ErrorMessage = "O Nome do Exame é Obrigatório!")]
        [Display(Name = "Exame")]
        public string NameExams { get; set; }

    }
}
