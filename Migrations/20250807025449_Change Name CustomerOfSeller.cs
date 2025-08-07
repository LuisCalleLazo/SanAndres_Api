using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SanAndres_Api.Migrations
{
    /// <inheritdoc />
    public partial class ChangeNameCustomerOfSeller : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CustomerOfSellers_seller_SellerId",
                table: "CustomerOfSellers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CustomerOfSellers",
                table: "CustomerOfSellers");

            migrationBuilder.RenameTable(
                name: "CustomerOfSellers",
                newName: "customer_of_seller");

            migrationBuilder.RenameIndex(
                name: "IX_CustomerOfSellers_SellerId",
                table: "customer_of_seller",
                newName: "IX_customer_of_seller_SellerId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_customer_of_seller",
                table: "customer_of_seller",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2025, 8, 7, 2, 54, 49, 480, DateTimeKind.Utc).AddTicks(3677));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2025, 8, 7, 2, 54, 49, 480, DateTimeKind.Utc).AddTicks(3683));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2025, 8, 7, 2, 54, 49, 480, DateTimeKind.Utc).AddTicks(3684));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2025, 8, 7, 2, 54, 49, 480, DateTimeKind.Utc).AddTicks(3685));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2025, 8, 7, 2, 54, 49, 480, DateTimeKind.Utc).AddTicks(3686));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateAt",
                value: new DateTime(2025, 8, 7, 2, 54, 49, 480, DateTimeKind.Utc).AddTicks(3688));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateAt",
                value: new DateTime(2025, 8, 7, 2, 54, 49, 480, DateTimeKind.Utc).AddTicks(3689));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateAt",
                value: new DateTime(2025, 8, 7, 2, 54, 49, 480, DateTimeKind.Utc).AddTicks(3690));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreateAt",
                value: new DateTime(2025, 8, 7, 2, 54, 49, 480, DateTimeKind.Utc).AddTicks(3690));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreateAt",
                value: new DateTime(2025, 8, 7, 2, 54, 49, 480, DateTimeKind.Utc).AddTicks(3692));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreateAt",
                value: new DateTime(2025, 8, 7, 2, 54, 49, 480, DateTimeKind.Utc).AddTicks(3693));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreateAt",
                value: new DateTime(2025, 8, 7, 2, 54, 49, 480, DateTimeKind.Utc).AddTicks(3694));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreateAt",
                value: new DateTime(2025, 8, 7, 2, 54, 49, 480, DateTimeKind.Utc).AddTicks(3695));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreateAt",
                value: new DateTime(2025, 8, 7, 2, 54, 49, 480, DateTimeKind.Utc).AddTicks(3695));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreateAt",
                value: new DateTime(2025, 8, 7, 2, 54, 49, 480, DateTimeKind.Utc).AddTicks(3696));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreateAt",
                value: new DateTime(2025, 8, 7, 2, 54, 49, 480, DateTimeKind.Utc).AddTicks(3697));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreateAt",
                value: new DateTime(2025, 8, 7, 2, 54, 49, 480, DateTimeKind.Utc).AddTicks(3698));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreateAt",
                value: new DateTime(2025, 8, 7, 2, 54, 49, 480, DateTimeKind.Utc).AddTicks(3699));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreateAt",
                value: new DateTime(2025, 8, 7, 2, 54, 49, 480, DateTimeKind.Utc).AddTicks(3700));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreateAt",
                value: new DateTime(2025, 8, 7, 2, 54, 49, 480, DateTimeKind.Utc).AddTicks(3701));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreateAt",
                value: new DateTime(2025, 8, 7, 2, 54, 49, 480, DateTimeKind.Utc).AddTicks(3702));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreateAt",
                value: new DateTime(2025, 8, 7, 2, 54, 49, 480, DateTimeKind.Utc).AddTicks(3702));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreateAt",
                value: new DateTime(2025, 8, 7, 2, 54, 49, 480, DateTimeKind.Utc).AddTicks(3703));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreateAt",
                value: new DateTime(2025, 8, 7, 2, 54, 49, 480, DateTimeKind.Utc).AddTicks(3704));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreateAt",
                value: new DateTime(2025, 8, 7, 2, 54, 49, 480, DateTimeKind.Utc).AddTicks(3705));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreateAt",
                value: new DateTime(2025, 8, 7, 2, 54, 49, 480, DateTimeKind.Utc).AddTicks(3706));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreateAt",
                value: new DateTime(2025, 8, 7, 2, 54, 49, 480, DateTimeKind.Utc).AddTicks(3706));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreateAt",
                value: new DateTime(2025, 8, 7, 2, 54, 49, 480, DateTimeKind.Utc).AddTicks(3707));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreateAt",
                value: new DateTime(2025, 8, 7, 2, 54, 49, 480, DateTimeKind.Utc).AddTicks(3708));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreateAt",
                value: new DateTime(2025, 8, 7, 2, 54, 49, 480, DateTimeKind.Utc).AddTicks(3709));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreateAt",
                value: new DateTime(2025, 8, 7, 2, 54, 49, 480, DateTimeKind.Utc).AddTicks(3709));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreateAt",
                value: new DateTime(2025, 8, 7, 2, 54, 49, 480, DateTimeKind.Utc).AddTicks(3710));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreateAt",
                value: new DateTime(2025, 8, 7, 2, 54, 49, 480, DateTimeKind.Utc).AddTicks(3711));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreateAt",
                value: new DateTime(2025, 8, 7, 2, 54, 49, 480, DateTimeKind.Utc).AddTicks(3713));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreateAt",
                value: new DateTime(2025, 8, 7, 2, 54, 49, 480, DateTimeKind.Utc).AddTicks(3713));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreateAt",
                value: new DateTime(2025, 8, 7, 2, 54, 49, 480, DateTimeKind.Utc).AddTicks(3714));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreateAt",
                value: new DateTime(2025, 8, 7, 2, 54, 49, 480, DateTimeKind.Utc).AddTicks(3715));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreateAt",
                value: new DateTime(2025, 8, 7, 2, 54, 49, 480, DateTimeKind.Utc).AddTicks(3715));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreateAt",
                value: new DateTime(2025, 8, 7, 2, 54, 49, 480, DateTimeKind.Utc).AddTicks(3716));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreateAt",
                value: new DateTime(2025, 8, 7, 2, 54, 49, 480, DateTimeKind.Utc).AddTicks(3718));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreateAt",
                value: new DateTime(2025, 8, 7, 2, 54, 49, 480, DateTimeKind.Utc).AddTicks(3719));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreateAt",
                value: new DateTime(2025, 8, 7, 2, 54, 49, 480, DateTimeKind.Utc).AddTicks(3719));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreateAt",
                value: new DateTime(2025, 8, 7, 2, 54, 49, 480, DateTimeKind.Utc).AddTicks(3720));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreateAt",
                value: new DateTime(2025, 8, 7, 2, 54, 49, 480, DateTimeKind.Utc).AddTicks(3721));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreateAt",
                value: new DateTime(2025, 8, 7, 2, 54, 49, 480, DateTimeKind.Utc).AddTicks(3746));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreateAt",
                value: new DateTime(2025, 8, 7, 2, 54, 49, 480, DateTimeKind.Utc).AddTicks(3747));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreateAt",
                value: new DateTime(2025, 8, 7, 2, 54, 49, 480, DateTimeKind.Utc).AddTicks(3748));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreateAt",
                value: new DateTime(2025, 8, 7, 2, 54, 49, 480, DateTimeKind.Utc).AddTicks(3749));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreateAt",
                value: new DateTime(2025, 8, 7, 2, 54, 49, 480, DateTimeKind.Utc).AddTicks(3750));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreateAt",
                value: new DateTime(2025, 8, 7, 2, 54, 49, 480, DateTimeKind.Utc).AddTicks(3751));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreateAt",
                value: new DateTime(2025, 8, 7, 2, 54, 49, 480, DateTimeKind.Utc).AddTicks(3751));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreateAt",
                value: new DateTime(2025, 8, 7, 2, 54, 49, 480, DateTimeKind.Utc).AddTicks(3752));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreateAt",
                value: new DateTime(2025, 8, 7, 2, 54, 49, 480, DateTimeKind.Utc).AddTicks(3753));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreateAt",
                value: new DateTime(2025, 8, 7, 2, 54, 49, 480, DateTimeKind.Utc).AddTicks(3754));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreateAt",
                value: new DateTime(2025, 8, 7, 2, 54, 49, 480, DateTimeKind.Utc).AddTicks(3755));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreateAt",
                value: new DateTime(2025, 8, 7, 2, 54, 49, 480, DateTimeKind.Utc).AddTicks(3755));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreateAt",
                value: new DateTime(2025, 8, 7, 2, 54, 49, 480, DateTimeKind.Utc).AddTicks(3756));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreateAt",
                value: new DateTime(2025, 8, 7, 2, 54, 49, 480, DateTimeKind.Utc).AddTicks(3757));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreateAt",
                value: new DateTime(2025, 8, 7, 2, 54, 49, 480, DateTimeKind.Utc).AddTicks(3758));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreateAt",
                value: new DateTime(2025, 8, 7, 2, 54, 49, 480, DateTimeKind.Utc).AddTicks(3758));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreateAt",
                value: new DateTime(2025, 8, 7, 2, 54, 49, 480, DateTimeKind.Utc).AddTicks(3759));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreateAt",
                value: new DateTime(2025, 8, 7, 2, 54, 49, 480, DateTimeKind.Utc).AddTicks(3760));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreateAt",
                value: new DateTime(2025, 8, 7, 2, 54, 49, 480, DateTimeKind.Utc).AddTicks(3761));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreateAt",
                value: new DateTime(2025, 8, 7, 2, 54, 49, 480, DateTimeKind.Utc).AddTicks(3761));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreateAt",
                value: new DateTime(2025, 8, 7, 2, 54, 49, 480, DateTimeKind.Utc).AddTicks(3762));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreateAt",
                value: new DateTime(2025, 8, 7, 2, 54, 49, 480, DateTimeKind.Utc).AddTicks(3764));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreateAt",
                value: new DateTime(2025, 8, 7, 2, 54, 49, 480, DateTimeKind.Utc).AddTicks(3764));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreateAt",
                value: new DateTime(2025, 8, 7, 2, 54, 49, 480, DateTimeKind.Utc).AddTicks(3765));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreateAt",
                value: new DateTime(2025, 8, 7, 2, 54, 49, 480, DateTimeKind.Utc).AddTicks(3766));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreateAt",
                value: new DateTime(2025, 8, 7, 2, 54, 49, 480, DateTimeKind.Utc).AddTicks(3767));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreateAt",
                value: new DateTime(2025, 8, 7, 2, 54, 49, 480, DateTimeKind.Utc).AddTicks(3767));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreateAt",
                value: new DateTime(2025, 8, 7, 2, 54, 49, 480, DateTimeKind.Utc).AddTicks(3768));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreateAt",
                value: new DateTime(2025, 8, 7, 2, 54, 49, 480, DateTimeKind.Utc).AddTicks(3769));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreateAt",
                value: new DateTime(2025, 8, 7, 2, 54, 49, 480, DateTimeKind.Utc).AddTicks(3769));

            migrationBuilder.UpdateData(
                table: "autopart_brand",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreateAt",
                value: new DateTime(2025, 8, 7, 2, 54, 49, 480, DateTimeKind.Utc).AddTicks(3770));

            migrationBuilder.UpdateData(
                table: "autopart_type_info",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2025, 8, 7, 2, 54, 49, 480, DateTimeKind.Utc).AddTicks(7773));

            migrationBuilder.UpdateData(
                table: "autopart_type_info",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2025, 8, 7, 2, 54, 49, 480, DateTimeKind.Utc).AddTicks(7811));

            migrationBuilder.UpdateData(
                table: "autopart_type_info",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2025, 8, 7, 2, 54, 49, 480, DateTimeKind.Utc).AddTicks(7812));

            migrationBuilder.UpdateData(
                table: "autopart_type_info",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2025, 8, 7, 2, 54, 49, 480, DateTimeKind.Utc).AddTicks(7813));

            migrationBuilder.UpdateData(
                table: "autopart_type_info",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2025, 8, 7, 2, 54, 49, 480, DateTimeKind.Utc).AddTicks(7814));

            migrationBuilder.UpdateData(
                table: "autopart_type_info",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateAt",
                value: new DateTime(2025, 8, 7, 2, 54, 49, 480, DateTimeKind.Utc).AddTicks(7816));

            migrationBuilder.UpdateData(
                table: "autopart_type_info",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateAt",
                value: new DateTime(2025, 8, 7, 2, 54, 49, 480, DateTimeKind.Utc).AddTicks(7817));

            migrationBuilder.UpdateData(
                table: "autopart_type_info",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateAt",
                value: new DateTime(2025, 8, 7, 2, 54, 49, 480, DateTimeKind.Utc).AddTicks(7817));

            migrationBuilder.UpdateData(
                table: "autopart_type_info",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreateAt",
                value: new DateTime(2025, 8, 7, 2, 54, 49, 480, DateTimeKind.Utc).AddTicks(7818));

            migrationBuilder.UpdateData(
                table: "autopart_type_info",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreateAt",
                value: new DateTime(2025, 8, 7, 2, 54, 49, 480, DateTimeKind.Utc).AddTicks(7820));

            migrationBuilder.UpdateData(
                table: "autopart_type_info",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreateAt",
                value: new DateTime(2025, 8, 7, 2, 54, 49, 480, DateTimeKind.Utc).AddTicks(7821));

            migrationBuilder.UpdateData(
                table: "autopart_type_info",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreateAt",
                value: new DateTime(2025, 8, 7, 2, 54, 49, 480, DateTimeKind.Utc).AddTicks(7821));

            migrationBuilder.UpdateData(
                table: "autopart_type_info",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreateAt",
                value: new DateTime(2025, 8, 7, 2, 54, 49, 480, DateTimeKind.Utc).AddTicks(7822));

            migrationBuilder.UpdateData(
                table: "autopart_type_info",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreateAt",
                value: new DateTime(2025, 8, 7, 2, 54, 49, 480, DateTimeKind.Utc).AddTicks(7823));

            migrationBuilder.UpdateData(
                table: "category",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2025, 8, 7, 2, 54, 49, 479, DateTimeKind.Utc).AddTicks(8760));

            migrationBuilder.UpdateData(
                table: "category",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2025, 8, 7, 2, 54, 49, 479, DateTimeKind.Utc).AddTicks(8764));

            migrationBuilder.UpdateData(
                table: "category",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2025, 8, 7, 2, 54, 49, 479, DateTimeKind.Utc).AddTicks(8797));

            migrationBuilder.UpdateData(
                table: "category",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2025, 8, 7, 2, 54, 49, 479, DateTimeKind.Utc).AddTicks(8799));

            migrationBuilder.UpdateData(
                table: "category",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2025, 8, 7, 2, 54, 49, 479, DateTimeKind.Utc).AddTicks(8800));

            migrationBuilder.UpdateData(
                table: "category",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateAt",
                value: new DateTime(2025, 8, 7, 2, 54, 49, 479, DateTimeKind.Utc).AddTicks(8803));

            migrationBuilder.UpdateData(
                table: "category",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateAt",
                value: new DateTime(2025, 8, 7, 2, 54, 49, 479, DateTimeKind.Utc).AddTicks(8804));

            migrationBuilder.UpdateData(
                table: "category",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateAt",
                value: new DateTime(2025, 8, 7, 2, 54, 49, 479, DateTimeKind.Utc).AddTicks(8805));

            migrationBuilder.UpdateData(
                table: "category",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreateAt",
                value: new DateTime(2025, 8, 7, 2, 54, 49, 479, DateTimeKind.Utc).AddTicks(8806));

            migrationBuilder.UpdateData(
                table: "category",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreateAt",
                value: new DateTime(2025, 8, 7, 2, 54, 49, 479, DateTimeKind.Utc).AddTicks(8808));

            migrationBuilder.UpdateData(
                table: "category",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreateAt",
                value: new DateTime(2025, 8, 7, 2, 54, 49, 479, DateTimeKind.Utc).AddTicks(8809));

            migrationBuilder.UpdateData(
                table: "category",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreateAt",
                value: new DateTime(2025, 8, 7, 2, 54, 49, 479, DateTimeKind.Utc).AddTicks(8810));

            migrationBuilder.UpdateData(
                table: "category",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreateAt",
                value: new DateTime(2025, 8, 7, 2, 54, 49, 479, DateTimeKind.Utc).AddTicks(8811));

            migrationBuilder.UpdateData(
                table: "category",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreateAt",
                value: new DateTime(2025, 8, 7, 2, 54, 49, 479, DateTimeKind.Utc).AddTicks(8812));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2025, 8, 7, 2, 54, 49, 479, DateTimeKind.Utc).AddTicks(3464));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2025, 8, 7, 2, 54, 49, 479, DateTimeKind.Utc).AddTicks(3522));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2025, 8, 7, 2, 54, 49, 479, DateTimeKind.Utc).AddTicks(3524));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2025, 8, 7, 2, 54, 49, 479, DateTimeKind.Utc).AddTicks(3525));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2025, 8, 7, 2, 54, 49, 479, DateTimeKind.Utc).AddTicks(3526));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateAt",
                value: new DateTime(2025, 8, 7, 2, 54, 49, 479, DateTimeKind.Utc).AddTicks(3528));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateAt",
                value: new DateTime(2025, 8, 7, 2, 54, 49, 479, DateTimeKind.Utc).AddTicks(3529));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateAt",
                value: new DateTime(2025, 8, 7, 2, 54, 49, 479, DateTimeKind.Utc).AddTicks(3530));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreateAt",
                value: new DateTime(2025, 8, 7, 2, 54, 49, 479, DateTimeKind.Utc).AddTicks(3531));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreateAt",
                value: new DateTime(2025, 8, 7, 2, 54, 49, 479, DateTimeKind.Utc).AddTicks(3533));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreateAt",
                value: new DateTime(2025, 8, 7, 2, 54, 49, 479, DateTimeKind.Utc).AddTicks(3534));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreateAt",
                value: new DateTime(2025, 8, 7, 2, 54, 49, 479, DateTimeKind.Utc).AddTicks(3535));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreateAt",
                value: new DateTime(2025, 8, 7, 2, 54, 49, 479, DateTimeKind.Utc).AddTicks(3536));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreateAt",
                value: new DateTime(2025, 8, 7, 2, 54, 49, 479, DateTimeKind.Utc).AddTicks(3537));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreateAt",
                value: new DateTime(2025, 8, 7, 2, 54, 49, 479, DateTimeKind.Utc).AddTicks(3538));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreateAt",
                value: new DateTime(2025, 8, 7, 2, 54, 49, 479, DateTimeKind.Utc).AddTicks(3539));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreateAt",
                value: new DateTime(2025, 8, 7, 2, 54, 49, 479, DateTimeKind.Utc).AddTicks(3540));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreateAt",
                value: new DateTime(2025, 8, 7, 2, 54, 49, 479, DateTimeKind.Utc).AddTicks(3542));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreateAt",
                value: new DateTime(2025, 8, 7, 2, 54, 49, 479, DateTimeKind.Utc).AddTicks(3543));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreateAt",
                value: new DateTime(2025, 8, 7, 2, 54, 49, 479, DateTimeKind.Utc).AddTicks(3544));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreateAt",
                value: new DateTime(2025, 8, 7, 2, 54, 49, 479, DateTimeKind.Utc).AddTicks(3545));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreateAt",
                value: new DateTime(2025, 8, 7, 2, 54, 49, 479, DateTimeKind.Utc).AddTicks(3545));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreateAt",
                value: new DateTime(2025, 8, 7, 2, 54, 49, 479, DateTimeKind.Utc).AddTicks(3546));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreateAt",
                value: new DateTime(2025, 8, 7, 2, 54, 49, 479, DateTimeKind.Utc).AddTicks(3547));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreateAt",
                value: new DateTime(2025, 8, 7, 2, 54, 49, 479, DateTimeKind.Utc).AddTicks(3548));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreateAt",
                value: new DateTime(2025, 8, 7, 2, 54, 49, 479, DateTimeKind.Utc).AddTicks(3549));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreateAt",
                value: new DateTime(2025, 8, 7, 2, 54, 49, 479, DateTimeKind.Utc).AddTicks(3550));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreateAt",
                value: new DateTime(2025, 8, 7, 2, 54, 49, 479, DateTimeKind.Utc).AddTicks(3551));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreateAt",
                value: new DateTime(2025, 8, 7, 2, 54, 49, 479, DateTimeKind.Utc).AddTicks(3552));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreateAt",
                value: new DateTime(2025, 8, 7, 2, 54, 49, 479, DateTimeKind.Utc).AddTicks(3553));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreateAt",
                value: new DateTime(2025, 8, 7, 2, 54, 49, 479, DateTimeKind.Utc).AddTicks(3553));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreateAt",
                value: new DateTime(2025, 8, 7, 2, 54, 49, 479, DateTimeKind.Utc).AddTicks(3554));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreateAt",
                value: new DateTime(2025, 8, 7, 2, 54, 49, 479, DateTimeKind.Utc).AddTicks(3555));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreateAt",
                value: new DateTime(2025, 8, 7, 2, 54, 49, 479, DateTimeKind.Utc).AddTicks(3557));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreateAt",
                value: new DateTime(2025, 8, 7, 2, 54, 49, 479, DateTimeKind.Utc).AddTicks(3558));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreateAt",
                value: new DateTime(2025, 8, 7, 2, 54, 49, 479, DateTimeKind.Utc).AddTicks(3559));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreateAt",
                value: new DateTime(2025, 8, 7, 2, 54, 49, 479, DateTimeKind.Utc).AddTicks(3560));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreateAt",
                value: new DateTime(2025, 8, 7, 2, 54, 49, 479, DateTimeKind.Utc).AddTicks(3561));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreateAt",
                value: new DateTime(2025, 8, 7, 2, 54, 49, 479, DateTimeKind.Utc).AddTicks(3562));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreateAt",
                value: new DateTime(2025, 8, 7, 2, 54, 49, 479, DateTimeKind.Utc).AddTicks(3563));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreateAt",
                value: new DateTime(2025, 8, 7, 2, 54, 49, 479, DateTimeKind.Utc).AddTicks(3564));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreateAt",
                value: new DateTime(2025, 8, 7, 2, 54, 49, 479, DateTimeKind.Utc).AddTicks(3565));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreateAt",
                value: new DateTime(2025, 8, 7, 2, 54, 49, 479, DateTimeKind.Utc).AddTicks(3566));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreateAt",
                value: new DateTime(2025, 8, 7, 2, 54, 49, 479, DateTimeKind.Utc).AddTicks(3566));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreateAt",
                value: new DateTime(2025, 8, 7, 2, 54, 49, 479, DateTimeKind.Utc).AddTicks(3567));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreateAt",
                value: new DateTime(2025, 8, 7, 2, 54, 49, 479, DateTimeKind.Utc).AddTicks(3568));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreateAt",
                value: new DateTime(2025, 8, 7, 2, 54, 49, 479, DateTimeKind.Utc).AddTicks(3569));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreateAt",
                value: new DateTime(2025, 8, 7, 2, 54, 49, 479, DateTimeKind.Utc).AddTicks(3570));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreateAt",
                value: new DateTime(2025, 8, 7, 2, 54, 49, 479, DateTimeKind.Utc).AddTicks(3571));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreateAt",
                value: new DateTime(2025, 8, 7, 2, 54, 49, 479, DateTimeKind.Utc).AddTicks(3572));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreateAt",
                value: new DateTime(2025, 8, 7, 2, 54, 49, 479, DateTimeKind.Utc).AddTicks(3573));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreateAt",
                value: new DateTime(2025, 8, 7, 2, 54, 49, 479, DateTimeKind.Utc).AddTicks(3574));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreateAt",
                value: new DateTime(2025, 8, 7, 2, 54, 49, 479, DateTimeKind.Utc).AddTicks(3574));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreateAt",
                value: new DateTime(2025, 8, 7, 2, 54, 49, 479, DateTimeKind.Utc).AddTicks(3575));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreateAt",
                value: new DateTime(2025, 8, 7, 2, 54, 49, 479, DateTimeKind.Utc).AddTicks(3576));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreateAt",
                value: new DateTime(2025, 8, 7, 2, 54, 49, 479, DateTimeKind.Utc).AddTicks(3577));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreateAt",
                value: new DateTime(2025, 8, 7, 2, 54, 49, 479, DateTimeKind.Utc).AddTicks(3578));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreateAt",
                value: new DateTime(2025, 8, 7, 2, 54, 49, 479, DateTimeKind.Utc).AddTicks(3579));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreateAt",
                value: new DateTime(2025, 8, 7, 2, 54, 49, 479, DateTimeKind.Utc).AddTicks(3580));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreateAt",
                value: new DateTime(2025, 8, 7, 2, 54, 49, 479, DateTimeKind.Utc).AddTicks(3581));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreateAt",
                value: new DateTime(2025, 8, 7, 2, 54, 49, 479, DateTimeKind.Utc).AddTicks(3582));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreateAt",
                value: new DateTime(2025, 8, 7, 2, 54, 49, 479, DateTimeKind.Utc).AddTicks(3582));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreateAt",
                value: new DateTime(2025, 8, 7, 2, 54, 49, 479, DateTimeKind.Utc).AddTicks(3583));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreateAt",
                value: new DateTime(2025, 8, 7, 2, 54, 49, 479, DateTimeKind.Utc).AddTicks(3584));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreateAt",
                value: new DateTime(2025, 8, 7, 2, 54, 49, 479, DateTimeKind.Utc).AddTicks(3585));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreateAt",
                value: new DateTime(2025, 8, 7, 2, 54, 49, 479, DateTimeKind.Utc).AddTicks(3616));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreateAt",
                value: new DateTime(2025, 8, 7, 2, 54, 49, 479, DateTimeKind.Utc).AddTicks(3617));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreateAt",
                value: new DateTime(2025, 8, 7, 2, 54, 49, 479, DateTimeKind.Utc).AddTicks(3618));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreateAt",
                value: new DateTime(2025, 8, 7, 2, 54, 49, 479, DateTimeKind.Utc).AddTicks(3619));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreateAt",
                value: new DateTime(2025, 8, 7, 2, 54, 49, 479, DateTimeKind.Utc).AddTicks(3620));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreateAt",
                value: new DateTime(2025, 8, 7, 2, 54, 49, 479, DateTimeKind.Utc).AddTicks(3621));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreateAt",
                value: new DateTime(2025, 8, 7, 2, 54, 49, 479, DateTimeKind.Utc).AddTicks(3621));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreateAt",
                value: new DateTime(2025, 8, 7, 2, 54, 49, 479, DateTimeKind.Utc).AddTicks(3622));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreateAt",
                value: new DateTime(2025, 8, 7, 2, 54, 49, 479, DateTimeKind.Utc).AddTicks(3623));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreateAt",
                value: new DateTime(2025, 8, 7, 2, 54, 49, 479, DateTimeKind.Utc).AddTicks(3624));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 76,
                column: "CreateAt",
                value: new DateTime(2025, 8, 7, 2, 54, 49, 479, DateTimeKind.Utc).AddTicks(3625));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 77,
                column: "CreateAt",
                value: new DateTime(2025, 8, 7, 2, 54, 49, 479, DateTimeKind.Utc).AddTicks(3626));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 78,
                column: "CreateAt",
                value: new DateTime(2025, 8, 7, 2, 54, 49, 479, DateTimeKind.Utc).AddTicks(3627));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 79,
                column: "CreateAt",
                value: new DateTime(2025, 8, 7, 2, 54, 49, 479, DateTimeKind.Utc).AddTicks(3628));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 80,
                column: "CreateAt",
                value: new DateTime(2025, 8, 7, 2, 54, 49, 479, DateTimeKind.Utc).AddTicks(3629));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 81,
                column: "CreateAt",
                value: new DateTime(2025, 8, 7, 2, 54, 49, 479, DateTimeKind.Utc).AddTicks(3630));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 82,
                column: "CreateAt",
                value: new DateTime(2025, 8, 7, 2, 54, 49, 479, DateTimeKind.Utc).AddTicks(3630));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 83,
                column: "CreateAt",
                value: new DateTime(2025, 8, 7, 2, 54, 49, 479, DateTimeKind.Utc).AddTicks(3631));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 84,
                column: "CreateAt",
                value: new DateTime(2025, 8, 7, 2, 54, 49, 479, DateTimeKind.Utc).AddTicks(3632));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 85,
                column: "CreateAt",
                value: new DateTime(2025, 8, 7, 2, 54, 49, 479, DateTimeKind.Utc).AddTicks(3633));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 86,
                column: "CreateAt",
                value: new DateTime(2025, 8, 7, 2, 54, 49, 479, DateTimeKind.Utc).AddTicks(3634));

            migrationBuilder.UpdateData(
                table: "city",
                keyColumn: "Id",
                keyValue: 87,
                column: "CreateAt",
                value: new DateTime(2025, 8, 7, 2, 54, 49, 479, DateTimeKind.Utc).AddTicks(3635));

            migrationBuilder.UpdateData(
                table: "country",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2025, 8, 7, 2, 54, 49, 479, DateTimeKind.Utc).AddTicks(4079));

            migrationBuilder.UpdateData(
                table: "country",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2025, 8, 7, 2, 54, 49, 479, DateTimeKind.Utc).AddTicks(4083));

            migrationBuilder.UpdateData(
                table: "country",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2025, 8, 7, 2, 54, 49, 479, DateTimeKind.Utc).AddTicks(4085));

            migrationBuilder.UpdateData(
                table: "country",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2025, 8, 7, 2, 54, 49, 479, DateTimeKind.Utc).AddTicks(4086));

            migrationBuilder.UpdateData(
                table: "country",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2025, 8, 7, 2, 54, 49, 479, DateTimeKind.Utc).AddTicks(4087));

            migrationBuilder.UpdateData(
                table: "country",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateAt",
                value: new DateTime(2025, 8, 7, 2, 54, 49, 479, DateTimeKind.Utc).AddTicks(4089));

            migrationBuilder.UpdateData(
                table: "country",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateAt",
                value: new DateTime(2025, 8, 7, 2, 54, 49, 479, DateTimeKind.Utc).AddTicks(4090));

            migrationBuilder.UpdateData(
                table: "country",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateAt",
                value: new DateTime(2025, 8, 7, 2, 54, 49, 479, DateTimeKind.Utc).AddTicks(4091));

            migrationBuilder.UpdateData(
                table: "country",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreateAt",
                value: new DateTime(2025, 8, 7, 2, 54, 49, 479, DateTimeKind.Utc).AddTicks(4092));

            migrationBuilder.UpdateData(
                table: "country",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreateAt",
                value: new DateTime(2025, 8, 7, 2, 54, 49, 479, DateTimeKind.Utc).AddTicks(4094));

            migrationBuilder.UpdateData(
                table: "country",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreateAt",
                value: new DateTime(2025, 8, 7, 2, 54, 49, 479, DateTimeKind.Utc).AddTicks(4095));

            migrationBuilder.UpdateData(
                table: "country",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreateAt",
                value: new DateTime(2025, 8, 7, 2, 54, 49, 479, DateTimeKind.Utc).AddTicks(4096));

            migrationBuilder.UpdateData(
                table: "country",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreateAt",
                value: new DateTime(2025, 8, 7, 2, 54, 49, 479, DateTimeKind.Utc).AddTicks(4097));

            migrationBuilder.UpdateData(
                table: "country",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreateAt",
                value: new DateTime(2025, 8, 7, 2, 54, 49, 479, DateTimeKind.Utc).AddTicks(4098));

            migrationBuilder.UpdateData(
                table: "country",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreateAt",
                value: new DateTime(2025, 8, 7, 2, 54, 49, 479, DateTimeKind.Utc).AddTicks(4099));

            migrationBuilder.UpdateData(
                table: "country",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreateAt",
                value: new DateTime(2025, 8, 7, 2, 54, 49, 479, DateTimeKind.Utc).AddTicks(4100));

            migrationBuilder.UpdateData(
                table: "country",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreateAt",
                value: new DateTime(2025, 8, 7, 2, 54, 49, 479, DateTimeKind.Utc).AddTicks(4101));

            migrationBuilder.UpdateData(
                table: "country",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreateAt",
                value: new DateTime(2025, 8, 7, 2, 54, 49, 479, DateTimeKind.Utc).AddTicks(4140));

            migrationBuilder.UpdateData(
                table: "country",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreateAt",
                value: new DateTime(2025, 8, 7, 2, 54, 49, 479, DateTimeKind.Utc).AddTicks(4141));

            migrationBuilder.AddForeignKey(
                name: "FK_customer_of_seller_seller_SellerId",
                table: "customer_of_seller",
                column: "SellerId",
                principalTable: "seller",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_customer_of_seller_seller_SellerId",
                table: "customer_of_seller");

            migrationBuilder.DropPrimaryKey(
                name: "PK_customer_of_seller",
                table: "customer_of_seller");

            migrationBuilder.RenameTable(
                name: "customer_of_seller",
                newName: "CustomerOfSellers");

            migrationBuilder.RenameIndex(
                name: "IX_customer_of_seller_SellerId",
                table: "CustomerOfSellers",
                newName: "IX_CustomerOfSellers_SellerId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CustomerOfSellers",
                table: "CustomerOfSellers",
                column: "Id");

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

            migrationBuilder.AddForeignKey(
                name: "FK_CustomerOfSellers_seller_SellerId",
                table: "CustomerOfSellers",
                column: "SellerId",
                principalTable: "seller",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
