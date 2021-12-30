using System;
using System.ComponentModel.DataAnnotations;

namespace GestãoClinica.Models
{
    public abstract class EntityBase
    {
        public EntityBase()
        {

        }

       

        [Key]
        public int Id { get; set; }

        [Display(Name = "Data de regidtro")]
        public DateTime DateRegister { get => DateTime.Now; }


    }
}
