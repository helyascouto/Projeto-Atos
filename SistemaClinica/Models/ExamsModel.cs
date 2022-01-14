using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SistemaClinica.Models
{

    [Table("Exams")]
    public class ExamsModel : EntityBaseModel
    {

        [Required(ErrorMessage = "O Nome do Exame é Obrigatório!")]
        [Display(Name = "Exame")]
#pragma warning disable CS8618 // O propriedade não anulável 'NameExams' precisa conter um valor não nulo ao sair do construtor. Considere declarar o propriedade como anulável.
        public string NameExams { get; set; }
#pragma warning restore CS8618 // O propriedade não anulável 'NameExams' precisa conter um valor não nulo ao sair do construtor. Considere declarar o propriedade como anulável.


    }

}
