
using System;
using System.Collections.Generic;
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

        public PeriodicConsultationModel(int idPatient, PatientModel patient, int idDoctor, DoctorModel doctor, int idCompany, CompanyModel company, int idExams, ExamsModel exams, DateTime dateQuery)
        {
            IdPatient = idPatient;
            Patient = patient;
            IdDoctor = idDoctor;
            Doctor = doctor;
            IdCompany = idCompany;
            Company = company;
            IdExams = idExams;
            Exams = exams;
            DateQuery = dateQuery;
       
        }
        [Required(ErrorMessage = "O Paciente é Obrigatório!")]
        [Display(Name = "Paciente")]
        public int IdPatient { get; set; }

        [ForeignKey("IdPatient")]
        public virtual PatientModel? Patient { get; set; }

        [Required(ErrorMessage = "O Médico é Obrigatório!")]
        [Display(Name = "Médico")]
        public int IdDoctor { get; set; }

       
        [ForeignKey("IdDoctor")]
        public virtual DoctorModel? Doctor { get; set; }

        [Required(ErrorMessage = "A Empresa é Obrigatório!")]
        [Display(Name = "Empresa")]
        public int IdCompany { get; set; }

      [ForeignKey("IdCompany")]
        public virtual CompanyModel? Company { get; set; }

       
        [Display(Name = "Exames")]
        public int IdExams { get; set; }

        [ForeignKey("IdExams")]
        public virtual ExamsModel? Exams { get; set; }

       
        [Display(Name = "Data da Consulta")]
        [DataType(DataType.Date, ErrorMessage = "DD/MM/AAAA")]
        public DateTime DateQuery { get; set; }



    }
}
