﻿// <auto-generated />
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

            modelBuilder.Entity("ARatsLifeApi.Models.Choice", b =>
                {
                    b.Property<int>("ChoiceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("PlotpointId")
                        .HasColumnType("int");

                    b.HasKey("ChoiceId");

                    b.ToTable("Choices");

                    b.HasData(
                        new
                        {
                            ChoiceId = 1,
                            Description = "Aa",
                            PlotpointId = 1
                        },
                        new
                        {
                            ChoiceId = 2,
                            Description = "Ab",
                            PlotpointId = 1
                        },
                        new
                        {
                            ChoiceId = 3,
                            Description = "Ba",
                            PlotpointId = 2
                        },
                        new
                        {
                            ChoiceId = 4,
                            Description = "Bb",
                            PlotpointId = 2
                        },
                        new
                        {
                            ChoiceId = 5,
                            Description = "Ca",
                            PlotpointId = 3
                        },
                        new
                        {
                            ChoiceId = 6,
                            Description = "Cb",
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

                    b.HasKey("ItemId");

                    b.ToTable("Items");
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
#pragma warning restore 612, 618
        }
    }
}
