using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SanAndres_Api.Migrations
{
    /// <inheritdoc />
    public partial class CustomerNullSale : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_sale_detail_customer_CustomerId",
                table: "sale_detail");

            migrationBuilder.AlterColumn<int>(
                name: "CustomerId",
                table: "sale_detail",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 19, 46, 59, 260, DateTimeKind.Utc).AddTicks(9902));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 19, 46, 59, 260, DateTimeKind.Utc).AddTicks(9908));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 19, 46, 59, 260, DateTimeKind.Utc).AddTicks(9909));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 19, 46, 59, 260, DateTimeKind.Utc).AddTicks(9910));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 19, 46, 59, 260, DateTimeKind.Utc).AddTicks(9911));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 19, 46, 59, 260, DateTimeKind.Utc).AddTicks(9913));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 19, 46, 59, 260, DateTimeKind.Utc).AddTicks(9913));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 19, 46, 59, 260, DateTimeKind.Utc).AddTicks(9914));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 19, 46, 59, 260, DateTimeKind.Utc).AddTicks(9915));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 19, 46, 59, 260, DateTimeKind.Utc).AddTicks(9916));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 19, 46, 59, 260, DateTimeKind.Utc).AddTicks(9917));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 19, 46, 59, 260, DateTimeKind.Utc).AddTicks(9918));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 19, 46, 59, 260, DateTimeKind.Utc).AddTicks(9918));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 19, 46, 59, 260, DateTimeKind.Utc).AddTicks(9919));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 19, 46, 59, 260, DateTimeKind.Utc).AddTicks(9920));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 19, 46, 59, 260, DateTimeKind.Utc).AddTicks(9920));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 19, 46, 59, 260, DateTimeKind.Utc).AddTicks(9921));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 19, 46, 59, 260, DateTimeKind.Utc).AddTicks(9922));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 19, 46, 59, 260, DateTimeKind.Utc).AddTicks(9923));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 19, 46, 59, 260, DateTimeKind.Utc).AddTicks(9924));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 19, 46, 59, 260, DateTimeKind.Utc).AddTicks(9924));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 19, 46, 59, 260, DateTimeKind.Utc).AddTicks(9925));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 19, 46, 59, 260, DateTimeKind.Utc).AddTicks(9926));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 19, 46, 59, 260, DateTimeKind.Utc).AddTicks(9926));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 19, 46, 59, 260, DateTimeKind.Utc).AddTicks(9927));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 19, 46, 59, 260, DateTimeKind.Utc).AddTicks(9928));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 19, 46, 59, 260, DateTimeKind.Utc).AddTicks(9928));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 19, 46, 59, 260, DateTimeKind.Utc).AddTicks(9929));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 19, 46, 59, 260, DateTimeKind.Utc).AddTicks(9930));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 19, 46, 59, 260, DateTimeKind.Utc).AddTicks(9930));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 19, 46, 59, 260, DateTimeKind.Utc).AddTicks(9931));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 19, 46, 59, 260, DateTimeKind.Utc).AddTicks(9932));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 19, 46, 59, 260, DateTimeKind.Utc).AddTicks(9932));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 19, 46, 59, 260, DateTimeKind.Utc).AddTicks(9934));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 19, 46, 59, 260, DateTimeKind.Utc).AddTicks(9934));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 19, 46, 59, 260, DateTimeKind.Utc).AddTicks(9936));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 19, 46, 59, 260, DateTimeKind.Utc).AddTicks(9937));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 19, 46, 59, 260, DateTimeKind.Utc).AddTicks(9937));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 19, 46, 59, 260, DateTimeKind.Utc).AddTicks(9938));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 19, 46, 59, 260, DateTimeKind.Utc).AddTicks(9939));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 19, 46, 59, 260, DateTimeKind.Utc).AddTicks(9939));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 19, 46, 59, 260, DateTimeKind.Utc).AddTicks(9940));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 19, 46, 59, 260, DateTimeKind.Utc).AddTicks(9941));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 19, 46, 59, 260, DateTimeKind.Utc).AddTicks(9941));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 19, 46, 59, 260, DateTimeKind.Utc).AddTicks(9942));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 19, 46, 59, 260, DateTimeKind.Utc).AddTicks(9942));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 19, 46, 59, 260, DateTimeKind.Utc).AddTicks(9943));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 19, 46, 59, 260, DateTimeKind.Utc).AddTicks(9944));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 19, 46, 59, 260, DateTimeKind.Utc).AddTicks(9944));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 19, 46, 59, 260, DateTimeKind.Utc).AddTicks(9945));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 19, 46, 59, 260, DateTimeKind.Utc).AddTicks(9946));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 19, 46, 59, 260, DateTimeKind.Utc).AddTicks(9946));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 19, 46, 59, 260, DateTimeKind.Utc).AddTicks(9947));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 19, 46, 59, 260, DateTimeKind.Utc).AddTicks(9948));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 19, 46, 59, 260, DateTimeKind.Utc).AddTicks(9948));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 19, 46, 59, 260, DateTimeKind.Utc).AddTicks(9971));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 19, 46, 59, 260, DateTimeKind.Utc).AddTicks(9972));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 19, 46, 59, 260, DateTimeKind.Utc).AddTicks(9973));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 19, 46, 59, 260, DateTimeKind.Utc).AddTicks(9974));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 19, 46, 59, 260, DateTimeKind.Utc).AddTicks(9974));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 19, 46, 59, 260, DateTimeKind.Utc).AddTicks(9975));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 19, 46, 59, 260, DateTimeKind.Utc).AddTicks(9976));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 19, 46, 59, 260, DateTimeKind.Utc).AddTicks(9976));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 19, 46, 59, 260, DateTimeKind.Utc).AddTicks(9977));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 19, 46, 59, 260, DateTimeKind.Utc).AddTicks(9978));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 19, 46, 59, 260, DateTimeKind.Utc).AddTicks(9979));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 19, 46, 59, 260, DateTimeKind.Utc).AddTicks(9980));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 19, 46, 59, 260, DateTimeKind.Utc).AddTicks(9981));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 19, 46, 59, 260, DateTimeKind.Utc).AddTicks(9982));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 19, 46, 59, 260, DateTimeKind.Utc).AddTicks(9982));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 19, 46, 59, 260, DateTimeKind.Utc).AddTicks(9983));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 19, 46, 59, 260, DateTimeKind.Utc).AddTicks(9983));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 19, 46, 59, 261, DateTimeKind.Utc).AddTicks(16));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 19, 46, 59, 261, DateTimeKind.Utc).AddTicks(16));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 19, 46, 59, 261, DateTimeKind.Utc).AddTicks(17));

            migrationBuilder.UpdateData(
                table: "autopart_type_info",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 19, 46, 59, 261, DateTimeKind.Utc).AddTicks(3482));

            migrationBuilder.UpdateData(
                table: "autopart_type_info",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 19, 46, 59, 261, DateTimeKind.Utc).AddTicks(3488));

            migrationBuilder.UpdateData(
                table: "autopart_type_info",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 19, 46, 59, 261, DateTimeKind.Utc).AddTicks(3489));

            migrationBuilder.UpdateData(
                table: "autopart_type_info",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 19, 46, 59, 261, DateTimeKind.Utc).AddTicks(3490));

            migrationBuilder.UpdateData(
                table: "autopart_type_info",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 19, 46, 59, 261, DateTimeKind.Utc).AddTicks(3491));

            migrationBuilder.UpdateData(
                table: "autopart_type_info",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 19, 46, 59, 261, DateTimeKind.Utc).AddTicks(3493));

            migrationBuilder.UpdateData(
                table: "autopart_type_info",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 19, 46, 59, 261, DateTimeKind.Utc).AddTicks(3493));

            migrationBuilder.UpdateData(
                table: "autopart_type_info",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 19, 46, 59, 261, DateTimeKind.Utc).AddTicks(3494));

            migrationBuilder.UpdateData(
                table: "autopart_type_info",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 19, 46, 59, 261, DateTimeKind.Utc).AddTicks(3495));

            migrationBuilder.UpdateData(
                table: "autopart_type_info",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 19, 46, 59, 261, DateTimeKind.Utc).AddTicks(3497));

            migrationBuilder.UpdateData(
                table: "autopart_type_info",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 19, 46, 59, 261, DateTimeKind.Utc).AddTicks(3521));

            migrationBuilder.UpdateData(
                table: "autopart_type_info",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 19, 46, 59, 261, DateTimeKind.Utc).AddTicks(3522));

            migrationBuilder.UpdateData(
                table: "autopart_type_info",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 19, 46, 59, 261, DateTimeKind.Utc).AddTicks(3523));

            migrationBuilder.UpdateData(
                table: "autopart_type_info",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 19, 46, 59, 261, DateTimeKind.Utc).AddTicks(3523));

            migrationBuilder.UpdateData(
                table: "category",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 19, 46, 59, 260, DateTimeKind.Utc).AddTicks(6626));

            migrationBuilder.UpdateData(
                table: "category",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 19, 46, 59, 260, DateTimeKind.Utc).AddTicks(6629));

            migrationBuilder.UpdateData(
                table: "category",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 19, 46, 59, 260, DateTimeKind.Utc).AddTicks(6630));

            migrationBuilder.UpdateData(
                table: "category",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 19, 46, 59, 260, DateTimeKind.Utc).AddTicks(6631));

            migrationBuilder.UpdateData(
                table: "category",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 19, 46, 59, 260, DateTimeKind.Utc).AddTicks(6632));

            migrationBuilder.UpdateData(
                table: "category",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 19, 46, 59, 260, DateTimeKind.Utc).AddTicks(6633));

            migrationBuilder.UpdateData(
                table: "category",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 19, 46, 59, 260, DateTimeKind.Utc).AddTicks(6634));

            migrationBuilder.UpdateData(
                table: "category",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 19, 46, 59, 260, DateTimeKind.Utc).AddTicks(6635));

            migrationBuilder.UpdateData(
                table: "category",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 19, 46, 59, 260, DateTimeKind.Utc).AddTicks(6635));

            migrationBuilder.UpdateData(
                table: "category",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 19, 46, 59, 260, DateTimeKind.Utc).AddTicks(6660));

            migrationBuilder.UpdateData(
                table: "category",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 19, 46, 59, 260, DateTimeKind.Utc).AddTicks(6661));

            migrationBuilder.UpdateData(
                table: "category",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 19, 46, 59, 260, DateTimeKind.Utc).AddTicks(6662));

            migrationBuilder.UpdateData(
                table: "category",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 19, 46, 59, 260, DateTimeKind.Utc).AddTicks(6662));

            migrationBuilder.UpdateData(
                table: "category",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 19, 46, 59, 260, DateTimeKind.Utc).AddTicks(6663));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 19, 46, 59, 260, DateTimeKind.Utc).AddTicks(3324));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 19, 46, 59, 260, DateTimeKind.Utc).AddTicks(3329));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 19, 46, 59, 260, DateTimeKind.Utc).AddTicks(3330));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 19, 46, 59, 260, DateTimeKind.Utc).AddTicks(3331));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 19, 46, 59, 260, DateTimeKind.Utc).AddTicks(3332));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 19, 46, 59, 260, DateTimeKind.Utc).AddTicks(3334));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 19, 46, 59, 260, DateTimeKind.Utc).AddTicks(3334));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 19, 46, 59, 260, DateTimeKind.Utc).AddTicks(3357));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 19, 46, 59, 260, DateTimeKind.Utc).AddTicks(3358));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 19, 46, 59, 260, DateTimeKind.Utc).AddTicks(3359));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 19, 46, 59, 260, DateTimeKind.Utc).AddTicks(3360));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 19, 46, 59, 260, DateTimeKind.Utc).AddTicks(3361));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 19, 46, 59, 260, DateTimeKind.Utc).AddTicks(3361));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 19, 46, 59, 260, DateTimeKind.Utc).AddTicks(3362));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 19, 46, 59, 260, DateTimeKind.Utc).AddTicks(3363));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 19, 46, 59, 260, DateTimeKind.Utc).AddTicks(3363));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 19, 46, 59, 260, DateTimeKind.Utc).AddTicks(3364));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 19, 46, 59, 260, DateTimeKind.Utc).AddTicks(3366));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 19, 46, 59, 260, DateTimeKind.Utc).AddTicks(3366));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 19, 46, 59, 260, DateTimeKind.Utc).AddTicks(3367));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 19, 46, 59, 260, DateTimeKind.Utc).AddTicks(3368));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 19, 46, 59, 260, DateTimeKind.Utc).AddTicks(3368));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 19, 46, 59, 260, DateTimeKind.Utc).AddTicks(3369));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 19, 46, 59, 260, DateTimeKind.Utc).AddTicks(3370));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 19, 46, 59, 260, DateTimeKind.Utc).AddTicks(3370));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 19, 46, 59, 260, DateTimeKind.Utc).AddTicks(3371));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 19, 46, 59, 260, DateTimeKind.Utc).AddTicks(3372));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 19, 46, 59, 260, DateTimeKind.Utc).AddTicks(3372));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 19, 46, 59, 260, DateTimeKind.Utc).AddTicks(3373));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 19, 46, 59, 260, DateTimeKind.Utc).AddTicks(3374));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 19, 46, 59, 260, DateTimeKind.Utc).AddTicks(3374));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 19, 46, 59, 260, DateTimeKind.Utc).AddTicks(3375));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 19, 46, 59, 260, DateTimeKind.Utc).AddTicks(3375));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 19, 46, 59, 260, DateTimeKind.Utc).AddTicks(3377));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 19, 46, 59, 260, DateTimeKind.Utc).AddTicks(3378));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 19, 46, 59, 260, DateTimeKind.Utc).AddTicks(3378));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 19, 46, 59, 260, DateTimeKind.Utc).AddTicks(3380));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 19, 46, 59, 260, DateTimeKind.Utc).AddTicks(3381));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 19, 46, 59, 260, DateTimeKind.Utc).AddTicks(3381));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 19, 46, 59, 260, DateTimeKind.Utc).AddTicks(3382));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 19, 46, 59, 260, DateTimeKind.Utc).AddTicks(3383));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 19, 46, 59, 260, DateTimeKind.Utc).AddTicks(3383));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 19, 46, 59, 260, DateTimeKind.Utc).AddTicks(3384));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 19, 46, 59, 260, DateTimeKind.Utc).AddTicks(3385));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 19, 46, 59, 260, DateTimeKind.Utc).AddTicks(3385));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 19, 46, 59, 260, DateTimeKind.Utc).AddTicks(3386));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 19, 46, 59, 260, DateTimeKind.Utc).AddTicks(3387));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 19, 46, 59, 260, DateTimeKind.Utc).AddTicks(3387));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 19, 46, 59, 260, DateTimeKind.Utc).AddTicks(3388));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 19, 46, 59, 260, DateTimeKind.Utc).AddTicks(3388));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 19, 46, 59, 260, DateTimeKind.Utc).AddTicks(3389));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 19, 46, 59, 260, DateTimeKind.Utc).AddTicks(3390));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 19, 46, 59, 260, DateTimeKind.Utc).AddTicks(3390));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 19, 46, 59, 260, DateTimeKind.Utc).AddTicks(3391));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 19, 46, 59, 260, DateTimeKind.Utc).AddTicks(3392));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 19, 46, 59, 260, DateTimeKind.Utc).AddTicks(3392));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 19, 46, 59, 260, DateTimeKind.Utc).AddTicks(3393));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 19, 46, 59, 260, DateTimeKind.Utc).AddTicks(3394));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 19, 46, 59, 260, DateTimeKind.Utc).AddTicks(3394));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 19, 46, 59, 260, DateTimeKind.Utc).AddTicks(3395));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 19, 46, 59, 260, DateTimeKind.Utc).AddTicks(3395));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 19, 46, 59, 260, DateTimeKind.Utc).AddTicks(3396));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 19, 46, 59, 260, DateTimeKind.Utc).AddTicks(3397));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 19, 46, 59, 260, DateTimeKind.Utc).AddTicks(3397));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 19, 46, 59, 260, DateTimeKind.Utc).AddTicks(3398));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 19, 46, 59, 260, DateTimeKind.Utc).AddTicks(3399));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 19, 46, 59, 260, DateTimeKind.Utc).AddTicks(3400));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 19, 46, 59, 260, DateTimeKind.Utc).AddTicks(3400));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 19, 46, 59, 260, DateTimeKind.Utc).AddTicks(3401));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 19, 46, 59, 260, DateTimeKind.Utc).AddTicks(3402));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 19, 46, 59, 260, DateTimeKind.Utc).AddTicks(3402));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 19, 46, 59, 260, DateTimeKind.Utc).AddTicks(3415));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 19, 46, 59, 260, DateTimeKind.Utc).AddTicks(3416));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 19, 46, 59, 260, DateTimeKind.Utc).AddTicks(3417));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 19, 46, 59, 260, DateTimeKind.Utc).AddTicks(3418));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 76,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 19, 46, 59, 260, DateTimeKind.Utc).AddTicks(3418));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 77,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 19, 46, 59, 260, DateTimeKind.Utc).AddTicks(3419));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 78,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 19, 46, 59, 260, DateTimeKind.Utc).AddTicks(3420));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 79,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 19, 46, 59, 260, DateTimeKind.Utc).AddTicks(3420));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 80,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 19, 46, 59, 260, DateTimeKind.Utc).AddTicks(3421));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 81,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 19, 46, 59, 260, DateTimeKind.Utc).AddTicks(3422));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 82,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 19, 46, 59, 260, DateTimeKind.Utc).AddTicks(3422));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 83,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 19, 46, 59, 260, DateTimeKind.Utc).AddTicks(3423));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 84,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 19, 46, 59, 260, DateTimeKind.Utc).AddTicks(3424));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 85,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 19, 46, 59, 260, DateTimeKind.Utc).AddTicks(3424));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 86,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 19, 46, 59, 260, DateTimeKind.Utc).AddTicks(3425));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 87,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 19, 46, 59, 260, DateTimeKind.Utc).AddTicks(3426));

            migrationBuilder.UpdateData(
                table: "country",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 19, 46, 59, 260, DateTimeKind.Utc).AddTicks(3576));

            migrationBuilder.UpdateData(
                table: "country",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 19, 46, 59, 260, DateTimeKind.Utc).AddTicks(3580));

            migrationBuilder.UpdateData(
                table: "country",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 19, 46, 59, 260, DateTimeKind.Utc).AddTicks(3581));

            migrationBuilder.UpdateData(
                table: "country",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 19, 46, 59, 260, DateTimeKind.Utc).AddTicks(3582));

            migrationBuilder.UpdateData(
                table: "country",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 19, 46, 59, 260, DateTimeKind.Utc).AddTicks(3582));

            migrationBuilder.UpdateData(
                table: "country",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 19, 46, 59, 260, DateTimeKind.Utc).AddTicks(3584));

            migrationBuilder.UpdateData(
                table: "country",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 19, 46, 59, 260, DateTimeKind.Utc).AddTicks(3585));

            migrationBuilder.UpdateData(
                table: "country",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 19, 46, 59, 260, DateTimeKind.Utc).AddTicks(3585));

            migrationBuilder.UpdateData(
                table: "country",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 19, 46, 59, 260, DateTimeKind.Utc).AddTicks(3586));

            migrationBuilder.UpdateData(
                table: "country",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 19, 46, 59, 260, DateTimeKind.Utc).AddTicks(3588));

            migrationBuilder.UpdateData(
                table: "country",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 19, 46, 59, 260, DateTimeKind.Utc).AddTicks(3588));

            migrationBuilder.UpdateData(
                table: "country",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 19, 46, 59, 260, DateTimeKind.Utc).AddTicks(3589));

            migrationBuilder.UpdateData(
                table: "country",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 19, 46, 59, 260, DateTimeKind.Utc).AddTicks(3590));

            migrationBuilder.UpdateData(
                table: "country",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 19, 46, 59, 260, DateTimeKind.Utc).AddTicks(3591));

            migrationBuilder.UpdateData(
                table: "country",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 19, 46, 59, 260, DateTimeKind.Utc).AddTicks(3591));

            migrationBuilder.UpdateData(
                table: "country",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 19, 46, 59, 260, DateTimeKind.Utc).AddTicks(3592));

            migrationBuilder.UpdateData(
                table: "country",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 19, 46, 59, 260, DateTimeKind.Utc).AddTicks(3593));

            migrationBuilder.UpdateData(
                table: "country",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 19, 46, 59, 260, DateTimeKind.Utc).AddTicks(3594));

            migrationBuilder.UpdateData(
                table: "country",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 19, 46, 59, 260, DateTimeKind.Utc).AddTicks(3595));

            migrationBuilder.AddForeignKey(
                name: "FK_sale_detail_customer_CustomerId",
                table: "sale_detail",
                column: "CustomerId",
                principalTable: "customer",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_sale_detail_customer_CustomerId",
                table: "sale_detail");

            migrationBuilder.AlterColumn<int>(
                name: "CustomerId",
                table: "sale_detail",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 12, 6, 55, 877, DateTimeKind.Utc).AddTicks(6221));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 12, 6, 55, 877, DateTimeKind.Utc).AddTicks(6233));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 12, 6, 55, 877, DateTimeKind.Utc).AddTicks(6236));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 12, 6, 55, 877, DateTimeKind.Utc).AddTicks(6240));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 12, 6, 55, 877, DateTimeKind.Utc).AddTicks(6243));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 12, 6, 55, 877, DateTimeKind.Utc).AddTicks(6249));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 12, 6, 55, 877, DateTimeKind.Utc).AddTicks(6251));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 12, 6, 55, 877, DateTimeKind.Utc).AddTicks(6254));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 12, 6, 55, 877, DateTimeKind.Utc).AddTicks(6257));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 12, 6, 55, 877, DateTimeKind.Utc).AddTicks(6261));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 12, 6, 55, 877, DateTimeKind.Utc).AddTicks(6264));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 12, 6, 55, 877, DateTimeKind.Utc).AddTicks(6266));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 12, 6, 55, 877, DateTimeKind.Utc).AddTicks(6268));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 12, 6, 55, 877, DateTimeKind.Utc).AddTicks(6270));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 12, 6, 55, 877, DateTimeKind.Utc).AddTicks(6272));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 12, 6, 55, 877, DateTimeKind.Utc).AddTicks(6275));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 12, 6, 55, 877, DateTimeKind.Utc).AddTicks(6277));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 12, 6, 55, 877, DateTimeKind.Utc).AddTicks(6283));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 12, 6, 55, 877, DateTimeKind.Utc).AddTicks(6285));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 12, 6, 55, 877, DateTimeKind.Utc).AddTicks(6287));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 12, 6, 55, 877, DateTimeKind.Utc).AddTicks(6290));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 12, 6, 55, 877, DateTimeKind.Utc).AddTicks(6292));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 12, 6, 55, 877, DateTimeKind.Utc).AddTicks(6295));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 12, 6, 55, 877, DateTimeKind.Utc).AddTicks(6297));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 12, 6, 55, 877, DateTimeKind.Utc).AddTicks(6300));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 12, 6, 55, 877, DateTimeKind.Utc).AddTicks(6302));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 12, 6, 55, 877, DateTimeKind.Utc).AddTicks(6305));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 12, 6, 55, 877, DateTimeKind.Utc).AddTicks(6307));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 12, 6, 55, 877, DateTimeKind.Utc).AddTicks(6310));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 12, 6, 55, 877, DateTimeKind.Utc).AddTicks(6312));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 12, 6, 55, 877, DateTimeKind.Utc).AddTicks(6315));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 12, 6, 55, 877, DateTimeKind.Utc).AddTicks(6317));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 12, 6, 55, 877, DateTimeKind.Utc).AddTicks(6319));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 12, 6, 55, 877, DateTimeKind.Utc).AddTicks(6324));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 12, 6, 55, 877, DateTimeKind.Utc).AddTicks(6326));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 12, 6, 55, 877, DateTimeKind.Utc).AddTicks(6328));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 12, 6, 55, 877, DateTimeKind.Utc).AddTicks(6331));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 12, 6, 55, 877, DateTimeKind.Utc).AddTicks(6333));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 12, 6, 55, 877, DateTimeKind.Utc).AddTicks(6335));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 12, 6, 55, 877, DateTimeKind.Utc).AddTicks(6337));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 12, 6, 55, 877, DateTimeKind.Utc).AddTicks(6340));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 12, 6, 55, 877, DateTimeKind.Utc).AddTicks(6342));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 12, 6, 55, 877, DateTimeKind.Utc).AddTicks(6344));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 12, 6, 55, 877, DateTimeKind.Utc).AddTicks(6346));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 12, 6, 55, 877, DateTimeKind.Utc).AddTicks(6348));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 12, 6, 55, 877, DateTimeKind.Utc).AddTicks(6351));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 12, 6, 55, 877, DateTimeKind.Utc).AddTicks(6353));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 12, 6, 55, 877, DateTimeKind.Utc).AddTicks(6355));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 12, 6, 55, 877, DateTimeKind.Utc).AddTicks(6358));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 12, 6, 55, 877, DateTimeKind.Utc).AddTicks(6360));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 12, 6, 55, 877, DateTimeKind.Utc).AddTicks(6362));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 12, 6, 55, 877, DateTimeKind.Utc).AddTicks(6364));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 12, 6, 55, 877, DateTimeKind.Utc).AddTicks(6367));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 12, 6, 55, 877, DateTimeKind.Utc).AddTicks(6369));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 12, 6, 55, 877, DateTimeKind.Utc).AddTicks(6372));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 12, 6, 55, 877, DateTimeKind.Utc).AddTicks(6374));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 12, 6, 55, 877, DateTimeKind.Utc).AddTicks(6458));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 12, 6, 55, 877, DateTimeKind.Utc).AddTicks(6462));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 12, 6, 55, 877, DateTimeKind.Utc).AddTicks(6464));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 12, 6, 55, 877, DateTimeKind.Utc).AddTicks(6466));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 12, 6, 55, 877, DateTimeKind.Utc).AddTicks(6469));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 12, 6, 55, 877, DateTimeKind.Utc).AddTicks(6472));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 12, 6, 55, 877, DateTimeKind.Utc).AddTicks(6474));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 12, 6, 55, 877, DateTimeKind.Utc).AddTicks(6476));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 12, 6, 55, 877, DateTimeKind.Utc).AddTicks(6479));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 12, 6, 55, 877, DateTimeKind.Utc).AddTicks(6484));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 12, 6, 55, 877, DateTimeKind.Utc).AddTicks(6487));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 12, 6, 55, 877, DateTimeKind.Utc).AddTicks(6489));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 12, 6, 55, 877, DateTimeKind.Utc).AddTicks(6491));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 12, 6, 55, 877, DateTimeKind.Utc).AddTicks(6493));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 12, 6, 55, 877, DateTimeKind.Utc).AddTicks(6495));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 12, 6, 55, 877, DateTimeKind.Utc).AddTicks(6497));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 12, 6, 55, 877, DateTimeKind.Utc).AddTicks(6525));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 12, 6, 55, 877, DateTimeKind.Utc).AddTicks(6527));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 12, 6, 55, 877, DateTimeKind.Utc).AddTicks(6530));

            migrationBuilder.UpdateData(
                table: "autopart_type_info",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 12, 6, 55, 879, DateTimeKind.Utc).AddTicks(5104));

            migrationBuilder.UpdateData(
                table: "autopart_type_info",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 12, 6, 55, 879, DateTimeKind.Utc).AddTicks(5114));

            migrationBuilder.UpdateData(
                table: "autopart_type_info",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 12, 6, 55, 879, DateTimeKind.Utc).AddTicks(5118));

            migrationBuilder.UpdateData(
                table: "autopart_type_info",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 12, 6, 55, 879, DateTimeKind.Utc).AddTicks(5120));

            migrationBuilder.UpdateData(
                table: "autopart_type_info",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 12, 6, 55, 879, DateTimeKind.Utc).AddTicks(5384));

            migrationBuilder.UpdateData(
                table: "autopart_type_info",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 12, 6, 55, 879, DateTimeKind.Utc).AddTicks(5390));

            migrationBuilder.UpdateData(
                table: "autopart_type_info",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 12, 6, 55, 879, DateTimeKind.Utc).AddTicks(5392));

            migrationBuilder.UpdateData(
                table: "autopart_type_info",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 12, 6, 55, 879, DateTimeKind.Utc).AddTicks(5394));

            migrationBuilder.UpdateData(
                table: "autopart_type_info",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 12, 6, 55, 879, DateTimeKind.Utc).AddTicks(5397));

            migrationBuilder.UpdateData(
                table: "autopart_type_info",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 12, 6, 55, 879, DateTimeKind.Utc).AddTicks(5401));

            migrationBuilder.UpdateData(
                table: "autopart_type_info",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 12, 6, 55, 879, DateTimeKind.Utc).AddTicks(5403));

            migrationBuilder.UpdateData(
                table: "autopart_type_info",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 12, 6, 55, 879, DateTimeKind.Utc).AddTicks(5406));

            migrationBuilder.UpdateData(
                table: "autopart_type_info",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 12, 6, 55, 879, DateTimeKind.Utc).AddTicks(5408));

            migrationBuilder.UpdateData(
                table: "autopart_type_info",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 12, 6, 55, 879, DateTimeKind.Utc).AddTicks(5410));

            migrationBuilder.UpdateData(
                table: "category",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 12, 6, 55, 876, DateTimeKind.Utc).AddTicks(3555));

            migrationBuilder.UpdateData(
                table: "category",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 12, 6, 55, 876, DateTimeKind.Utc).AddTicks(3575));

            migrationBuilder.UpdateData(
                table: "category",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 12, 6, 55, 876, DateTimeKind.Utc).AddTicks(3584));

            migrationBuilder.UpdateData(
                table: "category",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 12, 6, 55, 876, DateTimeKind.Utc).AddTicks(3591));

            migrationBuilder.UpdateData(
                table: "category",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 12, 6, 55, 876, DateTimeKind.Utc).AddTicks(3596));

            migrationBuilder.UpdateData(
                table: "category",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 12, 6, 55, 876, DateTimeKind.Utc).AddTicks(3614));

            migrationBuilder.UpdateData(
                table: "category",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 12, 6, 55, 876, DateTimeKind.Utc).AddTicks(3621));

            migrationBuilder.UpdateData(
                table: "category",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 12, 6, 55, 876, DateTimeKind.Utc).AddTicks(3627));

            migrationBuilder.UpdateData(
                table: "category",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 12, 6, 55, 876, DateTimeKind.Utc).AddTicks(3633));

            migrationBuilder.UpdateData(
                table: "category",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 12, 6, 55, 876, DateTimeKind.Utc).AddTicks(3646));

            migrationBuilder.UpdateData(
                table: "category",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 12, 6, 55, 876, DateTimeKind.Utc).AddTicks(3651));

            migrationBuilder.UpdateData(
                table: "category",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 12, 6, 55, 876, DateTimeKind.Utc).AddTicks(3657));

            migrationBuilder.UpdateData(
                table: "category",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 12, 6, 55, 876, DateTimeKind.Utc).AddTicks(3662));

            migrationBuilder.UpdateData(
                table: "category",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 12, 6, 55, 876, DateTimeKind.Utc).AddTicks(3668));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 12, 6, 55, 874, DateTimeKind.Utc).AddTicks(9596));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 12, 6, 55, 874, DateTimeKind.Utc).AddTicks(9607));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 12, 6, 55, 874, DateTimeKind.Utc).AddTicks(9610));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 12, 6, 55, 874, DateTimeKind.Utc).AddTicks(9612));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 12, 6, 55, 874, DateTimeKind.Utc).AddTicks(9614));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 12, 6, 55, 874, DateTimeKind.Utc).AddTicks(9620));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 12, 6, 55, 874, DateTimeKind.Utc).AddTicks(9622));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 12, 6, 55, 874, DateTimeKind.Utc).AddTicks(9625));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 12, 6, 55, 874, DateTimeKind.Utc).AddTicks(9627));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 12, 6, 55, 874, DateTimeKind.Utc).AddTicks(9632));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 12, 6, 55, 874, DateTimeKind.Utc).AddTicks(9634));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 12, 6, 55, 874, DateTimeKind.Utc).AddTicks(9637));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 12, 6, 55, 874, DateTimeKind.Utc).AddTicks(9639));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 12, 6, 55, 874, DateTimeKind.Utc).AddTicks(9641));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 12, 6, 55, 874, DateTimeKind.Utc).AddTicks(9643));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 12, 6, 55, 874, DateTimeKind.Utc).AddTicks(9645));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 12, 6, 55, 874, DateTimeKind.Utc).AddTicks(9647));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 12, 6, 55, 874, DateTimeKind.Utc).AddTicks(9652));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 12, 6, 55, 874, DateTimeKind.Utc).AddTicks(9655));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 12, 6, 55, 874, DateTimeKind.Utc).AddTicks(9657));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 12, 6, 55, 874, DateTimeKind.Utc).AddTicks(9659));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 12, 6, 55, 874, DateTimeKind.Utc).AddTicks(9661));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 12, 6, 55, 874, DateTimeKind.Utc).AddTicks(9663));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 12, 6, 55, 874, DateTimeKind.Utc).AddTicks(9665));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 12, 6, 55, 874, DateTimeKind.Utc).AddTicks(9667));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 12, 6, 55, 874, DateTimeKind.Utc).AddTicks(9669));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 12, 6, 55, 874, DateTimeKind.Utc).AddTicks(9671));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 12, 6, 55, 874, DateTimeKind.Utc).AddTicks(9673));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 12, 6, 55, 874, DateTimeKind.Utc).AddTicks(9675));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 12, 6, 55, 874, DateTimeKind.Utc).AddTicks(9677));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 12, 6, 55, 874, DateTimeKind.Utc).AddTicks(9679));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 12, 6, 55, 874, DateTimeKind.Utc).AddTicks(9681));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 12, 6, 55, 874, DateTimeKind.Utc).AddTicks(9683));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 12, 6, 55, 874, DateTimeKind.Utc).AddTicks(9688));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 12, 6, 55, 874, DateTimeKind.Utc).AddTicks(9690));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 12, 6, 55, 874, DateTimeKind.Utc).AddTicks(9692));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 12, 6, 55, 874, DateTimeKind.Utc).AddTicks(9696));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 12, 6, 55, 874, DateTimeKind.Utc).AddTicks(9698));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 12, 6, 55, 874, DateTimeKind.Utc).AddTicks(9700));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 12, 6, 55, 874, DateTimeKind.Utc).AddTicks(9702));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 12, 6, 55, 874, DateTimeKind.Utc).AddTicks(9704));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 12, 6, 55, 874, DateTimeKind.Utc).AddTicks(9707));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 12, 6, 55, 874, DateTimeKind.Utc).AddTicks(9709));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 12, 6, 55, 874, DateTimeKind.Utc).AddTicks(9711));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 12, 6, 55, 874, DateTimeKind.Utc).AddTicks(9713));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 12, 6, 55, 874, DateTimeKind.Utc).AddTicks(9715));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 12, 6, 55, 874, DateTimeKind.Utc).AddTicks(9718));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 12, 6, 55, 874, DateTimeKind.Utc).AddTicks(9720));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 12, 6, 55, 874, DateTimeKind.Utc).AddTicks(9722));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 12, 6, 55, 874, DateTimeKind.Utc).AddTicks(9724));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 12, 6, 55, 874, DateTimeKind.Utc).AddTicks(9726));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 12, 6, 55, 874, DateTimeKind.Utc).AddTicks(9728));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 12, 6, 55, 874, DateTimeKind.Utc).AddTicks(9730));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 12, 6, 55, 874, DateTimeKind.Utc).AddTicks(9732));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 12, 6, 55, 874, DateTimeKind.Utc).AddTicks(9734));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 12, 6, 55, 874, DateTimeKind.Utc).AddTicks(9736));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 12, 6, 55, 874, DateTimeKind.Utc).AddTicks(9738));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 12, 6, 55, 874, DateTimeKind.Utc).AddTicks(9740));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 12, 6, 55, 874, DateTimeKind.Utc).AddTicks(9742));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 12, 6, 55, 874, DateTimeKind.Utc).AddTicks(9744));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 12, 6, 55, 874, DateTimeKind.Utc).AddTicks(9746));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 12, 6, 55, 874, DateTimeKind.Utc).AddTicks(9748));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 12, 6, 55, 874, DateTimeKind.Utc).AddTicks(9750));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 12, 6, 55, 874, DateTimeKind.Utc).AddTicks(9752));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 12, 6, 55, 874, DateTimeKind.Utc).AddTicks(9754));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 12, 6, 55, 874, DateTimeKind.Utc).AddTicks(9882));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 12, 6, 55, 874, DateTimeKind.Utc).AddTicks(9884));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 12, 6, 55, 874, DateTimeKind.Utc).AddTicks(9887));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 12, 6, 55, 874, DateTimeKind.Utc).AddTicks(9889));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 12, 6, 55, 874, DateTimeKind.Utc).AddTicks(9891));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 12, 6, 55, 874, DateTimeKind.Utc).AddTicks(9893));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 12, 6, 55, 874, DateTimeKind.Utc).AddTicks(9895));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 12, 6, 55, 874, DateTimeKind.Utc).AddTicks(9898));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 12, 6, 55, 874, DateTimeKind.Utc).AddTicks(9900));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 12, 6, 55, 874, DateTimeKind.Utc).AddTicks(9902));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 76,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 12, 6, 55, 874, DateTimeKind.Utc).AddTicks(9904));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 77,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 12, 6, 55, 874, DateTimeKind.Utc).AddTicks(9906));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 78,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 12, 6, 55, 874, DateTimeKind.Utc).AddTicks(9908));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 79,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 12, 6, 55, 874, DateTimeKind.Utc).AddTicks(9910));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 80,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 12, 6, 55, 874, DateTimeKind.Utc).AddTicks(9912));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 81,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 12, 6, 55, 874, DateTimeKind.Utc).AddTicks(9914));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 82,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 12, 6, 55, 874, DateTimeKind.Utc).AddTicks(9916));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 83,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 12, 6, 55, 874, DateTimeKind.Utc).AddTicks(9918));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 84,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 12, 6, 55, 874, DateTimeKind.Utc).AddTicks(9920));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 85,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 12, 6, 55, 874, DateTimeKind.Utc).AddTicks(9922));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 86,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 12, 6, 55, 874, DateTimeKind.Utc).AddTicks(9924));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 87,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 12, 6, 55, 874, DateTimeKind.Utc).AddTicks(9926));

            migrationBuilder.UpdateData(
                table: "country",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 12, 6, 55, 875, DateTimeKind.Utc).AddTicks(445));

            migrationBuilder.UpdateData(
                table: "country",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 12, 6, 55, 875, DateTimeKind.Utc).AddTicks(455));

            migrationBuilder.UpdateData(
                table: "country",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 12, 6, 55, 875, DateTimeKind.Utc).AddTicks(459));

            migrationBuilder.UpdateData(
                table: "country",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 12, 6, 55, 875, DateTimeKind.Utc).AddTicks(461));

            migrationBuilder.UpdateData(
                table: "country",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 12, 6, 55, 875, DateTimeKind.Utc).AddTicks(464));

            migrationBuilder.UpdateData(
                table: "country",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 12, 6, 55, 875, DateTimeKind.Utc).AddTicks(469));

            migrationBuilder.UpdateData(
                table: "country",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 12, 6, 55, 875, DateTimeKind.Utc).AddTicks(471));

            migrationBuilder.UpdateData(
                table: "country",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 12, 6, 55, 875, DateTimeKind.Utc).AddTicks(474));

            migrationBuilder.UpdateData(
                table: "country",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 12, 6, 55, 875, DateTimeKind.Utc).AddTicks(476));

            migrationBuilder.UpdateData(
                table: "country",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 12, 6, 55, 875, DateTimeKind.Utc).AddTicks(481));

            migrationBuilder.UpdateData(
                table: "country",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 12, 6, 55, 875, DateTimeKind.Utc).AddTicks(483));

            migrationBuilder.UpdateData(
                table: "country",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 12, 6, 55, 875, DateTimeKind.Utc).AddTicks(485));

            migrationBuilder.UpdateData(
                table: "country",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 12, 6, 55, 875, DateTimeKind.Utc).AddTicks(488));

            migrationBuilder.UpdateData(
                table: "country",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 12, 6, 55, 875, DateTimeKind.Utc).AddTicks(490));

            migrationBuilder.UpdateData(
                table: "country",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 12, 6, 55, 875, DateTimeKind.Utc).AddTicks(492));

            migrationBuilder.UpdateData(
                table: "country",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 12, 6, 55, 875, DateTimeKind.Utc).AddTicks(495));

            migrationBuilder.UpdateData(
                table: "country",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 12, 6, 55, 875, DateTimeKind.Utc).AddTicks(497));

            migrationBuilder.UpdateData(
                table: "country",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 12, 6, 55, 875, DateTimeKind.Utc).AddTicks(567));

            migrationBuilder.UpdateData(
                table: "country",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreateAt",
                value: new DateTime(2025, 6, 9, 12, 6, 55, 875, DateTimeKind.Utc).AddTicks(571));

            migrationBuilder.AddForeignKey(
                name: "FK_sale_detail_customer_CustomerId",
                table: "sale_detail",
                column: "CustomerId",
                principalTable: "customer",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
