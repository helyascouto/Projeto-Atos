using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace SistemaClinica.Models
{
    [Table("Doctor")]
    public class DoctorModel : AddressModel
    {
#pragma warning disable CS8618 // O propriedade não anulável 'LastName' precisa conter um valor não nulo ao sair do construtor. Considere declarar o propriedade como anulável.
#pragma warning disable CS8618 // O propriedade não anulável 'FistName' precisa conter um valor não nulo ao sair do construtor. Considere declarar o propriedade como anulável.
        public DoctorModel()
#pragma warning restore CS8618 // O propriedade não anulável 'FistName' precisa conter um valor não nulo ao sair do construtor. Considere declarar o propriedade como anulável.
#pragma warning restore CS8618 // O propriedade não anulável 'LastName' precisa conter um valor não nulo ao sair do construtor. Considere declarar o propriedade como anulável.
        {

        }
        public DoctorModel(long crm, long cpf, string fistName, string lastName, DateTime dateBirth)
        {
            CRM = crm;
            CPF = cpf;
            FistName = fistName;
            LastName = lastName;
            DateBirth = dateBirth;
        }



        [Display(Name = "CRM")]
        public Int64? CRM { get; set; }

        [Required(ErrorMessage = "O CPF é Obrigatório!")]
        [Display(Name = "CPF")]
        [RegularExpression(
               @"([0-9]{2}[\.]?[0-9]{3}[\.]?[0-9]{3}[\/]?[0-9]{4}[-]?[0-9]{2})|([0-9]{3}[\.]?[0-9]{3}[\.]?[0-9]{3}[-]?[0-9]{2})",
               ErrorMessage = "Informe um CPF válido!")]
        public Int64? CPF { get; set; }

        [Required(ErrorMessage = "O Nome é Obrigatório!")]
        [Display(Name = "Nome")]
        [StringLength(40, MinimumLength = 3, ErrorMessage = "Entre 3 a 40 Caracteres")]
        public string FistName { get; set; }

        [Required(ErrorMessage = "O Nome é Obrigatório!")]
        [Display(Name = "Sobrenome")]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "Entre 3 a 20 Caracteres")]

        public string LastName { get; set; }

        [DataType(DataType.Date, ErrorMessage = "Data em formato inválido!")]
        [Required(ErrorMessage = "O Data de Nascimento é Obrigatório!")]
        [Display(Name = "Data de Nascimento")]
        public DateTime DateBirth { get; set; }


    }
}
