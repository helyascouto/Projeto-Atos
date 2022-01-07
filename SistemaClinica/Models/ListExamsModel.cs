using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SistemaClinica.Models
{
    [Table("ListExams")]
    public class ListExamsModel : EntityBaseModel
    {
        public ListExamsModel()
        {

        }

        [Required(ErrorMessage = " O Paciente é Obrigatório!")]
        [Display(Name = "Paciente")]
        public int IdPatient { get; set; }

        [ForeignKey("IdPatient")]
        public virtual PatientModel? Patient { get; set; }

        [Required(ErrorMessage = " Exames é Obrigatório!")]
        [Display(Name = "Exames")]
        public int IdExams { get; set; }

        [ForeignKey("IdExams")]
        public virtual ExamsModel? Exams { get; set; }


    }
}
