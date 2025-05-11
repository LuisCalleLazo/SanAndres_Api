using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace SanAndres_Api.Migrations
{
    /// <inheritdoc />
    public partial class Datacontext : Migration
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
                    table.PrimaryKey("PK_seller", x => x.Id);
                    table.ForeignKey(
                        name: "FK_seller_company_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "company",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
