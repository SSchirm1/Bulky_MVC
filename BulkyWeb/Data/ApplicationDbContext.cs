﻿using BulkyWeb.Models;
using Microsoft.EntityFrameworkCore;

namespace BulkyWeb.Data
{
    public class ApplicationDbContext : DbContext
    {
        // inherits from the DbContext class
        // have to pass the connection string from appsettings into the constructor

        // the options configured in the constructor is passed in to the base class (DbContext)
        // to register the ApplicationDbContext class, we have to do it in Program.cs
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Comedy", DisplayOrder = 1 },
                new Category { Id = 2, Name = "Documentary", DisplayOrder = 2 },
                new Category { Id = 3, Name = "Action", DisplayOrder = 3 }
            );

        }


    }
}
