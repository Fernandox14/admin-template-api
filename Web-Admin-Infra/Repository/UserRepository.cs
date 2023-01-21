using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web_Admin.Infra.Repositories;
using Web_Admin_Domain.Domain.Interfaces;
using Web_Admin_Domain.Entities;
using Web_Admin_Domain.Interface;
using Web_Admin_Infra.Database;

namespace Web_Admin_Infra.Repository
{
    public class UserRepository: GenericRepository<User>, IUserRepository
    {
        public UserRepository(DatabaseConnection context) : base(context)
        {
        }

        public IEnumerable<User> All()
        {
            return null;
        }
    }
}
