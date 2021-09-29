using CourseProject.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace CourseProject.EF
{
    public class AuctionContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            try
            {
                optionsBuilder.UseSqlServer("Server=DESKTOP-U3J331Q;Database=UserAuction;Trusted_Connection=True;");
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
        }

    }
}

