
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace GestãoClinica.Models
{
    [Table("Exams")]
    public class Exams : EntityBase
    {

        [Required(ErrorMessage = "O Nome do Exame é Obrigatório!")]
        [Display(Name = "Exame")]
        public string NameExams { get; set; }

    }
}
