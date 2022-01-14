using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace SistemaClinica.Models
{
    [Table("PeriodicConsultation")]
    public class PeriodicConsultationModel : EntityBaseModel
    {
        public PeriodicConsultationModel()
        {

        }

        public PeriodicConsultationModel(int idPatient, PatientModel? patient, int idDoctor, DoctorModel? doctor, int idCompany, CompanyModel? company, int idExams, ExamsModel exams, DateTime dateQuery)
        {
            IdPatient = idPatient;
            Patient = patient;
            IdDoctor = idDoctor;
            Doctor = doctor;
            IdCompany = idCompany;
            Company = company;
            IdExams = idExams;
            ExamsModel = exams;
            DateQuery = dateQuery;
        }

        [Required(ErrorMessage = "O Paciente é Obrigatório!")]
        [Display(Name = "Paciente")]
        public int IdPatient { get; set; }

        [ForeignKey("IdPatient")]
        [Display(Name = "Paciente")]
        public virtual PatientModel? Patient { get; set; }

        [Display(Name = "Médico")]
        [Required(ErrorMessage = "O Médico é Obrigatório!")]
        public int IdDoctor { get; set; }


        [ForeignKey("IdDoctor")]
        [Display(Name = "Médico")]
        public virtual DoctorModel? Doctor { get; set; }

        [Display(Name = "Empresa")]
        [Required(ErrorMessage = "A Empresa é Obrigatório!")]
        public int IdCompany { get; set; }

        [ForeignKey("IdCompany")]
        [Display(Name = "Empresa")]
        public virtual CompanyModel? Company { get; set; }


        [Display(Name = "Exames")]
        public int IdExams { get; set; }

        [ForeignKey("IdExams")]
        [Display(Name = "Exames")]
        public virtual ExamsModel? ExamsModel { get; set; }


        [Display(Name = "Data da Consulta")]
        [DataType(DataType.Date, ErrorMessage = "DD/MM/AAAA")]
        public DateTime DateQuery { get; set; }



    }
}
