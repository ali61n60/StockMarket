﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RepositoryStd;

namespace RepositoryStd.Migrations
{
    [DbContext(typeof(StockDbContext))]
    [Migration("20190112200742_firstStep")]
    partial class firstStep
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("stock")
                .HasAnnotation("ProductVersion", "2.2.1-servicing-10028")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ModelStd.DB.StockName", b =>
                {
                    b.Property<int>("StockId")
                        .HasColumnName("stockId");

                    b.Property<string>("StockSymbol")
                        .IsRequired()
                        .HasColumnName("stockSymbol")
                        .HasMaxLength(150);

                    b.HasKey("StockId");

                    b.ToTable("StocksName","stock");
                });
#pragma warning restore 612, 618
        }
    }
}
