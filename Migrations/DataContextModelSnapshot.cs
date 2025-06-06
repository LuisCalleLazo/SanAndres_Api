﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using SanAndres_Api.Database;

#nullable disable

namespace SanAndres_Api.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("SanAndres_Api.Models.Admin", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreateAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("CreateUserId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("DeleteAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("DeleteUserId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("UpdateAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("UpdateUserId")
                        .HasColumnType("integer");

                    b.Property<int?>("UserId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("admin");
                });

            modelBuilder.Entity("SanAndres_Api.Models.Autopart", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int?>("AutopartBrandId")
                        .HasColumnType("integer");

                    b.Property<int>("BrandId")
                        .HasColumnType("integer");

                    b.Property<int>("CategoryId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("CreateAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("CreateUserId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("DeleteAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("DeleteUserId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("UpdateAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("UpdateUserId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("AutopartBrandId");

                    b.HasIndex("CategoryId");

                    b.ToTable("autopart");
                });

            modelBuilder.Entity("SanAndres_Api.Models.AutopartAsset", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Asset")
                        .HasColumnType("text");

                    b.Property<int>("AutopartId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("CreateAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("CreateUserId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("DeleteAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("DeleteUserId")
                        .HasColumnType("integer");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<DateTime>("UpdateAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("UpdateUserId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("AutopartId");

                    b.ToTable("autopart_asset");
                });

            modelBuilder.Entity("SanAndres_Api.Models.AutopartBrand", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreateAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("CreateUserId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("DeleteAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("DeleteUserId")
                        .HasColumnType("integer");

                    b.Property<string>("Logo")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<DateTime>("UpdateAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("UpdateUserId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("autopart_brand");
                });

            modelBuilder.Entity("SanAndres_Api.Models.AutopartInfo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("AutopartId")
                        .HasColumnType("integer");

                    b.Property<int?>("AutopartTypeInfoId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("CreateAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("CreateUserId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("DeleteAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("DeleteUserId")
                        .HasColumnType("integer");

                    b.Property<int>("TypeId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("UpdateAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("UpdateUserId")
                        .HasColumnType("integer");

                    b.Property<string>("Value")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("AutopartId");

                    b.HasIndex("AutopartTypeInfoId");

                    b.ToTable("autopart_info");
                });

            modelBuilder.Entity("SanAndres_Api.Models.AutopartOfSeller", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("AmountUnit")
                        .HasColumnType("integer");

                    b.Property<int>("AmountUnitPublic")
                        .HasColumnType("integer");

                    b.Property<int>("AutopartId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("CreateAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("CreateUserId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("DeleteAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("DeleteUserId")
                        .HasColumnType("integer");

                    b.Property<int>("SellerId")
                        .HasColumnType("integer");

                    b.Property<decimal>("UnitPrice")
                        .HasColumnType("numeric");

                    b.Property<decimal>("UnitPricePublic")
                        .HasColumnType("numeric");

                    b.Property<DateTime>("UpdateAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("UpdateUserId")
                        .HasColumnType("integer");

                    b.Property<decimal>("WholessalePrice")
                        .HasColumnType("numeric");

                    b.Property<decimal>("WholessalePricePublic")
                        .HasColumnType("numeric");

                    b.HasKey("Id");

                    b.ToTable("autopart_of_seller");
                });

            modelBuilder.Entity("SanAndres_Api.Models.AutopartTypeInfo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreateAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("CreateUserId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("DeleteAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("DeleteUserId")
                        .HasColumnType("integer");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<int>("TypeValue")
                        .HasColumnType("integer");

                    b.Property<DateTime>("UpdateAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("UpdateUserId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("autopart_type_info");
                });

            modelBuilder.Entity("SanAndres_Api.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Asset")
                        .HasColumnType("text");

                    b.Property<DateTime>("CreateAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("CreateUserId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("DeleteAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("DeleteUserId")
                        .HasColumnType("integer");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<DateTime>("UpdateAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("UpdateUserId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("category");
                });

            modelBuilder.Entity("SanAndres_Api.Models.City", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("CountryId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("CreateAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("CreateUserId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("DeleteAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("DeleteUserId")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("Photo")
                        .HasColumnType("text");

                    b.Property<DateTime>("UpdateAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("UpdateUserId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("CountryId");

                    b.ToTable("city");
                });

            modelBuilder.Entity("SanAndres_Api.Models.Company", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("CountryId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("CreateAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("CreateUserId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("DeleteAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("DeleteUserId")
                        .HasColumnType("integer");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<string>("Logo")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<DateTime>("UpdateAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("UpdateUserId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("CountryId");

                    b.ToTable("company");
                });

            modelBuilder.Entity("SanAndres_Api.Models.CompanyInfo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("CompanyId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("CreateAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("CreateUserId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("DeleteAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("DeleteUserId")
                        .HasColumnType("integer");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<int>("Type")
                        .HasColumnType("integer");

                    b.Property<DateTime>("UpdateAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("UpdateUserId")
                        .HasColumnType("integer");

                    b.Property<string>("ValueInfo")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.ToTable("company_info");
                });

            modelBuilder.Entity("SanAndres_Api.Models.Country", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("CodePhone")
                        .HasColumnType("text");

                    b.Property<DateTime>("CreateAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("CreateUserId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("DeleteAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("DeleteUserId")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("Photo")
                        .HasColumnType("text");

                    b.Property<DateTime>("UpdateAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("UpdateUserId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("country");
                });

            modelBuilder.Entity("SanAndres_Api.Models.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreateAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("CreateUserId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("DeleteAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("DeleteUserId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("UpdateAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("UpdateUserId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("customer");
                });

            modelBuilder.Entity("SanAndres_Api.Models.Sale", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("Amount")
                        .HasColumnType("integer");

                    b.Property<int>("AutopartId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("CreateAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("CreateUserId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("DeleteAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("DeleteUserId")
                        .HasColumnType("integer");

                    b.Property<int>("SaleDetailId")
                        .HasColumnType("integer");

                    b.Property<decimal>("UnitPrice")
                        .HasColumnType("numeric");

                    b.Property<DateTime>("UpdateAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("UpdateUserId")
                        .HasColumnType("integer");

                    b.Property<decimal>("WholessalePrice")
                        .HasColumnType("numeric");

                    b.HasKey("Id");

                    b.HasIndex("AutopartId");

                    b.HasIndex("SaleDetailId");

                    b.ToTable("sale");
                });

            modelBuilder.Entity("SanAndres_Api.Models.SaleDetail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreateAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("CreateUserId")
                        .HasColumnType("integer");

                    b.Property<int?>("CustomerId")
                        .HasColumnType("integer");

                    b.Property<string>("CustomerNotSubscribed")
                        .HasColumnType("text");

                    b.Property<DateTime>("DeleteAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("DeleteUserId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("SaleDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("SellerId")
                        .HasColumnType("integer");

                    b.Property<int>("State")
                        .HasColumnType("integer");

                    b.Property<DateTime>("UpdateAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("UpdateUserId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.HasIndex("SellerId");

                    b.ToTable("sale_detail");
                });

            modelBuilder.Entity("SanAndres_Api.Models.Seller", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int?>("CompanyId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("CreateAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("CreateUserId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("DeleteAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("DeleteUserId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("UpdateAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("UpdateUserId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.ToTable("seller");
                });

            modelBuilder.Entity("SanAndres_Api.Models.Token", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<bool>("Active")
                        .HasColumnType("boolean");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("CurrentToken")
                        .HasColumnType("text");

                    b.Property<DateTime>("ExpiredDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("RefreshToken")
                        .HasColumnType("text");

                    b.Property<int>("UserId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Tokens");
                });

            modelBuilder.Entity("SanAndres_Api.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreateAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("CreateUserId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("DeleteAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("DeleteUserId")
                        .HasColumnType("integer");

                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<bool>("IsSeller")
                        .HasColumnType("boolean");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("Password")
                        .HasColumnType("text");

                    b.Property<Guid>("PasswordSalt")
                        .HasColumnType("uuid");

                    b.Property<DateTime>("UpdateAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("UpdateUserId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("user");
                });

            modelBuilder.Entity("SanAndres_Api.Models.UserInfo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Adress")
                        .HasColumnType("text");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Ci")
                        .HasColumnType("text");

                    b.Property<int>("CityId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("CreateAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("CreateUserId")
                        .HasColumnType("integer");

                    b.Property<string>("DadFirstName")
                        .HasColumnType("text");

                    b.Property<string>("DadLastName")
                        .HasColumnType("text");

                    b.Property<DateTime>("DeleteAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("DeleteUserId")
                        .HasColumnType("integer");

                    b.Property<string>("MomFirstName")
                        .HasColumnType("text");

                    b.Property<string>("MomLastName")
                        .HasColumnType("text");

                    b.Property<DateTime>("UpdateAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("UpdateUserId")
                        .HasColumnType("integer");

                    b.Property<int?>("UserId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("CityId");

                    b.HasIndex("UserId");

                    b.ToTable("user_info");
                });

            modelBuilder.Entity("SanAndres_Api.Models.Admin", b =>
                {
                    b.HasOne("SanAndres_Api.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");

                    b.Navigation("User");
                });

            modelBuilder.Entity("SanAndres_Api.Models.Autopart", b =>
                {
                    b.HasOne("SanAndres_Api.Models.AutopartBrand", null)
                        .WithMany("Autoparts")
                        .HasForeignKey("AutopartBrandId");

                    b.HasOne("SanAndres_Api.Models.Category", null)
                        .WithMany("Autoparts")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SanAndres_Api.Models.AutopartAsset", b =>
                {
                    b.HasOne("SanAndres_Api.Models.Autopart", "Autopart")
                        .WithMany()
                        .HasForeignKey("AutopartId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Autopart");
                });

            modelBuilder.Entity("SanAndres_Api.Models.AutopartInfo", b =>
                {
                    b.HasOne("SanAndres_Api.Models.Autopart", "Autopart")
                        .WithMany()
                        .HasForeignKey("AutopartId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SanAndres_Api.Models.AutopartTypeInfo", "AutopartTypeInfo")
                        .WithMany("AutopartInfos")
                        .HasForeignKey("AutopartTypeInfoId");

                    b.Navigation("Autopart");

                    b.Navigation("AutopartTypeInfo");
                });

            modelBuilder.Entity("SanAndres_Api.Models.City", b =>
                {
                    b.HasOne("SanAndres_Api.Models.Country", "Country")
                        .WithMany("Cities")
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Country");
                });

            modelBuilder.Entity("SanAndres_Api.Models.Company", b =>
                {
                    b.HasOne("SanAndres_Api.Models.Country", "Country")
                        .WithMany("Companies")
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Country");
                });

            modelBuilder.Entity("SanAndres_Api.Models.CompanyInfo", b =>
                {
                    b.HasOne("SanAndres_Api.Models.Company", "Companies")
                        .WithMany("CompanyInfos")
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Companies");
                });

            modelBuilder.Entity("SanAndres_Api.Models.Sale", b =>
                {
                    b.HasOne("SanAndres_Api.Models.Autopart", "Autopart")
                        .WithMany()
                        .HasForeignKey("AutopartId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SanAndres_Api.Models.SaleDetail", "SaleDetail")
                        .WithMany("Sales")
                        .HasForeignKey("SaleDetailId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Autopart");

                    b.Navigation("SaleDetail");
                });

            modelBuilder.Entity("SanAndres_Api.Models.SaleDetail", b =>
                {
                    b.HasOne("SanAndres_Api.Models.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("CustomerId");

                    b.HasOne("SanAndres_Api.Models.Seller", "Seller")
                        .WithMany()
                        .HasForeignKey("SellerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");

                    b.Navigation("Seller");
                });

            modelBuilder.Entity("SanAndres_Api.Models.Seller", b =>
                {
                    b.HasOne("SanAndres_Api.Models.Company", null)
                        .WithMany("Sellers")
                        .HasForeignKey("CompanyId");
                });

            modelBuilder.Entity("SanAndres_Api.Models.Token", b =>
                {
                    b.HasOne("SanAndres_Api.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("SanAndres_Api.Models.UserInfo", b =>
                {
                    b.HasOne("SanAndres_Api.Models.City", "City")
                        .WithMany("UserInfos")
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SanAndres_Api.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");

                    b.Navigation("City");

                    b.Navigation("User");
                });

            modelBuilder.Entity("SanAndres_Api.Models.AutopartBrand", b =>
                {
                    b.Navigation("Autoparts");
                });

            modelBuilder.Entity("SanAndres_Api.Models.AutopartTypeInfo", b =>
                {
                    b.Navigation("AutopartInfos");
                });

            modelBuilder.Entity("SanAndres_Api.Models.Category", b =>
                {
                    b.Navigation("Autoparts");
                });

            modelBuilder.Entity("SanAndres_Api.Models.City", b =>
                {
                    b.Navigation("UserInfos");
                });

            modelBuilder.Entity("SanAndres_Api.Models.Company", b =>
                {
                    b.Navigation("CompanyInfos");

                    b.Navigation("Sellers");
                });

            modelBuilder.Entity("SanAndres_Api.Models.Country", b =>
                {
                    b.Navigation("Cities");

                    b.Navigation("Companies");
                });

            modelBuilder.Entity("SanAndres_Api.Models.SaleDetail", b =>
                {
                    b.Navigation("Sales");
                });
#pragma warning restore 612, 618
        }
    }
}
