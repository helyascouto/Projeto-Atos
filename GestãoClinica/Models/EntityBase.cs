using System;
using System.ComponentModel.DataAnnotations;

namespace GestãoClinica.Models
{
    public abstract class EntityBase
    {
        [Key]
        public int Id { get; set; }
        public bool Ativo { get; set; }
        public DateTime DateRegister { get; set; }
    }
}
