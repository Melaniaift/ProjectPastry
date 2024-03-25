using Microsoft.EntityFrameworkCore;
using PASTRY.DomainEntities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PASTRYInfrastructure.DataAccess
{
    public class MvcCakeContext : DbContext
    {
        private string connectionString;


        public MvcCakeContext(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public MvcCakeContext(DbContextOptions<MvcCakeContext> options)
            : base(options)
        {
        }

        public DbSet<Cake> Cake { get; set; }

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
