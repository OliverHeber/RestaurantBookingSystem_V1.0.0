﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RestaurantBookingSystem_V1._0._0.Data;

namespace RestaurantBookingSystem_V1._0._0.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20201009110604_restaurant")]
    partial class restaurant
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("RestaurantBookingSystem_V1._0._0.Data.Area", b =>
                {
                    b.Property<int>("AreaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AreaName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("FullyBooked")
                        .HasColumnType("bit");

                    b.Property<int?>("RestaurantId")
                        .HasColumnType("int");

                    b.Property<int?>("SittingId")
                        .HasColumnType("int");

                    b.HasKey("AreaId");

                    b.HasIndex("RestaurantId");

                    b.HasIndex("SittingId");

                    b.ToTable("Areas");
                });

            modelBuilder.Entity("RestaurantBookingSystem_V1._0._0.Data.Classes.Restaurant", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Available")
                        .HasColumnType("bit");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Restaurants");
                });

            modelBuilder.Entity("RestaurantBookingSystem_V1._0._0.Data.Guest", b =>
                {
                    b.Property<string>("Contact")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Contact");

                    b.ToTable("Guests");

                    b.HasData(
                        new
                        {
                            Contact = "1234",
                            FirstName = "Chris",
                            LastName = "G"
                        },
                        new
                        {
                            Contact = "Dale@dale.com",
                            FirstName = "Dale",
                            LastName = "C"
                        },
                        new
                        {
                            Contact = "75643",
                            FirstName = "Oliver",
                            LastName = "H"
                        },
                        new
                        {
                            Contact = "564324325436",
                            FirstName = "Peter",
                            LastName = "H"
                        });
                });

            modelBuilder.Entity("RestaurantBookingSystem_V1._0._0.Data.Member", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ContactNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DoB")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("RestaurantId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RestaurantId");

                    b.ToTable("Members");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ContactNumber = "123454",
                            DoB = new DateTime(2020, 10, 9, 22, 6, 4, 480, DateTimeKind.Local).AddTicks(9739),
                            Email = "Ben@ben.com",
                            FirstName = "Benn",
                            LastName = "Bennson"
                        },
                        new
                        {
                            Id = 2,
                            ContactNumber = "5645235",
                            DoB = new DateTime(2020, 10, 9, 22, 6, 4, 483, DateTimeKind.Local).AddTicks(6089),
                            Email = "Charli@Chals.com",
                            FirstName = "Charlie",
                            LastName = "Charleson"
                        },
                        new
                        {
                            Id = 3,
                            ContactNumber = "5645322",
                            DoB = new DateTime(2020, 10, 9, 22, 6, 4, 483, DateTimeKind.Local).AddTicks(6138),
                            Email = "Fake@fakeemails.com",
                            FirstName = "Mike",
                            LastName = "Mikeson"
                        });
                });

            modelBuilder.Entity("RestaurantBookingSystem_V1._0._0.Data.Reservation", b =>
                {
                    b.Property<int>("ReservationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<TimeSpan>("Duration")
                        .HasColumnType("time");

                    b.Property<string>("ReservationSource")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("StartTime")
                        .HasColumnType("datetime2");

                    b.HasKey("ReservationId");

                    b.ToTable("Reservations");
                });

            modelBuilder.Entity("RestaurantBookingSystem_V1._0._0.Data.Sitting", b =>
                {
                    b.Property<int>("SittingId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("FullyBooked")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<TimeSpan>("SittingDuration")
                        .HasColumnType("time");

                    b.Property<bool>("Special")
                        .HasColumnType("bit");

                    b.HasKey("SittingId");

                    b.ToTable("Sittings");
                });

            modelBuilder.Entity("RestaurantBookingSystem_V1._0._0.Data.Staff", b =>
                {
                    b.Property<int>("StaffId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ContactPhone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("RestaurantId")
                        .HasColumnType("int");

                    b.HasKey("StaffId");

                    b.HasIndex("RestaurantId");

                    b.ToTable("Staff");

                    b.HasData(
                        new
                        {
                            StaffId = 1,
                            ContactPhone = "4259308",
                            DateOfBirth = new DateTime(2020, 10, 9, 22, 6, 4, 483, DateTimeKind.Local).AddTicks(8210),
                            Email = "Staff1@ThisRestaurant.com",
                            FirstName = "Harold",
                            LastName = "Holt"
                        },
                        new
                        {
                            StaffId = 2,
                            ContactPhone = "05349308",
                            DateOfBirth = new DateTime(2020, 10, 9, 22, 6, 4, 483, DateTimeKind.Local).AddTicks(8748),
                            Email = "Staff2@ThisRestaurant.com",
                            FirstName = "Gemma",
                            LastName = "Gemstone"
                        },
                        new
                        {
                            StaffId = 3,
                            ContactPhone = "0534308",
                            DateOfBirth = new DateTime(2020, 10, 9, 22, 6, 4, 483, DateTimeKind.Local).AddTicks(8765),
                            Email = "Staff3@ThisRestaurant.com",
                            FirstName = "Tina",
                            LastName = "Tiny"
                        },
                        new
                        {
                            StaffId = 4,
                            ContactPhone = "05425308",
                            DateOfBirth = new DateTime(2020, 10, 9, 22, 6, 4, 483, DateTimeKind.Local).AddTicks(8769),
                            Email = "Staff4@ThisRestaurant.com",
                            FirstName = "Alfred",
                            LastName = "Alfredson"
                        },
                        new
                        {
                            StaffId = 5,
                            ContactPhone = "8634259308",
                            DateOfBirth = new DateTime(2020, 10, 9, 22, 6, 4, 483, DateTimeKind.Local).AddTicks(8772),
                            Email = "Staff5@ThisRestaurant.com",
                            FirstName = "Ben",
                            LastName = "Benderson"
                        });
                });

            modelBuilder.Entity("RestaurantBookingSystem_V1._0._0.Data.Table", b =>
                {
                    b.Property<int>("TableId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AreaId")
                        .HasColumnType("int");

                    b.Property<bool>("Booked")
                        .HasColumnType("bit");

                    b.Property<int>("Seats")
                        .HasColumnType("int");

                    b.HasKey("TableId");

                    b.HasIndex("AreaId");

                    b.ToTable("Tables");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("RestaurantBookingSystem_V1._0._0.Data.Area", b =>
                {
                    b.HasOne("RestaurantBookingSystem_V1._0._0.Data.Classes.Restaurant", null)
                        .WithMany("Areas")
                        .HasForeignKey("RestaurantId");

                    b.HasOne("RestaurantBookingSystem_V1._0._0.Data.Sitting", null)
                        .WithMany("Areas")
                        .HasForeignKey("SittingId");
                });

            modelBuilder.Entity("RestaurantBookingSystem_V1._0._0.Data.Member", b =>
                {
                    b.HasOne("RestaurantBookingSystem_V1._0._0.Data.Classes.Restaurant", null)
                        .WithMany("Members")
                        .HasForeignKey("RestaurantId");
                });

            modelBuilder.Entity("RestaurantBookingSystem_V1._0._0.Data.Staff", b =>
                {
                    b.HasOne("RestaurantBookingSystem_V1._0._0.Data.Classes.Restaurant", null)
                        .WithMany("Staff")
                        .HasForeignKey("RestaurantId");
                });

            modelBuilder.Entity("RestaurantBookingSystem_V1._0._0.Data.Table", b =>
                {
                    b.HasOne("RestaurantBookingSystem_V1._0._0.Data.Area", null)
                        .WithMany("Tables")
                        .HasForeignKey("AreaId");
                });
#pragma warning restore 612, 618
        }
    }
}
