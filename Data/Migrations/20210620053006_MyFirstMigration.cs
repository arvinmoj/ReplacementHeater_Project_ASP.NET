using System;
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
                    UserNumber = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
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
                    UserLegalPerson = table.Column<bool>(type: "bit", nullable: false),
                    InstallerUserName = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    CompanyName = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    NameCEO = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    EmailAddress = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    City = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    State = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    PostalCode = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    RegistrationNumber = table.Column<float>(type: "real", maxLength: 128, nullable: false),
                    EconomicCode = table.Column<float>(type: "real", maxLength: 128, nullable: false),
                    RecipientName = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    InstallationLocation = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    GasometerType = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    GasometerNumber = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    PersonNumber = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
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
                    UserNaturalPerson = table.Column<bool>(type: "bit", nullable: false),
                    InstallerUserName = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    NationalCode = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    EmailAddress = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    MobileNumber = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    City = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    State = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    PostalCode = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    InstallationLocation = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    GasometerType = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    GasometerNumber = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    PersonNumber = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Attachment = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
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
                    { new Guid("21582bb5-7873-49b1-8401-fcd3caf32914"), "تهران", null, new Guid("16bcbb89-9dcf-4742-82eb-474013215322"), new DateTime(2021, 6, 20, 10, 0, 5, 637, DateTimeKind.Local).AddTicks(1130) },
                    { new Guid("64dca989-e358-4cc5-9326-f1c3a48ee89e"), "اصفهان", null, new Guid("a1d501b1-dbb0-478e-8b54-5aea1497bbfb"), new DateTime(2021, 6, 20, 10, 0, 5, 637, DateTimeKind.Local).AddTicks(2500) },
                    { new Guid("4bfec858-cc50-4837-b432-0ff352f43fdf"), "كرمان", null, new Guid("5b59b32a-ce68-406a-9eef-1390de1fff51"), new DateTime(2021, 6, 20, 10, 0, 5, 637, DateTimeKind.Local).AddTicks(2540) }
                });

            migrationBuilder.InsertData(
                table: "Country",
                columns: new[] { "Id", "CountryName", "IdCountry", "InsertDateTime" },
                values: new object[] { new Guid("6f07adab-50d6-413f-9fe5-2938affe5624"), "ایران", new Guid("00bc82fd-6896-4cf2-9180-53b1ed4b2c69"), new DateTime(2021, 6, 20, 10, 0, 5, 629, DateTimeKind.Local).AddTicks(3520) });

            migrationBuilder.InsertData(
                table: "State",
                columns: new[] { "Id", "CityId", "IdState", "InsertDateTime", "StateName" },
                values: new object[,]
                {
                    { new Guid("f278996c-7d70-4cb9-8715-46b7dd9adc4c"), null, new Guid("f1ee2853-a064-4621-ac54-891ab9e323c9"), new DateTime(2021, 6, 20, 10, 0, 5, 637, DateTimeKind.Local).AddTicks(6190), "بم" },
                    { new Guid("9f04d8af-b7c2-457f-9bcd-b63bd5722339"), null, new Guid("486c575d-b834-4195-baf6-f9ff84026829"), new DateTime(2021, 6, 20, 10, 0, 5, 637, DateTimeKind.Local).AddTicks(7650), "ايمانشهر" },
                    { new Guid("f458cec2-697e-4e07-b6ca-6a60f2feac9d"), null, new Guid("61116603-0348-4a8d-8c04-dd0599c5d549"), new DateTime(2021, 6, 20, 10, 0, 5, 637, DateTimeKind.Local).AddTicks(7700), "البرز" }
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
