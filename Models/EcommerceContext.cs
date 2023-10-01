using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceTermProject.Models
{
    public class EcommerceContext : DbContext
    {
        public EcommerceContext(DbContextOptions<EcommerceContext> options) : base(options)
        { }
        public DbSet<AddListings> ListProduct {  get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AddListings>().HasData(
                new AddListings {
                    Id = 1,
                    ProductName = "PlayStation 5",
                    City = "Detroit",
                    State = "MI"
                },
                new AddListings
                {
                    Id = 2,
                    ProductName = "Leather Couch",
                    City = "Memphis",
                    State = "TN"
                },
                new AddListings
                {
                    Id = 3,
                    ProductName = "",
                    City = "Detroit",
                    State = "MI"
                }
            );
        }
    }
}