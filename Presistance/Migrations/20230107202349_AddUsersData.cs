using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Presistance.Migrations
{
    /// <inheritdoc />
    public partial class AddUsersData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4ddb7071-40ad-4a51-aeff-39f611aee3cf");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("2c76607e-f46f-4ad2-8ea8-d55c8407bd17"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c4d41bfc-0ca8-4a1d-ade0-607fa3131914"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d292fe6e-cc0c-4a61-a9c4-223bd0565ac7"));

            migrationBuilder.DeleteData(
                table: "ProductBrands",
                keyColumn: "Id",
                keyValue: new Guid("15ca1443-27a4-4f04-91b0-2e1c17c33fde"));

            migrationBuilder.DeleteData(
                table: "ProductBrands",
                keyColumn: "Id",
                keyValue: new Guid("61748f41-1e0f-49f6-8bc3-318c42e3cf8f"));

            migrationBuilder.DeleteData(
                table: "ProductBrands",
                keyColumn: "Id",
                keyValue: new Guid("6efa7777-6c4d-47ee-930a-ae508239256d"));

            migrationBuilder.DeleteData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: new Guid("3cebc6c7-4ee4-4130-81db-fd752e3ca86b"));

            migrationBuilder.DeleteData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: new Guid("5ada2b42-6795-4195-a3e3-0e4c7dc5bc57"));

            migrationBuilder.DeleteData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: new Guid("7e06bb66-7c77-413a-b3c4-6c54a0de1ea8"));

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "4ddb7071-40ad-4a51-aeff-39f611aee3cf", 0, null, "e3b85295-9a98-49ee-8494-061409256fd3", "hassanhemdan92@gmail.com", false, "Hassan", "Hemdan", false, null, null, null, null, null, false, "c2c58345-c331-46e7-802f-cc0c30b15a7a", false, "Hassan Hemdan" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedBy", "CreatedOn", "Name" },
                values: new object[,]
                {
                    { new Guid("2c76607e-f46f-4ad2-8ea8-d55c8407bd17"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2023, 1, 7, 13, 7, 28, 898, DateTimeKind.Local).AddTicks(4637), "Mobiles" },
                    { new Guid("c4d41bfc-0ca8-4a1d-ade0-607fa3131914"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2023, 1, 7, 13, 7, 28, 898, DateTimeKind.Local).AddTicks(4684), "Tvs" },
                    { new Guid("d292fe6e-cc0c-4a61-a9c4-223bd0565ac7"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2023, 1, 7, 13, 7, 28, 898, DateTimeKind.Local).AddTicks(4687), "Watches" }
                });

            migrationBuilder.InsertData(
                table: "ProductBrands",
                columns: new[] { "Id", "CreatedBy", "CreatedOn", "Name" },
                values: new object[,]
                {
                    { new Guid("15ca1443-27a4-4f04-91b0-2e1c17c33fde"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2023, 1, 7, 13, 7, 28, 898, DateTimeKind.Local).AddTicks(4878), "Apple" },
                    { new Guid("61748f41-1e0f-49f6-8bc3-318c42e3cf8f"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2023, 1, 7, 13, 7, 28, 898, DateTimeKind.Local).AddTicks(4882), "Samsung" },
                    { new Guid("6efa7777-6c4d-47ee-930a-ae508239256d"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2023, 1, 7, 13, 7, 28, 898, DateTimeKind.Local).AddTicks(4884), "Nokia" }
                });

            migrationBuilder.InsertData(
                table: "ProductTypes",
                columns: new[] { "Id", "CreatedBy", "CreatedOn", "Name" },
                values: new object[,]
                {
                    { new Guid("3cebc6c7-4ee4-4130-81db-fd752e3ca86b"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2023, 1, 7, 13, 7, 28, 898, DateTimeKind.Local).AddTicks(4855), "ProductType 1" },
                    { new Guid("5ada2b42-6795-4195-a3e3-0e4c7dc5bc57"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2023, 1, 7, 13, 7, 28, 898, DateTimeKind.Local).AddTicks(4859), "ProductType 2" },
                    { new Guid("7e06bb66-7c77-413a-b3c4-6c54a0de1ea8"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2023, 1, 7, 13, 7, 28, 898, DateTimeKind.Local).AddTicks(4861), "ProductType 3" }
                });
        }
    }
}
