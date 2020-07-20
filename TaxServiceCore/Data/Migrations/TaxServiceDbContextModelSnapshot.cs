﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TaxService.Data;

namespace TaxService.Data.Migrations
{
    [DbContext(typeof(TaxServiceDbContext))]
    partial class TaxServiceDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.0");

            modelBuilder.Entity("TaxService.Models.ConfigRegister", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("Value")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Configs");
                });

            modelBuilder.Entity("TaxService.Models.Organization", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<bool>("AutoPDV")
                        .HasColumnType("INTEGER");

                    b.Property<string>("CODE_IN_1C")
                        .HasColumnType("TEXT");

                    b.Property<int>("C_RAJ")
                        .HasColumnType("INTEGER");

                    b.Property<int>("C_REG")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ConfigType")
                        .HasColumnType("INTEGER");

                    b.Property<string>("DataBaseName")
                        .HasColumnType("TEXT");

                    b.Property<string>("DataBasePath")
                        .HasColumnType("TEXT");

                    b.Property<bool>("Exclusive")
                        .HasColumnType("INTEGER");

                    b.Property<string>("FilialNumber")
                        .HasColumnType("TEXT");

                    b.Property<string>("FirmCode")
                        .HasColumnType("TEXT");

                    b.Property<string>("FullName")
                        .HasColumnType("TEXT");

                    b.Property<bool>("IS_NP")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsReadOnly")
                        .HasColumnType("INTEGER");

                    b.Property<string>("J12010_OutPath")
                        .HasColumnType("TEXT");

                    b.Property<int>("J12010_StartNumber")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Manager")
                        .HasColumnType("TEXT");

                    b.Property<string>("ManagerIPN")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<int>("PlatformType")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ServerAdress")
                        .HasColumnType("TEXT");

                    b.Property<int>("ServerLocation")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("UseLocalKey")
                        .HasColumnType("INTEGER");

                    b.Property<string>("UserName")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserPass")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Organizations");
                });
#pragma warning restore 612, 618
        }
    }
}
