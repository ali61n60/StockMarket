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
    [Migration("20190202201918_step11")]
    partial class step11
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("stock")
                .HasAnnotation("ProductVersion", "2.2.1-servicing-10028")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ModelStd.DB.Shareholder", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnName("id");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnName("name")
                        .HasMaxLength(150);

                    b.HasKey("Id");

                    b.ToTable("Shareholder","stock");
                });

            modelBuilder.Entity("ModelStd.DB.Stock.CapitalIncrease", b =>
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

            modelBuilder.Entity("ModelStd.DB.Stock.Dividend", b =>
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

            modelBuilder.Entity("ModelStd.DB.Stock.StockGroup", b =>
                {
                    b.Property<int>("GroupId")
                        .HasColumnName("groupId");

                    b.Property<string>("groupName")
                        .IsRequired()
                        .HasColumnName("groupName")
                        .HasMaxLength(150);

                    b.HasKey("GroupId");

                    b.ToTable("StockGroup","stock");
                });

            modelBuilder.Entity("ModelStd.DB.Stock.StockInfo", b =>
                {
                    b.Property<int>("StockId")
                        .HasColumnName("stockId");

                    b.Property<int>("GroupId")
                        .HasColumnName("groupId");

                    b.Property<string>("NameLatin")
                        .IsRequired()
                        .HasColumnName("nameLatin")
                        .HasMaxLength(150);

                    b.Property<string>("NamePersian")
                        .IsRequired()
                        .HasColumnName("namePersian")
                        .HasMaxLength(150);

                    b.Property<string>("SymbolLatin")
                        .IsRequired()
                        .HasColumnName("symbolLatin")
                        .HasMaxLength(150);

                    b.Property<string>("SymbolPersian")
                        .IsRequired()
                        .HasColumnName("symbolPersian")
                        .HasMaxLength(150);

                    b.HasKey("StockId");

                    b.HasIndex("GroupId");

                    b.ToTable("StocksInfo","stock");
                });

            modelBuilder.Entity("ModelStd.DB.Stock.TradeData", b =>
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

                    b.Property<int>("NumberOfDeals")
                        .HasColumnName("numberOfDeals");

                    b.Property<double>("Open")
                        .HasColumnName("open");

                    b.Property<int>("StockId")
                        .HasColumnName("stockId");

                    b.Property<double>("Value")
                        .HasColumnName("value");

                    b.Property<int>("Volume")
                        .HasColumnName("volume");

                    b.HasKey("Id");

                    b.HasIndex("StockId");

                    b.ToTable("TradeData","stock");
                });

            modelBuilder.Entity("ModelStd.DB.StockTrading", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Date")
                        .HasColumnName("date");

                    b.Property<double>("PricePerShare")
                        .HasColumnName("pricePerShare");

                    b.Property<int>("ShareholderId")
                        .HasColumnName("shareholderId");

                    b.Property<int>("StockId")
                        .HasColumnName("stockId");

                    b.Property<double>("TotalPrice")
                        .HasColumnName("totalPrice");

                    b.Property<int>("TradeType")
                        .HasColumnName("tradeType");

                    b.Property<int>("Volume")
                        .HasColumnName("volume");

                    b.HasKey("Id");

                    b.HasIndex("ShareholderId");

                    b.HasIndex("StockId");

                    b.ToTable("StockTrading","stock");
                });

            modelBuilder.Entity("ModelStd.DB.Stock.CapitalIncrease", b =>
                {
                    b.HasOne("ModelStd.DB.Stock.StockInfo", "StockInfo")
                        .WithMany()
                        .HasForeignKey("StockId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ModelStd.DB.Stock.Dividend", b =>
                {
                    b.HasOne("ModelStd.DB.Stock.StockInfo", "StockInfo")
                        .WithMany("Dividends")
                        .HasForeignKey("StockId")
                        .HasConstraintName("FK_Dividend_StockInfo")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("ModelStd.DB.Stock.StockInfo", b =>
                {
                    b.HasOne("ModelStd.DB.Stock.StockGroup", "StockGroup")
                        .WithMany("Stocks")
                        .HasForeignKey("GroupId")
                        .HasConstraintName("FK_StockInfo_StockGroup")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("ModelStd.DB.Stock.TradeData", b =>
                {
                    b.HasOne("ModelStd.DB.Stock.StockInfo", "StockInfo")
                        .WithMany()
                        .HasForeignKey("StockId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ModelStd.DB.StockTrading", b =>
                {
                    b.HasOne("ModelStd.DB.Shareholder", "Shareholder")
                        .WithMany("StockTradings")
                        .HasForeignKey("ShareholderId")
                        .HasConstraintName("FK_StockTrading_Shareholder")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("ModelStd.DB.Stock.StockInfo", "StockInfo")
                        .WithMany("StockTradings")
                        .HasForeignKey("StockId")
                        .HasConstraintName("FK_StockTrading_StockInfo")
                        .OnDelete(DeleteBehavior.Restrict);
                });
#pragma warning restore 612, 618
        }
    }
}
