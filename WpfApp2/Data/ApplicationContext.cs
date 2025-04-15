using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp2.Model;

namespace WpfApp2.Data
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Company> Companies { get; set; }
        public DbSet<Inventory> Inventories { get; set; }
        public ApplicationContext()
        {
            if (Database.EnsureCreated() == true)
            {
                Companies.Load();
                Inventories.Load();
            }
            else
            {
                Companies.Load();
                Inventories.Load();
                Companies.AddRange(companies);
                SaveChanges();
            }
        }

        List<Company> companies = new List<Company>()
        {
            new Company()
            {
                Name = "Test",
                PhomeNumber = "2134567890"
            }
        };
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=biba.db");
        }
    }
}
