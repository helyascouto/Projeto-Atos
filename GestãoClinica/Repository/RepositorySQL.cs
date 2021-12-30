using GestãoClinica.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestãoClinica.Repository
{
    public abstract class RepositorySQL<T> : IRepository<T> where T : EntityBase
    {
        private Contexo ContextSQL = new Contexo(); 
        internal readonly DbSet<T> _Tables;

      

        RepositorySQL(Contexo contextSQL, DbSet<T> tables)
        {
            ContextSQL = contextSQL;
            _Tables = tables;
        }

        public int Add(T Entity)
        {
            _Tables.Add(Entity);
            return Entity.Id;
        }

        public int Count()
        {
           return _Tables.Count();
        }

        public void Delete(T Entity)
        {
            _Tables.Remove(Entity);
        }

        public void Edit(T Entity)
        {
            _Tables.Update(Entity);
            
        }

        public IEnumerable<T> GetAll()
        {
            return _Tables.ToList();
        }

        public T GetID(int Id)
        {
            return _Tables.Find(Id);
        }
    }
}
