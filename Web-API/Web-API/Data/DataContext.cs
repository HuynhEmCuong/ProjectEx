using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web_API.Models;

namespace Web_API.Data
{

    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
        public DbSet<User> Users { get; set; }
        public DbSet<Building> Building { get; set; }
        public DbSet<PDC> PDC { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<User>().HasKey(x => new { x.UserID });
            modelBuilder.Entity<Building>().HasKey(x => new { x.BuildingID });
            modelBuilder.Entity<PDC>().HasKey(x => new { x.PDCID });
        }

    }
}
