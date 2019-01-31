﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RepositoryStd;

namespace RepositoryStd.Migrations
{
    [DbContext(typeof(StockDbContext))]
    [Migration("20190131195421_step4")]
    partial class step4
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("stock")
                .HasAnnotation("ProductVersion", "2.2.1-servicing-10028")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ModelStd.DB.CapitalIncrease", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("CashPercent")
                        .HasColumnName("cashPercent");

                    b.Property<DateTime>("Date")
                        .HasColumnName("date");

                    b.Property<double>("Percent")
                        .HasColumnName("percent");

                    b.Property<double>("SavingPercent")
                        .HasColumnName("savingPercent");

                    b.Property<int>("StockId")
                        .HasColumnName("stockId");

                    b.HasKey("Id");

                    b.HasIndex("StockId");

                    b.ToTable("CapitalIncrease","stock");
                });

            modelBuilder.Entity("ModelStd.DB.Dividend", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Date")
                        .HasColumnName("date");

                    b.Property<int>("StockId")
                        .HasColumnName("stockId");

                    b.Property<double>("Value")
                        .HasColumnName("value");

                    b.HasKey("Id");

                    b.HasIndex("StockId");

                    b.ToTable("Dividend","stock");
                });

            modelBuilder.Entity("ModelStd.DB.StockInfo", b =>
                {
                    b.Property<int>("StockId")
                        .HasColumnName("stockId");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnName("stockName")
                        .HasMaxLength(150);

                    b.Property<string>("StockSymbol")
                        .IsRequired()
                        .HasColumnName("stockSymbol")
                        .HasMaxLength(150);

                    b.HasKey("StockId");

                    b.ToTable("StocksInfo","stock");
                });

            modelBuilder.Entity("ModelStd.DB.TradeData", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("Close")
                        .HasColumnName("close");

                    b.Property<DateTime>("Date")
                        .HasColumnName("date");

                    b.Property<double>("Final")
                        .HasColumnName("final");

                    b.Property<double>("Max")
                        .HasColumnName("max");

                    b.Property<double>("Min")
                        .HasColumnName("min");

                    b.Property<double>("Open")
                        .HasColumnName("open");

                    b.Property<int>("StockId")
                        .HasColumnName("stockId");

                    b.Property<int>("Volume")
                        .HasColumnName("volume");

                    b.HasKey("Id");

                    b.HasIndex("StockId");

                    b.ToTable("TradeData","stock");
                });

            modelBuilder.Entity("ModelStd.DB.CapitalIncrease", b =>
                {
                    b.HasOne("ModelStd.DB.StockInfo", "StockName")
                        .WithMany()
                        .HasForeignKey("StockId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ModelStd.DB.Dividend", b =>
                {
                    b.HasOne("ModelStd.DB.StockInfo", "StockName")
                        .WithMany("Dividends")
                        .HasForeignKey("StockId")
                        .HasConstraintName("FK_Dividend_StockName")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ModelStd.DB.TradeData", b =>
                {
                    b.HasOne("ModelStd.DB.StockInfo", "StockName")
                        .WithMany()
                        .HasForeignKey("StockId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
