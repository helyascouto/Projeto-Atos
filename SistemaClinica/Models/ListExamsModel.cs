using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SistemaClinica.Models
{
    [Table("ListExams")]
    public class ListExamsModel : EntityBaseModel
    {

        [Display(Name = "Paciente")]
        public virtual PatientModel Patient { get; set; }

        [Display(Name = "Exames")]
        public virtual ExamsModel Exams { get; set; }

        [Display(Name = "Consulta Periodica ")]
        public virtual PeriodicConsultationModel PeriodicConsultation { get; set; }

    }
}
