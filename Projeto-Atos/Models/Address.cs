using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Projeto_Atos.Models
{
    [Table("Address")]
    public class Address : EntityBase

    {

        [Required(ErrorMessage = "O Telefone é Obrigatório!")]
        [Display(Name = "Telefone")]
        [RegularExpression(
             @"^\(?(?:[14689][1-9]|2[12478]|3[1234578]|5[1345]|7[134579])\)? ?(?:[2-8]|9[1-9])[0-9]{3}\-?[0-9]{4}$",
             ErrorMessage = "Informe um Tefone válido!")]
        public Int64 Telephone { get; set; }

        [Required(ErrorMessage = "O Email é Obrigatório!")]
        [Display(Name = "Email")]
        [DataType(DataType.EmailAddress, ErrorMessage = "Informe um Email válido")]
        public string Email { get; set; }

        [Required(ErrorMessage = "O Cep é Obrigatório!")]
        [Display(Name = "Cep")]
        [RegularExpression(
           @"^\d{5}-?\d{3}$",
           ErrorMessage = "Informe um Cep válido!")]
        public string ZipCod { get; set; }

        [Required(ErrorMessage = "O Numero é Obrigatório!")]
        public string Number { get; set; }

        [Required(ErrorMessage = "O Bairro é Obrigatório!")]
        public string District { get; set; }

        [Required(ErrorMessage = "O Cidade é Obrigatório!")]
        public string City { get; set; }

        [Required(ErrorMessage = "O Uf é Obrigatório!")]
        public string State { get; set; }


    }
}

