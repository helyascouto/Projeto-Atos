using System;
using System.ComponentModel.DataAnnotations;

namespace GestãoClinica.Models
{
    public abstract class EntityBase
    {
        public EntityBase()
        {

        }

        protected EntityBase(int id, DateTime dateRegister, bool ativo)
        {
            Id = id;
            DateRegister = dateRegister;
            Ativo = ativo;
        }

        [Key]
        public int Id { get; set; }
        private DateTime DateRegister;
        private bool Ativo;

        public bool SetAtivo
        {
            get { return Ativo; }
            set { Ativo = true; }
        }

        public DateTime SetDateRegister
        {
            get { return DateRegister; }
            set { DateRegister = DateTime.Now; }
        }


    }
}
