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

        public ListExamsModel(int idPatient, PatientModel? patient, int idExams, ExamsModel? exams)
        {
            IdPatient = idPatient;
            Patient = patient;
            IdExams = idExams;
            Exams = exams;
        }


        [Display(Name = "Paciente")]
        public int? IdPatient { get; set; }

        [ForeignKey("IdPatient")]
        public virtual PatientModel? Patient { get; set; }


        [Display(Name = "Exames")]
        public int IdExams { get; set; }

        [ForeignKey("IdExams")]
        public virtual ExamsModel? Exams { get; set; }


    }
}
