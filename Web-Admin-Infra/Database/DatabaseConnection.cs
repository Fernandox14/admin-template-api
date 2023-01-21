using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using Web_Admin_Domain.Entities;

namespace Web_Admin_Infra.Database
{
    public class DatabaseConnection : DbContext
    {
        public DatabaseConnection(DbContextOptions<DatabaseConnection> options) : base(options){}

        protected override void OnModelCreating(ModelBuilder modelBuilder){}
        public DbSet<User> User { get; set; }
        public DbSet<UserLevel> UserLevel { get; set; }
    }
}
