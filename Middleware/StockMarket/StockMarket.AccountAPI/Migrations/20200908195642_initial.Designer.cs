﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using StockMarket.AccountAPI.DBAccess;

namespace StockMarket.AccountAPI.Migrations
{
    [DbContext(typeof(StockDBContext))]
    [Migration("20200908195642_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("StockMarket.AccountAPI.Models.Company", b =>
                {
                    b.Property<string>("CompanyCode")
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.Property<string>("BoardOfDirectors")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CEO")
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.Property<string>("CompanyName")
                        .IsRequired()
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.Property<string>("StockExchangesListedOn")
                        .HasColumnType("nvarchar(10)")
                        .HasMaxLength(10);

                    b.HasKey("CompanyCode");

                    b.ToTable("Company");
                });

            modelBuilder.Entity("StockMarket.AccountAPI.Models.IPO", b =>
                {
                    b.Property<int>("RowId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CompanyCode")
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.Property<int>("NumberOfShares")
                        .HasColumnType("int");

                    b.Property<double>("PricePerShare")
                        .HasColumnType("float");

                    b.Property<string>("Remarks")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StockExchange")
                        .IsRequired()
                        .HasColumnType("nvarchar(5)")
                        .HasMaxLength(5);

                    b.Property<DateTime>("dateTime")
                        .HasColumnType("datetime2");

                    b.HasKey("RowId");

                    b.HasIndex("CompanyCode");

                    b.ToTable("IPO");
                });

            modelBuilder.Entity("StockMarket.AccountAPI.Models.StockPrice", b =>
                {
                    b.Property<int>("RowId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CompanyCode")
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.Property<double>("CurrentPrice")
                        .HasColumnType("float");

                    b.Property<DateTime>("Date")
                        .HasColumnType("Date");

                    b.Property<string>("StockExchange")
                        .IsRequired()
                        .HasColumnType("nvarchar(5)")
                        .HasMaxLength(5);

                    b.Property<string>("Time")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RowId");

                    b.HasIndex("CompanyCode");

                    b.ToTable("StockPrice");
                });

            modelBuilder.Entity("StockMarket.AccountAPI.Models.User", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.Property<string>("Confirmed")
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.Property<string>("Mobile")
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.HasKey("UserId");

                    b.ToTable("User");
                });

            modelBuilder.Entity("StockMarket.AccountAPI.Models.IPO", b =>
                {
                    b.HasOne("StockMarket.AccountAPI.Models.Company", "Company")
                        .WithMany("IPOs")
                        .HasForeignKey("CompanyCode");
                });

            modelBuilder.Entity("StockMarket.AccountAPI.Models.StockPrice", b =>
                {
                    b.HasOne("StockMarket.AccountAPI.Models.Company", "Company")
                        .WithMany("StockPrices")
                        .HasForeignKey("CompanyCode");
                });
#pragma warning restore 612, 618
        }
    }
}
