
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Projeto_Atos.Models{
    [Table("PeriodicConsultation")]
    public class PeriodicConsultation 
    {

        [Required(ErrorMessage = "O Nome do Diagnostico é Obrigatório!")]
        public string Diagnosis { get; set; }

        [Required(ErrorMessage = "A Descrição é Obrigatório!")]
        [Display(Name = "Descrição")]
        public string Description { get; set; }

        [Required(ErrorMessage = "O Nome do Paciente é Obrigatório!")]
        [Display(Name = "Paciente")]
        public Patient Patients { get; set; }

        [Required(ErrorMessage = "O Nome do Doutor é Obrigatório!")]
        [Display(Name = "Doutor")]
        public Doctor Doctor { get; set; }

        [Required(ErrorMessage = "O Nome do Empresa é Obrigatório!")]
        [Display(Name = "Empresa")]
        public Company Company { get; set; }


        [Required(ErrorMessage = "O Nome do Exames é Obrigatório!")]
        [Display(Name = "Exames")]
        public List<Exams> Exams { get; set; }

        [DataType(DataType.Date, ErrorMessage = "Data em formato inválido")]
        public DateTime DateQuery { get; set; }

        [DataType(DataType.Date, ErrorMessage = "Data em formato inválido!")]
        public DateTime NextPeriodic { get; set; }

    }
}
