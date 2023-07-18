using Microsoft.EntityFrameworkCore;
using SeedData.Medels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeedData.Data
{
    public class DbUser : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Server=localhost; Port=5432; User Id=postgres; Password=0124; Database=DbUser");
            base.OnConfiguring(optionsBuilder);
        }
        
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(new List<User> {
                new User { Id = 1, Name = "Sevinch", Email = "sev@gmail.com", Password = "0124"},
                new User { Id = 2, Name = "Sadaf" , Email = "sad@gamil.com", Password = "0123" },
                new User { Id = 3, Name = "Go`zal" , Email = "gozal@gmail.com", Password = "0213"},
            });
            base.OnModelCreating(modelBuilder);
        }
    }
}
