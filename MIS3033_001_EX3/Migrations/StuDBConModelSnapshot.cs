﻿// <auto-generated />
using MIS3033_001_EX3.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MIS3033_001_EX3.Migrations
{
    [DbContext(typeof(StuDBCon))]
    partial class StuDBConModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.10");

            modelBuilder.Entity("MIS3033_001_EX3.Student", b =>
                {
                    b.Property<string>("ID")
                        .HasColumnType("TEXT");

                    b.Property<double>("grade")
                        .HasColumnType("REAL");

                    b.Property<char>("letterGrade")
                        .HasColumnType("TEXT");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.ToTable("students");
                });
#pragma warning restore 612, 618
        }
    }
}