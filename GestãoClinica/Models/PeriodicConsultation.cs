
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace GestãoClinica.Models
{
    [Table("PeriodicConsultation")]
    public class PeriodicConsultation : EntityBase
    {

        [Required(ErrorMessage = "O Nome do Diagnostico é Obrigatório!")]
        public string Diagnosis { get; set; }

        [Required(ErrorMessage = "A Descrição é Obrigatório!")]
        [Display(Name = "Descrição")]
        public string Description { get; set; }

        //[ForeignKey("Patient")]
        //public int IdPatient { get; set; }

        [Required(ErrorMessage = "O Nome do Paciente é Obrigatório!")]
        [Display(Name = "Paciente")]
        public virtual Patient Patients { get; set; }

        //[ForeignKey("Doctor")]
        //public int IdDoctor { get; set; }

        [Required(ErrorMessage = "O Nome do Doutor é Obrigatório!")]
        [Display(Name = "Doutor")]
        public virtual Doctor Doctor { get; set; }

        //[ForeignKey("Company")]
        //public int IdCompany { get; set; }

        [Required(ErrorMessage = "O Nome do Empresa é Obrigatório!")]
        [Display(Name = "Empresa")]
        public virtual Company Company { get; set; }


        [Required(ErrorMessage = "O Nome do Exames é Obrigatório!")]
        [Display(Name = "Exames")]
        public virtual ICollection<Exams> Exams { get; set; }

        [DataType(DataType.Date, ErrorMessage = "Data em formato inválido")]
        public DateTime DateQuery { get; set; }

        [DataType(DataType.Date, ErrorMessage = "Data em formato inválido!")]
        public DateTime NextPeriodic { get; set; }

    }
}
