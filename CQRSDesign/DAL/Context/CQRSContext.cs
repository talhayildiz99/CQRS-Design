﻿using CQRSDesign.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace CQRSDesign.DAL.Context
{
    public class CQRSContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-DSQNOEI\\SQLEXPRESS03; initial catalog = DbCQRS; integrated security = true");
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}