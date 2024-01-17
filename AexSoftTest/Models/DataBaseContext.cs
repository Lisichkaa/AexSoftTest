using Microsoft.EntityFrameworkCore.Sqlite;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AexSoftTest.Models
{
    public class DataBaseContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Manager> Managers { get; set; }
        public DbSet<Order> Orders { get; set; }

        public DataBaseContext()
        {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        //C: \Users\Lisichka\source\repos\AexSoftTest\AexSoftTest\aexsoft.db
            optionsBuilder.UseSqlite("Filename=\\aexsoft.db");
        }
    }


}
