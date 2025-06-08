using Microsoft.EntityFrameworkCore;
using SanAndres_Api.Database.Seeders;
using SanAndres_Api.Models;

namespace SanAndres_Api.Database
{
  public class DataContext : DbContext
  {
    public DataContext(DbContextOptions<DataContext> options) : base(options) { }

    // Usuarios
    public DbSet<User> Users { get; set; }
    public DbSet<Admin> Admins{ get; set; }
    public DbSet<UserInfo> UserInfos { get; set; }
    public DbSet<Seller> Sellers { get; set; }
    public DbSet<Customer> Customers { get; set; }

    // Ubicacion
    public DbSet<City> Cities { get; set; }
    public DbSet<Country> Countries { get; set; }

    // Companie
    public DbSet<Company> Companies { get; set; }
    public DbSet<CompanyInfo> CompanyInfos { get; set; }
    
    // Ventas
    public DbSet<Sale> Sales { get; set; }
    public DbSet<SaleDetail> SaleDetails { get; set; }
    public DbSet<Category> Categories { get; set; }
    
    // Autopartes
    public DbSet<Autopart> Autoparts { get; set; }
    public DbSet<AutopartAsset> AutopartAssets { get; set; }
    public DbSet<AutopartBrand> AutopartBrands { get; set; }
    public DbSet<AutopartInfo> AutopartInfos { get; set; }
    public DbSet<AutopartOfSeller> AutopartOfSellers { get; set; }
    public DbSet<AutopartTypeInfo> AutopartTypeInfos { get; set; }
    public DbSet<Token> Tokens { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      
        modelBuilder.Entity<User>(tb => {
          tb.HasKey(p => p.Id);

        });

        modelBuilder.Entity<UserInfo>(tb => {
          tb.HasKey(p => p.Id);

          tb.HasOne(u => u.User)
            .WithOne(u => u.UserInfo)
            .HasForeignKey<UserInfo>(p => p.Id);

          tb.HasOne(p => p.City)
            .WithMany(p => p.UserInfos)
            .HasForeignKey(p => p.CityId)
            .IsRequired();
        });

        modelBuilder.Entity<Admin>(tb => {
          tb.HasKey(p => p.Id);
          
          tb.HasOne(u => u.User)
            .WithOne(u => u.Admin)
            .HasForeignKey<Admin>(p => p.Id);
        });

        modelBuilder.Entity<Seller>(tb => {
          tb.HasKey(p => p.Id);
          
          tb.HasOne(u => u.User)
            .WithOne(u => u.Seller)
            .HasForeignKey<Seller>(p => p.Id);

          tb.HasOne(p => p.Company)
            .WithMany(p => p.Sellers)
            .HasForeignKey(p => p.CompanyId)
            .IsRequired(false);
        });

        modelBuilder.Entity<Customer>(tb => {
          tb.HasKey(p => p.Id);
          
          tb.HasOne(u => u.User)
            .WithOne(u => u.Customer)
            .HasForeignKey<Customer>(p => p.Id);
        });

        modelBuilder.Entity<City>(tb => {
          tb.HasKey(p => p.Id);

          tb.HasOne(p => p.Country)
            .WithMany(p => p.Cities)
            .HasForeignKey(p => p.CountryId)
            .IsRequired();

          tb.HasData(CitySeed.GetSeed());
        });

        modelBuilder.Entity<Country>(tb => {
          tb.HasKey(p => p.Id);
          tb.HasData(CountrySeed.GetSeed());
        });
        
        modelBuilder.Entity<Company>(tb => {
          tb.HasKey(p => p.Id);

          tb.HasOne(p => p.Country)
            .WithMany(p => p.Companies)
            .HasForeignKey(p => p.CountryId)
            .IsRequired();
        });

        modelBuilder.Entity<CompanyInfo>(tb => {
          tb.HasKey(p => p.Id);

        tb.HasOne(p => p.Companies)
          .WithMany(p => p.CompanyInfos)
          .HasForeignKey(p => p.CompanyId)
          .IsRequired();
      });

      modelBuilder.Entity<Sale>(tb => {
        tb.HasKey(p => p.Id);

        tb.HasOne(p => p.Autopart)
          .WithMany(p => p.Sales)
          .HasForeignKey(p => p.AutopartId)
          .IsRequired();

          
        tb.HasOne(p => p.SaleDetail)
          .WithMany(p => p.Sales)
          .HasForeignKey(p => p.SaleDetailId)
          .IsRequired();

      });
      
      modelBuilder.Entity<SaleDetail>(tb => {
        tb.HasKey(p => p.Id);

        tb.HasOne(p => p.Customer)
          .WithMany(p => p.SaleDetails)
          .HasForeignKey(p => p.CustomerId)
          .IsRequired();

        tb.HasOne(p => p.Seller)
          .WithMany(p => p.SaleDetails)
          .HasForeignKey(p => p.SellerId)
          .IsRequired();
      });

      modelBuilder.Entity<Category>(tb => {
        tb.HasKey(p => p.Id);

      });


      modelBuilder.Entity<Autopart>(tb => {
        tb.HasKey(p => p.Id);

        tb.HasOne(p => p.Category)
          .WithMany(p => p.Autoparts)
          .HasForeignKey(p => p.CategoryId)
          .IsRequired();

        tb.HasOne(p => p.AutopartBrand)
          .WithMany(p => p.Autoparts)
          .HasForeignKey(p => p.BrandId)
          .IsRequired();
      });
      
      modelBuilder.Entity<AutopartAsset>(tb => {
        tb.HasKey(p => p.Id);

        tb.HasOne(p => p.Autopart)
          .WithMany(p => p.AutopartAssets)
          .HasForeignKey(p => p.AutopartId)
          .IsRequired();

      });

      modelBuilder.Entity<AutopartBrand>(tb => {
        tb.HasKey(p => p.Id);

      });

      modelBuilder.Entity<AutopartInfo>(tb => {
        tb.HasKey(p => p.Id);

        tb.HasOne(p => p.Autopart)
          .WithMany(p => p.AutopartInfos)
          .HasForeignKey(p => p.AutopartId)
          .IsRequired();
          
        tb.HasOne(p => p.AutopartTypeInfo)
          .WithMany(p => p.AutopartInfos)
          .HasForeignKey(p => p.TypeId)
          .IsRequired();
      });
      
      modelBuilder.Entity<AutopartOfSeller>(tb => {
        tb.HasKey(p => p.Id);

        tb.HasOne(p => p.Autopart)
          .WithMany(p => p.AutopartOfSellers)
          .HasForeignKey(p => p.AutopartId)
          .IsRequired();
          
        tb.HasOne(p => p.Seller)
          .WithMany(p => p.AutopartOfSellers)
          .HasForeignKey(p => p.SellerId)
          .IsRequired();
      });

      modelBuilder.Entity<AutopartTypeInfo>(tb => {
        tb.HasKey(p => p.Id);

      });

      modelBuilder.Entity<Token>(tb => {
        tb.HasKey(p => p.Id);

        tb.HasOne(p => p.User)
          .WithMany(p => p.Tokens)
          .HasForeignKey(p => p.UserId)
          .IsRequired();
      });
    }
  }
}