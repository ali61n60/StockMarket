using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using ModelStd.DB;
using RepositoryStd.Database;

namespace RepositoryStd.Context.AD
{
    public class StockDbContext : DbContext
    {
        private readonly string _connectionString;

        public StockDbContext(string connectionString)
        {
            _connectionString = connectionString;
        }

        public StockDbContext()
        {
            _connectionString =StockDataClass.DefaultConnectionString();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_connectionString,
                x => x.MigrationsHistoryTable("__MigrationsHistory", "stock"));
        }

        public virtual DbSet<StockName> StockNames { get; set; }

        //public virtual DbSet<AdAttributeTransportation> AdAttributeTransportation { get; set; }
        //public virtual DbSet<AdPrivilege> AdPrivilege { get; set; }
        //public virtual DbSet<Advertisement> Advertisements { get; set; }
        //public virtual DbSet<ApprovedAd> ApprovedAds { get; set; }
        //public virtual DbSet<Brand> Brands { get; set; }
        //public virtual DbSet<CarModel> CarModels { get; set; }
        //public virtual DbSet<Category> Categories { get; set; }
        //public virtual DbSet<City> Cities { get; set; }
        //public virtual DbSet<District> Districts { get; set; }
        //public virtual DbSet<EmailMessage> EmailMessages { get; set; }
        //public virtual DbSet<FixedPrice> FixedPrices { get; set; }
        //public virtual DbSet<AgreementPrice> AgreementPrices { get; set; }
        //public virtual DbSet<ExchangePrice> ExchangePrices { get; set; }
        //public virtual DbSet<InstallmentPrice> InstallmentPrices { get; set; }
        //public virtual DbSet<MortgageAndRentPrice> MortgageAndRentPrices { get; set; }
        //public virtual DbSet<LetMeKnow> LetMeKnows { get; set; }
        //public virtual DbSet<LetMeKnowAttributeTransportaion> LetMeKnowAttributeTransportaions { get; set; }
        //public virtual DbSet<MarkedAd> MarkedAds { get; set; }
        //public virtual DbSet<MobileBrands> MobileBrands { get; set; }
        //public virtual DbSet<Province> Provinces { get; set; }
        //public virtual DbSet<SimilarAds> SimilarAds { get; set; }
        //public virtual DbSet<SmsMessage> SmsMessages { get; set; }
        //public virtual DbSet<Temperature> Temperatures { get; set; }
        
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("stock");

            //modelBuilder.Entity<AdAttributeTransportation>(entity =>
            //{
            //    entity.HasOne(d => d.Ad)
            //        .WithOne(advertisements => advertisements.AdAttributeTransportation)
            //        .OnDelete(DeleteBehavior.Cascade)
            //        .HasForeignKey<Advertisement>(advertisement => advertisement.AdId)
            //        .HasConstraintName("FK_AdAttributeTransportations_Advertisements");

            //    entity.HasOne(d => d.CarModel)
            //        .WithMany(carModel => carModel.AdAttributeTransportations)
            //        .HasForeignKey(d => d.ModelId)
            //        .HasConstraintName("FK_AdAttributeTransportations_CarModels");
            //});

            //modelBuilder.Entity<AdPrivilege>(entity =>
            //{
            //    entity.HasKey(e => new { e.AdId, e.Privilege, e.InsertionDate })
            //        .HasName("PK_AdPrivilage");

            //    entity.HasOne(d => d.Ad)
            //        .WithMany(p => p.AdPrivilege)
            //        .HasForeignKey(d => d.AdId)
            //        .OnDelete(DeleteBehavior.Cascade)
            //        .HasConstraintName("FK_AdPrivilage_Advertisements");
            //    });

            //modelBuilder.Entity<Advertisement>(entity =>
            //{
            //    entity.HasKey(e => e.AdId)
            //        .HasName("PK_Advertisements_1");

            //    entity.HasOne(d => d.Category)
            //        .WithMany(p => p.Advertisements)
            //        .HasForeignKey(d => d.CategoryId)
            //        .OnDelete(DeleteBehavior.Restrict)
            //        .HasConstraintName("FK_Advertisements_Categories");

            //    entity.HasOne(d => d.District)
            //        .WithMany(p => p.Advertisements)
            //        .HasForeignKey(d => d.DistrictId)
            //        .OnDelete(DeleteBehavior.Restrict)
            //        .HasConstraintName("FK_Advertisements_Districts");
            //});

            //modelBuilder.Entity<ApprovedAd>(entity =>
            //{
            //    entity.HasKey(approvedAd => approvedAd.AdId)
            //        .HasName("PK_ApprovedAd");

            //    entity.HasOne(approvedAd=> approvedAd.Ad)
            //        .WithOne()
            //        .OnDelete(DeleteBehavior.Cascade)
            //        .HasConstraintName("FK_ApprovedAd_Advertisements");
            //});

            //modelBuilder.Entity<Brand>(entity =>
            // {
            //     entity.HasKey(e => e.BrandId)
            //         .HasName("PK_CarBrand");
            // });

            //modelBuilder.Entity<CarModel>(entity =>
            //{
            //    entity.HasKey(e => e.ModelId)
            //        .HasName("PK_CarModel");

            //    entity.HasOne(carModel => carModel.Brand)
            //        .WithMany(brand => brand.CarModels)
            //        .HasForeignKey(carModel => carModel.BrandId)
            //        .OnDelete(DeleteBehavior.Cascade)
            //        .HasConstraintName("FK_CarModel_CarBrand");
            //});

            //modelBuilder.Entity<Category>(entity =>
            //{
            //    entity.HasKey(e => e.CategoryId)
            //        .HasName("PK_Categories");
            //});

            //modelBuilder.Entity<City>(entity =>
            //{
            //    entity.HasOne(d => d.Province)
            //         .WithMany(p => p.Cities)
            //         .HasForeignKey(d => d.ProvinceId)
            //         .HasConstraintName("FK_Cities_Provinces");
            //});

            //modelBuilder.Entity<District>(entity =>
            //{
            //    entity.HasOne(d => d.City)
            //        .WithMany(p => p.Districts)
            //        .HasForeignKey(d => d.CityId)
            //        .OnDelete(DeleteBehavior.Restrict)
            //        .HasConstraintName("FK_Districts_Cities");
            //});

            //modelBuilder.Entity<EmailMessage>(entity =>
            //{
            //    entity.HasKey(e => e.MessageId)
            //        .HasName("PK_EmailMessage");

            //    entity.HasOne(emailMessage => emailMessage.User)
            //        .WithMany()
            //        .OnDelete(DeleteBehavior.Cascade)
            //        .HasForeignKey(emailMessage => emailMessage.UserId);
            //});

           
            //modelBuilder.Entity<LetMeKnow>(entity =>
            //{
            //    entity.HasKey(letMeKnow=>letMeKnow.Id)
            //    .HasName("PK_Id");

            //    entity.HasOne(letMeKnow => letMeKnow.Category)
            //        .WithMany()
            //        .HasForeignKey(letMeKnow => letMeKnow.CategoryId)
            //        .OnDelete(DeleteBehavior.Restrict)
            //        .HasConstraintName("FK_LetMeKnows_Categories");

            //    entity.HasOne(letMeKnow => letMeKnow.User)
            //        .WithMany()
            //        .HasForeignKey(letMeKnow => letMeKnow.UserId)
            //        .OnDelete(DeleteBehavior.Cascade)
            //        .HasConstraintName("FK_LetMeKnows_AspNetUsers");

            //});

            //modelBuilder.Entity<LetMeKnowAttributeTransportaion>(entity =>
            //{
            //    entity.HasKey(transportaion => transportaion.Id)
            //    .HasName("PK_LetMeKnowAttributeTransportaion");

                

            //    entity.HasOne(transportation => transportation.LetMeKnow)
            //        .WithOne(letMeKnow => letMeKnow.LetMeKnowAttributeTransportaion)
            //        .OnDelete(DeleteBehavior.Cascade)
            //        .HasConstraintName("FK_LetMeKnowAttributeTransportaion_LetMeKnow");

            //    entity.HasOne(transportation => transportation.Brand)
            //        .WithMany(brand => brand.LetMeKnowAttributeTransportaion)
            //        .HasForeignKey(letMeKnowAttributeTransportaions => letMeKnowAttributeTransportaions.BrandId)
            //        .OnDelete(DeleteBehavior.Restrict)
            //        .HasConstraintName("FK_LetMeKnowAttributeTransportaion_Brand");

            //    entity.HasOne(transportation => transportation.CarModel)
            //        .WithMany(model => model.LetMeKnowAttributeTransportaion)
            //        .HasForeignKey(letMeKnowAttributeTransportaions => letMeKnowAttributeTransportaions.ModelId)
            //        .OnDelete(DeleteBehavior.Restrict)
            //        .HasConstraintName("FK_LetMeKnowAttributeTransportaion_CarModel");
            //});

            //modelBuilder.Entity<MarkedAd>(entity =>
            //{
            //    entity.HasKey(markedAd =>
            //        new { markedAd.AdId, markedAd.UserId }
            //    ).HasName("PK_MarkedAd");

            //    entity.HasOne(markedAd => markedAd.Ad)
            //        .WithMany(advertisements => advertisements.MarkedAds)
            //        .HasForeignKey(markedAd => markedAd.AdId)
            //        .OnDelete(DeleteBehavior.Cascade)
            //        .HasConstraintName("FK_MarkedAds_Advertisements");

            //    entity.HasOne(markedAd => markedAd.User)
            //        .WithMany(appUser => appUser.MarkedAds)
            //        .HasForeignKey(markedAd => markedAd.UserId)
            //        .OnDelete(DeleteBehavior.Cascade)
            //        .HasConstraintName("FK_MarkedAds_AspNetUsers");
            //});

            //modelBuilder.Entity<MobileBrands>(entity =>
            //{
            //    entity.HasKey(e => e.BrandId)
            //        .HasName("PK_MobileBrands");

            //    entity.ToTable("MobileBrands", "ad");

            //    entity.Property(e => e.BrandId)
            //        .HasColumnName("brandId")
            //        .ValueGeneratedNever();

            //    entity.Property(e => e.BrandMakerId).HasColumnName("brandMakerId");

            //    entity.Property(e => e.BrandName)
            //        .IsRequired()
            //        .HasColumnName("brandName")
            //        .HasMaxLength(150);
            //});

           
            //modelBuilder.Entity<SimilarAds>(entity =>
            // {
            //     entity.HasKey(e => new { e.AdId, e.SimilarAdId })
            //         .HasName("PK_SimilarAds");

            //     entity.HasOne(d => d.Ad)
            //         .WithMany(p => p.SimilarAds)
            //         .HasForeignKey(d => d.AdId)
            //         .OnDelete(DeleteBehavior.Cascade)
            //         .HasConstraintName("FK_SimilarAds_Advertisements");
            // });

            //modelBuilder.Entity<SmsMessage>(entity =>
            //{
            //    entity.HasKey(e => e.MessageId)
            //        .HasName("PK_SmsMessage");

            //    entity.HasOne(m => m.User)
            //        .WithMany()
            //        .OnDelete(DeleteBehavior.Cascade)
            //        .HasForeignKey(message => message.UserId);
            //});

        }
    }
}