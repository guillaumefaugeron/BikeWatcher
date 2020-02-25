using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BikeWatcher.Models;
using Microsoft.EntityFrameworkCore;

namespace BikeWatcher.Data
{
    public class FavorisContext : DbContext
    {
        public FavorisContext(DbContextOptions<FavorisContext> options) : base(options)
        {
        }

        public DbSet<Favoris> Favoris { get; set; }
        public DbSet<SignVelo> SignVelo { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SignVelo>().ToTable("SignVelo");

            modelBuilder.Entity<Favoris>().ToTable("Favoris");


        }


    }
}
