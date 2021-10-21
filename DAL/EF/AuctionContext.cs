using System;
using System.Configuration;

using Microsoft.EntityFrameworkCore;

using DTO.Models;

namespace DAL.EF
{
    public class AuctionContext : DbContext
    {
        public DbSet<UserDto> Users { get; set; }
        public DbSet<ProductDto> Products { get; set; }
        public DbSet<CategoryDto> Categories { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            try
            {
                optionsBuilder.UseSqlServer(@"Server=.;Database=UserAuctionTest;Trusted_Connection=True;");//ConfigurationManager.ConnectionStrings["conn"].ConnectionString);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
        }

    }
}

