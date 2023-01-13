using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Presistance.Migrations
{
    /// <inheritdoc />
    public partial class Test : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("27a8c969-1f7b-4253-a69a-fb054669ec42"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("5b684242-a023-4cac-851b-aa129aa9dba6"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("666d9127-f0bd-48e9-9fbc-dc9cf257b522"));

            migrationBuilder.DeleteData(
                table: "ProductBrands",
                keyColumn: "Id",
                keyValue: new Guid("1f38ec05-3d12-4ae3-b674-31c0e3e6aa0f"));

            migrationBuilder.DeleteData(
                table: "ProductBrands",
                keyColumn: "Id",
                keyValue: new Guid("48ee7744-8046-4658-8c2c-354786871e89"));

            migrationBuilder.DeleteData(
                table: "ProductBrands",
                keyColumn: "Id",
                keyValue: new Guid("70bc1481-f0d0-40ef-8216-ce7ffb2ace41"));

            migrationBuilder.DeleteData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: new Guid("75e6524b-be27-4dd1-86f7-4f7c204e0162"));

            migrationBuilder.DeleteData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: new Guid("dcda2e96-74f4-4764-892e-443020a756bd"));

            migrationBuilder.DeleteData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: new Guid("eccf3730-c5d3-4719-b7ce-3033eacdf904"));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedBy", "CreatedOn", "Name" },
                values: new object[,]
                {
                    { new Guid("27a8c969-1f7b-4253-a69a-fb054669ec42"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2023, 1, 7, 22, 23, 49, 377, DateTimeKind.Local).AddTicks(9275), "Tvs" },
                    { new Guid("5b684242-a023-4cac-851b-aa129aa9dba6"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2023, 1, 7, 22, 23, 49, 377, DateTimeKind.Local).AddTicks(9278), "Watches" },
                    { new Guid("666d9127-f0bd-48e9-9fbc-dc9cf257b522"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2023, 1, 7, 22, 23, 49, 377, DateTimeKind.Local).AddTicks(9227), "Mobiles" }
                });

            migrationBuilder.InsertData(
                table: "ProductBrands",
                columns: new[] { "Id", "CreatedBy", "CreatedOn", "Name" },
                values: new object[,]
                {
                    { new Guid("1f38ec05-3d12-4ae3-b674-31c0e3e6aa0f"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2023, 1, 7, 22, 23, 49, 377, DateTimeKind.Local).AddTicks(9460), "Apple" },
                    { new Guid("48ee7744-8046-4658-8c2c-354786871e89"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2023, 1, 7, 22, 23, 49, 377, DateTimeKind.Local).AddTicks(9467), "Nokia" },
                    { new Guid("70bc1481-f0d0-40ef-8216-ce7ffb2ace41"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2023, 1, 7, 22, 23, 49, 377, DateTimeKind.Local).AddTicks(9465), "Samsung" }
                });

            migrationBuilder.InsertData(
                table: "ProductTypes",
                columns: new[] { "Id", "CreatedBy", "CreatedOn", "Name" },
                values: new object[,]
                {
                    { new Guid("75e6524b-be27-4dd1-86f7-4f7c204e0162"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2023, 1, 7, 22, 23, 49, 377, DateTimeKind.Local).AddTicks(9433), "ProductType 1" },
                    { new Guid("dcda2e96-74f4-4764-892e-443020a756bd"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2023, 1, 7, 22, 23, 49, 377, DateTimeKind.Local).AddTicks(9441), "ProductType 3" },
                    { new Guid("eccf3730-c5d3-4719-b7ce-3033eacdf904"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2023, 1, 7, 22, 23, 49, 377, DateTimeKind.Local).AddTicks(9438), "ProductType 2" }
                });
        }
    }
}
