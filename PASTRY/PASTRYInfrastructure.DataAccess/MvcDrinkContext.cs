using Microsoft.EntityFrameworkCore;
using PASTRY.DomainEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PASTRY.Data
{
    public class MvcDrinkContext : DbContext
    {
        private string connectionString;


        public MvcDrinkContext(string connectionString)
        {
            this.connectionString = connectionString;
        }
        public MvcDrinkContext(DbContextOptions<MvcDrinkContext> options)
            : base(options)
        {
        }

        /*public MvcDrinkContext(DbContextOptions options)
            : base(options)
        {
        }*/

        public DbSet<Drink> Drink { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            var connectionString = "Server = (localdb)\\mssqllocaldb; Database = PASTRY-1; Trusted_Connection = True; MultipleActiveResultSets = true";
            optionsBuilder.UseSqlServer(connectionString);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(this.GetType().Assembly);
        }
    }
}
