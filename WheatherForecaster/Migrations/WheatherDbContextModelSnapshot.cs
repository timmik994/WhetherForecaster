﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using WheatherForecaster.Models;

namespace WheatherForecaster.Migrations
{
    [DbContext(typeof(WeatherDbContext))]
    partial class WheatherDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.1-rtm-30846")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WheatherForecaster.Models.StandartDeviation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CalculationTime");

                    b.Property<float>("Deviation");

                    b.Property<int>("HoursForward");

                    b.HasKey("Id");

                    b.ToTable("Deviations");
                });

            modelBuilder.Entity("WhetherForecaster.Models.WheatherRecord", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<float>("ActualTempreche");

                    b.Property<int>("ForecastHours");

                    b.Property<float>("ForecastTempreche");

                    b.Property<DateTime>("ForecastTime");

                    b.Property<bool>("IsFull");

                    b.HasKey("Id");

                    b.ToTable("WhetherRecords");
                });
#pragma warning restore 612, 618
        }
    }
}
