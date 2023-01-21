
using Microsoft.EntityFrameworkCore;
using Web_Admin_Domain.Domain.Interfaces;
using Web_Admin_Infra.Database;

namespace Web_Admin.Infra.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly DatabaseConnection _context;
        public GenericRepository(DatabaseConnection context){
            this._context = context;
        }
       
        public IEnumerable<T> GetAll()
        {
            return _context.Set<T>().ToList();
        }

        public T GetById(int id)
        {
            return _context.Set<T>().Find(id);
        }

        public T GetByUser(T user)
        {
            return _context.Set<T>().Find(user);
        }

        public void ToDelete(T entidade)
        {
            _context.Set<T>().Remove(entidade);
            _context.SaveChanges();
        }

        public void ToSave(T entidade)
        {
            _context.Set<T>().Add(entidade);
            _context.SaveChanges();
        }

        public void ToUpdate(T entidade)
        {
            _context.Set<T>().Update(entidade);
            _context.SaveChanges();
        }

    }
}