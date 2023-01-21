using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web_Admin_Domain.Domain.Interfaces;
using Web_Admin_Domain.Entities;

namespace Web_Admin_Domain.Interface
{
    public interface IUserRepository: IGenericRepository<User>
    {
        public IEnumerable<User> All();
    }
}
