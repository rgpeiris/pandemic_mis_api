﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Pandemic_MIS.Services.PandemicTestsManagementAPI.Data;

#nullable disable

namespace Pandemic_MIS.Services.PandemicTestsManagementAPI.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20231221112842_SeedTestsAppointmentsTable")]
    partial class SeedTestsAppointmentsTable
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Pandemic_MIS.Services.PandemicTestsManagementAPI.Models.PandemicTest", b =>
                {
                    b.Property<int>("PandemicTestId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PandemicTestId"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TestType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PandemicTestId");

                    b.ToTable("PandemicTests");

                    b.HasData(
                        new
                        {
                            PandemicTestId = 1,
                            Description = "Detects genetic material of a virus.",
                            TestType = "Molecular (PCR)"
                        },
                        new
                        {
                            PandemicTestId = 2,
                            Description = "Detects proteins found on a virus.",
                            TestType = "Antigen"
                        });
                });

            modelBuilder.Entity("Pandemic_MIS.Services.PandemicTestsManagementAPI.Models.PandemicTestResult", b =>
                {
                    b.Property<int>("PandemicTestResultId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PandemicTestResultId"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateOfPandemicTest")
                        .HasColumnType("datetime2");

                    b.Property<string>("District")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GramaNiladhariArea")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MOHArea")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NICNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SerialNumber")
                        .HasColumnType("int");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TestCentreId")
                        .HasColumnType("int");

                    b.Property<string>("TestResult")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TestResultSummary")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PandemicTestResultId");

                    b.ToTable("PandemicTestResults");
                });

            modelBuilder.Entity("Pandemic_MIS.Services.PandemicTestsManagementAPI.Models.ScheduledTestCentre", b =>
                {
                    b.Property<int>("ScheduledTestCentreId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ScheduledTestCentreId"));

                    b.Property<int>("AvailableCapacity")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateScheduled")
                        .HasColumnType("datetime2");

                    b.Property<int>("TestCentreId")
                        .HasColumnType("int");

                    b.Property<string>("TimeScheduled")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ScheduledTestCentreId");

                    b.ToTable("ScheduledTestCentres");

                    b.HasData(
                        new
                        {
                            ScheduledTestCentreId = 1,
                            AvailableCapacity = 300,
                            DateScheduled = new DateTime(2023, 12, 21, 16, 58, 42, 668, DateTimeKind.Local).AddTicks(2773),
                            TestCentreId = 1,
                            TimeScheduled = "Forenoon"
                        });
                });

            modelBuilder.Entity("Pandemic_MIS.Services.PandemicTestsManagementAPI.Models.TestCentre", b =>
                {
                    b.Property<int>("TestCentreId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TestCentreId"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CentreName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("District")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<double>("Latitude")
                        .HasColumnType("float");

                    b.Property<double>("Longitude")
                        .HasColumnType("float");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TestCentreId");

                    b.ToTable("TestCentres");

                    b.HasData(
                        new
                        {
                            TestCentreId = 1,
                            Address = "RW99+J9X, Makuluduwa Rd, Piliyandala",
                            CentreName = "MOH Office Piliyandala",
                            City = "Piliyandala",
                            District = "Colombo",
                            IsActive = true,
                            Latitude = 6.8018029999999996,
                            Longitude = 79.922684000000004,
                            PhoneNumber = "0112708553"
                        });
                });

            modelBuilder.Entity("Pandemic_MIS.Services.PandemicTestsManagementAPI.Models.TestsAppointment", b =>
                {
                    b.Property<int>("TestsAppointmentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TestsAppointmentId"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateScheduled")
                        .HasColumnType("datetime2");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NICNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TestCentreId")
                        .HasColumnType("int");

                    b.Property<string>("TimeScheduled")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TestsAppointmentId");

                    b.ToTable("TestsAppointments");

                    b.HasData(
                        new
                        {
                            TestsAppointmentId = 1,
                            Address = "538/7 Aluthmawatha Road, Colombo",
                            Age = 32,
                            CreatedBy = "rgpeiris-927810379V",
                            DateScheduled = new DateTime(2023, 12, 21, 16, 58, 42, 668, DateTimeKind.Local).AddTicks(2805),
                            Gender = "Female",
                            NICNumber = "917283783V",
                            Name = "Janvi Fernando",
                            PhoneNumber = "772523191",
                            Status = "SCHEDULED",
                            TestCentreId = 1,
                            TimeScheduled = "Forenoon"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
