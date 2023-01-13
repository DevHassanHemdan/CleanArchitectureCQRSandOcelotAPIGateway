using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Presistance.Migrations
{
    /// <inheritdoc />
    public partial class AddDataIdentityTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("23a1033c-fd9e-4d9d-8791-cc7482065a2f"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("69f46dec-731a-4c9a-b6ca-44376c14a096"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("fc8fb09a-e5f7-438c-98dc-171c893882c7"));

            migrationBuilder.DeleteData(
                table: "ProductBrands",
                keyColumn: "Id",
                keyValue: new Guid("ad5d3318-2b14-474f-93dd-bc5f2ea5a8b8"));

            migrationBuilder.DeleteData(
                table: "ProductBrands",
                keyColumn: "Id",
                keyValue: new Guid("c1191fb9-e9b5-4e87-8bb1-83fb752813c8"));

            migrationBuilder.DeleteData(
                table: "ProductBrands",
                keyColumn: "Id",
                keyValue: new Guid("ceb747d2-7e27-438e-9a6c-02d3f30febaa"));

            migrationBuilder.DeleteData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: new Guid("13eb50f1-7cae-4671-ab28-84733811df73"));

            migrationBuilder.DeleteData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: new Guid("42e4e58b-8059-4ada-afaf-7c2cb4050489"));

            migrationBuilder.DeleteData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: new Guid("bb889e62-f3bc-449e-bec0-dfd59db19e6f"));

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { new Guid("23a1033c-fd9e-4d9d-8791-cc7482065a2f"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2023, 1, 7, 12, 36, 32, 398, DateTimeKind.Local).AddTicks(979), "Tvs" },
                    { new Guid("69f46dec-731a-4c9a-b6ca-44376c14a096"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2023, 1, 7, 12, 36, 32, 398, DateTimeKind.Local).AddTicks(927), "Mobiles" },
                    { new Guid("fc8fb09a-e5f7-438c-98dc-171c893882c7"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2023, 1, 7, 12, 36, 32, 398, DateTimeKind.Local).AddTicks(981), "Watches" }
                });

            migrationBuilder.InsertData(
                table: "ProductBrands",
                columns: new[] { "Id", "CreatedBy", "CreatedOn", "Name" },
                values: new object[,]
                {
                    { new Guid("ad5d3318-2b14-474f-93dd-bc5f2ea5a8b8"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2023, 1, 7, 12, 36, 32, 398, DateTimeKind.Local).AddTicks(1283), "Nokia" },
                    { new Guid("c1191fb9-e9b5-4e87-8bb1-83fb752813c8"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2023, 1, 7, 12, 36, 32, 398, DateTimeKind.Local).AddTicks(1278), "Apple" },
                    { new Guid("ceb747d2-7e27-438e-9a6c-02d3f30febaa"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2023, 1, 7, 12, 36, 32, 398, DateTimeKind.Local).AddTicks(1281), "Samsung" }
                });

            migrationBuilder.InsertData(
                table: "ProductTypes",
                columns: new[] { "Id", "CreatedBy", "CreatedOn", "Name" },
                values: new object[,]
                {
                    { new Guid("13eb50f1-7cae-4671-ab28-84733811df73"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2023, 1, 7, 12, 36, 32, 398, DateTimeKind.Local).AddTicks(1242), "ProductType 2" },
                    { new Guid("42e4e58b-8059-4ada-afaf-7c2cb4050489"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2023, 1, 7, 12, 36, 32, 398, DateTimeKind.Local).AddTicks(1235), "ProductType 1" },
                    { new Guid("bb889e62-f3bc-449e-bec0-dfd59db19e6f"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2023, 1, 7, 12, 36, 32, 398, DateTimeKind.Local).AddTicks(1258), "ProductType 3" }
                });
        }
    }
}
