using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SistemaClinica.Models
{

    [Table("Exams")]
    public class ExamsModel : EntityBaseModel
    {

        [Required(ErrorMessage = "O Nome do Exame é Obrigatório!")]
        [Display(Name = "Exame")]
        public string NameExams { get; set; }


    }

}
