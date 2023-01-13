using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Presistance.Migrations
{
    /// <inheritdoc />
    public partial class AddIdentityTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

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
    }
}
