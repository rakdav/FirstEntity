using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbFromCSV
{
    internal class IrisContext:DbContext
    {
        public IrisContext() 
        {
            Database.EnsureCreated();
        }
        public DbSet<Iris> Iris { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=postgres;" +
                "Username=postgres;Password=postgres");
        }
    }
}
