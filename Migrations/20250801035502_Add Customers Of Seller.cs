using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace SanAndres_Api.Migrations
{
    /// <inheritdoc />
    public partial class AddCustomersOfSeller : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CustomerOfSellers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Phone = table.Column<string>(type: "text", nullable: true),
                    Email = table.Column<string>(type: "text", nullable: true),
                    SellerId = table.Column<int>(type: "integer", nullable: false),
                    CreateAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdateAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    DeleteAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    CreateUserId = table.Column<int>(type: "integer", nullable: false),
                    UpdateUserId = table.Column<int>(type: "integer", nullable: false),
                    DeleteUserId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerOfSellers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CustomerOfSellers_seller_SellerId",
                        column: x => x.SellerId,
                        principalTable: "seller",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 3, 55, 2, 640, DateTimeKind.Utc).AddTicks(239));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 3, 55, 2, 640, DateTimeKind.Utc).AddTicks(244));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 3, 55, 2, 640, DateTimeKind.Utc).AddTicks(245));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 3, 55, 2, 640, DateTimeKind.Utc).AddTicks(246));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 3, 55, 2, 640, DateTimeKind.Utc).AddTicks(247));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 3, 55, 2, 640, DateTimeKind.Utc).AddTicks(249));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 3, 55, 2, 640, DateTimeKind.Utc).AddTicks(250));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 3, 55, 2, 640, DateTimeKind.Utc).AddTicks(251));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 3, 55, 2, 640, DateTimeKind.Utc).AddTicks(252));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 3, 55, 2, 640, DateTimeKind.Utc).AddTicks(253));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 3, 55, 2, 640, DateTimeKind.Utc).AddTicks(254));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 3, 55, 2, 640, DateTimeKind.Utc).AddTicks(254));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 3, 55, 2, 640, DateTimeKind.Utc).AddTicks(255));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 3, 55, 2, 640, DateTimeKind.Utc).AddTicks(256));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 3, 55, 2, 640, DateTimeKind.Utc).AddTicks(256));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 3, 55, 2, 640, DateTimeKind.Utc).AddTicks(257));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 3, 55, 2, 640, DateTimeKind.Utc).AddTicks(258));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 3, 55, 2, 640, DateTimeKind.Utc).AddTicks(285));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 3, 55, 2, 640, DateTimeKind.Utc).AddTicks(286));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 3, 55, 2, 640, DateTimeKind.Utc).AddTicks(287));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 3, 55, 2, 640, DateTimeKind.Utc).AddTicks(287));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 3, 55, 2, 640, DateTimeKind.Utc).AddTicks(288));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 3, 55, 2, 640, DateTimeKind.Utc).AddTicks(289));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 3, 55, 2, 640, DateTimeKind.Utc).AddTicks(290));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 3, 55, 2, 640, DateTimeKind.Utc).AddTicks(290));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 3, 55, 2, 640, DateTimeKind.Utc).AddTicks(291));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 3, 55, 2, 640, DateTimeKind.Utc).AddTicks(292));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 3, 55, 2, 640, DateTimeKind.Utc).AddTicks(292));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 3, 55, 2, 640, DateTimeKind.Utc).AddTicks(293));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 3, 55, 2, 640, DateTimeKind.Utc).AddTicks(294));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 3, 55, 2, 640, DateTimeKind.Utc).AddTicks(294));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 3, 55, 2, 640, DateTimeKind.Utc).AddTicks(295));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 3, 55, 2, 640, DateTimeKind.Utc).AddTicks(296));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 3, 55, 2, 640, DateTimeKind.Utc).AddTicks(297));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 3, 55, 2, 640, DateTimeKind.Utc).AddTicks(298));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 3, 55, 2, 640, DateTimeKind.Utc).AddTicks(298));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 3, 55, 2, 640, DateTimeKind.Utc).AddTicks(299));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 3, 55, 2, 640, DateTimeKind.Utc).AddTicks(300));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 3, 55, 2, 640, DateTimeKind.Utc).AddTicks(300));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 3, 55, 2, 640, DateTimeKind.Utc).AddTicks(303));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 3, 55, 2, 640, DateTimeKind.Utc).AddTicks(304));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 3, 55, 2, 640, DateTimeKind.Utc).AddTicks(304));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 3, 55, 2, 640, DateTimeKind.Utc).AddTicks(305));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 3, 55, 2, 640, DateTimeKind.Utc).AddTicks(305));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 3, 55, 2, 640, DateTimeKind.Utc).AddTicks(306));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 3, 55, 2, 640, DateTimeKind.Utc).AddTicks(307));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 3, 55, 2, 640, DateTimeKind.Utc).AddTicks(307));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 3, 55, 2, 640, DateTimeKind.Utc).AddTicks(308));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 3, 55, 2, 640, DateTimeKind.Utc).AddTicks(309));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 3, 55, 2, 640, DateTimeKind.Utc).AddTicks(309));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 3, 55, 2, 640, DateTimeKind.Utc).AddTicks(310));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 3, 55, 2, 640, DateTimeKind.Utc).AddTicks(311));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 3, 55, 2, 640, DateTimeKind.Utc).AddTicks(311));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 3, 55, 2, 640, DateTimeKind.Utc).AddTicks(312));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 3, 55, 2, 640, DateTimeKind.Utc).AddTicks(313));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 3, 55, 2, 640, DateTimeKind.Utc).AddTicks(313));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 3, 55, 2, 640, DateTimeKind.Utc).AddTicks(314));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 3, 55, 2, 640, DateTimeKind.Utc).AddTicks(315));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 3, 55, 2, 640, DateTimeKind.Utc).AddTicks(315));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 3, 55, 2, 640, DateTimeKind.Utc).AddTicks(316));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 3, 55, 2, 640, DateTimeKind.Utc).AddTicks(317));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 3, 55, 2, 640, DateTimeKind.Utc).AddTicks(317));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 3, 55, 2, 640, DateTimeKind.Utc).AddTicks(318));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 3, 55, 2, 640, DateTimeKind.Utc).AddTicks(318));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 3, 55, 2, 640, DateTimeKind.Utc).AddTicks(319));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 3, 55, 2, 640, DateTimeKind.Utc).AddTicks(320));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 3, 55, 2, 640, DateTimeKind.Utc).AddTicks(321));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 3, 55, 2, 640, DateTimeKind.Utc).AddTicks(322));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 3, 55, 2, 640, DateTimeKind.Utc).AddTicks(322));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 3, 55, 2, 640, DateTimeKind.Utc).AddTicks(323));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 3, 55, 2, 640, DateTimeKind.Utc).AddTicks(324));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 3, 55, 2, 640, DateTimeKind.Utc).AddTicks(324));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 3, 55, 2, 640, DateTimeKind.Utc).AddTicks(325));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 3, 55, 2, 640, DateTimeKind.Utc).AddTicks(326));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 3, 55, 2, 640, DateTimeKind.Utc).AddTicks(326));

            migrationBuilder.UpdateData(
                table: "autopart_type_info",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 3, 55, 2, 640, DateTimeKind.Utc).AddTicks(3830));

            migrationBuilder.UpdateData(
                table: "autopart_type_info",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 3, 55, 2, 640, DateTimeKind.Utc).AddTicks(3834));

            migrationBuilder.UpdateData(
                table: "autopart_type_info",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 3, 55, 2, 640, DateTimeKind.Utc).AddTicks(3835));

            migrationBuilder.UpdateData(
                table: "autopart_type_info",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 3, 55, 2, 640, DateTimeKind.Utc).AddTicks(3836));

            migrationBuilder.UpdateData(
                table: "autopart_type_info",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 3, 55, 2, 640, DateTimeKind.Utc).AddTicks(3837));

            migrationBuilder.UpdateData(
                table: "autopart_type_info",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 3, 55, 2, 640, DateTimeKind.Utc).AddTicks(3839));

            migrationBuilder.UpdateData(
                table: "autopart_type_info",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 3, 55, 2, 640, DateTimeKind.Utc).AddTicks(3840));

            migrationBuilder.UpdateData(
                table: "autopart_type_info",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 3, 55, 2, 640, DateTimeKind.Utc).AddTicks(3840));

            migrationBuilder.UpdateData(
                table: "autopart_type_info",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 3, 55, 2, 640, DateTimeKind.Utc).AddTicks(3841));

            migrationBuilder.UpdateData(
                table: "autopart_type_info",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 3, 55, 2, 640, DateTimeKind.Utc).AddTicks(3842));

            migrationBuilder.UpdateData(
                table: "autopart_type_info",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 3, 55, 2, 640, DateTimeKind.Utc).AddTicks(3843));

            migrationBuilder.UpdateData(
                table: "autopart_type_info",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 3, 55, 2, 640, DateTimeKind.Utc).AddTicks(3844));

            migrationBuilder.UpdateData(
                table: "autopart_type_info",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 3, 55, 2, 640, DateTimeKind.Utc).AddTicks(3844));

            migrationBuilder.UpdateData(
                table: "autopart_type_info",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 3, 55, 2, 640, DateTimeKind.Utc).AddTicks(3845));

            migrationBuilder.UpdateData(
                table: "category",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 3, 55, 2, 639, DateTimeKind.Utc).AddTicks(6985));

            migrationBuilder.UpdateData(
                table: "category",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 3, 55, 2, 639, DateTimeKind.Utc).AddTicks(6989));

            migrationBuilder.UpdateData(
                table: "category",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 3, 55, 2, 639, DateTimeKind.Utc).AddTicks(6990));

            migrationBuilder.UpdateData(
                table: "category",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 3, 55, 2, 639, DateTimeKind.Utc).AddTicks(6991));

            migrationBuilder.UpdateData(
                table: "category",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 3, 55, 2, 639, DateTimeKind.Utc).AddTicks(6992));

            migrationBuilder.UpdateData(
                table: "category",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 3, 55, 2, 639, DateTimeKind.Utc).AddTicks(6994));

            migrationBuilder.UpdateData(
                table: "category",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 3, 55, 2, 639, DateTimeKind.Utc).AddTicks(6994));

            migrationBuilder.UpdateData(
                table: "category",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 3, 55, 2, 639, DateTimeKind.Utc).AddTicks(6995));

            migrationBuilder.UpdateData(
                table: "category",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 3, 55, 2, 639, DateTimeKind.Utc).AddTicks(6996));

            migrationBuilder.UpdateData(
                table: "category",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 3, 55, 2, 639, DateTimeKind.Utc).AddTicks(6997));

            migrationBuilder.UpdateData(
                table: "category",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 3, 55, 2, 639, DateTimeKind.Utc).AddTicks(6998));

            migrationBuilder.UpdateData(
                table: "category",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 3, 55, 2, 639, DateTimeKind.Utc).AddTicks(6998));

            migrationBuilder.UpdateData(
                table: "category",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 3, 55, 2, 639, DateTimeKind.Utc).AddTicks(6999));

            migrationBuilder.UpdateData(
                table: "category",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 3, 55, 2, 639, DateTimeKind.Utc).AddTicks(7000));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 3, 55, 2, 639, DateTimeKind.Utc).AddTicks(3569));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 3, 55, 2, 639, DateTimeKind.Utc).AddTicks(3573));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 3, 55, 2, 639, DateTimeKind.Utc).AddTicks(3574));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 3, 55, 2, 639, DateTimeKind.Utc).AddTicks(3575));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 3, 55, 2, 639, DateTimeKind.Utc).AddTicks(3576));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 3, 55, 2, 639, DateTimeKind.Utc).AddTicks(3578));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 3, 55, 2, 639, DateTimeKind.Utc).AddTicks(3579));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 3, 55, 2, 639, DateTimeKind.Utc).AddTicks(3579));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 3, 55, 2, 639, DateTimeKind.Utc).AddTicks(3580));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 3, 55, 2, 639, DateTimeKind.Utc).AddTicks(3582));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 3, 55, 2, 639, DateTimeKind.Utc).AddTicks(3583));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 3, 55, 2, 639, DateTimeKind.Utc).AddTicks(3583));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 3, 55, 2, 639, DateTimeKind.Utc).AddTicks(3584));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 3, 55, 2, 639, DateTimeKind.Utc).AddTicks(3585));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 3, 55, 2, 639, DateTimeKind.Utc).AddTicks(3586));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 3, 55, 2, 639, DateTimeKind.Utc).AddTicks(3586));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 3, 55, 2, 639, DateTimeKind.Utc).AddTicks(3587));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 3, 55, 2, 639, DateTimeKind.Utc).AddTicks(3588));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 3, 55, 2, 639, DateTimeKind.Utc).AddTicks(3589));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 3, 55, 2, 639, DateTimeKind.Utc).AddTicks(3590));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 3, 55, 2, 639, DateTimeKind.Utc).AddTicks(3590));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 3, 55, 2, 639, DateTimeKind.Utc).AddTicks(3591));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 3, 55, 2, 639, DateTimeKind.Utc).AddTicks(3592));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 3, 55, 2, 639, DateTimeKind.Utc).AddTicks(3592));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 3, 55, 2, 639, DateTimeKind.Utc).AddTicks(3593));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 3, 55, 2, 639, DateTimeKind.Utc).AddTicks(3594));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 3, 55, 2, 639, DateTimeKind.Utc).AddTicks(3594));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 3, 55, 2, 639, DateTimeKind.Utc).AddTicks(3595));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 3, 55, 2, 639, DateTimeKind.Utc).AddTicks(3596));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 3, 55, 2, 639, DateTimeKind.Utc).AddTicks(3596));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 3, 55, 2, 639, DateTimeKind.Utc).AddTicks(3597));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 3, 55, 2, 639, DateTimeKind.Utc).AddTicks(3598));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 3, 55, 2, 639, DateTimeKind.Utc).AddTicks(3598));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 3, 55, 2, 639, DateTimeKind.Utc).AddTicks(3600));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 3, 55, 2, 639, DateTimeKind.Utc).AddTicks(3600));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 3, 55, 2, 639, DateTimeKind.Utc).AddTicks(3601));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 3, 55, 2, 639, DateTimeKind.Utc).AddTicks(3602));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 3, 55, 2, 639, DateTimeKind.Utc).AddTicks(3602));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 3, 55, 2, 639, DateTimeKind.Utc).AddTicks(3603));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 3, 55, 2, 639, DateTimeKind.Utc).AddTicks(3603));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 3, 55, 2, 639, DateTimeKind.Utc).AddTicks(3604));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 3, 55, 2, 639, DateTimeKind.Utc).AddTicks(3606));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 3, 55, 2, 639, DateTimeKind.Utc).AddTicks(3606));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 3, 55, 2, 639, DateTimeKind.Utc).AddTicks(3621));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 3, 55, 2, 639, DateTimeKind.Utc).AddTicks(3621));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 3, 55, 2, 639, DateTimeKind.Utc).AddTicks(3622));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 3, 55, 2, 639, DateTimeKind.Utc).AddTicks(3623));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 3, 55, 2, 639, DateTimeKind.Utc).AddTicks(3624));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 3, 55, 2, 639, DateTimeKind.Utc).AddTicks(3624));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 3, 55, 2, 639, DateTimeKind.Utc).AddTicks(3625));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 3, 55, 2, 639, DateTimeKind.Utc).AddTicks(3626));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 3, 55, 2, 639, DateTimeKind.Utc).AddTicks(3626));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 3, 55, 2, 639, DateTimeKind.Utc).AddTicks(3627));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 3, 55, 2, 639, DateTimeKind.Utc).AddTicks(3627));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 3, 55, 2, 639, DateTimeKind.Utc).AddTicks(3628));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 3, 55, 2, 639, DateTimeKind.Utc).AddTicks(3629));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 3, 55, 2, 639, DateTimeKind.Utc).AddTicks(3629));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 3, 55, 2, 639, DateTimeKind.Utc).AddTicks(3630));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 3, 55, 2, 639, DateTimeKind.Utc).AddTicks(3631));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 3, 55, 2, 639, DateTimeKind.Utc).AddTicks(3631));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 3, 55, 2, 639, DateTimeKind.Utc).AddTicks(3632));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 3, 55, 2, 639, DateTimeKind.Utc).AddTicks(3633));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 3, 55, 2, 639, DateTimeKind.Utc).AddTicks(3633));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 3, 55, 2, 639, DateTimeKind.Utc).AddTicks(3634));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 3, 55, 2, 639, DateTimeKind.Utc).AddTicks(3635));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 3, 55, 2, 639, DateTimeKind.Utc).AddTicks(3636));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 3, 55, 2, 639, DateTimeKind.Utc).AddTicks(3637));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 3, 55, 2, 639, DateTimeKind.Utc).AddTicks(3637));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 3, 55, 2, 639, DateTimeKind.Utc).AddTicks(3638));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 3, 55, 2, 639, DateTimeKind.Utc).AddTicks(3639));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 3, 55, 2, 639, DateTimeKind.Utc).AddTicks(3639));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 3, 55, 2, 639, DateTimeKind.Utc).AddTicks(3640));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 3, 55, 2, 639, DateTimeKind.Utc).AddTicks(3641));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 3, 55, 2, 639, DateTimeKind.Utc).AddTicks(3641));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 3, 55, 2, 639, DateTimeKind.Utc).AddTicks(3642));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 76,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 3, 55, 2, 639, DateTimeKind.Utc).AddTicks(3643));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 77,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 3, 55, 2, 639, DateTimeKind.Utc).AddTicks(3643));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 78,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 3, 55, 2, 639, DateTimeKind.Utc).AddTicks(3644));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 79,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 3, 55, 2, 639, DateTimeKind.Utc).AddTicks(3645));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 80,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 3, 55, 2, 639, DateTimeKind.Utc).AddTicks(3645));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 81,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 3, 55, 2, 639, DateTimeKind.Utc).AddTicks(3646));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 82,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 3, 55, 2, 639, DateTimeKind.Utc).AddTicks(3646));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 83,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 3, 55, 2, 639, DateTimeKind.Utc).AddTicks(3647));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 84,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 3, 55, 2, 639, DateTimeKind.Utc).AddTicks(3648));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 85,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 3, 55, 2, 639, DateTimeKind.Utc).AddTicks(3648));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 86,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 3, 55, 2, 639, DateTimeKind.Utc).AddTicks(3649));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 87,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 3, 55, 2, 639, DateTimeKind.Utc).AddTicks(3650));

            migrationBuilder.UpdateData(
                table: "country",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 3, 55, 2, 639, DateTimeKind.Utc).AddTicks(3870));

            migrationBuilder.UpdateData(
                table: "country",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 3, 55, 2, 639, DateTimeKind.Utc).AddTicks(3873));

            migrationBuilder.UpdateData(
                table: "country",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 3, 55, 2, 639, DateTimeKind.Utc).AddTicks(3875));

            migrationBuilder.UpdateData(
                table: "country",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 3, 55, 2, 639, DateTimeKind.Utc).AddTicks(3876));

            migrationBuilder.UpdateData(
                table: "country",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 3, 55, 2, 639, DateTimeKind.Utc).AddTicks(3877));

            migrationBuilder.UpdateData(
                table: "country",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 3, 55, 2, 639, DateTimeKind.Utc).AddTicks(3878));

            migrationBuilder.UpdateData(
                table: "country",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 3, 55, 2, 639, DateTimeKind.Utc).AddTicks(3879));

            migrationBuilder.UpdateData(
                table: "country",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 3, 55, 2, 639, DateTimeKind.Utc).AddTicks(3880));

            migrationBuilder.UpdateData(
                table: "country",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 3, 55, 2, 639, DateTimeKind.Utc).AddTicks(3881));

            migrationBuilder.UpdateData(
                table: "country",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 3, 55, 2, 639, DateTimeKind.Utc).AddTicks(3882));

            migrationBuilder.UpdateData(
                table: "country",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 3, 55, 2, 639, DateTimeKind.Utc).AddTicks(3883));

            migrationBuilder.UpdateData(
                table: "country",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 3, 55, 2, 639, DateTimeKind.Utc).AddTicks(3884));

            migrationBuilder.UpdateData(
                table: "country",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 3, 55, 2, 639, DateTimeKind.Utc).AddTicks(3885));

            migrationBuilder.UpdateData(
                table: "country",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 3, 55, 2, 639, DateTimeKind.Utc).AddTicks(3886));

            migrationBuilder.UpdateData(
                table: "country",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 3, 55, 2, 639, DateTimeKind.Utc).AddTicks(3886));

            migrationBuilder.UpdateData(
                table: "country",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 3, 55, 2, 639, DateTimeKind.Utc).AddTicks(3887));

            migrationBuilder.UpdateData(
                table: "country",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 3, 55, 2, 639, DateTimeKind.Utc).AddTicks(3888));

            migrationBuilder.UpdateData(
                table: "country",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 3, 55, 2, 639, DateTimeKind.Utc).AddTicks(3889));

            migrationBuilder.UpdateData(
                table: "country",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 3, 55, 2, 639, DateTimeKind.Utc).AddTicks(3890));

            migrationBuilder.CreateIndex(
                name: "IX_CustomerOfSellers_SellerId",
                table: "CustomerOfSellers",
                column: "SellerId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CustomerOfSellers");

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 2, 51, 1, 322, DateTimeKind.Utc).AddTicks(4726));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 2, 51, 1, 322, DateTimeKind.Utc).AddTicks(4730));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 2, 51, 1, 322, DateTimeKind.Utc).AddTicks(4731));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 2, 51, 1, 322, DateTimeKind.Utc).AddTicks(4732));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 2, 51, 1, 322, DateTimeKind.Utc).AddTicks(4733));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 2, 51, 1, 322, DateTimeKind.Utc).AddTicks(4735));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 2, 51, 1, 322, DateTimeKind.Utc).AddTicks(4736));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 2, 51, 1, 322, DateTimeKind.Utc).AddTicks(4736));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 2, 51, 1, 322, DateTimeKind.Utc).AddTicks(4737));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 2, 51, 1, 322, DateTimeKind.Utc).AddTicks(4739));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 2, 51, 1, 322, DateTimeKind.Utc).AddTicks(4739));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 2, 51, 1, 322, DateTimeKind.Utc).AddTicks(4740));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 2, 51, 1, 322, DateTimeKind.Utc).AddTicks(4741));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 2, 51, 1, 322, DateTimeKind.Utc).AddTicks(4741));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 2, 51, 1, 322, DateTimeKind.Utc).AddTicks(4742));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 2, 51, 1, 322, DateTimeKind.Utc).AddTicks(4742));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 2, 51, 1, 322, DateTimeKind.Utc).AddTicks(4743));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 2, 51, 1, 322, DateTimeKind.Utc).AddTicks(4744));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 2, 51, 1, 322, DateTimeKind.Utc).AddTicks(4745));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 2, 51, 1, 322, DateTimeKind.Utc).AddTicks(4746));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 2, 51, 1, 322, DateTimeKind.Utc).AddTicks(4746));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 2, 51, 1, 322, DateTimeKind.Utc).AddTicks(4748));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 2, 51, 1, 322, DateTimeKind.Utc).AddTicks(4749));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 2, 51, 1, 322, DateTimeKind.Utc).AddTicks(4749));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 2, 51, 1, 322, DateTimeKind.Utc).AddTicks(4750));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 2, 51, 1, 322, DateTimeKind.Utc).AddTicks(4751));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 2, 51, 1, 322, DateTimeKind.Utc).AddTicks(4751));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 2, 51, 1, 322, DateTimeKind.Utc).AddTicks(4752));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 2, 51, 1, 322, DateTimeKind.Utc).AddTicks(4753));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 2, 51, 1, 322, DateTimeKind.Utc).AddTicks(4753));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 2, 51, 1, 322, DateTimeKind.Utc).AddTicks(4754));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 2, 51, 1, 322, DateTimeKind.Utc).AddTicks(4755));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 2, 51, 1, 322, DateTimeKind.Utc).AddTicks(4755));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 2, 51, 1, 322, DateTimeKind.Utc).AddTicks(4757));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 2, 51, 1, 322, DateTimeKind.Utc).AddTicks(4758));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 2, 51, 1, 322, DateTimeKind.Utc).AddTicks(4758));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 2, 51, 1, 322, DateTimeKind.Utc).AddTicks(4759));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 2, 51, 1, 322, DateTimeKind.Utc).AddTicks(4760));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 2, 51, 1, 322, DateTimeKind.Utc).AddTicks(4760));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 2, 51, 1, 322, DateTimeKind.Utc).AddTicks(4761));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 2, 51, 1, 322, DateTimeKind.Utc).AddTicks(4761));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 2, 51, 1, 322, DateTimeKind.Utc).AddTicks(4762));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 2, 51, 1, 322, DateTimeKind.Utc).AddTicks(4763));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 2, 51, 1, 322, DateTimeKind.Utc).AddTicks(4763));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 2, 51, 1, 322, DateTimeKind.Utc).AddTicks(4764));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 2, 51, 1, 322, DateTimeKind.Utc).AddTicks(4813));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 2, 51, 1, 322, DateTimeKind.Utc).AddTicks(4814));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 2, 51, 1, 322, DateTimeKind.Utc).AddTicks(4815));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 2, 51, 1, 322, DateTimeKind.Utc).AddTicks(4816));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 2, 51, 1, 322, DateTimeKind.Utc).AddTicks(4816));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 2, 51, 1, 322, DateTimeKind.Utc).AddTicks(4817));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 2, 51, 1, 322, DateTimeKind.Utc).AddTicks(4818));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 2, 51, 1, 322, DateTimeKind.Utc).AddTicks(4818));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 2, 51, 1, 322, DateTimeKind.Utc).AddTicks(4819));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 2, 51, 1, 322, DateTimeKind.Utc).AddTicks(4820));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 2, 51, 1, 322, DateTimeKind.Utc).AddTicks(4820));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 2, 51, 1, 322, DateTimeKind.Utc).AddTicks(4821));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 2, 51, 1, 322, DateTimeKind.Utc).AddTicks(4822));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 2, 51, 1, 322, DateTimeKind.Utc).AddTicks(4822));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 2, 51, 1, 322, DateTimeKind.Utc).AddTicks(4823));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 2, 51, 1, 322, DateTimeKind.Utc).AddTicks(4823));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 2, 51, 1, 322, DateTimeKind.Utc).AddTicks(4824));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 2, 51, 1, 322, DateTimeKind.Utc).AddTicks(4825));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 2, 51, 1, 322, DateTimeKind.Utc).AddTicks(4825));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 2, 51, 1, 322, DateTimeKind.Utc).AddTicks(4826));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 2, 51, 1, 322, DateTimeKind.Utc).AddTicks(4827));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 2, 51, 1, 322, DateTimeKind.Utc).AddTicks(4828));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 2, 51, 1, 322, DateTimeKind.Utc).AddTicks(4829));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 2, 51, 1, 322, DateTimeKind.Utc).AddTicks(4829));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 2, 51, 1, 322, DateTimeKind.Utc).AddTicks(4830));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 2, 51, 1, 322, DateTimeKind.Utc).AddTicks(4830));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 2, 51, 1, 322, DateTimeKind.Utc).AddTicks(4831));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 2, 51, 1, 322, DateTimeKind.Utc).AddTicks(4832));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 2, 51, 1, 322, DateTimeKind.Utc).AddTicks(4832));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 2, 51, 1, 322, DateTimeKind.Utc).AddTicks(4833));

            migrationBuilder.UpdateData(
                table: "autopart_type_info",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 2, 51, 1, 322, DateTimeKind.Utc).AddTicks(8247));

            migrationBuilder.UpdateData(
                table: "autopart_type_info",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 2, 51, 1, 322, DateTimeKind.Utc).AddTicks(8252));

            migrationBuilder.UpdateData(
                table: "autopart_type_info",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 2, 51, 1, 322, DateTimeKind.Utc).AddTicks(8253));

            migrationBuilder.UpdateData(
                table: "autopart_type_info",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 2, 51, 1, 322, DateTimeKind.Utc).AddTicks(8253));

            migrationBuilder.UpdateData(
                table: "autopart_type_info",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 2, 51, 1, 322, DateTimeKind.Utc).AddTicks(8276));

            migrationBuilder.UpdateData(
                table: "autopart_type_info",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 2, 51, 1, 322, DateTimeKind.Utc).AddTicks(8277));

            migrationBuilder.UpdateData(
                table: "autopart_type_info",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 2, 51, 1, 322, DateTimeKind.Utc).AddTicks(8278));

            migrationBuilder.UpdateData(
                table: "autopart_type_info",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 2, 51, 1, 322, DateTimeKind.Utc).AddTicks(8279));

            migrationBuilder.UpdateData(
                table: "autopart_type_info",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 2, 51, 1, 322, DateTimeKind.Utc).AddTicks(8279));

            migrationBuilder.UpdateData(
                table: "autopart_type_info",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 2, 51, 1, 322, DateTimeKind.Utc).AddTicks(8281));

            migrationBuilder.UpdateData(
                table: "autopart_type_info",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 2, 51, 1, 322, DateTimeKind.Utc).AddTicks(8282));

            migrationBuilder.UpdateData(
                table: "autopart_type_info",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 2, 51, 1, 322, DateTimeKind.Utc).AddTicks(8282));

            migrationBuilder.UpdateData(
                table: "autopart_type_info",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 2, 51, 1, 322, DateTimeKind.Utc).AddTicks(8283));

            migrationBuilder.UpdateData(
                table: "autopart_type_info",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 2, 51, 1, 322, DateTimeKind.Utc).AddTicks(8284));

            migrationBuilder.UpdateData(
                table: "category",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 2, 51, 1, 322, DateTimeKind.Utc).AddTicks(1694));

            migrationBuilder.UpdateData(
                table: "category",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 2, 51, 1, 322, DateTimeKind.Utc).AddTicks(1697));

            migrationBuilder.UpdateData(
                table: "category",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 2, 51, 1, 322, DateTimeKind.Utc).AddTicks(1698));

            migrationBuilder.UpdateData(
                table: "category",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 2, 51, 1, 322, DateTimeKind.Utc).AddTicks(1699));

            migrationBuilder.UpdateData(
                table: "category",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 2, 51, 1, 322, DateTimeKind.Utc).AddTicks(1700));

            migrationBuilder.UpdateData(
                table: "category",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 2, 51, 1, 322, DateTimeKind.Utc).AddTicks(1724));

            migrationBuilder.UpdateData(
                table: "category",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 2, 51, 1, 322, DateTimeKind.Utc).AddTicks(1725));

            migrationBuilder.UpdateData(
                table: "category",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 2, 51, 1, 322, DateTimeKind.Utc).AddTicks(1726));

            migrationBuilder.UpdateData(
                table: "category",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 2, 51, 1, 322, DateTimeKind.Utc).AddTicks(1727));

            migrationBuilder.UpdateData(
                table: "category",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 2, 51, 1, 322, DateTimeKind.Utc).AddTicks(1728));

            migrationBuilder.UpdateData(
                table: "category",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 2, 51, 1, 322, DateTimeKind.Utc).AddTicks(1729));

            migrationBuilder.UpdateData(
                table: "category",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 2, 51, 1, 322, DateTimeKind.Utc).AddTicks(1730));

            migrationBuilder.UpdateData(
                table: "category",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 2, 51, 1, 322, DateTimeKind.Utc).AddTicks(1730));

            migrationBuilder.UpdateData(
                table: "category",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 2, 51, 1, 322, DateTimeKind.Utc).AddTicks(1731));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 2, 51, 1, 321, DateTimeKind.Utc).AddTicks(8208));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 2, 51, 1, 321, DateTimeKind.Utc).AddTicks(8214));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 2, 51, 1, 321, DateTimeKind.Utc).AddTicks(8215));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 2, 51, 1, 321, DateTimeKind.Utc).AddTicks(8216));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 2, 51, 1, 321, DateTimeKind.Utc).AddTicks(8217));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 2, 51, 1, 321, DateTimeKind.Utc).AddTicks(8219));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 2, 51, 1, 321, DateTimeKind.Utc).AddTicks(8219));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 2, 51, 1, 321, DateTimeKind.Utc).AddTicks(8220));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 2, 51, 1, 321, DateTimeKind.Utc).AddTicks(8221));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 2, 51, 1, 321, DateTimeKind.Utc).AddTicks(8222));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 2, 51, 1, 321, DateTimeKind.Utc).AddTicks(8223));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 2, 51, 1, 321, DateTimeKind.Utc).AddTicks(8224));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 2, 51, 1, 321, DateTimeKind.Utc).AddTicks(8224));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 2, 51, 1, 321, DateTimeKind.Utc).AddTicks(8225));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 2, 51, 1, 321, DateTimeKind.Utc).AddTicks(8226));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 2, 51, 1, 321, DateTimeKind.Utc).AddTicks(8226));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 2, 51, 1, 321, DateTimeKind.Utc).AddTicks(8227));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 2, 51, 1, 321, DateTimeKind.Utc).AddTicks(8228));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 2, 51, 1, 321, DateTimeKind.Utc).AddTicks(8229));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 2, 51, 1, 321, DateTimeKind.Utc).AddTicks(8230));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 2, 51, 1, 321, DateTimeKind.Utc).AddTicks(8230));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 2, 51, 1, 321, DateTimeKind.Utc).AddTicks(8231));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 2, 51, 1, 321, DateTimeKind.Utc).AddTicks(8232));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 2, 51, 1, 321, DateTimeKind.Utc).AddTicks(8233));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 2, 51, 1, 321, DateTimeKind.Utc).AddTicks(8234));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 2, 51, 1, 321, DateTimeKind.Utc).AddTicks(8234));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 2, 51, 1, 321, DateTimeKind.Utc).AddTicks(8235));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 2, 51, 1, 321, DateTimeKind.Utc).AddTicks(8236));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 2, 51, 1, 321, DateTimeKind.Utc).AddTicks(8236));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 2, 51, 1, 321, DateTimeKind.Utc).AddTicks(8237));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 2, 51, 1, 321, DateTimeKind.Utc).AddTicks(8238));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 2, 51, 1, 321, DateTimeKind.Utc).AddTicks(8238));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 2, 51, 1, 321, DateTimeKind.Utc).AddTicks(8239));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 2, 51, 1, 321, DateTimeKind.Utc).AddTicks(8240));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 2, 51, 1, 321, DateTimeKind.Utc).AddTicks(8241));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 2, 51, 1, 321, DateTimeKind.Utc).AddTicks(8242));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 2, 51, 1, 321, DateTimeKind.Utc).AddTicks(8242));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 2, 51, 1, 321, DateTimeKind.Utc).AddTicks(8243));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 2, 51, 1, 321, DateTimeKind.Utc).AddTicks(8244));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 2, 51, 1, 321, DateTimeKind.Utc).AddTicks(8244));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 2, 51, 1, 321, DateTimeKind.Utc).AddTicks(8245));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 2, 51, 1, 321, DateTimeKind.Utc).AddTicks(8246));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 2, 51, 1, 321, DateTimeKind.Utc).AddTicks(8246));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 2, 51, 1, 321, DateTimeKind.Utc).AddTicks(8247));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 2, 51, 1, 321, DateTimeKind.Utc).AddTicks(8248));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 2, 51, 1, 321, DateTimeKind.Utc).AddTicks(8248));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 2, 51, 1, 321, DateTimeKind.Utc).AddTicks(8249));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 2, 51, 1, 321, DateTimeKind.Utc).AddTicks(8249));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 2, 51, 1, 321, DateTimeKind.Utc).AddTicks(8250));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 2, 51, 1, 321, DateTimeKind.Utc).AddTicks(8251));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 2, 51, 1, 321, DateTimeKind.Utc).AddTicks(8251));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 2, 51, 1, 321, DateTimeKind.Utc).AddTicks(8252));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 2, 51, 1, 321, DateTimeKind.Utc).AddTicks(8253));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 2, 51, 1, 321, DateTimeKind.Utc).AddTicks(8253));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 2, 51, 1, 321, DateTimeKind.Utc).AddTicks(8254));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 2, 51, 1, 321, DateTimeKind.Utc).AddTicks(8255));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 2, 51, 1, 321, DateTimeKind.Utc).AddTicks(8255));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 2, 51, 1, 321, DateTimeKind.Utc).AddTicks(8256));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 2, 51, 1, 321, DateTimeKind.Utc).AddTicks(8256));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 2, 51, 1, 321, DateTimeKind.Utc).AddTicks(8257));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 2, 51, 1, 321, DateTimeKind.Utc).AddTicks(8258));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 2, 51, 1, 321, DateTimeKind.Utc).AddTicks(8258));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 2, 51, 1, 321, DateTimeKind.Utc).AddTicks(8259));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 2, 51, 1, 321, DateTimeKind.Utc).AddTicks(8259));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 2, 51, 1, 321, DateTimeKind.Utc).AddTicks(8260));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 2, 51, 1, 321, DateTimeKind.Utc).AddTicks(8289));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 2, 51, 1, 321, DateTimeKind.Utc).AddTicks(8290));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 2, 51, 1, 321, DateTimeKind.Utc).AddTicks(8290));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 2, 51, 1, 321, DateTimeKind.Utc).AddTicks(8291));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 2, 51, 1, 321, DateTimeKind.Utc).AddTicks(8292));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 2, 51, 1, 321, DateTimeKind.Utc).AddTicks(8292));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 2, 51, 1, 321, DateTimeKind.Utc).AddTicks(8293));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 2, 51, 1, 321, DateTimeKind.Utc).AddTicks(8294));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 2, 51, 1, 321, DateTimeKind.Utc).AddTicks(8295));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 2, 51, 1, 321, DateTimeKind.Utc).AddTicks(8295));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 76,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 2, 51, 1, 321, DateTimeKind.Utc).AddTicks(8296));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 77,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 2, 51, 1, 321, DateTimeKind.Utc).AddTicks(8297));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 78,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 2, 51, 1, 321, DateTimeKind.Utc).AddTicks(8297));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 79,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 2, 51, 1, 321, DateTimeKind.Utc).AddTicks(8298));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 80,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 2, 51, 1, 321, DateTimeKind.Utc).AddTicks(8299));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 81,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 2, 51, 1, 321, DateTimeKind.Utc).AddTicks(8299));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 82,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 2, 51, 1, 321, DateTimeKind.Utc).AddTicks(8300));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 83,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 2, 51, 1, 321, DateTimeKind.Utc).AddTicks(8301));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 84,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 2, 51, 1, 321, DateTimeKind.Utc).AddTicks(8301));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 85,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 2, 51, 1, 321, DateTimeKind.Utc).AddTicks(8302));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 86,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 2, 51, 1, 321, DateTimeKind.Utc).AddTicks(8303));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 87,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 2, 51, 1, 321, DateTimeKind.Utc).AddTicks(8303));

            migrationBuilder.UpdateData(
                table: "country",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 2, 51, 1, 321, DateTimeKind.Utc).AddTicks(8458));

            migrationBuilder.UpdateData(
                table: "country",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 2, 51, 1, 321, DateTimeKind.Utc).AddTicks(8462));

            migrationBuilder.UpdateData(
                table: "country",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 2, 51, 1, 321, DateTimeKind.Utc).AddTicks(8463));

            migrationBuilder.UpdateData(
                table: "country",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 2, 51, 1, 321, DateTimeKind.Utc).AddTicks(8464));

            migrationBuilder.UpdateData(
                table: "country",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 2, 51, 1, 321, DateTimeKind.Utc).AddTicks(8464));

            migrationBuilder.UpdateData(
                table: "country",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 2, 51, 1, 321, DateTimeKind.Utc).AddTicks(8466));

            migrationBuilder.UpdateData(
                table: "country",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 2, 51, 1, 321, DateTimeKind.Utc).AddTicks(8467));

            migrationBuilder.UpdateData(
                table: "country",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 2, 51, 1, 321, DateTimeKind.Utc).AddTicks(8468));

            migrationBuilder.UpdateData(
                table: "country",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 2, 51, 1, 321, DateTimeKind.Utc).AddTicks(8468));

            migrationBuilder.UpdateData(
                table: "country",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 2, 51, 1, 321, DateTimeKind.Utc).AddTicks(8470));

            migrationBuilder.UpdateData(
                table: "country",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 2, 51, 1, 321, DateTimeKind.Utc).AddTicks(8471));

            migrationBuilder.UpdateData(
                table: "country",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 2, 51, 1, 321, DateTimeKind.Utc).AddTicks(8471));

            migrationBuilder.UpdateData(
                table: "country",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 2, 51, 1, 321, DateTimeKind.Utc).AddTicks(8472));

            migrationBuilder.UpdateData(
                table: "country",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 2, 51, 1, 321, DateTimeKind.Utc).AddTicks(8473));

            migrationBuilder.UpdateData(
                table: "country",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 2, 51, 1, 321, DateTimeKind.Utc).AddTicks(8474));

            migrationBuilder.UpdateData(
                table: "country",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 2, 51, 1, 321, DateTimeKind.Utc).AddTicks(8474));

            migrationBuilder.UpdateData(
                table: "country",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 2, 51, 1, 321, DateTimeKind.Utc).AddTicks(8475));

            migrationBuilder.UpdateData(
                table: "country",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 2, 51, 1, 321, DateTimeKind.Utc).AddTicks(8498));

            migrationBuilder.UpdateData(
                table: "country",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreateAt",
                value: new DateTime(2025, 8, 1, 2, 51, 1, 321, DateTimeKind.Utc).AddTicks(8499));
        }
    }
}
