
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace GestãoClinica.Models
{
    [Table("PeriodicConsultation")]
    public class PeriodicConsultation : EntityBase
    {
        public PeriodicConsultation()
        {

        }

        public PeriodicConsultation(int idPatient, Patient patient, int idDoctor, Doctor doctor, int idCompany, Company company, int idExams, Exams exams, DateTime dateQuery, bool ativo)
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
            Ativo = ativo;
        }

        [Display(Name = "Paciente")]
        public int IdPatient { get; set; }

        //[Required(ErrorMessage = "O Paciente é Obrigatório!")]
        [ForeignKey("IdPatient")]
        public virtual Patient Patient { get; set; }

        [Display(Name = "Médico")]
        public int IdDoctor { get; set; }

        //[Required(ErrorMessage = "O Médico é Obrigatório!")]
        [ForeignKey("IdDoctor")]
        public virtual Doctor Doctor { get; set; }

        [Display(Name = "Empresa")]
        public int IdCompany { get; set; }

        // [Required(ErrorMessage = "A Empresa é Obrigatório!")]
        [ForeignKey("IdCompany")]
        public virtual Company Company { get; set; }


        [Display(Name = "Exames")]
        public int IdExams { get; set; }

        [ForeignKey("IdExams")]
        public virtual Exams Exams { get; set; }

       
        [Display(Name = "Data da Consulta")]
        [DataType(DataType.Date, ErrorMessage = "Data em formato inválido")]
        public DateTime DateQuery { get; set; }


        //[Required(ErrorMessage = "O Nome do Diagnostico é Obrigatório!")]
        [Display(Name = "Ativo")]
        public bool Ativo { get; set; }

    }
}
