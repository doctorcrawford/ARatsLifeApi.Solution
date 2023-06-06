﻿// <auto-generated />
using System;
using ARatsLifeApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ARatsLifeApi.Migrations
{
    [DbContext(typeof(ARatsLifeApiContext))]
    partial class ARatsLifeApiContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("ARatsLifeApi.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("longtext");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("longtext");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("longtext");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("longtext");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("ARatsLifeApi.Models.Choice", b =>
                {
                    b.Property<int>("ChoiceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("HeatLevel")
                        .HasColumnType("int");

                    b.Property<int>("PlotpointId")
                        .HasColumnType("int");

                    b.HasKey("ChoiceId");

                    b.ToTable("Choices");

                    b.HasData(
                        new
                        {
                            ChoiceId = 1,
                            Description = "Aa",
                            HeatLevel = 30,
                            PlotpointId = 1
                        },
                        new
                        {
                            ChoiceId = 2,
                            Description = "Ab",
                            HeatLevel = 0,
                            PlotpointId = 1
                        },
                        new
                        {
                            ChoiceId = 3,
                            Description = "Ba",
                            HeatLevel = 10,
                            PlotpointId = 2
                        },
                        new
                        {
                            ChoiceId = 4,
                            Description = "Bb",
                            HeatLevel = 25,
                            PlotpointId = 2
                        },
                        new
                        {
                            ChoiceId = 5,
                            Description = "Ca",
                            HeatLevel = 0,
                            PlotpointId = 3
                        },
                        new
                        {
                            ChoiceId = 6,
                            Description = "Cb",
                            HeatLevel = 35,
                            PlotpointId = 3
                        });
                });

            modelBuilder.Entity("ARatsLifeApi.Models.Inventory", b =>
                {
                    b.Property<int>("InventoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("ItemId")
                        .HasColumnType("int");

                    b.Property<int>("RatId")
                        .HasColumnType("int");

                    b.HasKey("InventoryId");

                    b.ToTable("Inventories");
                });

            modelBuilder.Entity("ARatsLifeApi.Models.Item", b =>
                {
                    b.Property<int>("ItemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("InventoryId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("Value")
                        .HasColumnType("int");

                    b.HasKey("ItemId");

                    b.ToTable("Items");

                    b.HasData(
                        new
                        {
                            ItemId = 1,
                            InventoryId = 1,
                            Name = "Gucci Belt",
                            Value = 25
                        },
                        new
                        {
                            ItemId = 2,
                            InventoryId = 2,
                            Name = "Balenciaga Sunglasses",
                            Value = 35
                        },
                        new
                        {
                            ItemId = 3,
                            InventoryId = 3,
                            Name = "Louis Vuitton Necktie",
                            Value = 15
                        },
                        new
                        {
                            ItemId = 4,
                            InventoryId = 4,
                            Name = "Hermez Birken Bag",
                            Value = 50
                        },
                        new
                        {
                            ItemId = 5,
                            InventoryId = 5,
                            Name = "Rolex Wristwatch",
                            Value = 40
                        },
                        new
                        {
                            ItemId = 6,
                            InventoryId = 6,
                            Name = "White Stilton Gold Cheese",
                            Value = 50
                        },
                        new
                        {
                            ItemId = 7,
                            InventoryId = 7,
                            Name = "$200, Straight Up",
                            Value = 15
                        },
                        new
                        {
                            ItemId = 8,
                            InventoryId = 8,
                            Name = "Silver Tiffany Tennis Bracelet",
                            Value = 20
                        },
                        new
                        {
                            ItemId = 9,
                            InventoryId = 9,
                            Name = "Gucci Slides (Whatever those are)",
                            Value = 10
                        },
                        new
                        {
                            ItemId = 10,
                            InventoryId = 10,
                            Name = "Versace Platform Heels",
                            Value = 30
                        });
                });

            modelBuilder.Entity("ARatsLifeApi.Models.Plotpoint", b =>
                {
                    b.Property<int>("PlotpointId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("StoryPosition")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("PlotpointId");

                    b.ToTable("Plotpoints");

                    b.HasData(
                        new
                        {
                            PlotpointId = 1,
                            Description = "plotpoint A",
                            StoryPosition = 1,
                            Title = "A"
                        },
                        new
                        {
                            PlotpointId = 2,
                            Description = "plotpoint B",
                            StoryPosition = 2,
                            Title = "B"
                        },
                        new
                        {
                            PlotpointId = 3,
                            Description = "plotpoint C",
                            StoryPosition = 3,
                            Title = "C"
                        },
                        new
                        {
                            PlotpointId = 4,
                            Description = "plotpoint D",
                            StoryPosition = 4,
                            Title = "D"
                        },
                        new
                        {
                            PlotpointId = 5,
                            Description = "plotpoint E",
                            StoryPosition = 5,
                            Title = "E"
                        });
                });

            modelBuilder.Entity("ARatsLifeApi.Models.Rat", b =>
                {
                    b.Property<int>("RatId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Heat")
                        .HasColumnType("int");

                    b.Property<int>("InventoryId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.HasKey("RatId");

                    b.ToTable("Rats");

                    b.HasData(
                        new
                        {
                            RatId = 1,
                            Heat = 40,
                            InventoryId = 1,
                            Name = "Remy le Rouge"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ClaimType")
                        .HasColumnType("longtext");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("longtext");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ClaimType")
                        .HasColumnType("longtext");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("longtext");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("longtext");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("RoleId")
                        .HasColumnType("varchar(255)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Name")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Value")
                        .HasColumnType("longtext");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
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
                    b.HasOne("ARatsLifeApi.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("ARatsLifeApi.Models.ApplicationUser", null)
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

                    b.HasOne("ARatsLifeApi.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("ARatsLifeApi.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
