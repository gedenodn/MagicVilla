using System;
using MagicVilla_VillaAPI.Models;
using Microsoft.EntityFrameworkCore;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace MagicVilla_VillaAPI.Data
{
	public class ApplicationDbContext : DbContext
	{ 
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
		{

		}
        

        public DbSet<Villa> Villas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
			modelBuilder.Entity<Villa>().HasData(
				new Villa()
				{
					Id = 1,
					Name = "Royal Villa",
					Details = "Best Villa",
					ImageUrl = "https://www.google.com/url?sa=i&url=https%3A%2F%2Fprorus.ru%2Fprojects%2Fvilla-julia-v-sochi%2F&psig=AOvVaw33QXfCdTW1JpQ9MH--Ekgk&ust=1697719265695000&source=images&cd=vfe&opi=89978449&ved=0CBEQjRxqFwoTCOCOk6HP_4EDFQAAAAAdAAAAABAE",
					Occupancy = 5,
					Rate = 200,
					Sqft = 550,
					Amenity = "",
					CreatedDate = DateTime.Now
				}
				);
        }
    }
}

