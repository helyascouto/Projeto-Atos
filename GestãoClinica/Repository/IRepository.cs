using GestãoClinica.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestãoClinica.Repository
{
    public interface IRepository<T> where T : EntityBase
    {
        int Add(T Entity);
        void Edit(T Entity);
        void Delete(T Entity);
        T GetID(int Id);
        IEnumerable<T> GetAll();
        int Count();
    }
}
