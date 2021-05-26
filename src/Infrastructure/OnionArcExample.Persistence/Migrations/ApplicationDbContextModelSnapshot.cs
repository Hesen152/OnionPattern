﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OnionArcExample.Persistence.Context;

namespace OnionArcExample.Persistence.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.3")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("OnionArcExample.Domain.Entities.Product", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<int>("Stock")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = new Guid("6d46d7e5-6fa2-4ecf-b0cd-d8c4a3bce5a6"),
                            Description = "Product 1 Description",
                            Name = "Product 1",
                            Price = 1000,
                            Stock = 10
                        },
                        new
                        {
                            Id = new Guid("f66a0255-bf2a-47bd-a05d-85e61c317d68"),
                            Description = "Product 2 Description",
                            Name = "Product 2",
                            Price = 2000,
                            Stock = 20
                        },
                        new
                        {
                            Id = new Guid("793f39e8-76f0-49fe-b68c-8f61d3c2db8a"),
                            Description = "Product 3 Description",
                            Name = "Product 3",
                            Price = 3000,
                            Stock = 30
                        },
                        new
                        {
                            Id = new Guid("c657f0ea-ae3b-4cce-8091-9bc8eccd68ff"),
                            Description = "Product 4 Description",
                            Name = "Product 4",
                            Price = 4000,
                            Stock = 40
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
