using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace SistemaClinica.Models
{
    [Table("Address")]

    public abstract class AddressModel : EntityBaseModel

    {
#pragma warning disable CS8618 // O propriedade não anulável 'District' precisa conter um valor não nulo ao sair do construtor. Considere declarar o propriedade como anulável.
#pragma warning disable CS8618 // O propriedade não anulável 'ZipCod' precisa conter um valor não nulo ao sair do construtor. Considere declarar o propriedade como anulável.
#pragma warning disable CS8618 // O propriedade não anulável 'Number' precisa conter um valor não nulo ao sair do construtor. Considere declarar o propriedade como anulável.
#pragma warning disable CS8618 // O propriedade não anulável 'State' precisa conter um valor não nulo ao sair do construtor. Considere declarar o propriedade como anulável.
#pragma warning disable CS8618 // O propriedade não anulável 'Email' precisa conter um valor não nulo ao sair do construtor. Considere declarar o propriedade como anulável.
#pragma warning disable CS8618 // O propriedade não anulável 'City' precisa conter um valor não nulo ao sair do construtor. Considere declarar o propriedade como anulável.
#pragma warning disable CS8618 // O propriedade não anulável 'Telephone' precisa conter um valor não nulo ao sair do construtor. Considere declarar o propriedade como anulável.
#pragma warning disable CS8618 // O propriedade não anulável 'Street' precisa conter um valor não nulo ao sair do construtor. Considere declarar o propriedade como anulável.
        public AddressModel()
#pragma warning restore CS8618 // O propriedade não anulável 'Street' precisa conter um valor não nulo ao sair do construtor. Considere declarar o propriedade como anulável.
#pragma warning restore CS8618 // O propriedade não anulável 'Telephone' precisa conter um valor não nulo ao sair do construtor. Considere declarar o propriedade como anulável.
#pragma warning restore CS8618 // O propriedade não anulável 'City' precisa conter um valor não nulo ao sair do construtor. Considere declarar o propriedade como anulável.
#pragma warning restore CS8618 // O propriedade não anulável 'Email' precisa conter um valor não nulo ao sair do construtor. Considere declarar o propriedade como anulável.
#pragma warning restore CS8618 // O propriedade não anulável 'State' precisa conter um valor não nulo ao sair do construtor. Considere declarar o propriedade como anulável.
#pragma warning restore CS8618 // O propriedade não anulável 'Number' precisa conter um valor não nulo ao sair do construtor. Considere declarar o propriedade como anulável.
#pragma warning restore CS8618 // O propriedade não anulável 'ZipCod' precisa conter um valor não nulo ao sair do construtor. Considere declarar o propriedade como anulável.
#pragma warning restore CS8618 // O propriedade não anulável 'District' precisa conter um valor não nulo ao sair do construtor. Considere declarar o propriedade como anulável.
        {

        }
#pragma warning disable CS8618 // O propriedade não anulável 'Street' precisa conter um valor não nulo ao sair do construtor. Considere declarar o propriedade como anulável.
        protected AddressModel(string telephone, string email, string zipCod, string number, string district, string city, string state)
#pragma warning restore CS8618 // O propriedade não anulável 'Street' precisa conter um valor não nulo ao sair do construtor. Considere declarar o propriedade como anulável.
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
        [StringLength(11, MinimumLength = 10, ErrorMessage = "DDD+Numero do Telefone")]
        public string Telephone { get; set; }

        [Required(ErrorMessage = "O E-mail é Obrigatório!")]
        [Display(Name = "E-mail")]
        [DataType(DataType.EmailAddress, ErrorMessage = "Informe um E-mail válido")]
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

        [Display(Name = "Número")]
        public string Number { get; set; }

        [Display(Name = "Estado")]
        [Required(ErrorMessage = "O Estado é Obrigatório!")]
        public string State { get; set; }


    }
}

