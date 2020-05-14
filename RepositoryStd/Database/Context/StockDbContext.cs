using Microsoft.EntityFrameworkCore;
using ModelStd.DB;
using ModelStd.DB.Stock;
using RepositoryStd.Database;

namespace RepositoryStd
{
    //Methanol http://www.sunsirs.com/uk/prodetail-429.html
    //مدل تنزیل جریانات نقدی (DCF)
    //مدل تنزیل سود نقدی( FCFE)

    public class StockDbContext : DbContext
    {
        private readonly string _connectionString;

        public StockDbContext(string connectionString)
        {
            _connectionString = connectionString;
        }

        public StockDbContext()
        {
            _connectionString = DatabaseInfoClass.DefaultConnectionString();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_connectionString,
                x =>
                {
                    x.MigrationsHistoryTable("__MigrationsHistory", "stock");
                });
        }

        public virtual DbSet<Symbol> Symbols { get; set; }
        public virtual DbSet<SymbolGroup> SymbolGroups { get; set; }
        public virtual DbSet<LiveDataUrl> LiveDataUrls { get; set; }

        public virtual DbSet<Dividend> Dividends { get; set; }
        public virtual DbSet<CapitalIncrease> CapitalIncreases { get; set; }
        public virtual DbSet<TradeData> TradeDatas { get; set; }
        
        public virtual DbSet<Shareholder> Shareholders { get; set; }
        public virtual DbSet<StockTrading> StockTradings { get; set; }

        public virtual DbSet<StockList> StockList { get; set; }
        public virtual DbSet<StockListStockInfo> StockListStockInfos { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.HasDefaultSchema("stock");

            modelBuilder.Entity<Symbol>(entity =>
            {
                entity.HasOne(symbol => symbol.SymbolGroup)
                .WithMany(symbolGroup => symbolGroup.Symbols)
                .HasForeignKey(symbol => symbol.GroupId)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("FK_Symbol_SymbolGroup");
            });

           

            modelBuilder.Entity<Dividend>(entity =>
            {
                entity.HasOne(dividend => dividend.Symbol)
                .WithMany(stock => stock.Dividends)
                .HasForeignKey(dividend => dividend.SymbolId)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("FK_Dividend_Symbol");
            });

            

            modelBuilder.Entity<StockTrading>(entity =>
            {
                entity.HasOne(stockTrading => stockTrading.Shareholder)
                    .WithMany(shareHolder => shareHolder.StockTradings)
                    .HasForeignKey(stockTrading => stockTrading.ShareholderId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_StockTrading_Shareholder");

                entity.HasOne(stockTrading => stockTrading.Symbol)
                    .WithMany(stockInfo => stockInfo.StockTradings)
                    .HasForeignKey(stockTrading => stockTrading.SymbolId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_StockTrading_Symbol");
            });


            modelBuilder.Entity<StockListStockInfo>()
                .HasKey(s => new { s.ListId, s.SymbolId });

            modelBuilder.Entity<StockListStockInfo>()
              .HasOne<StockList>(sc => sc.StockList)
              .WithMany(s => s.StockListStockInfo)
              .HasForeignKey(sc => sc.ListId);


            modelBuilder.Entity<StockListStockInfo>()
                .HasOne<Symbol>(sc => sc.Symbol)
                .WithMany(s => s.StockListStockInfo)
                .HasForeignKey(sc => sc.SymbolId);
        }
    }
}