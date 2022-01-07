using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace SistemaClinica.Models
{
    [Table("Address")]

    public abstract class AddressModel : EntityBaseModel

    {
        public AddressModel()
        {

        }
        protected AddressModel(long telephone, string email, string zipCod, string number, string district, string city, string state)
        {
            Telephone = telephone;
            Email = email;
            ZipCod = zipCod;
            Number = number;
            District = district;
            City = city;
            State = state;
        }

        [Required(ErrorMessage = "O Telefone é Obrigatório!")]
        [Display(Name = "Telefone")]
        [RegularExpression(
             @"^\(?(?:[14689][1-9]|2[12478]|3[1234578]|5[1345]|7[134579])\)? ?(?:[2-8]|9[1-9])[0-9]{3}\-?[0-9]{4}$",
             ErrorMessage = "Informe um Telefone válido:")]
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
     
        
        [Display(Name = "Cidade")]
        [Required(ErrorMessage = "O Cidade é Obrigatório!")]
        public string City { get; set; }

        [Display(Name = "Bairro")]
        [Required(ErrorMessage = "O Bairro é Obrigatório!")]
        public string District { get; set; }

        [Display(Name = "Rua")]
        [Required(ErrorMessage = "A Rua é Obrigatório!")]
        public string Street { get; set; }

        [Display(Name = "Numero")]
        public string Number { get; set; }

        [Display(Name = "Estado")]
        [Required(ErrorMessage = "O Estado é Obrigatório!")]
        public string State { get; set; }


    }
}

