using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFApps
{
    class ApplicationContext : DbContext
    {
        // Объекты таблицы Users
        public DbSet<User> Users { get; set; }

        public ApplicationContext()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=NOTEBOOK/SQLEXPRESS01;Database=EF;Trusted_Connection=True;Trust Server Certificate=true;Encrypt=false");
        }
    }
}
