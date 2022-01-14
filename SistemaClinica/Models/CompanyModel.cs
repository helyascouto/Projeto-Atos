using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace SistemaClinica.Models
{
    [Table("Company")]
    public class CompanyModel : AddressModel
    {
#pragma warning disable CS8618 // O propriedade não anulável 'NameCompany' precisa conter um valor não nulo ao sair do construtor. Considere declarar o propriedade como anulável.
        public CompanyModel()
#pragma warning restore CS8618 // O propriedade não anulável 'NameCompany' precisa conter um valor não nulo ao sair do construtor. Considere declarar o propriedade como anulável.
        {

        }
        public CompanyModel(string nameCompany, long cnpj)
        {
            NameCompany = nameCompany;
            CNPJ = cnpj;
        }

        [Required(ErrorMessage = "O Nome é Obrigatório!")]
        [Display(Name = "Nome da Empresa")]
        [StringLength(40, MinimumLength = 3, ErrorMessage = "Entre 3 a 40 Caracteres")]
        public string NameCompany { get; set; }


        [Required(ErrorMessage = "O CNPJ é Obrigatório!")]
        [Display(Name = "CNPJ")]
        [RegularExpression(
           @"([0-9]{14})",
           ErrorMessage = "Informe um CNPJ válido EX:00000000348945!")]
        public Int64 CNPJ { get; set; }


    }
}