using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace SistemaClinica.Models
{
    [Table("Company")]
    public class CompanyModel : AddressModel
    {
        public CompanyModel()
        {

        }
        public CompanyModel(string nameCompany, long cnpj)
        {
            NameCompany = nameCompany;
            CNPJ = cnpj;
        }

        [Required(ErrorMessage = "O Nome é Obrigatório!")]
        [Display(Name = "Empresa")]
        [StringLength(40, MinimumLength = 3, ErrorMessage = "Entre 3 a 40 Caracteres")]
        [RegularExpression(@"^[a-zA-Z''-'\s]{1,40}$", ErrorMessage =
            "Números e caracteres especiais não são permitidos no nome.")]
        public string NameCompany { get; set; }


        [Required(ErrorMessage = "O CNPJ é Obrigatório!")]
        [Display(Name = "CNPJ")]
        [RegularExpression(
           @"([0-9]{14})",
           ErrorMessage = "Informe um CNPJ válido EX:00000000348945!")]

        public Int64 CNPJ { get; set; }


    }
}