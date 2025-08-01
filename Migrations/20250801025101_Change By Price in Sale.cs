using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SanAndres_Api.Migrations
{
    /// <inheritdoc />
    public partial class ChangeByPriceinSale : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UnitPrice",
                table: "sale");

            migrationBuilder.RenameColumn(
                name: "WholessalePrice",
                table: "sale",
                newName: "Price");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Price",
                table: "sale",
                newName: "WholessalePrice");

            migrationBuilder.AddColumn<decimal>(
                name: "UnitPrice",
                table: "sale",
                type: "numeric",
                nullable: false,
                defaultValue: 0m);

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
        }
    }
}
