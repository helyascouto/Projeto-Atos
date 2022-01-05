using System;
using System.ComponentModel.DataAnnotations;

namespace SistemaClinica.Models
{
    public abstract class EntityBaseModel
    {
        public EntityBaseModel()
        {

        }

       

        [Key]
        public int Id { get; set; }

        [Display(Name = "Data de regidtro")]
        public DateTime DateRegister { get => DateTime.Now; }


    }
}
