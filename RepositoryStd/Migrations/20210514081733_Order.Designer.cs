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
    [Migration("20210514081733_Order")]
    partial class Order
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("stock")
                .HasAnnotation("ProductVersion", "2.2.1-servicing-10028")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ModelStd.AspBook.Order", b =>
                {
                    b.Property<int>("OrderID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("City")
                        .IsRequired();

                    b.Property<string>("Country")
                        .IsRequired();

                    b.Property<bool>("GiftWrap");

                    b.Property<string>("Line1")
                        .IsRequired();

                    b.Property<string>("Line2");

                    b.Property<string>("Line3");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<bool>("Shipped");

                    b.Property<string>("State")
                        .IsRequired();

                    b.Property<string>("Zip");

                    b.HasKey("OrderID");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("ModelStd.Carts.SymbolLine", b =>
                {
                    b.Property<int>("SymbolLineId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("OrderID");

                    b.Property<int>("Quantity");

                    b.Property<int?>("SymbolId");

                    b.HasKey("SymbolLineId");

                    b.HasIndex("OrderID");

                    b.HasIndex("SymbolId");

                    b.ToTable("SymbolLine");
                });

            modelBuilder.Entity("ModelStd.DB.Product.Product", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnName("id");

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

                    b.HasKey("Id");

                    b.HasIndex("GroupId");

                    b.ToTable("Product","stock");
                });

            modelBuilder.Entity("ModelStd.DB.Product.ProductGroup", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnName("id");

                    b.Property<string>("NameLatin")
                        .IsRequired()
                        .HasColumnName("nameLatin")
                        .HasMaxLength(150);

                    b.Property<string>("NamePersian")
                        .IsRequired()
                        .HasColumnName("namePersian")
                        .HasMaxLength(150);

                    b.HasKey("Id");

                    b.ToTable("ProductGroup","stock");
                });

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

                    b.Property<int>("SymbolId")
                        .HasColumnName("symbolId");

                    b.HasKey("Id");

                    b.HasIndex("SymbolId");

                    b.ToTable("CapitalIncrease","stock");
                });

            modelBuilder.Entity("ModelStd.DB.Stock.CustomGroup", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnName("name")
                        .HasMaxLength(150);

                    b.HasKey("Id");

                    b.ToTable("CustomGroup","stock");
                });

            modelBuilder.Entity("ModelStd.DB.Stock.CustomGroupMember", b =>
                {
                    b.Property<int>("GroupId")
                        .HasColumnName("groupId");

                    b.Property<int>("SymbolId")
                        .HasColumnName("symbolId");

                    b.HasKey("GroupId", "SymbolId");

                    b.HasIndex("SymbolId");

                    b.ToTable("customGroupMember","stock");
                });

            modelBuilder.Entity("ModelStd.DB.Stock.Dividend", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Date")
                        .HasColumnName("date");

                    b.Property<int>("SymbolId")
                        .HasColumnName("symbolId");

                    b.Property<double>("Value")
                        .HasColumnName("value");

                    b.HasKey("Id");

                    b.HasIndex("SymbolId");

                    b.ToTable("Dividend","stock");
                });

            modelBuilder.Entity("ModelStd.DB.Stock.LiveDataUrl", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnName("id");

                    b.Property<int>("SymbolId")
                        .HasColumnName("symbolId");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnName("url")
                        .HasMaxLength(500);

                    b.HasKey("Id");

                    b.HasIndex("SymbolId")
                        .IsUnique();

                    b.ToTable("LiveDataUrl","stock");
                });

            modelBuilder.Entity("ModelStd.DB.Stock.StockExchange", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BoughtSymbolId")
                        .HasColumnName("boughtSymbolId");

                    b.Property<double>("BoughtSymbolPricePerShare")
                        .HasColumnName("boughtSymbolPricePerShare");

                    b.Property<int>("BoughtSymbolVolume")
                        .HasColumnName("boughtSymbolVolume");

                    b.Property<DateTime>("ExchangeDate")
                        .HasColumnName("exchangeDate");

                    b.Property<int>("SoldSymbolId")
                        .HasColumnName("soldSymbolId");

                    b.Property<double>("SoldSymbolPricePerShare")
                        .HasColumnName("soldSymbolPricePerShare");

                    b.Property<int>("SoldSymbolVolume")
                        .HasColumnName("soldSymbolVolume");

                    b.HasKey("Id");

                    b.HasIndex("BoughtSymbolId");

                    b.HasIndex("SoldSymbolId");

                    b.ToTable("StockExchange","stock");
                });

            modelBuilder.Entity("ModelStd.DB.Stock.Symbol", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnName("id");

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

                    b.HasKey("Id");

                    b.HasIndex("GroupId");

                    b.ToTable("Symbol","stock");
                });

            modelBuilder.Entity("ModelStd.DB.Stock.SymbolGroup", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnName("id");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnName("name")
                        .HasMaxLength(150);

                    b.HasKey("Id");

                    b.ToTable("SymbolGroup","stock");
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

                    b.Property<int>("SymbolId")
                        .HasColumnName("symbolId");

                    b.Property<double>("Value")
                        .HasColumnName("value");

                    b.Property<int>("Volume")
                        .HasColumnName("volume");

                    b.HasKey("Id");

                    b.HasIndex("SymbolId");

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

                    b.Property<int>("SymbolId")
                        .HasColumnName("symbolId");

                    b.Property<double>("TotalPrice")
                        .HasColumnName("totalPrice");

                    b.Property<int>("TradeType")
                        .HasColumnName("tradeType");

                    b.Property<int>("Volume")
                        .HasColumnName("volume");

                    b.HasKey("Id");

                    b.HasIndex("ShareholderId");

                    b.HasIndex("SymbolId");

                    b.ToTable("Trades","stock");
                });

            modelBuilder.Entity("ModelStd.Carts.SymbolLine", b =>
                {
                    b.HasOne("ModelStd.AspBook.Order")
                        .WithMany("Lines")
                        .HasForeignKey("OrderID");

                    b.HasOne("ModelStd.DB.Stock.Symbol", "Symbol")
                        .WithMany()
                        .HasForeignKey("SymbolId");
                });

            modelBuilder.Entity("ModelStd.DB.Product.Product", b =>
                {
                    b.HasOne("ModelStd.DB.Product.ProductGroup", "ProductGroup")
                        .WithMany("Products")
                        .HasForeignKey("GroupId")
                        .HasConstraintName("FK_Product_ProductGroup")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("ModelStd.DB.Stock.CapitalIncrease", b =>
                {
                    b.HasOne("ModelStd.DB.Stock.Symbol", "Symbol")
                        .WithMany()
                        .HasForeignKey("SymbolId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ModelStd.DB.Stock.CustomGroupMember", b =>
                {
                    b.HasOne("ModelStd.DB.Stock.CustomGroup", "StockList")
                        .WithMany("CustomGroupMembers")
                        .HasForeignKey("GroupId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ModelStd.DB.Stock.Symbol", "Symbol")
                        .WithMany("StockListStockInfo")
                        .HasForeignKey("SymbolId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ModelStd.DB.Stock.Dividend", b =>
                {
                    b.HasOne("ModelStd.DB.Stock.Symbol", "Symbol")
                        .WithMany("Dividends")
                        .HasForeignKey("SymbolId")
                        .HasConstraintName("FK_Dividend_Symbol")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("ModelStd.DB.Stock.LiveDataUrl", b =>
                {
                    b.HasOne("ModelStd.DB.Stock.Symbol")
                        .WithOne("LiveDataUrl")
                        .HasForeignKey("ModelStd.DB.Stock.LiveDataUrl", "SymbolId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ModelStd.DB.Stock.StockExchange", b =>
                {
                    b.HasOne("ModelStd.DB.Stock.Symbol", "BoughtSymbol")
                        .WithMany("BoughtStockExchages")
                        .HasForeignKey("BoughtSymbolId")
                        .HasConstraintName("FK_StockExchageBought_Symbol")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("ModelStd.DB.Stock.Symbol", "SoldSymbol")
                        .WithMany("SoldStockExchages")
                        .HasForeignKey("SoldSymbolId")
                        .HasConstraintName("FK_StockExchageSold_Symbol")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("ModelStd.DB.Stock.Symbol", b =>
                {
                    b.HasOne("ModelStd.DB.Stock.SymbolGroup", "SymbolGroup")
                        .WithMany("Symbols")
                        .HasForeignKey("GroupId")
                        .HasConstraintName("FK_Symbol_SymbolGroup")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("ModelStd.DB.Stock.TradeData", b =>
                {
                    b.HasOne("ModelStd.DB.Stock.Symbol", "Symbol")
                        .WithMany()
                        .HasForeignKey("SymbolId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ModelStd.DB.StockTrading", b =>
                {
                    b.HasOne("ModelStd.DB.Shareholder", "Shareholder")
                        .WithMany("StockTradings")
                        .HasForeignKey("ShareholderId")
                        .HasConstraintName("FK_StockTrading_Shareholder")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("ModelStd.DB.Stock.Symbol", "Symbol")
                        .WithMany("StockTradings")
                        .HasForeignKey("SymbolId")
                        .HasConstraintName("FK_StockTrading_Symbol")
                        .OnDelete(DeleteBehavior.Restrict);
                });
#pragma warning restore 612, 618
        }
    }
}
