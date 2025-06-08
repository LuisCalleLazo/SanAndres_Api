using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SanAndres_Api.Migrations
{
    /// <inheritdoc />
    public partial class SellerCompanyNull : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_seller_company_CompanyId",
                table: "seller");

            migrationBuilder.AlterColumn<int>(
                name: "CompanyId",
                table: "seller",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2025, 6, 8, 21, 23, 4, 209, DateTimeKind.Utc).AddTicks(8347));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2025, 6, 8, 21, 23, 4, 209, DateTimeKind.Utc).AddTicks(8352));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2025, 6, 8, 21, 23, 4, 209, DateTimeKind.Utc).AddTicks(8353));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2025, 6, 8, 21, 23, 4, 209, DateTimeKind.Utc).AddTicks(8354));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2025, 6, 8, 21, 23, 4, 209, DateTimeKind.Utc).AddTicks(8381));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateAt",
                value: new DateTime(2025, 6, 8, 21, 23, 4, 209, DateTimeKind.Utc).AddTicks(8383));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateAt",
                value: new DateTime(2025, 6, 8, 21, 23, 4, 209, DateTimeKind.Utc).AddTicks(8383));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateAt",
                value: new DateTime(2025, 6, 8, 21, 23, 4, 209, DateTimeKind.Utc).AddTicks(8384));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreateAt",
                value: new DateTime(2025, 6, 8, 21, 23, 4, 209, DateTimeKind.Utc).AddTicks(8385));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreateAt",
                value: new DateTime(2025, 6, 8, 21, 23, 4, 209, DateTimeKind.Utc).AddTicks(8386));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreateAt",
                value: new DateTime(2025, 6, 8, 21, 23, 4, 209, DateTimeKind.Utc).AddTicks(8387));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreateAt",
                value: new DateTime(2025, 6, 8, 21, 23, 4, 209, DateTimeKind.Utc).AddTicks(8388));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreateAt",
                value: new DateTime(2025, 6, 8, 21, 23, 4, 209, DateTimeKind.Utc).AddTicks(8389));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreateAt",
                value: new DateTime(2025, 6, 8, 21, 23, 4, 209, DateTimeKind.Utc).AddTicks(8390));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreateAt",
                value: new DateTime(2025, 6, 8, 21, 23, 4, 209, DateTimeKind.Utc).AddTicks(8390));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreateAt",
                value: new DateTime(2025, 6, 8, 21, 23, 4, 209, DateTimeKind.Utc).AddTicks(8391));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreateAt",
                value: new DateTime(2025, 6, 8, 21, 23, 4, 209, DateTimeKind.Utc).AddTicks(8392));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreateAt",
                value: new DateTime(2025, 6, 8, 21, 23, 4, 209, DateTimeKind.Utc).AddTicks(8393));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreateAt",
                value: new DateTime(2025, 6, 8, 21, 23, 4, 209, DateTimeKind.Utc).AddTicks(8394));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreateAt",
                value: new DateTime(2025, 6, 8, 21, 23, 4, 209, DateTimeKind.Utc).AddTicks(8395));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreateAt",
                value: new DateTime(2025, 6, 8, 21, 23, 4, 209, DateTimeKind.Utc).AddTicks(8395));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreateAt",
                value: new DateTime(2025, 6, 8, 21, 23, 4, 209, DateTimeKind.Utc).AddTicks(8396));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreateAt",
                value: new DateTime(2025, 6, 8, 21, 23, 4, 209, DateTimeKind.Utc).AddTicks(8397));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreateAt",
                value: new DateTime(2025, 6, 8, 21, 23, 4, 209, DateTimeKind.Utc).AddTicks(8397));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreateAt",
                value: new DateTime(2025, 6, 8, 21, 23, 4, 209, DateTimeKind.Utc).AddTicks(8398));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreateAt",
                value: new DateTime(2025, 6, 8, 21, 23, 4, 209, DateTimeKind.Utc).AddTicks(8399));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreateAt",
                value: new DateTime(2025, 6, 8, 21, 23, 4, 209, DateTimeKind.Utc).AddTicks(8400));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreateAt",
                value: new DateTime(2025, 6, 8, 21, 23, 4, 209, DateTimeKind.Utc).AddTicks(8400));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreateAt",
                value: new DateTime(2025, 6, 8, 21, 23, 4, 209, DateTimeKind.Utc).AddTicks(8401));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreateAt",
                value: new DateTime(2025, 6, 8, 21, 23, 4, 209, DateTimeKind.Utc).AddTicks(8402));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreateAt",
                value: new DateTime(2025, 6, 8, 21, 23, 4, 209, DateTimeKind.Utc).AddTicks(8402));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreateAt",
                value: new DateTime(2025, 6, 8, 21, 23, 4, 209, DateTimeKind.Utc).AddTicks(8403));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreateAt",
                value: new DateTime(2025, 6, 8, 21, 23, 4, 209, DateTimeKind.Utc).AddTicks(8404));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreateAt",
                value: new DateTime(2025, 6, 8, 21, 23, 4, 209, DateTimeKind.Utc).AddTicks(8405));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreateAt",
                value: new DateTime(2025, 6, 8, 21, 23, 4, 209, DateTimeKind.Utc).AddTicks(8406));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreateAt",
                value: new DateTime(2025, 6, 8, 21, 23, 4, 209, DateTimeKind.Utc).AddTicks(8407));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreateAt",
                value: new DateTime(2025, 6, 8, 21, 23, 4, 209, DateTimeKind.Utc).AddTicks(8409));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreateAt",
                value: new DateTime(2025, 6, 8, 21, 23, 4, 209, DateTimeKind.Utc).AddTicks(8409));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreateAt",
                value: new DateTime(2025, 6, 8, 21, 23, 4, 209, DateTimeKind.Utc).AddTicks(8410));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreateAt",
                value: new DateTime(2025, 6, 8, 21, 23, 4, 209, DateTimeKind.Utc).AddTicks(8411));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreateAt",
                value: new DateTime(2025, 6, 8, 21, 23, 4, 209, DateTimeKind.Utc).AddTicks(8411));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreateAt",
                value: new DateTime(2025, 6, 8, 21, 23, 4, 209, DateTimeKind.Utc).AddTicks(8412));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreateAt",
                value: new DateTime(2025, 6, 8, 21, 23, 4, 209, DateTimeKind.Utc).AddTicks(8413));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreateAt",
                value: new DateTime(2025, 6, 8, 21, 23, 4, 209, DateTimeKind.Utc).AddTicks(8414));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreateAt",
                value: new DateTime(2025, 6, 8, 21, 23, 4, 209, DateTimeKind.Utc).AddTicks(8414));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreateAt",
                value: new DateTime(2025, 6, 8, 21, 23, 4, 209, DateTimeKind.Utc).AddTicks(8415));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreateAt",
                value: new DateTime(2025, 6, 8, 21, 23, 4, 209, DateTimeKind.Utc).AddTicks(8416));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreateAt",
                value: new DateTime(2025, 6, 8, 21, 23, 4, 209, DateTimeKind.Utc).AddTicks(8416));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreateAt",
                value: new DateTime(2025, 6, 8, 21, 23, 4, 209, DateTimeKind.Utc).AddTicks(8417));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreateAt",
                value: new DateTime(2025, 6, 8, 21, 23, 4, 209, DateTimeKind.Utc).AddTicks(8418));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreateAt",
                value: new DateTime(2025, 6, 8, 21, 23, 4, 209, DateTimeKind.Utc).AddTicks(8418));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreateAt",
                value: new DateTime(2025, 6, 8, 21, 23, 4, 209, DateTimeKind.Utc).AddTicks(8419));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreateAt",
                value: new DateTime(2025, 6, 8, 21, 23, 4, 209, DateTimeKind.Utc).AddTicks(8420));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreateAt",
                value: new DateTime(2025, 6, 8, 21, 23, 4, 209, DateTimeKind.Utc).AddTicks(8420));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreateAt",
                value: new DateTime(2025, 6, 8, 21, 23, 4, 209, DateTimeKind.Utc).AddTicks(8421));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreateAt",
                value: new DateTime(2025, 6, 8, 21, 23, 4, 209, DateTimeKind.Utc).AddTicks(8422));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreateAt",
                value: new DateTime(2025, 6, 8, 21, 23, 4, 209, DateTimeKind.Utc).AddTicks(8422));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreateAt",
                value: new DateTime(2025, 6, 8, 21, 23, 4, 209, DateTimeKind.Utc).AddTicks(8423));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreateAt",
                value: new DateTime(2025, 6, 8, 21, 23, 4, 209, DateTimeKind.Utc).AddTicks(8424));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreateAt",
                value: new DateTime(2025, 6, 8, 21, 23, 4, 209, DateTimeKind.Utc).AddTicks(8424));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreateAt",
                value: new DateTime(2025, 6, 8, 21, 23, 4, 209, DateTimeKind.Utc).AddTicks(8425));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreateAt",
                value: new DateTime(2025, 6, 8, 21, 23, 4, 209, DateTimeKind.Utc).AddTicks(8426));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreateAt",
                value: new DateTime(2025, 6, 8, 21, 23, 4, 209, DateTimeKind.Utc).AddTicks(8426));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreateAt",
                value: new DateTime(2025, 6, 8, 21, 23, 4, 209, DateTimeKind.Utc).AddTicks(8427));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreateAt",
                value: new DateTime(2025, 6, 8, 21, 23, 4, 209, DateTimeKind.Utc).AddTicks(8428));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreateAt",
                value: new DateTime(2025, 6, 8, 21, 23, 4, 209, DateTimeKind.Utc).AddTicks(8429));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreateAt",
                value: new DateTime(2025, 6, 8, 21, 23, 4, 209, DateTimeKind.Utc).AddTicks(8430));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreateAt",
                value: new DateTime(2025, 6, 8, 21, 23, 4, 209, DateTimeKind.Utc).AddTicks(8431));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreateAt",
                value: new DateTime(2025, 6, 8, 21, 23, 4, 209, DateTimeKind.Utc).AddTicks(8445));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreateAt",
                value: new DateTime(2025, 6, 8, 21, 23, 4, 209, DateTimeKind.Utc).AddTicks(8446));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreateAt",
                value: new DateTime(2025, 6, 8, 21, 23, 4, 209, DateTimeKind.Utc).AddTicks(8446));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreateAt",
                value: new DateTime(2025, 6, 8, 21, 23, 4, 209, DateTimeKind.Utc).AddTicks(8447));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreateAt",
                value: new DateTime(2025, 6, 8, 21, 23, 4, 209, DateTimeKind.Utc).AddTicks(8448));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreateAt",
                value: new DateTime(2025, 6, 8, 21, 23, 4, 209, DateTimeKind.Utc).AddTicks(8449));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreateAt",
                value: new DateTime(2025, 6, 8, 21, 23, 4, 209, DateTimeKind.Utc).AddTicks(8449));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 76,
                column: "CreateAt",
                value: new DateTime(2025, 6, 8, 21, 23, 4, 209, DateTimeKind.Utc).AddTicks(8450));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 77,
                column: "CreateAt",
                value: new DateTime(2025, 6, 8, 21, 23, 4, 209, DateTimeKind.Utc).AddTicks(8451));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 78,
                column: "CreateAt",
                value: new DateTime(2025, 6, 8, 21, 23, 4, 209, DateTimeKind.Utc).AddTicks(8452));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 79,
                column: "CreateAt",
                value: new DateTime(2025, 6, 8, 21, 23, 4, 209, DateTimeKind.Utc).AddTicks(8452));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 80,
                column: "CreateAt",
                value: new DateTime(2025, 6, 8, 21, 23, 4, 209, DateTimeKind.Utc).AddTicks(8453));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 81,
                column: "CreateAt",
                value: new DateTime(2025, 6, 8, 21, 23, 4, 209, DateTimeKind.Utc).AddTicks(8454));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 82,
                column: "CreateAt",
                value: new DateTime(2025, 6, 8, 21, 23, 4, 209, DateTimeKind.Utc).AddTicks(8454));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 83,
                column: "CreateAt",
                value: new DateTime(2025, 6, 8, 21, 23, 4, 209, DateTimeKind.Utc).AddTicks(8455));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 84,
                column: "CreateAt",
                value: new DateTime(2025, 6, 8, 21, 23, 4, 209, DateTimeKind.Utc).AddTicks(8456));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 85,
                column: "CreateAt",
                value: new DateTime(2025, 6, 8, 21, 23, 4, 209, DateTimeKind.Utc).AddTicks(8456));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 86,
                column: "CreateAt",
                value: new DateTime(2025, 6, 8, 21, 23, 4, 209, DateTimeKind.Utc).AddTicks(8457));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 87,
                column: "CreateAt",
                value: new DateTime(2025, 6, 8, 21, 23, 4, 209, DateTimeKind.Utc).AddTicks(8458));

            migrationBuilder.UpdateData(
                table: "country",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2025, 6, 8, 21, 23, 4, 209, DateTimeKind.Utc).AddTicks(8595));

            migrationBuilder.UpdateData(
                table: "country",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2025, 6, 8, 21, 23, 4, 209, DateTimeKind.Utc).AddTicks(8598));

            migrationBuilder.UpdateData(
                table: "country",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2025, 6, 8, 21, 23, 4, 209, DateTimeKind.Utc).AddTicks(8600));

            migrationBuilder.UpdateData(
                table: "country",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2025, 6, 8, 21, 23, 4, 209, DateTimeKind.Utc).AddTicks(8601));

            migrationBuilder.UpdateData(
                table: "country",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2025, 6, 8, 21, 23, 4, 209, DateTimeKind.Utc).AddTicks(8602));

            migrationBuilder.UpdateData(
                table: "country",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateAt",
                value: new DateTime(2025, 6, 8, 21, 23, 4, 209, DateTimeKind.Utc).AddTicks(8603));

            migrationBuilder.UpdateData(
                table: "country",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateAt",
                value: new DateTime(2025, 6, 8, 21, 23, 4, 209, DateTimeKind.Utc).AddTicks(8604));

            migrationBuilder.UpdateData(
                table: "country",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateAt",
                value: new DateTime(2025, 6, 8, 21, 23, 4, 209, DateTimeKind.Utc).AddTicks(8605));

            migrationBuilder.UpdateData(
                table: "country",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreateAt",
                value: new DateTime(2025, 6, 8, 21, 23, 4, 209, DateTimeKind.Utc).AddTicks(8606));

            migrationBuilder.UpdateData(
                table: "country",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreateAt",
                value: new DateTime(2025, 6, 8, 21, 23, 4, 209, DateTimeKind.Utc).AddTicks(8608));

            migrationBuilder.UpdateData(
                table: "country",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreateAt",
                value: new DateTime(2025, 6, 8, 21, 23, 4, 209, DateTimeKind.Utc).AddTicks(8608));

            migrationBuilder.UpdateData(
                table: "country",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreateAt",
                value: new DateTime(2025, 6, 8, 21, 23, 4, 209, DateTimeKind.Utc).AddTicks(8609));

            migrationBuilder.UpdateData(
                table: "country",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreateAt",
                value: new DateTime(2025, 6, 8, 21, 23, 4, 209, DateTimeKind.Utc).AddTicks(8610));

            migrationBuilder.UpdateData(
                table: "country",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreateAt",
                value: new DateTime(2025, 6, 8, 21, 23, 4, 209, DateTimeKind.Utc).AddTicks(8611));

            migrationBuilder.UpdateData(
                table: "country",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreateAt",
                value: new DateTime(2025, 6, 8, 21, 23, 4, 209, DateTimeKind.Utc).AddTicks(8612));

            migrationBuilder.UpdateData(
                table: "country",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreateAt",
                value: new DateTime(2025, 6, 8, 21, 23, 4, 209, DateTimeKind.Utc).AddTicks(8612));

            migrationBuilder.UpdateData(
                table: "country",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreateAt",
                value: new DateTime(2025, 6, 8, 21, 23, 4, 209, DateTimeKind.Utc).AddTicks(8613));

            migrationBuilder.UpdateData(
                table: "country",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreateAt",
                value: new DateTime(2025, 6, 8, 21, 23, 4, 209, DateTimeKind.Utc).AddTicks(8615));

            migrationBuilder.UpdateData(
                table: "country",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreateAt",
                value: new DateTime(2025, 6, 8, 21, 23, 4, 209, DateTimeKind.Utc).AddTicks(8725));

            migrationBuilder.AddForeignKey(
                name: "FK_seller_company_CompanyId",
                table: "seller",
                column: "CompanyId",
                principalTable: "company",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_seller_company_CompanyId",
                table: "seller");

            migrationBuilder.AlterColumn<int>(
                name: "CompanyId",
                table: "seller",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2025, 6, 8, 21, 9, 51, 601, DateTimeKind.Utc).AddTicks(382));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2025, 6, 8, 21, 9, 51, 601, DateTimeKind.Utc).AddTicks(387));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2025, 6, 8, 21, 9, 51, 601, DateTimeKind.Utc).AddTicks(402));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2025, 6, 8, 21, 9, 51, 601, DateTimeKind.Utc).AddTicks(403));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2025, 6, 8, 21, 9, 51, 601, DateTimeKind.Utc).AddTicks(403));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateAt",
                value: new DateTime(2025, 6, 8, 21, 9, 51, 601, DateTimeKind.Utc).AddTicks(405));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateAt",
                value: new DateTime(2025, 6, 8, 21, 9, 51, 601, DateTimeKind.Utc).AddTicks(406));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateAt",
                value: new DateTime(2025, 6, 8, 21, 9, 51, 601, DateTimeKind.Utc).AddTicks(407));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreateAt",
                value: new DateTime(2025, 6, 8, 21, 9, 51, 601, DateTimeKind.Utc).AddTicks(408));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreateAt",
                value: new DateTime(2025, 6, 8, 21, 9, 51, 601, DateTimeKind.Utc).AddTicks(409));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreateAt",
                value: new DateTime(2025, 6, 8, 21, 9, 51, 601, DateTimeKind.Utc).AddTicks(410));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreateAt",
                value: new DateTime(2025, 6, 8, 21, 9, 51, 601, DateTimeKind.Utc).AddTicks(410));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreateAt",
                value: new DateTime(2025, 6, 8, 21, 9, 51, 601, DateTimeKind.Utc).AddTicks(411));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreateAt",
                value: new DateTime(2025, 6, 8, 21, 9, 51, 601, DateTimeKind.Utc).AddTicks(412));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreateAt",
                value: new DateTime(2025, 6, 8, 21, 9, 51, 601, DateTimeKind.Utc).AddTicks(412));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreateAt",
                value: new DateTime(2025, 6, 8, 21, 9, 51, 601, DateTimeKind.Utc).AddTicks(413));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreateAt",
                value: new DateTime(2025, 6, 8, 21, 9, 51, 601, DateTimeKind.Utc).AddTicks(414));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreateAt",
                value: new DateTime(2025, 6, 8, 21, 9, 51, 601, DateTimeKind.Utc).AddTicks(415));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreateAt",
                value: new DateTime(2025, 6, 8, 21, 9, 51, 601, DateTimeKind.Utc).AddTicks(416));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreateAt",
                value: new DateTime(2025, 6, 8, 21, 9, 51, 601, DateTimeKind.Utc).AddTicks(417));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreateAt",
                value: new DateTime(2025, 6, 8, 21, 9, 51, 601, DateTimeKind.Utc).AddTicks(417));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreateAt",
                value: new DateTime(2025, 6, 8, 21, 9, 51, 601, DateTimeKind.Utc).AddTicks(418));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreateAt",
                value: new DateTime(2025, 6, 8, 21, 9, 51, 601, DateTimeKind.Utc).AddTicks(419));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreateAt",
                value: new DateTime(2025, 6, 8, 21, 9, 51, 601, DateTimeKind.Utc).AddTicks(419));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreateAt",
                value: new DateTime(2025, 6, 8, 21, 9, 51, 601, DateTimeKind.Utc).AddTicks(420));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreateAt",
                value: new DateTime(2025, 6, 8, 21, 9, 51, 601, DateTimeKind.Utc).AddTicks(421));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreateAt",
                value: new DateTime(2025, 6, 8, 21, 9, 51, 601, DateTimeKind.Utc).AddTicks(421));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreateAt",
                value: new DateTime(2025, 6, 8, 21, 9, 51, 601, DateTimeKind.Utc).AddTicks(422));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreateAt",
                value: new DateTime(2025, 6, 8, 21, 9, 51, 601, DateTimeKind.Utc).AddTicks(423));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreateAt",
                value: new DateTime(2025, 6, 8, 21, 9, 51, 601, DateTimeKind.Utc).AddTicks(423));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreateAt",
                value: new DateTime(2025, 6, 8, 21, 9, 51, 601, DateTimeKind.Utc).AddTicks(424));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreateAt",
                value: new DateTime(2025, 6, 8, 21, 9, 51, 601, DateTimeKind.Utc).AddTicks(424));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreateAt",
                value: new DateTime(2025, 6, 8, 21, 9, 51, 601, DateTimeKind.Utc).AddTicks(425));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreateAt",
                value: new DateTime(2025, 6, 8, 21, 9, 51, 601, DateTimeKind.Utc).AddTicks(427));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreateAt",
                value: new DateTime(2025, 6, 8, 21, 9, 51, 601, DateTimeKind.Utc).AddTicks(427));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreateAt",
                value: new DateTime(2025, 6, 8, 21, 9, 51, 601, DateTimeKind.Utc).AddTicks(429));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreateAt",
                value: new DateTime(2025, 6, 8, 21, 9, 51, 601, DateTimeKind.Utc).AddTicks(429));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreateAt",
                value: new DateTime(2025, 6, 8, 21, 9, 51, 601, DateTimeKind.Utc).AddTicks(430));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreateAt",
                value: new DateTime(2025, 6, 8, 21, 9, 51, 601, DateTimeKind.Utc).AddTicks(431));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreateAt",
                value: new DateTime(2025, 6, 8, 21, 9, 51, 601, DateTimeKind.Utc).AddTicks(432));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreateAt",
                value: new DateTime(2025, 6, 8, 21, 9, 51, 601, DateTimeKind.Utc).AddTicks(432));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreateAt",
                value: new DateTime(2025, 6, 8, 21, 9, 51, 601, DateTimeKind.Utc).AddTicks(433));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreateAt",
                value: new DateTime(2025, 6, 8, 21, 9, 51, 601, DateTimeKind.Utc).AddTicks(433));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreateAt",
                value: new DateTime(2025, 6, 8, 21, 9, 51, 601, DateTimeKind.Utc).AddTicks(434));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreateAt",
                value: new DateTime(2025, 6, 8, 21, 9, 51, 601, DateTimeKind.Utc).AddTicks(435));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreateAt",
                value: new DateTime(2025, 6, 8, 21, 9, 51, 601, DateTimeKind.Utc).AddTicks(435));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreateAt",
                value: new DateTime(2025, 6, 8, 21, 9, 51, 601, DateTimeKind.Utc).AddTicks(436));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreateAt",
                value: new DateTime(2025, 6, 8, 21, 9, 51, 601, DateTimeKind.Utc).AddTicks(437));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreateAt",
                value: new DateTime(2025, 6, 8, 21, 9, 51, 601, DateTimeKind.Utc).AddTicks(437));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreateAt",
                value: new DateTime(2025, 6, 8, 21, 9, 51, 601, DateTimeKind.Utc).AddTicks(438));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreateAt",
                value: new DateTime(2025, 6, 8, 21, 9, 51, 601, DateTimeKind.Utc).AddTicks(439));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreateAt",
                value: new DateTime(2025, 6, 8, 21, 9, 51, 601, DateTimeKind.Utc).AddTicks(439));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreateAt",
                value: new DateTime(2025, 6, 8, 21, 9, 51, 601, DateTimeKind.Utc).AddTicks(440));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreateAt",
                value: new DateTime(2025, 6, 8, 21, 9, 51, 601, DateTimeKind.Utc).AddTicks(441));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreateAt",
                value: new DateTime(2025, 6, 8, 21, 9, 51, 601, DateTimeKind.Utc).AddTicks(441));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreateAt",
                value: new DateTime(2025, 6, 8, 21, 9, 51, 601, DateTimeKind.Utc).AddTicks(442));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreateAt",
                value: new DateTime(2025, 6, 8, 21, 9, 51, 601, DateTimeKind.Utc).AddTicks(443));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreateAt",
                value: new DateTime(2025, 6, 8, 21, 9, 51, 601, DateTimeKind.Utc).AddTicks(443));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreateAt",
                value: new DateTime(2025, 6, 8, 21, 9, 51, 601, DateTimeKind.Utc).AddTicks(444));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreateAt",
                value: new DateTime(2025, 6, 8, 21, 9, 51, 601, DateTimeKind.Utc).AddTicks(444));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreateAt",
                value: new DateTime(2025, 6, 8, 21, 9, 51, 601, DateTimeKind.Utc).AddTicks(445));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreateAt",
                value: new DateTime(2025, 6, 8, 21, 9, 51, 601, DateTimeKind.Utc).AddTicks(446));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreateAt",
                value: new DateTime(2025, 6, 8, 21, 9, 51, 601, DateTimeKind.Utc).AddTicks(446));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreateAt",
                value: new DateTime(2025, 6, 8, 21, 9, 51, 601, DateTimeKind.Utc).AddTicks(447));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreateAt",
                value: new DateTime(2025, 6, 8, 21, 9, 51, 601, DateTimeKind.Utc).AddTicks(448));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreateAt",
                value: new DateTime(2025, 6, 8, 21, 9, 51, 601, DateTimeKind.Utc).AddTicks(503));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreateAt",
                value: new DateTime(2025, 6, 8, 21, 9, 51, 601, DateTimeKind.Utc).AddTicks(504));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreateAt",
                value: new DateTime(2025, 6, 8, 21, 9, 51, 601, DateTimeKind.Utc).AddTicks(505));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreateAt",
                value: new DateTime(2025, 6, 8, 21, 9, 51, 601, DateTimeKind.Utc).AddTicks(506));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreateAt",
                value: new DateTime(2025, 6, 8, 21, 9, 51, 601, DateTimeKind.Utc).AddTicks(507));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreateAt",
                value: new DateTime(2025, 6, 8, 21, 9, 51, 601, DateTimeKind.Utc).AddTicks(507));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreateAt",
                value: new DateTime(2025, 6, 8, 21, 9, 51, 601, DateTimeKind.Utc).AddTicks(508));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreateAt",
                value: new DateTime(2025, 6, 8, 21, 9, 51, 601, DateTimeKind.Utc).AddTicks(509));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreateAt",
                value: new DateTime(2025, 6, 8, 21, 9, 51, 601, DateTimeKind.Utc).AddTicks(509));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreateAt",
                value: new DateTime(2025, 6, 8, 21, 9, 51, 601, DateTimeKind.Utc).AddTicks(510));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 76,
                column: "CreateAt",
                value: new DateTime(2025, 6, 8, 21, 9, 51, 601, DateTimeKind.Utc).AddTicks(511));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 77,
                column: "CreateAt",
                value: new DateTime(2025, 6, 8, 21, 9, 51, 601, DateTimeKind.Utc).AddTicks(511));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 78,
                column: "CreateAt",
                value: new DateTime(2025, 6, 8, 21, 9, 51, 601, DateTimeKind.Utc).AddTicks(512));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 79,
                column: "CreateAt",
                value: new DateTime(2025, 6, 8, 21, 9, 51, 601, DateTimeKind.Utc).AddTicks(513));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 80,
                column: "CreateAt",
                value: new DateTime(2025, 6, 8, 21, 9, 51, 601, DateTimeKind.Utc).AddTicks(513));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 81,
                column: "CreateAt",
                value: new DateTime(2025, 6, 8, 21, 9, 51, 601, DateTimeKind.Utc).AddTicks(514));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 82,
                column: "CreateAt",
                value: new DateTime(2025, 6, 8, 21, 9, 51, 601, DateTimeKind.Utc).AddTicks(515));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 83,
                column: "CreateAt",
                value: new DateTime(2025, 6, 8, 21, 9, 51, 601, DateTimeKind.Utc).AddTicks(515));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 84,
                column: "CreateAt",
                value: new DateTime(2025, 6, 8, 21, 9, 51, 601, DateTimeKind.Utc).AddTicks(516));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 85,
                column: "CreateAt",
                value: new DateTime(2025, 6, 8, 21, 9, 51, 601, DateTimeKind.Utc).AddTicks(517));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 86,
                column: "CreateAt",
                value: new DateTime(2025, 6, 8, 21, 9, 51, 601, DateTimeKind.Utc).AddTicks(517));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 87,
                column: "CreateAt",
                value: new DateTime(2025, 6, 8, 21, 9, 51, 601, DateTimeKind.Utc).AddTicks(518));

            migrationBuilder.UpdateData(
                table: "country",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2025, 6, 8, 21, 9, 51, 601, DateTimeKind.Utc).AddTicks(645));

            migrationBuilder.UpdateData(
                table: "country",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2025, 6, 8, 21, 9, 51, 601, DateTimeKind.Utc).AddTicks(648));

            migrationBuilder.UpdateData(
                table: "country",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2025, 6, 8, 21, 9, 51, 601, DateTimeKind.Utc).AddTicks(649));

            migrationBuilder.UpdateData(
                table: "country",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2025, 6, 8, 21, 9, 51, 601, DateTimeKind.Utc).AddTicks(650));

            migrationBuilder.UpdateData(
                table: "country",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2025, 6, 8, 21, 9, 51, 601, DateTimeKind.Utc).AddTicks(651));

            migrationBuilder.UpdateData(
                table: "country",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateAt",
                value: new DateTime(2025, 6, 8, 21, 9, 51, 601, DateTimeKind.Utc).AddTicks(653));

            migrationBuilder.UpdateData(
                table: "country",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateAt",
                value: new DateTime(2025, 6, 8, 21, 9, 51, 601, DateTimeKind.Utc).AddTicks(653));

            migrationBuilder.UpdateData(
                table: "country",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateAt",
                value: new DateTime(2025, 6, 8, 21, 9, 51, 601, DateTimeKind.Utc).AddTicks(654));

            migrationBuilder.UpdateData(
                table: "country",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreateAt",
                value: new DateTime(2025, 6, 8, 21, 9, 51, 601, DateTimeKind.Utc).AddTicks(655));

            migrationBuilder.UpdateData(
                table: "country",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreateAt",
                value: new DateTime(2025, 6, 8, 21, 9, 51, 601, DateTimeKind.Utc).AddTicks(657));

            migrationBuilder.UpdateData(
                table: "country",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreateAt",
                value: new DateTime(2025, 6, 8, 21, 9, 51, 601, DateTimeKind.Utc).AddTicks(657));

            migrationBuilder.UpdateData(
                table: "country",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreateAt",
                value: new DateTime(2025, 6, 8, 21, 9, 51, 601, DateTimeKind.Utc).AddTicks(658));

            migrationBuilder.UpdateData(
                table: "country",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreateAt",
                value: new DateTime(2025, 6, 8, 21, 9, 51, 601, DateTimeKind.Utc).AddTicks(659));

            migrationBuilder.UpdateData(
                table: "country",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreateAt",
                value: new DateTime(2025, 6, 8, 21, 9, 51, 601, DateTimeKind.Utc).AddTicks(660));

            migrationBuilder.UpdateData(
                table: "country",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreateAt",
                value: new DateTime(2025, 6, 8, 21, 9, 51, 601, DateTimeKind.Utc).AddTicks(661));

            migrationBuilder.UpdateData(
                table: "country",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreateAt",
                value: new DateTime(2025, 6, 8, 21, 9, 51, 601, DateTimeKind.Utc).AddTicks(661));

            migrationBuilder.UpdateData(
                table: "country",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreateAt",
                value: new DateTime(2025, 6, 8, 21, 9, 51, 601, DateTimeKind.Utc).AddTicks(662));

            migrationBuilder.UpdateData(
                table: "country",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreateAt",
                value: new DateTime(2025, 6, 8, 21, 9, 51, 601, DateTimeKind.Utc).AddTicks(716));

            migrationBuilder.UpdateData(
                table: "country",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreateAt",
                value: new DateTime(2025, 6, 8, 21, 9, 51, 601, DateTimeKind.Utc).AddTicks(717));

            migrationBuilder.AddForeignKey(
                name: "FK_seller_company_CompanyId",
                table: "seller",
                column: "CompanyId",
                principalTable: "company",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
