using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Presistance.Migrations
{
    /// <inheritdoc />
    public partial class SeedInitialData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedBy", "CreatedOn", "Name" },
                values: new object[,]
                {
                    { new Guid("3c02a72d-6245-4dd3-a6a0-08202e5cf733"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2023, 1, 6, 13, 5, 38, 676, DateTimeKind.Local).AddTicks(3268), "Mobiles" },
                    { new Guid("72d9fbb6-fd2d-471d-9f59-8ceac8ce3159"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2023, 1, 6, 13, 5, 38, 676, DateTimeKind.Local).AddTicks(3340), "Tvs" },
                    { new Guid("f80beb6a-f931-4f99-8000-e1db05943080"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2023, 1, 6, 13, 5, 38, 676, DateTimeKind.Local).AddTicks(3343), "Watches" }
                });

            migrationBuilder.InsertData(
                table: "ProductBrands",
                columns: new[] { "Id", "CreatedBy", "CreatedOn", "Name" },
                values: new object[,]
                {
                    { new Guid("064f943f-ef0c-42cd-b866-09bac6136323"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2023, 1, 6, 13, 5, 38, 676, DateTimeKind.Local).AddTicks(3581), "Apple" },
                    { new Guid("c14cb589-ed2d-4849-a6b3-def30e0301e0"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2023, 1, 6, 13, 5, 38, 676, DateTimeKind.Local).AddTicks(3588), "Nokia" },
                    { new Guid("d96b5f53-42ab-42d3-9d5f-aa6d2916d90d"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2023, 1, 6, 13, 5, 38, 676, DateTimeKind.Local).AddTicks(3586), "Samsung" }
                });

            migrationBuilder.InsertData(
                table: "ProductTypes",
                columns: new[] { "Id", "CreatedBy", "CreatedOn", "Name" },
                values: new object[,]
                {
                    { new Guid("15d877d1-f4b1-4a25-9391-36174a0988b8"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2023, 1, 6, 13, 5, 38, 676, DateTimeKind.Local).AddTicks(3534), "ProductType 2" },
                    { new Guid("b28b4962-9f0e-42a6-86db-c176fdbc3089"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2023, 1, 6, 13, 5, 38, 676, DateTimeKind.Local).AddTicks(3536), "ProductType 3" },
                    { new Guid("d0d0c631-18f2-4d09-818e-f8160eaff75a"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2023, 1, 6, 13, 5, 38, 676, DateTimeKind.Local).AddTicks(3526), "ProductType 1" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("3c02a72d-6245-4dd3-a6a0-08202e5cf733"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("72d9fbb6-fd2d-471d-9f59-8ceac8ce3159"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f80beb6a-f931-4f99-8000-e1db05943080"));

            migrationBuilder.DeleteData(
                table: "ProductBrands",
                keyColumn: "Id",
                keyValue: new Guid("064f943f-ef0c-42cd-b866-09bac6136323"));

            migrationBuilder.DeleteData(
                table: "ProductBrands",
                keyColumn: "Id",
                keyValue: new Guid("c14cb589-ed2d-4849-a6b3-def30e0301e0"));

            migrationBuilder.DeleteData(
                table: "ProductBrands",
                keyColumn: "Id",
                keyValue: new Guid("d96b5f53-42ab-42d3-9d5f-aa6d2916d90d"));

            migrationBuilder.DeleteData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: new Guid("15d877d1-f4b1-4a25-9391-36174a0988b8"));

            migrationBuilder.DeleteData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: new Guid("b28b4962-9f0e-42a6-86db-c176fdbc3089"));

            migrationBuilder.DeleteData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: new Guid("d0d0c631-18f2-4d09-818e-f8160eaff75a"));
        }
    }
}
