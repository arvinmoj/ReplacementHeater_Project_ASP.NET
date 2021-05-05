﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class MyFirstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                name: "Country",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdCountry = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CountryName = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    InsertDateTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Country", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Installer",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    InstallerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    InstallerUserName = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    UserNumber = table.Column<int>(type: "int", nullable: false),
                    NationalCode = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    MobileNumber = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    InsertDateTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Installer", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ShokatHeater",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdShokatHeater = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    HeaterSerialNumber = table.Column<int>(type: "int", nullable: false),
                    ProductionDate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InsertDateTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShokatHeater", x => x.Id);
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

            migrationBuilder.CreateTable(
                name: "City",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdCity = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CityName = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    CountryId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    InsertDateTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_City", x => x.Id);
                    table.ForeignKey(
                        name: "FK_City_Country_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Country",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "LegalPerson",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LegalPersonId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    InstallerUserName = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    CompanyName = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    NameCEO = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    EmailAddress = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    City = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    State = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Region = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    NationalCode = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    RegistrationNumber = table.Column<float>(type: "real", nullable: false),
                    EconomicCode = table.Column<float>(type: "real", nullable: false),
                    RecipientName = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    InstallationLocation = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    GasometerType = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    GasometerNumber = table.Column<int>(type: "int", nullable: false),
                    PersonNumber = table.Column<int>(type: "int", nullable: false),
                    Attachment = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InstallerId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    InsertDateTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LegalPerson", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LegalPerson_Installer_InstallerId",
                        column: x => x.InstallerId,
                        principalTable: "Installer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "NaturalPerson",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NaturalPersonId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    InstallerUserName = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    NationalCode = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    EmailAddress = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    MobileNumber = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    City = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    State = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Region = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    InstallationLocation = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    GasometerType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GasometerNumber = table.Column<int>(type: "int", nullable: false),
                    PersonNumber = table.Column<int>(type: "int", nullable: false),
                    Attachment = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InstallerId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    InsertDateTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NaturalPerson", x => x.Id);
                    table.ForeignKey(
                        name: "FK_NaturalPerson_Installer_InstallerId",
                        column: x => x.InstallerId,
                        principalTable: "Installer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "State",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdState = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StateName = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    CityId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    InsertDateTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_State", x => x.Id);
                    table.ForeignKey(
                        name: "FK_State_City_CityId",
                        column: x => x.CityId,
                        principalTable: "City",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ReplacementHeater",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ReplacementHeaterId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserLegalPerson = table.Column<bool>(type: "bit", nullable: false),
                    UserNaturalPerson = table.Column<bool>(type: "bit", nullable: false),
                    HeaterInstalledType = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    NameCEO = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: true),
                    FullName = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: true),
                    HeaterScrapType = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Model = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Capacity = table.Column<float>(type: "real", nullable: false),
                    HeaterScrapSerialNumber = table.Column<int>(type: "int", maxLength: 128, nullable: false),
                    HeaterInstalledSerialNumber = table.Column<int>(type: "int", maxLength: 128, nullable: false),
                    InstallationDate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InstallationTime = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NaturalPersonId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LegalPersonId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    InsertDateTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReplacementHeater", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ReplacementHeater_LegalPerson_LegalPersonId",
                        column: x => x.LegalPersonId,
                        principalTable: "LegalPerson",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ReplacementHeater_NaturalPerson_NaturalPersonId",
                        column: x => x.NaturalPersonId,
                        principalTable: "NaturalPerson",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "City",
                columns: new[] { "Id", "CityName", "CountryId", "IdCity", "InsertDateTime" },
                values: new object[,]
                {
                    { new Guid("30650ae3-51e0-4711-9933-9318739d74da"), "تهران", null, new Guid("16bcbb89-9dcf-4742-82eb-474013215322"), new DateTime(2021, 5, 6, 15, 6, 7, 151, DateTimeKind.Local).AddTicks(6230) },
                    { new Guid("552999a9-7965-4991-8a36-c0370ec1345a"), "اصفهان", null, new Guid("a1d501b1-dbb0-478e-8b54-5aea1497bbfb"), new DateTime(2021, 5, 6, 15, 6, 7, 151, DateTimeKind.Local).AddTicks(7380) },
                    { new Guid("fc624aa3-6489-423a-a610-f9b6f9fcc0ca"), "كرمان", null, new Guid("5b59b32a-ce68-406a-9eef-1390de1fff51"), new DateTime(2021, 5, 6, 15, 6, 7, 151, DateTimeKind.Local).AddTicks(7400) }
                });

            migrationBuilder.InsertData(
                table: "Country",
                columns: new[] { "Id", "CountryName", "IdCountry", "InsertDateTime" },
                values: new object[] { new Guid("4c53b0e6-db0b-4666-8f92-bb97ab8c80d6"), "ایران", new Guid("00bc82fd-6896-4cf2-9180-53b1ed4b2c69"), new DateTime(2021, 5, 6, 15, 6, 7, 141, DateTimeKind.Local).AddTicks(210) });

            migrationBuilder.InsertData(
                table: "State",
                columns: new[] { "Id", "CityId", "IdState", "InsertDateTime", "StateName" },
                values: new object[,]
                {
                    { new Guid("69e74990-b7ae-4152-a7dc-37c9ff95bbdd"), null, new Guid("0339dbb2-186d-4bcf-97ac-5f79196422bc"), new DateTime(2021, 5, 6, 15, 6, 7, 152, DateTimeKind.Local).AddTicks(150), "بم" },
                    { new Guid("2da57844-9452-4338-affb-bc978444a88f"), null, new Guid("2635cc83-4f96-40c8-aa6f-726b0a96225d"), new DateTime(2021, 5, 6, 15, 6, 7, 152, DateTimeKind.Local).AddTicks(1080), "ايمانشهر" },
                    { new Guid("d6425d63-61ce-43ef-9451-338e50842cc5"), null, new Guid("edcbeb03-81c0-4d9f-8661-2fb20bd838e0"), new DateTime(2021, 5, 6, 15, 6, 7, 152, DateTimeKind.Local).AddTicks(1120), "البرز" }
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

            migrationBuilder.CreateIndex(
                name: "IX_City_CountryId",
                table: "City",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_LegalPerson_InstallerId",
                table: "LegalPerson",
                column: "InstallerId");

            migrationBuilder.CreateIndex(
                name: "IX_NaturalPerson_InstallerId",
                table: "NaturalPerson",
                column: "InstallerId");

            migrationBuilder.CreateIndex(
                name: "IX_ReplacementHeater_LegalPersonId",
                table: "ReplacementHeater",
                column: "LegalPersonId");

            migrationBuilder.CreateIndex(
                name: "IX_ReplacementHeater_NaturalPersonId",
                table: "ReplacementHeater",
                column: "NaturalPersonId");

            migrationBuilder.CreateIndex(
                name: "IX_State_CityId",
                table: "State",
                column: "CityId");
        }

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
                name: "ReplacementHeater");

            migrationBuilder.DropTable(
                name: "ShokatHeater");

            migrationBuilder.DropTable(
                name: "State");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "LegalPerson");

            migrationBuilder.DropTable(
                name: "NaturalPerson");

            migrationBuilder.DropTable(
                name: "City");

            migrationBuilder.DropTable(
                name: "Installer");

            migrationBuilder.DropTable(
                name: "Country");
        }
    }
}