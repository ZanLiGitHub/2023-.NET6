﻿// <auto-generated />
using Blazor.Server.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Blazor.Server.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20230520084454_Categories")]
    partial class Categories
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Blazor.Shared.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "SandBox",
                            Url = "sandboxs"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Simulation",
                            Url = "simulations"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Survival",
                            Url = "survivals"
                        });
                });

            modelBuilder.Entity("Blazor.Shared.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 3,
                            Description = "Don't Starve is a survival video game developed by the Canadian indie video game developer Klei Entertainment.",
                            ImageUrl = "https://upload.wikimedia.org/wikipedia/en/d/d2/Don%27t_Starve_cover.jpg",
                            Price = 9.9m,
                            Title = "Don't Starve"
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 2,
                            Description = "Stardew Valley is a simulation role-playing video game developed by Eric 'ConcernedApe' Barone.",
                            ImageUrl = "https://thumbnails.pcgamingwiki.com/1/1b/Stardew_Valley_cover.png/300px-Stardew_Valley_cover.png",
                            Price = 9.9m,
                            Title = "Stardew Valley"
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 1,
                            Description = "Minecraft is a sandbox game developed by Mojang Studios.",
                            ImageUrl = "https://upload.wikimedia.org/wikipedia/en/5/51/Minecraft_cover.png",
                            Price = 9.9m,
                            Title = "Minecraft"
                        });
                });

            modelBuilder.Entity("Blazor.Shared.Product", b =>
                {
                    b.HasOne("Blazor.Shared.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });
#pragma warning restore 612, 618
        }
    }
}
