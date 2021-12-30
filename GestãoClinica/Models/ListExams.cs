using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GestãoClinica.Models
{
    [Table("ListExams")]
    public class ListExams : EntityBase
    {

        [Display(Name = "Paciente")]
        public virtual Patient Patient { get; set; }

        [Display(Name = "Exames")]
        public virtual Exams Exams { get; set; }

        [Display(Name = "Consulta Periodica ")]
        public virtual PeriodicConsultation PeriodicConsultation { get; set; }

    }
}
