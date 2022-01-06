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

        public ListExamsModel(int idPatient, PatientModel patientModel, int idExams, ExamsModel examsModel)
        {
            IdPatient = idPatient;
            PatientModel = patientModel;
            IdExams = idExams;
            ExamsModel = examsModel;
        }

        [Display(Name = "Paciente")]
        public int IdPatient { get; set; }

        [ForeignKey("IdPatient")]
        public virtual PatientModel PatientModel { get; set; }

        [Display(Name = "Exames")]
        public int IdExams { get; set; }

        [ForeignKey("IdExams")]
        public virtual ExamsModel ExamsModel { get; set; }


    }
}
