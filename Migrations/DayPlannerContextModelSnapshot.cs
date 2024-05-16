﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using REST_BOT.Models;

#nullable disable

namespace REST_BOT.Migrations
{
    [DbContext(typeof(DayPlannerContext))]
    partial class DayPlannerContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.30")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("REST_BOT.Models.DayPlanner", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("activity")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("breakTime")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("day")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("endTime")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("startTime")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("planners");
                });
#pragma warning restore 612, 618
        }
    }
}
