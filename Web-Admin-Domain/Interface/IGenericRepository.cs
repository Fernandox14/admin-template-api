using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web_Admin_Domain.Domain.Interfaces
{
    public interface IGenericRepository<T> where T : class
    {
        public void ToDelete(T entidade);

        public void ToSave(T entidade);

        public void ToUpdate(T entidade);

        public T GetById(int id);

        IEnumerable<T> GetAll();

        public T GetByUser(T entidade);

    }
}
