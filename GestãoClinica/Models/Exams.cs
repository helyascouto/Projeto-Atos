
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace GestãoClinica.Models
{
    [Table("Exams")]
    public class Exams : EntityBase
    {
        public Exams()
        {

        }
        public Exams(string nameExams)
        {
            NameExams = nameExams;
        }

        [Required(ErrorMessage = "O Nome do Exame é Obrigatório!")]
        [Display(Name = "Exame")]
        public string NameExams { get; set; }


    }
}
