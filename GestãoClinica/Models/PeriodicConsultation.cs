
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
        public PeriodicConsultation(int idPatient, Patient patients, int idDoctor, Doctor doctor, int idCompany, Company company, ICollection<Exams> exams, string diagnosis, string description, DateTime dateQuery, DateTime nextPeriodic)
        {
            IdPatient = idPatient;
            Patients = patients;
            IdDoctor = idDoctor;
            Doctor = doctor;
            IdCompany = idCompany;
            Company = company;
            Exams = exams;
            Diagnosis = diagnosis;
            Description = description;
            DateQuery = dateQuery;
            NextPeriodic = nextPeriodic;
        }

        [ForeignKey("Patient")]
        public int IdPatient { get; set; }

        //[Required(ErrorMessage = "O Paciente é Obrigatório!")]
        [Display(Name = "Paciente")]
        public virtual Patient? Patients { get; set; }

        [ForeignKey("Doctor")]
        public int IdDoctor { get; set; }

        // [Required(ErrorMessage = "O Médico é Obrigatório!")]
        [Display(Name = "Médico")]
        public virtual Doctor? Doctor { get; set; }

        [ForeignKey("Company")]
        public int IdCompany { get; set; }

        //[Required(ErrorMessage = "A Empresa é Obrigatório!")]
        [Display(Name = "Empresa")]
        public virtual Company? Company { get; set; }

        [Required(ErrorMessage = "O Nome do Exames é Obrigatório!")]
        [Display(Name = "Exames")]
        public virtual ICollection<Exams> Exams { get; set; }

        [Required(ErrorMessage = "O Nome do Diagnostico é Obrigatório!")]
        [Display(Name = "Diagnóstico")]
        public string Diagnosis { get; set; }

        [Display(Name = "Descrição")]
        public string Description { get; set; }

        [Display(Name = "Data da Consulta")]
        [DataType(DataType.Date, ErrorMessage = "Data em formato inválido")]
        public DateTime DateQuery { get; set; }

        [Display(Name = "Próxima consulta")]
        [DataType(DataType.Date, ErrorMessage = "Data em formato inválido!")]
        public DateTime NextPeriodic { get; set; }

    }
}
