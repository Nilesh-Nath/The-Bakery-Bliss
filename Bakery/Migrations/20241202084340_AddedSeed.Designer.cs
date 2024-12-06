﻿// <auto-generated />
using Bakery.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Bakery.Migrations
{
    [DbContext(typeof(BakeryContext))]
    [Migration("20241202084340_AddedSeed")]
    partial class AddedSeed
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Bakery.Model.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("ImageFileName");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "A scrumptious carrot cake encrusted with sliced almonds",
                            ImageName = "carrot-cake.jpg",
                            Name = "Carrot Cake",
                            Price = 8.99m
                        },
                        new
                        {
                            Id = 2,
                            Description = "A delicious lemon tart smothered with juicy fresh fruit",
                            ImageName = "lemon-tart.jpg",
                            Name = "Lemon Tart",
                            Price = 9.99m
                        },
                        new
                        {
                            Id = 3,
                            Description = "Delectable vanilla and chocolate cupcakes",
                            ImageName = "cup-cakes.jpg",
                            Name = "Cupcakes",
                            Price = 5.99m
                        },
                        new
                        {
                            Id = 4,
                            Description = "Fresh baked French-style bread, bagettes and cobs",
                            ImageName = "bread.jpg",
                            Name = "Bread",
                            Price = 2.49m
                        },
                        new
                        {
                            Id = 5,
                            Description = "Deliciously chewy freshly made New York-style bagels.",
                            ImageName = "bagels.jpg",
                            Name = "Bagels",
                            Price = 5.99m
                        },
                        new
                        {
                            Id = 6,
                            Description = "Rich chocolate frosting cover this chocolate lover's dream",
                            ImageName = "chocolate-cake.jpg",
                            Name = "Chocolate Cake",
                            Price = 8.99m
                        },
                        new
                        {
                            Id = 7,
                            Description = "Fudgy, gooey and super chocolaty with a crispy top",
                            ImageName = "brownie.jpg",
                            Name = "Brownies",
                            Price = 5.99m
                        },
                        new
                        {
                            Id = 8,
                            Description = "Sweet, light, airy and perfect with your afternoon tea",
                            ImageName = "buns.jpg",
                            Name = "Sweet Buns",
                            Price = 3.49m
                        },
                        new
                        {
                            Id = 9,
                            Description = "Creamy and vibrant lemon cheesecake made with organic lemons",
                            ImageName = "cheesecake.jpg",
                            Name = "Cheesecake",
                            Price = 2.49m
                        },
                        new
                        {
                            Id = 10,
                            Description = "Crisp on the outside, soft on the inside and full of chocolate chips",
                            ImageName = "chocolate-chip.jpg",
                            Name = "Chocolate Cookies",
                            Price = 3.49m
                        },
                        new
                        {
                            Id = 11,
                            Description = "Big, fluffy, soft and delicious with warming cinnamon",
                            ImageName = "cinnamon-roll.jpg",
                            Name = "Cinnamon Rolls",
                            Price = 3.99m
                        },
                        new
                        {
                            Id = 12,
                            Description = "Flaky and buttery, perfect for savoury or sweet",
                            ImageName = "croissant.jpg",
                            Name = "Croissants",
                            Price = 3.49m
                        },
                        new
                        {
                            Id = 13,
                            Description = "Traditional ring doughnuts with a variety of toppings",
                            ImageName = "doughnuts.jpg",
                            Name = "Doughnuts",
                            Price = 5.49m
                        },
                        new
                        {
                            Id = 14,
                            Description = "Packed full with ony the juiciest, plumpest fruit",
                            ImageName = "fruit-loaf.jpg",
                            Name = "Fruit Loaf",
                            Price = 8.49m
                        },
                        new
                        {
                            Id = 15,
                            Description = "Light pastry with a selection of the freshest fruit",
                            ImageName = "fruit-tart.jpg",
                            Name = "Fruit Tart",
                            Price = 6.49m
                        },
                        new
                        {
                            Id = 16,
                            Description = "Zingy lemon on a light pastry covered with light clouds of meringue",
                            ImageName = "lemon-meringue.jpg",
                            Name = "Lemon Meringue",
                            Price = 10.99m
                        },
                        new
                        {
                            Id = 17,
                            Description = "Tiny, delicate meringue pillows with a variety of fillings",
                            ImageName = "macaron.jpg",
                            Name = "Macaron",
                            Price = 9.99m
                        },
                        new
                        {
                            Id = 18,
                            Description = "The lighest pastry shot through with top quality chocolate",
                            ImageName = "pain-au-chocolate.jpg",
                            Name = "Pain Au Chocolate",
                            Price = 4.49m
                        },
                        new
                        {
                            Id = 19,
                            Description = "A meaty treat based on traditional Cornish recipes",
                            ImageName = "pasty.jpg",
                            Name = "Cornish Pasty",
                            Price = 5.99m
                        },
                        new
                        {
                            Id = 20,
                            Description = "Our top quality loaves sliced for your convenience",
                            ImageName = "sliced-bread.jpg",
                            Name = "Sliced Bread",
                            Price = 2.49m
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
