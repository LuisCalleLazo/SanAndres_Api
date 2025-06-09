using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SanAndres_Api.Migrations
{
    /// <inheritdoc />
    public partial class AddSeedAutopart : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "autopart_brand",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Logo = table.Column<string>(type: "text", nullable: true),
                    CreateAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdateAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    DeleteAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    CreateUserId = table.Column<int>(type: "integer", nullable: false),
                    UpdateUserId = table.Column<int>(type: "integer", nullable: false),
                    DeleteUserId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_autopart_brand", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "autopart_type_info",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Description = table.Column<string>(type: "text", nullable: true),
                    TypeValue = table.Column<int>(type: "integer", nullable: false),
                    CreateAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdateAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    DeleteAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    CreateUserId = table.Column<int>(type: "integer", nullable: false),
                    UpdateUserId = table.Column<int>(type: "integer", nullable: false),
                    DeleteUserId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_autopart_type_info", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "category",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Description = table.Column<string>(type: "text", nullable: true),
                    Asset = table.Column<string>(type: "text", nullable: true),
                    CreateAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdateAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    DeleteAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    CreateUserId = table.Column<int>(type: "integer", nullable: false),
                    UpdateUserId = table.Column<int>(type: "integer", nullable: false),
                    DeleteUserId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_category", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "country",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Photo = table.Column<string>(type: "text", nullable: true),
                    CodePhone = table.Column<string>(type: "text", nullable: true),
                    CreateAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdateAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    DeleteAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    CreateUserId = table.Column<int>(type: "integer", nullable: false),
                    UpdateUserId = table.Column<int>(type: "integer", nullable: false),
                    DeleteUserId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_country", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "user",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Email = table.Column<string>(type: "text", nullable: true),
                    Password = table.Column<string>(type: "text", nullable: true),
                    PasswordSalt = table.Column<Guid>(type: "uuid", nullable: false),
                    CreateAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdateAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    DeleteAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    CreateUserId = table.Column<int>(type: "integer", nullable: false),
                    UpdateUserId = table.Column<int>(type: "integer", nullable: false),
                    DeleteUserId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_user", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "autopart",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true),
                    BrandId = table.Column<int>(type: "integer", nullable: false),
                    CategoryId = table.Column<int>(type: "integer", nullable: false),
                    CreateAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdateAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    DeleteAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    CreateUserId = table.Column<int>(type: "integer", nullable: false),
                    UpdateUserId = table.Column<int>(type: "integer", nullable: false),
                    DeleteUserId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_autopart", x => x.Id);
                    table.ForeignKey(
                        name: "FK_autopart_autopart_brand_BrandId",
                        column: x => x.BrandId,
                        principalTable: "autopart_brand",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_autopart_category_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "category",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "city",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Photo = table.Column<string>(type: "text", nullable: true),
                    CountryId = table.Column<int>(type: "integer", nullable: false),
                    CreateAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdateAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    DeleteAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    CreateUserId = table.Column<int>(type: "integer", nullable: false),
                    UpdateUserId = table.Column<int>(type: "integer", nullable: false),
                    DeleteUserId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_city", x => x.Id);
                    table.ForeignKey(
                        name: "FK_city_country_CountryId",
                        column: x => x.CountryId,
                        principalTable: "country",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "company",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Description = table.Column<string>(type: "text", nullable: true),
                    Logo = table.Column<string>(type: "text", nullable: true),
                    CountryId = table.Column<int>(type: "integer", nullable: false),
                    CreateAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdateAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    DeleteAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    CreateUserId = table.Column<int>(type: "integer", nullable: false),
                    UpdateUserId = table.Column<int>(type: "integer", nullable: false),
                    DeleteUserId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_company", x => x.Id);
                    table.ForeignKey(
                        name: "FK_company_country_CountryId",
                        column: x => x.CountryId,
                        principalTable: "country",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "admin",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false),
                    CreateAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdateAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    DeleteAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    CreateUserId = table.Column<int>(type: "integer", nullable: false),
                    UpdateUserId = table.Column<int>(type: "integer", nullable: false),
                    DeleteUserId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_admin", x => x.Id);
                    table.ForeignKey(
                        name: "FK_admin_user_Id",
                        column: x => x.Id,
                        principalTable: "user",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "customer",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false),
                    CreateAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdateAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    DeleteAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    CreateUserId = table.Column<int>(type: "integer", nullable: false),
                    UpdateUserId = table.Column<int>(type: "integer", nullable: false),
                    DeleteUserId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_customer", x => x.Id);
                    table.ForeignKey(
                        name: "FK_customer_user_Id",
                        column: x => x.Id,
                        principalTable: "user",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tokens",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CurrentToken = table.Column<string>(type: "text", nullable: true),
                    RefreshToken = table.Column<string>(type: "text", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    ExpiredDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Active = table.Column<bool>(type: "boolean", nullable: false),
                    UserId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tokens", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tokens_user_UserId",
                        column: x => x.UserId,
                        principalTable: "user",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "autopart_asset",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Asset = table.Column<string>(type: "text", nullable: true),
                    Description = table.Column<string>(type: "text", nullable: true),
                    AutopartId = table.Column<int>(type: "integer", nullable: false),
                    CreateAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdateAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    DeleteAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    CreateUserId = table.Column<int>(type: "integer", nullable: false),
                    UpdateUserId = table.Column<int>(type: "integer", nullable: false),
                    DeleteUserId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_autopart_asset", x => x.Id);
                    table.ForeignKey(
                        name: "FK_autopart_asset_autopart_AutopartId",
                        column: x => x.AutopartId,
                        principalTable: "autopart",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "autopart_info",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Value = table.Column<string>(type: "text", nullable: true),
                    TypeId = table.Column<int>(type: "integer", nullable: false),
                    AutopartId = table.Column<int>(type: "integer", nullable: false),
                    CreateAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdateAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    DeleteAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    CreateUserId = table.Column<int>(type: "integer", nullable: false),
                    UpdateUserId = table.Column<int>(type: "integer", nullable: false),
                    DeleteUserId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_autopart_info", x => x.Id);
                    table.ForeignKey(
                        name: "FK_autopart_info_autopart_AutopartId",
                        column: x => x.AutopartId,
                        principalTable: "autopart",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_autopart_info_autopart_type_info_TypeId",
                        column: x => x.TypeId,
                        principalTable: "autopart_type_info",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "user_info",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false),
                    DadFirstName = table.Column<string>(type: "text", nullable: true),
                    MomFirstName = table.Column<string>(type: "text", nullable: true),
                    DadLastName = table.Column<string>(type: "text", nullable: true),
                    MomLastName = table.Column<string>(type: "text", nullable: true),
                    BirthDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Adress = table.Column<string>(type: "text", nullable: true),
                    Ci = table.Column<string>(type: "text", nullable: true),
                    CityId = table.Column<int>(type: "integer", nullable: false),
                    CreateAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdateAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    DeleteAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    CreateUserId = table.Column<int>(type: "integer", nullable: false),
                    UpdateUserId = table.Column<int>(type: "integer", nullable: false),
                    DeleteUserId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_user_info", x => x.Id);
                    table.ForeignKey(
                        name: "FK_user_info_city_CityId",
                        column: x => x.CityId,
                        principalTable: "city",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_user_info_user_Id",
                        column: x => x.Id,
                        principalTable: "user",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "company_info",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Type = table.Column<int>(type: "integer", nullable: false),
                    ValueInfo = table.Column<string>(type: "text", nullable: true),
                    Description = table.Column<string>(type: "text", nullable: true),
                    CompanyId = table.Column<int>(type: "integer", nullable: false),
                    CreateAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdateAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    DeleteAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    CreateUserId = table.Column<int>(type: "integer", nullable: false),
                    UpdateUserId = table.Column<int>(type: "integer", nullable: false),
                    DeleteUserId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_company_info", x => x.Id);
                    table.ForeignKey(
                        name: "FK_company_info_company_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "company",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "seller",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false),
                    CompanyId = table.Column<int>(type: "integer", nullable: true),
                    CreateAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdateAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    DeleteAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    CreateUserId = table.Column<int>(type: "integer", nullable: false),
                    UpdateUserId = table.Column<int>(type: "integer", nullable: false),
                    DeleteUserId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_seller", x => x.Id);
                    table.ForeignKey(
                        name: "FK_seller_company_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "company",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_seller_user_Id",
                        column: x => x.Id,
                        principalTable: "user",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "autopart_of_seller",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    AutopartId = table.Column<int>(type: "integer", nullable: false),
                    SellerId = table.Column<int>(type: "integer", nullable: false),
                    AmountUnit = table.Column<int>(type: "integer", nullable: false),
                    AmountUnitPublic = table.Column<int>(type: "integer", nullable: false),
                    UnitPrice = table.Column<decimal>(type: "numeric", nullable: false),
                    UnitPricePublic = table.Column<decimal>(type: "numeric", nullable: false),
                    WholessalePrice = table.Column<decimal>(type: "numeric", nullable: false),
                    WholessalePricePublic = table.Column<decimal>(type: "numeric", nullable: false),
                    CreateAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdateAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    DeleteAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    CreateUserId = table.Column<int>(type: "integer", nullable: false),
                    UpdateUserId = table.Column<int>(type: "integer", nullable: false),
                    DeleteUserId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_autopart_of_seller", x => x.Id);
                    table.ForeignKey(
                        name: "FK_autopart_of_seller_autopart_AutopartId",
                        column: x => x.AutopartId,
                        principalTable: "autopart",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_autopart_of_seller_seller_SellerId",
                        column: x => x.SellerId,
                        principalTable: "seller",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "sale_detail",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CustomerId = table.Column<int>(type: "integer", nullable: false),
                    CustomerNotSubscribed = table.Column<string>(type: "text", nullable: true),
                    SellerId = table.Column<int>(type: "integer", nullable: false),
                    SaleDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    State = table.Column<int>(type: "integer", nullable: false),
                    CreateAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdateAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    DeleteAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    CreateUserId = table.Column<int>(type: "integer", nullable: false),
                    UpdateUserId = table.Column<int>(type: "integer", nullable: false),
                    DeleteUserId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sale_detail", x => x.Id);
                    table.ForeignKey(
                        name: "FK_sale_detail_customer_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "customer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_sale_detail_seller_SellerId",
                        column: x => x.SellerId,
                        principalTable: "seller",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "sale",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    AutopartId = table.Column<int>(type: "integer", nullable: false),
                    SaleDetailId = table.Column<int>(type: "integer", nullable: false),
                    Amount = table.Column<int>(type: "integer", nullable: false),
                    UnitPrice = table.Column<decimal>(type: "numeric", nullable: false),
                    WholessalePrice = table.Column<decimal>(type: "numeric", nullable: false),
                    CreateAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdateAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    DeleteAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    CreateUserId = table.Column<int>(type: "integer", nullable: false),
                    UpdateUserId = table.Column<int>(type: "integer", nullable: false),
                    DeleteUserId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sale", x => x.Id);
                    table.ForeignKey(
                        name: "FK_sale_autopart_AutopartId",
                        column: x => x.AutopartId,
                        principalTable: "autopart",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_sale_sale_detail_SaleDetailId",
                        column: x => x.SaleDetailId,
                        principalTable: "sale_detail",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "autopart_brand",
                columns: new[] { "Id", "CreateAt", "CreateUserId", "DeleteAt", "DeleteUserId", "Logo", "Name", "UpdateAt", "UpdateUserId" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 6, 9, 12, 6, 55, 877, DateTimeKind.Utc).AddTicks(6221), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "", "Yoitoki", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 2, new DateTime(2025, 6, 9, 12, 6, 55, 877, DateTimeKind.Utc).AddTicks(6233), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "", "Perfect", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 3, new DateTime(2025, 6, 9, 12, 6, 55, 877, DateTimeKind.Utc).AddTicks(6236), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "", "Nissan", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 4, new DateTime(2025, 6, 9, 12, 6, 55, 877, DateTimeKind.Utc).AddTicks(6240), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "", "Bosch", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 5, new DateTime(2025, 6, 9, 12, 6, 55, 877, DateTimeKind.Utc).AddTicks(6243), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "", "Denso", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 6, new DateTime(2025, 6, 9, 12, 6, 55, 877, DateTimeKind.Utc).AddTicks(6249), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "", "Hibari", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 7, new DateTime(2025, 6, 9, 12, 6, 55, 877, DateTimeKind.Utc).AddTicks(6251), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "", "Koyo", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 8, new DateTime(2025, 6, 9, 12, 6, 55, 877, DateTimeKind.Utc).AddTicks(6254), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "", "KYB", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 9, new DateTime(2025, 6, 9, 12, 6, 55, 877, DateTimeKind.Utc).AddTicks(6257), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "", "MAHLE", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 10, new DateTime(2025, 6, 9, 12, 6, 55, 877, DateTimeKind.Utc).AddTicks(6261), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "", "Mando", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 11, new DateTime(2025, 6, 9, 12, 6, 55, 877, DateTimeKind.Utc).AddTicks(6264), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "", "NPC", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 12, new DateTime(2025, 6, 9, 12, 6, 55, 877, DateTimeKind.Utc).AddTicks(6266), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "", "PHC", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 13, new DateTime(2025, 6, 9, 12, 6, 55, 877, DateTimeKind.Utc).AddTicks(6268), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "", "RIK", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 14, new DateTime(2025, 6, 9, 12, 6, 55, 877, DateTimeKind.Utc).AddTicks(6270), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "", "SACHS", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 15, new DateTime(2025, 6, 9, 12, 6, 55, 877, DateTimeKind.Utc).AddTicks(6272), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "", "SCHAEFFLER", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 16, new DateTime(2025, 6, 9, 12, 6, 55, 877, DateTimeKind.Utc).AddTicks(6275), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "", "Shibumi", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 17, new DateTime(2025, 6, 9, 12, 6, 55, 877, DateTimeKind.Utc).AddTicks(6277), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "", "Toto Pistons", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 18, new DateTime(2025, 6, 9, 12, 6, 55, 877, DateTimeKind.Utc).AddTicks(6283), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "", "YUASA", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 19, new DateTime(2025, 6, 9, 12, 6, 55, 877, DateTimeKind.Utc).AddTicks(6285), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "", "GMB", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 20, new DateTime(2025, 6, 9, 12, 6, 55, 877, DateTimeKind.Utc).AddTicks(6287), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "", "OSK", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 21, new DateTime(2025, 6, 9, 12, 6, 55, 877, DateTimeKind.Utc).AddTicks(6290), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "", "PHILIPS", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 22, new DateTime(2025, 6, 9, 12, 6, 55, 877, DateTimeKind.Utc).AddTicks(6292), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "", "SKF", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 23, new DateTime(2025, 6, 9, 12, 6, 55, 877, DateTimeKind.Utc).AddTicks(6295), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "", "TBK", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 24, new DateTime(2025, 6, 9, 12, 6, 55, 877, DateTimeKind.Utc).AddTicks(6297), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "", "OIL PUMP", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 25, new DateTime(2025, 6, 9, 12, 6, 55, 877, DateTimeKind.Utc).AddTicks(6300), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "", "Wolf", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 26, new DateTime(2025, 6, 9, 12, 6, 55, 877, DateTimeKind.Utc).AddTicks(6302), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "", "Mitsubishi", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 27, new DateTime(2025, 6, 9, 12, 6, 55, 877, DateTimeKind.Utc).AddTicks(6305), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "", "Aisin", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 28, new DateTime(2025, 6, 9, 12, 6, 55, 877, DateTimeKind.Utc).AddTicks(6307), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "", "Mann-Filter", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 29, new DateTime(2025, 6, 9, 12, 6, 55, 877, DateTimeKind.Utc).AddTicks(6310), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "", "Wix", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 30, new DateTime(2025, 6, 9, 12, 6, 55, 877, DateTimeKind.Utc).AddTicks(6312), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "", "Fram", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 31, new DateTime(2025, 6, 9, 12, 6, 55, 877, DateTimeKind.Utc).AddTicks(6315), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "", "NGK", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 32, new DateTime(2025, 6, 9, 12, 6, 55, 877, DateTimeKind.Utc).AddTicks(6317), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "", "Hitachi", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 33, new DateTime(2025, 6, 9, 12, 6, 55, 877, DateTimeKind.Utc).AddTicks(6319), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "", "TRW", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 34, new DateTime(2025, 6, 9, 12, 6, 55, 877, DateTimeKind.Utc).AddTicks(6324), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "", "Valeo", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 35, new DateTime(2025, 6, 9, 12, 6, 55, 877, DateTimeKind.Utc).AddTicks(6326), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "", "Delphi", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 36, new DateTime(2025, 6, 9, 12, 6, 55, 877, DateTimeKind.Utc).AddTicks(6328), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "", "Mevotech", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 37, new DateTime(2025, 6, 9, 12, 6, 55, 877, DateTimeKind.Utc).AddTicks(6331), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "", "Corteco", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 38, new DateTime(2025, 6, 9, 12, 6, 55, 877, DateTimeKind.Utc).AddTicks(6333), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "", "Timken", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 39, new DateTime(2025, 6, 9, 12, 6, 55, 877, DateTimeKind.Utc).AddTicks(6335), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "", "ZF", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 40, new DateTime(2025, 6, 9, 12, 6, 55, 877, DateTimeKind.Utc).AddTicks(6337), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "", "Federal Mogul", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 41, new DateTime(2025, 6, 9, 12, 6, 55, 877, DateTimeKind.Utc).AddTicks(6340), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "", "Gates", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 42, new DateTime(2025, 6, 9, 12, 6, 55, 877, DateTimeKind.Utc).AddTicks(6342), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "", "Bando", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 43, new DateTime(2025, 6, 9, 12, 6, 55, 877, DateTimeKind.Utc).AddTicks(6344), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "", "Dayco", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 44, new DateTime(2025, 6, 9, 12, 6, 55, 877, DateTimeKind.Utc).AddTicks(6346), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "", "Pirelli", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 45, new DateTime(2025, 6, 9, 12, 6, 55, 877, DateTimeKind.Utc).AddTicks(6348), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "", "Firestone", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 46, new DateTime(2025, 6, 9, 12, 6, 55, 877, DateTimeKind.Utc).AddTicks(6351), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "", "Bridgestone", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 47, new DateTime(2025, 6, 9, 12, 6, 55, 877, DateTimeKind.Utc).AddTicks(6353), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "", "Goodyear", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 48, new DateTime(2025, 6, 9, 12, 6, 55, 877, DateTimeKind.Utc).AddTicks(6355), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "", "Yokohama", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 49, new DateTime(2025, 6, 9, 12, 6, 55, 877, DateTimeKind.Utc).AddTicks(6358), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "", "Maxxis", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 50, new DateTime(2025, 6, 9, 12, 6, 55, 877, DateTimeKind.Utc).AddTicks(6360), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "", "Toyo", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 51, new DateTime(2025, 6, 9, 12, 6, 55, 877, DateTimeKind.Utc).AddTicks(6362), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "", "Falken", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 52, new DateTime(2025, 6, 9, 12, 6, 55, 877, DateTimeKind.Utc).AddTicks(6364), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "", "Avon", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 53, new DateTime(2025, 6, 9, 12, 6, 55, 877, DateTimeKind.Utc).AddTicks(6367), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "", "Kenda", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 54, new DateTime(2025, 6, 9, 12, 6, 55, 877, DateTimeKind.Utc).AddTicks(6369), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "", "Michelin", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 55, new DateTime(2025, 6, 9, 12, 6, 55, 877, DateTimeKind.Utc).AddTicks(6372), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "", "Continental", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 56, new DateTime(2025, 6, 9, 12, 6, 55, 877, DateTimeKind.Utc).AddTicks(6374), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "", "BKT", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 57, new DateTime(2025, 6, 9, 12, 6, 55, 877, DateTimeKind.Utc).AddTicks(6458), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "", "Trelleborg", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 58, new DateTime(2025, 6, 9, 12, 6, 55, 877, DateTimeKind.Utc).AddTicks(6462), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "", "Uniroyal", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 59, new DateTime(2025, 6, 9, 12, 6, 55, 877, DateTimeKind.Utc).AddTicks(6464), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "", "Kumho", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 60, new DateTime(2025, 6, 9, 12, 6, 55, 877, DateTimeKind.Utc).AddTicks(6466), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "", "Hankook", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 61, new DateTime(2025, 6, 9, 12, 6, 55, 877, DateTimeKind.Utc).AddTicks(6469), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "", "Cooper", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 62, new DateTime(2025, 6, 9, 12, 6, 55, 877, DateTimeKind.Utc).AddTicks(6472), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "", "Nitto", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 63, new DateTime(2025, 6, 9, 12, 6, 55, 877, DateTimeKind.Utc).AddTicks(6474), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "", "Wabco", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 64, new DateTime(2025, 6, 9, 12, 6, 55, 877, DateTimeKind.Utc).AddTicks(6476), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "", "Haldex", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 65, new DateTime(2025, 6, 9, 12, 6, 55, 877, DateTimeKind.Utc).AddTicks(6479), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "", "Spicer", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 66, new DateTime(2025, 6, 9, 12, 6, 55, 877, DateTimeKind.Utc).AddTicks(6484), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "", "VDO", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 67, new DateTime(2025, 6, 9, 12, 6, 55, 877, DateTimeKind.Utc).AddTicks(6487), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "", "Mann", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 68, new DateTime(2025, 6, 9, 12, 6, 55, 877, DateTimeKind.Utc).AddTicks(6489), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "", "Lucas", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 69, new DateTime(2025, 6, 9, 12, 6, 55, 877, DateTimeKind.Utc).AddTicks(6491), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "", "Sylvania", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 70, new DateTime(2025, 6, 9, 12, 6, 55, 877, DateTimeKind.Utc).AddTicks(6493), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "", "Behr", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 71, new DateTime(2025, 6, 9, 12, 6, 55, 877, DateTimeKind.Utc).AddTicks(6495), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "", "Optima", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 72, new DateTime(2025, 6, 9, 12, 6, 55, 877, DateTimeKind.Utc).AddTicks(6497), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "", "Exide", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 73, new DateTime(2025, 6, 9, 12, 6, 55, 877, DateTimeKind.Utc).AddTicks(6525), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "", "Interstate", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 74, new DateTime(2025, 6, 9, 12, 6, 55, 877, DateTimeKind.Utc).AddTicks(6527), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "", "GPC", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 75, new DateTime(2025, 6, 9, 12, 6, 55, 877, DateTimeKind.Utc).AddTicks(6530), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "", "Tukisumi", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 }
                });

            migrationBuilder.InsertData(
                table: "autopart_type_info",
                columns: new[] { "Id", "CreateAt", "CreateUserId", "DeleteAt", "DeleteUserId", "Description", "Name", "TypeValue", "UpdateAt", "UpdateUserId" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 6, 9, 12, 6, 55, 879, DateTimeKind.Utc).AddTicks(5104), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, null, "Código general", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 2, new DateTime(2025, 6, 9, 12, 6, 55, 879, DateTimeKind.Utc).AddTicks(5114), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, null, "Código alternativo", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 3, new DateTime(2025, 6, 9, 12, 6, 55, 879, DateTimeKind.Utc).AddTicks(5118), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, null, "Código de fabricante", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 4, new DateTime(2025, 6, 9, 12, 6, 55, 879, DateTimeKind.Utc).AddTicks(5120), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, null, "Medidas (dimensiones)", 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 5, new DateTime(2025, 6, 9, 12, 6, 55, 879, DateTimeKind.Utc).AddTicks(5384), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, null, "Peso", 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 6, new DateTime(2025, 6, 9, 12, 6, 55, 879, DateTimeKind.Utc).AddTicks(5390), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, null, "Diámetro", 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 7, new DateTime(2025, 6, 9, 12, 6, 55, 879, DateTimeKind.Utc).AddTicks(5392), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, null, "Longitud", 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 8, new DateTime(2025, 6, 9, 12, 6, 55, 879, DateTimeKind.Utc).AddTicks(5394), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, null, "Contenido del paquete", 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 9, new DateTime(2025, 6, 9, 12, 6, 55, 879, DateTimeKind.Utc).AddTicks(5397), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, null, "Material", 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 10, new DateTime(2025, 6, 9, 12, 6, 55, 879, DateTimeKind.Utc).AddTicks(5401), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, null, "Color", 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 11, new DateTime(2025, 6, 9, 12, 6, 55, 879, DateTimeKind.Utc).AddTicks(5403), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, null, "Cantidad de piezas", 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 12, new DateTime(2025, 6, 9, 12, 6, 55, 879, DateTimeKind.Utc).AddTicks(5406), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, null, "Torque", 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 13, new DateTime(2025, 6, 9, 12, 6, 55, 879, DateTimeKind.Utc).AddTicks(5408), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, null, "Voltaje", 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 14, new DateTime(2025, 6, 9, 12, 6, 55, 879, DateTimeKind.Utc).AddTicks(5410), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, null, "Amperaje", 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 }
                });

            migrationBuilder.InsertData(
                table: "category",
                columns: new[] { "Id", "Asset", "CreateAt", "CreateUserId", "DeleteAt", "DeleteUserId", "Description", "Name", "UpdateAt", "UpdateUserId" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2025, 6, 9, 12, 6, 55, 876, DateTimeKind.Utc).AddTicks(3555), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, null, "JUNTAS", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 2, null, new DateTime(2025, 6, 9, 12, 6, 55, 876, DateTimeKind.Utc).AddTicks(3575), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, null, "AMORTIGUADORES", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 3, null, new DateTime(2025, 6, 9, 12, 6, 55, 876, DateTimeKind.Utc).AddTicks(3584), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, null, "FRENOS", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 4, null, new DateTime(2025, 6, 9, 12, 6, 55, 876, DateTimeKind.Utc).AddTicks(3591), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, null, "SUSPENSIÓN", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 5, null, new DateTime(2025, 6, 9, 12, 6, 55, 876, DateTimeKind.Utc).AddTicks(3596), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, null, "MOTOR", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 6, null, new DateTime(2025, 6, 9, 12, 6, 55, 876, DateTimeKind.Utc).AddTicks(3614), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, null, "TRANSMISIÓN", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 7, null, new DateTime(2025, 6, 9, 12, 6, 55, 876, DateTimeKind.Utc).AddTicks(3621), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, null, "ELECTRICIDAD", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 8, null, new DateTime(2025, 6, 9, 12, 6, 55, 876, DateTimeKind.Utc).AddTicks(3627), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, null, "ESCAPE", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 9, null, new DateTime(2025, 6, 9, 12, 6, 55, 876, DateTimeKind.Utc).AddTicks(3633), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, null, "FILTROS", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 10, null, new DateTime(2025, 6, 9, 12, 6, 55, 876, DateTimeKind.Utc).AddTicks(3646), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, null, "LUCES", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 11, null, new DateTime(2025, 6, 9, 12, 6, 55, 876, DateTimeKind.Utc).AddTicks(3651), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, null, "BATERÍAS", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 12, null, new DateTime(2025, 6, 9, 12, 6, 55, 876, DateTimeKind.Utc).AddTicks(3657), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, null, "NEUMÁTICOS", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 13, null, new DateTime(2025, 6, 9, 12, 6, 55, 876, DateTimeKind.Utc).AddTicks(3662), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, null, "CARROCERÍA", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 14, null, new DateTime(2025, 6, 9, 12, 6, 55, 876, DateTimeKind.Utc).AddTicks(3668), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, null, "ACCESORIOS", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 }
                });

            migrationBuilder.InsertData(
                table: "country",
                columns: new[] { "Id", "CodePhone", "CreateAt", "CreateUserId", "DeleteAt", "DeleteUserId", "Name", "Photo", "UpdateAt", "UpdateUserId" },
                values: new object[,]
                {
                    { 1, "+54", new DateTime(2025, 6, 9, 12, 6, 55, 875, DateTimeKind.Utc).AddTicks(445), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Argentina", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 2, "+591", new DateTime(2025, 6, 9, 12, 6, 55, 875, DateTimeKind.Utc).AddTicks(455), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Bolivia", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 3, "+55", new DateTime(2025, 6, 9, 12, 6, 55, 875, DateTimeKind.Utc).AddTicks(459), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Brasil", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 4, "+56", new DateTime(2025, 6, 9, 12, 6, 55, 875, DateTimeKind.Utc).AddTicks(461), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Chile", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 5, "+57", new DateTime(2025, 6, 9, 12, 6, 55, 875, DateTimeKind.Utc).AddTicks(464), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Colombia", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 6, "+506", new DateTime(2025, 6, 9, 12, 6, 55, 875, DateTimeKind.Utc).AddTicks(469), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Costa Rica", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 7, "+53", new DateTime(2025, 6, 9, 12, 6, 55, 875, DateTimeKind.Utc).AddTicks(471), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Cuba", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 8, "+593", new DateTime(2025, 6, 9, 12, 6, 55, 875, DateTimeKind.Utc).AddTicks(474), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Ecuador", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 9, "+503", new DateTime(2025, 6, 9, 12, 6, 55, 875, DateTimeKind.Utc).AddTicks(476), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "El Salvador", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 10, "+502", new DateTime(2025, 6, 9, 12, 6, 55, 875, DateTimeKind.Utc).AddTicks(481), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Guatemala", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 11, "+504", new DateTime(2025, 6, 9, 12, 6, 55, 875, DateTimeKind.Utc).AddTicks(483), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Honduras", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 12, "+52", new DateTime(2025, 6, 9, 12, 6, 55, 875, DateTimeKind.Utc).AddTicks(485), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "México", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 13, "+505", new DateTime(2025, 6, 9, 12, 6, 55, 875, DateTimeKind.Utc).AddTicks(488), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Nicaragua", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 14, "+507", new DateTime(2025, 6, 9, 12, 6, 55, 875, DateTimeKind.Utc).AddTicks(490), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Panamá", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 15, "+595", new DateTime(2025, 6, 9, 12, 6, 55, 875, DateTimeKind.Utc).AddTicks(492), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Paraguay", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 16, "+51", new DateTime(2025, 6, 9, 12, 6, 55, 875, DateTimeKind.Utc).AddTicks(495), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Perú", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 17, "+1", new DateTime(2025, 6, 9, 12, 6, 55, 875, DateTimeKind.Utc).AddTicks(497), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "República Dominicana", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 18, "+598", new DateTime(2025, 6, 9, 12, 6, 55, 875, DateTimeKind.Utc).AddTicks(567), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Uruguay", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 19, "+58", new DateTime(2025, 6, 9, 12, 6, 55, 875, DateTimeKind.Utc).AddTicks(571), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Venezuela", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 }
                });

            migrationBuilder.InsertData(
                table: "city",
                columns: new[] { "Id", "CountryId", "CreateAt", "CreateUserId", "DeleteAt", "DeleteUserId", "Name", "Photo", "UpdateAt", "UpdateUserId" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2025, 6, 9, 12, 6, 55, 874, DateTimeKind.Utc).AddTicks(9596), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Buenos Aires", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 2, 1, new DateTime(2025, 6, 9, 12, 6, 55, 874, DateTimeKind.Utc).AddTicks(9607), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Córdoba", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 3, 1, new DateTime(2025, 6, 9, 12, 6, 55, 874, DateTimeKind.Utc).AddTicks(9610), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Mendoza", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 4, 1, new DateTime(2025, 6, 9, 12, 6, 55, 874, DateTimeKind.Utc).AddTicks(9612), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Santa Fe", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 5, 1, new DateTime(2025, 6, 9, 12, 6, 55, 874, DateTimeKind.Utc).AddTicks(9614), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Tucumán", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 6, 1, new DateTime(2025, 6, 9, 12, 6, 55, 874, DateTimeKind.Utc).AddTicks(9620), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Salta", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 7, 2, new DateTime(2025, 6, 9, 12, 6, 55, 874, DateTimeKind.Utc).AddTicks(9622), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "La Paz", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 8, 2, new DateTime(2025, 6, 9, 12, 6, 55, 874, DateTimeKind.Utc).AddTicks(9625), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Cochabamba", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 9, 2, new DateTime(2025, 6, 9, 12, 6, 55, 874, DateTimeKind.Utc).AddTicks(9627), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Santa Cruz", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 10, 2, new DateTime(2025, 6, 9, 12, 6, 55, 874, DateTimeKind.Utc).AddTicks(9632), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Oruro", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 11, 2, new DateTime(2025, 6, 9, 12, 6, 55, 874, DateTimeKind.Utc).AddTicks(9634), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Potosí", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 12, 2, new DateTime(2025, 6, 9, 12, 6, 55, 874, DateTimeKind.Utc).AddTicks(9637), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Tarija", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 13, 2, new DateTime(2025, 6, 9, 12, 6, 55, 874, DateTimeKind.Utc).AddTicks(9639), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Beni", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 14, 2, new DateTime(2025, 6, 9, 12, 6, 55, 874, DateTimeKind.Utc).AddTicks(9641), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Chuquisaca", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 15, 2, new DateTime(2025, 6, 9, 12, 6, 55, 874, DateTimeKind.Utc).AddTicks(9643), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Pando", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 16, 3, new DateTime(2025, 6, 9, 12, 6, 55, 874, DateTimeKind.Utc).AddTicks(9645), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "São Paulo", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 17, 3, new DateTime(2025, 6, 9, 12, 6, 55, 874, DateTimeKind.Utc).AddTicks(9647), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Rio de Janeiro", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 18, 3, new DateTime(2025, 6, 9, 12, 6, 55, 874, DateTimeKind.Utc).AddTicks(9652), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Bahía", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 19, 3, new DateTime(2025, 6, 9, 12, 6, 55, 874, DateTimeKind.Utc).AddTicks(9655), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Minas Gerais", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 20, 3, new DateTime(2025, 6, 9, 12, 6, 55, 874, DateTimeKind.Utc).AddTicks(9657), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Paraná", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 21, 3, new DateTime(2025, 6, 9, 12, 6, 55, 874, DateTimeKind.Utc).AddTicks(9659), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Pernambuco", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 22, 4, new DateTime(2025, 6, 9, 12, 6, 55, 874, DateTimeKind.Utc).AddTicks(9661), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Santiago Metropolitana", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 23, 4, new DateTime(2025, 6, 9, 12, 6, 55, 874, DateTimeKind.Utc).AddTicks(9663), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Valparaíso", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 24, 4, new DateTime(2025, 6, 9, 12, 6, 55, 874, DateTimeKind.Utc).AddTicks(9665), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Biobío", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 25, 4, new DateTime(2025, 6, 9, 12, 6, 55, 874, DateTimeKind.Utc).AddTicks(9667), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Araucanía", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 26, 4, new DateTime(2025, 6, 9, 12, 6, 55, 874, DateTimeKind.Utc).AddTicks(9669), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Coquimbo", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 27, 5, new DateTime(2025, 6, 9, 12, 6, 55, 874, DateTimeKind.Utc).AddTicks(9671), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Bogotá D.C.", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 28, 5, new DateTime(2025, 6, 9, 12, 6, 55, 874, DateTimeKind.Utc).AddTicks(9673), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Antioquia", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 29, 5, new DateTime(2025, 6, 9, 12, 6, 55, 874, DateTimeKind.Utc).AddTicks(9675), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Valle del Cauca", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 30, 5, new DateTime(2025, 6, 9, 12, 6, 55, 874, DateTimeKind.Utc).AddTicks(9677), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Cundinamarca", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 31, 5, new DateTime(2025, 6, 9, 12, 6, 55, 874, DateTimeKind.Utc).AddTicks(9679), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Atlántico", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 32, 6, new DateTime(2025, 6, 9, 12, 6, 55, 874, DateTimeKind.Utc).AddTicks(9681), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "San José", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 33, 6, new DateTime(2025, 6, 9, 12, 6, 55, 874, DateTimeKind.Utc).AddTicks(9683), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Alajuela", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 34, 6, new DateTime(2025, 6, 9, 12, 6, 55, 874, DateTimeKind.Utc).AddTicks(9688), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Cartago", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 35, 6, new DateTime(2025, 6, 9, 12, 6, 55, 874, DateTimeKind.Utc).AddTicks(9690), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Heredia", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 36, 7, new DateTime(2025, 6, 9, 12, 6, 55, 874, DateTimeKind.Utc).AddTicks(9692), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "La Habana", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 37, 7, new DateTime(2025, 6, 9, 12, 6, 55, 874, DateTimeKind.Utc).AddTicks(9696), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Santiago de Cuba", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 38, 7, new DateTime(2025, 6, 9, 12, 6, 55, 874, DateTimeKind.Utc).AddTicks(9698), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Camagüey", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 39, 7, new DateTime(2025, 6, 9, 12, 6, 55, 874, DateTimeKind.Utc).AddTicks(9700), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Holguín", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 40, 8, new DateTime(2025, 6, 9, 12, 6, 55, 874, DateTimeKind.Utc).AddTicks(9702), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Pichincha", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 41, 8, new DateTime(2025, 6, 9, 12, 6, 55, 874, DateTimeKind.Utc).AddTicks(9704), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Guayas", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 42, 8, new DateTime(2025, 6, 9, 12, 6, 55, 874, DateTimeKind.Utc).AddTicks(9707), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Azuay", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 43, 8, new DateTime(2025, 6, 9, 12, 6, 55, 874, DateTimeKind.Utc).AddTicks(9709), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Manabí", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 44, 9, new DateTime(2025, 6, 9, 12, 6, 55, 874, DateTimeKind.Utc).AddTicks(9711), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "San Salvador", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 45, 9, new DateTime(2025, 6, 9, 12, 6, 55, 874, DateTimeKind.Utc).AddTicks(9713), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Santa Ana", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 46, 9, new DateTime(2025, 6, 9, 12, 6, 55, 874, DateTimeKind.Utc).AddTicks(9715), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "La Libertad", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 47, 9, new DateTime(2025, 6, 9, 12, 6, 55, 874, DateTimeKind.Utc).AddTicks(9718), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "San Miguel", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 48, 10, new DateTime(2025, 6, 9, 12, 6, 55, 874, DateTimeKind.Utc).AddTicks(9720), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Guatemala", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 49, 10, new DateTime(2025, 6, 9, 12, 6, 55, 874, DateTimeKind.Utc).AddTicks(9722), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Quetzaltenango", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 50, 10, new DateTime(2025, 6, 9, 12, 6, 55, 874, DateTimeKind.Utc).AddTicks(9724), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Petén", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 51, 10, new DateTime(2025, 6, 9, 12, 6, 55, 874, DateTimeKind.Utc).AddTicks(9726), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Huehuetenango", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 52, 11, new DateTime(2025, 6, 9, 12, 6, 55, 874, DateTimeKind.Utc).AddTicks(9728), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Francisco Morazán", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 53, 11, new DateTime(2025, 6, 9, 12, 6, 55, 874, DateTimeKind.Utc).AddTicks(9730), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Cortés", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 54, 11, new DateTime(2025, 6, 9, 12, 6, 55, 874, DateTimeKind.Utc).AddTicks(9732), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Atlántida", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 55, 11, new DateTime(2025, 6, 9, 12, 6, 55, 874, DateTimeKind.Utc).AddTicks(9734), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Yoro", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 56, 12, new DateTime(2025, 6, 9, 12, 6, 55, 874, DateTimeKind.Utc).AddTicks(9736), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Ciudad de México", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 57, 12, new DateTime(2025, 6, 9, 12, 6, 55, 874, DateTimeKind.Utc).AddTicks(9738), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Jalisco", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 58, 12, new DateTime(2025, 6, 9, 12, 6, 55, 874, DateTimeKind.Utc).AddTicks(9740), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Nuevo León", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 59, 12, new DateTime(2025, 6, 9, 12, 6, 55, 874, DateTimeKind.Utc).AddTicks(9742), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Puebla", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 60, 13, new DateTime(2025, 6, 9, 12, 6, 55, 874, DateTimeKind.Utc).AddTicks(9744), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Managua", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 61, 13, new DateTime(2025, 6, 9, 12, 6, 55, 874, DateTimeKind.Utc).AddTicks(9746), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "León", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 62, 13, new DateTime(2025, 6, 9, 12, 6, 55, 874, DateTimeKind.Utc).AddTicks(9748), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Matagalpa", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 63, 13, new DateTime(2025, 6, 9, 12, 6, 55, 874, DateTimeKind.Utc).AddTicks(9750), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Chinandega", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 64, 14, new DateTime(2025, 6, 9, 12, 6, 55, 874, DateTimeKind.Utc).AddTicks(9752), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Panamá", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 65, 14, new DateTime(2025, 6, 9, 12, 6, 55, 874, DateTimeKind.Utc).AddTicks(9754), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Colón", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 66, 14, new DateTime(2025, 6, 9, 12, 6, 55, 874, DateTimeKind.Utc).AddTicks(9882), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Chiriquí", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 67, 14, new DateTime(2025, 6, 9, 12, 6, 55, 874, DateTimeKind.Utc).AddTicks(9884), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Veraguas", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 68, 15, new DateTime(2025, 6, 9, 12, 6, 55, 874, DateTimeKind.Utc).AddTicks(9887), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Asunción", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 69, 15, new DateTime(2025, 6, 9, 12, 6, 55, 874, DateTimeKind.Utc).AddTicks(9889), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Central", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 70, 15, new DateTime(2025, 6, 9, 12, 6, 55, 874, DateTimeKind.Utc).AddTicks(9891), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Alto Paraná", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 71, 15, new DateTime(2025, 6, 9, 12, 6, 55, 874, DateTimeKind.Utc).AddTicks(9893), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Itapúa", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 72, 16, new DateTime(2025, 6, 9, 12, 6, 55, 874, DateTimeKind.Utc).AddTicks(9895), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Lima", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 73, 16, new DateTime(2025, 6, 9, 12, 6, 55, 874, DateTimeKind.Utc).AddTicks(9898), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Cusco", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 74, 16, new DateTime(2025, 6, 9, 12, 6, 55, 874, DateTimeKind.Utc).AddTicks(9900), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Arequipa", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 75, 16, new DateTime(2025, 6, 9, 12, 6, 55, 874, DateTimeKind.Utc).AddTicks(9902), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Piura", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 76, 17, new DateTime(2025, 6, 9, 12, 6, 55, 874, DateTimeKind.Utc).AddTicks(9904), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Santo Domingo", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 77, 17, new DateTime(2025, 6, 9, 12, 6, 55, 874, DateTimeKind.Utc).AddTicks(9906), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Santiago", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 78, 17, new DateTime(2025, 6, 9, 12, 6, 55, 874, DateTimeKind.Utc).AddTicks(9908), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "La Vega", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 79, 17, new DateTime(2025, 6, 9, 12, 6, 55, 874, DateTimeKind.Utc).AddTicks(9910), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "San Cristóbal", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 80, 18, new DateTime(2025, 6, 9, 12, 6, 55, 874, DateTimeKind.Utc).AddTicks(9912), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Montevideo", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 81, 18, new DateTime(2025, 6, 9, 12, 6, 55, 874, DateTimeKind.Utc).AddTicks(9914), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Canelones", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 82, 18, new DateTime(2025, 6, 9, 12, 6, 55, 874, DateTimeKind.Utc).AddTicks(9916), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Maldonado", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 83, 18, new DateTime(2025, 6, 9, 12, 6, 55, 874, DateTimeKind.Utc).AddTicks(9918), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Colonia", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 84, 19, new DateTime(2025, 6, 9, 12, 6, 55, 874, DateTimeKind.Utc).AddTicks(9920), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Distrito Capital", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 85, 19, new DateTime(2025, 6, 9, 12, 6, 55, 874, DateTimeKind.Utc).AddTicks(9922), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Zulia", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 86, 19, new DateTime(2025, 6, 9, 12, 6, 55, 874, DateTimeKind.Utc).AddTicks(9924), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Carabobo", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 87, 19, new DateTime(2025, 6, 9, 12, 6, 55, 874, DateTimeKind.Utc).AddTicks(9926), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Lara", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_autopart_BrandId",
                table: "autopart",
                column: "BrandId");

            migrationBuilder.CreateIndex(
                name: "IX_autopart_CategoryId",
                table: "autopart",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_autopart_asset_AutopartId",
                table: "autopart_asset",
                column: "AutopartId");

            migrationBuilder.CreateIndex(
                name: "IX_autopart_info_AutopartId",
                table: "autopart_info",
                column: "AutopartId");

            migrationBuilder.CreateIndex(
                name: "IX_autopart_info_TypeId",
                table: "autopart_info",
                column: "TypeId");

            migrationBuilder.CreateIndex(
                name: "IX_autopart_of_seller_AutopartId",
                table: "autopart_of_seller",
                column: "AutopartId");

            migrationBuilder.CreateIndex(
                name: "IX_autopart_of_seller_SellerId",
                table: "autopart_of_seller",
                column: "SellerId");

            migrationBuilder.CreateIndex(
                name: "IX_city_CountryId",
                table: "city",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_company_CountryId",
                table: "company",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_company_info_CompanyId",
                table: "company_info",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_sale_AutopartId",
                table: "sale",
                column: "AutopartId");

            migrationBuilder.CreateIndex(
                name: "IX_sale_SaleDetailId",
                table: "sale",
                column: "SaleDetailId");

            migrationBuilder.CreateIndex(
                name: "IX_sale_detail_CustomerId",
                table: "sale_detail",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_sale_detail_SellerId",
                table: "sale_detail",
                column: "SellerId");

            migrationBuilder.CreateIndex(
                name: "IX_seller_CompanyId",
                table: "seller",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_Tokens_UserId",
                table: "Tokens",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_user_info_CityId",
                table: "user_info",
                column: "CityId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "admin");

            migrationBuilder.DropTable(
                name: "autopart_asset");

            migrationBuilder.DropTable(
                name: "autopart_info");

            migrationBuilder.DropTable(
                name: "autopart_of_seller");

            migrationBuilder.DropTable(
                name: "company_info");

            migrationBuilder.DropTable(
                name: "sale");

            migrationBuilder.DropTable(
                name: "Tokens");

            migrationBuilder.DropTable(
                name: "user_info");

            migrationBuilder.DropTable(
                name: "autopart_type_info");

            migrationBuilder.DropTable(
                name: "autopart");

            migrationBuilder.DropTable(
                name: "sale_detail");

            migrationBuilder.DropTable(
                name: "city");

            migrationBuilder.DropTable(
                name: "autopart_brand");

            migrationBuilder.DropTable(
                name: "category");

            migrationBuilder.DropTable(
                name: "customer");

            migrationBuilder.DropTable(
                name: "seller");

            migrationBuilder.DropTable(
                name: "company");

            migrationBuilder.DropTable(
                name: "user");

            migrationBuilder.DropTable(
                name: "country");
        }
    }
}
