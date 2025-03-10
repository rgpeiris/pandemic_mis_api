﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Pandemic_MIS.Services.PandemicNewsAPI.Data;

#nullable disable

namespace Pandemic_MIS.Services.PandemicNewsAPI.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Pandemic_MIS.Services.PandemicNewsAPI.Models.PandemicNews", b =>
                {
                    b.Property<int>("NewsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("NewsId"));

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<int>("Priority")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("NewsId");

                    b.ToTable("PandemicNews");

                    b.HasData(
                        new
                        {
                            NewsId = 1,
                            CreatedBy = "ad_rpeiris",
                            CreatedDate = new DateTime(2024, 1, 28, 12, 58, 42, 799, DateTimeKind.Local).AddTicks(7262),
                            Description = "Let's Stay Safe",
                            IsActive = true,
                            Priority = 1,
                            Title = "Let's Stay Safe"
                        },
                        new
                        {
                            NewsId = 2,
                            CreatedBy = "ad_rpeiris",
                            CreatedDate = new DateTime(2024, 1, 28, 12, 58, 42, 799, DateTimeKind.Local).AddTicks(7312),
                            Description = "Know about COVID-19 Vaccine",
                            IsActive = true,
                            Priority = 2,
                            Title = "Know about COVID-19 Vaccine"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
