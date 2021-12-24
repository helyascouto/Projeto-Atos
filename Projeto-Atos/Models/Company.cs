
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Projeto_Atos.Models
{
    [Table("Company")]
    public class Company : EntityBase
    {

        [Required(ErrorMessage = "O Nome é Obrigatório!")]
        [Display(Name = "Empresa")]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "Entre 3 a 20 Caracteres")]
        [RegularExpression(@"^[a-zA-Z''-'\s]{1,40}$", ErrorMessage =
            "Números e caracteres especiais não são permitidos no nome.")]
        public string NameCompany { get; set; }


        [Required(ErrorMessage = "O CNPJ é Obrigatório!")]
        [Display(Name = "CNPJ")]
        [RegularExpression(
           @"([0-9]{2}[\.]?[0-9]{3}[\.]?[0-9]{3}[\/]?[0-9]{4}[-]?[0-9]{2})|([0-9]{3}[\.]?[0-9]{3}[\.]?[0-9]{3}[-]?[0-9]{2})",
           ErrorMessage = "Informe um CNPJ válido!")]
        public Int64 CNPJ { get; set; }

        [Required(ErrorMessage = "Endereço é Obrigatório!")]
        [Display(Name = "Endereço")]
        public virtual Address? Address { get; set; }

    }
}