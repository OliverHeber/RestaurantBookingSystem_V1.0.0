using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using RestaurantBookingSystem_V1._0._0.Data.Classes;

namespace RestaurantBookingSystem_V1._0._0.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        { }
        public DbSet<Guest> Guests { get; set; }

        public DbSet<Member> Members { get; set; }

        public DbSet<Staff> Staff { get; set; }

        public DbSet<Restaurant> Restaurants { get; set; }

        public DbSet<Reservation> Reservations { get; set; }

        public DbSet<Sitting> Sittings { get; set; }

        public DbSet<Area> Areas { get; set; }

        public DbSet<Table> Tables { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {

            builder.Entity<Guest>().HasData(

                new Guest { FirstName = "Chris", LastName = "G", Contact = "1234" },
                new Guest { FirstName = "Dale", LastName = "C", Contact = "Dale@dale.com" },
                new Guest { FirstName = "Oliver", LastName = "H", Contact = "75643" },
                new Guest { FirstName = "Peter", LastName = "H", Contact = "564324325436" }
                );


            builder.Entity<Member>().HasData(

                new Member { FirstName = "Benn", LastName = "Bennson", ContactNumber = "123454", Email = "Ben@ben.com", DoB = DateTime.Now, Id = 1, },
                new Member { FirstName = "Charlie", LastName = "Charleson", ContactNumber = "5645235", Email = "Charli@Chals.com", DoB = DateTime.Now, Id = 2, },
                new Member { FirstName = "Mike", LastName = "Mikeson", ContactNumber = "5645322", Email = "Fake@fakeemails.com", DoB = DateTime.Now, Id = 3 }
                );


            builder.Entity<Staff>().HasData(
                new Staff { StaffId = 1, FirstName = "Harold", LastName = "Holt", ContactPhone = "4259308", Email = "Staff1@ThisRestaurant.com", DateOfBirth = DateTime.Now },
                new Staff { StaffId = 2, FirstName = "Gemma", LastName = "Gemstone", ContactPhone = "05349308", Email = "Staff2@ThisRestaurant.com", DateOfBirth = DateTime.Now },
                new Staff { StaffId = 3, FirstName = "Tina", LastName = "Tiny", ContactPhone = "0534308", Email = "Staff3@ThisRestaurant.com", DateOfBirth = DateTime.Now },
                new Staff { StaffId = 4, FirstName = "Alfred", LastName = "Alfredson", ContactPhone = "05425308", Email = "Staff4@ThisRestaurant.com", DateOfBirth = DateTime.Now },
                new Staff { StaffId = 5, FirstName = "Ben", LastName = "Benderson", ContactPhone = "8634259308", Email = "Staff5@ThisRestaurant.com", DateOfBirth = DateTime.Now }
                );
            base.OnModelCreating(builder);
        }

    }

}
