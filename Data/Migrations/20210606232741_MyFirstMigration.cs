using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class MyFirstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: new Guid("447be69d-9d5f-4c99-bddd-d14bfdefd314"));

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: new Guid("4c94018b-0804-4ab8-835c-5a6f388eac55"));

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: new Guid("c57e2047-50f3-4266-bfcb-68e1bafc3ddb"));

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("2b2f7a3b-c1b1-4bfe-9ca6-52b270b7848a"));

            migrationBuilder.DeleteData(
                table: "State",
                keyColumn: "Id",
                keyValue: new Guid("4e1aa7b7-71b2-444d-945a-2f9d1c776bdf"));

            migrationBuilder.DeleteData(
                table: "State",
                keyColumn: "Id",
                keyValue: new Guid("56a410b6-cb38-428d-a4c4-73db5dd9b47b"));

            migrationBuilder.DeleteData(
                table: "State",
                keyColumn: "Id",
                keyValue: new Guid("98955c0c-2667-4b48-9272-44aa6d36d01b"));

            migrationBuilder.AlterColumn<string>(
                name: "PersonNumber",
                table: "NaturalPerson",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "GasometerType",
                table: "NaturalPerson",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "GasometerNumber",
                table: "NaturalPerson",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Attachment",
                table: "NaturalPerson",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "PersonNumber",
                table: "LegalPerson",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "GasometerNumber",
                table: "LegalPerson",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "UserNumber",
                table: "Installer",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.InsertData(
                table: "City",
                columns: new[] { "Id", "CityName", "CountryId", "IdCity", "InsertDateTime" },
                values: new object[,]
                {
                    { new Guid("f4bedb26-68b5-460f-b6e5-f6405c57e54b"), "تهران", null, new Guid("16bcbb89-9dcf-4742-82eb-474013215322"), new DateTime(2021, 6, 7, 3, 57, 40, 887, DateTimeKind.Local).AddTicks(300) },
                    { new Guid("3e61bef9-ae9e-41f3-8ce3-de74b6b532b0"), "اصفهان", null, new Guid("a1d501b1-dbb0-478e-8b54-5aea1497bbfb"), new DateTime(2021, 6, 7, 3, 57, 40, 887, DateTimeKind.Local).AddTicks(1440) },
                    { new Guid("38de17b1-46fe-44a3-b232-343c22625318"), "كرمان", null, new Guid("5b59b32a-ce68-406a-9eef-1390de1fff51"), new DateTime(2021, 6, 7, 3, 57, 40, 887, DateTimeKind.Local).AddTicks(1480) }
                });

            migrationBuilder.InsertData(
                table: "Country",
                columns: new[] { "Id", "CountryName", "IdCountry", "InsertDateTime" },
                values: new object[] { new Guid("055e1419-1774-4fd3-b87d-8b5a4dd8cb09"), "ایران", new Guid("00bc82fd-6896-4cf2-9180-53b1ed4b2c69"), new DateTime(2021, 6, 7, 3, 57, 40, 877, DateTimeKind.Local).AddTicks(6200) });

            migrationBuilder.InsertData(
                table: "State",
                columns: new[] { "Id", "CityId", "IdState", "InsertDateTime", "StateName" },
                values: new object[,]
                {
                    { new Guid("249b42ac-4f6e-4baa-b3c5-a1541a622e43"), null, new Guid("e4e8a327-425a-4704-b364-39deedacd105"), new DateTime(2021, 6, 7, 3, 57, 40, 887, DateTimeKind.Local).AddTicks(4750), "بم" },
                    { new Guid("5a8c35d3-9d8a-4f1d-80b4-3a8cbf959521"), null, new Guid("4f1a0fad-9bea-4a56-8c9c-81a19d8f52b3"), new DateTime(2021, 6, 7, 3, 57, 40, 887, DateTimeKind.Local).AddTicks(5850), "ايمانشهر" },
                    { new Guid("c9c26268-0c4e-4444-84a0-b6d3ca8e35ea"), null, new Guid("55d84303-1f28-46e5-81f5-66c9a6c75776"), new DateTime(2021, 6, 7, 3, 57, 40, 887, DateTimeKind.Local).AddTicks(5900), "البرز" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: new Guid("38de17b1-46fe-44a3-b232-343c22625318"));

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: new Guid("3e61bef9-ae9e-41f3-8ce3-de74b6b532b0"));

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: new Guid("f4bedb26-68b5-460f-b6e5-f6405c57e54b"));

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("055e1419-1774-4fd3-b87d-8b5a4dd8cb09"));

            migrationBuilder.DeleteData(
                table: "State",
                keyColumn: "Id",
                keyValue: new Guid("249b42ac-4f6e-4baa-b3c5-a1541a622e43"));

            migrationBuilder.DeleteData(
                table: "State",
                keyColumn: "Id",
                keyValue: new Guid("5a8c35d3-9d8a-4f1d-80b4-3a8cbf959521"));

            migrationBuilder.DeleteData(
                table: "State",
                keyColumn: "Id",
                keyValue: new Guid("c9c26268-0c4e-4444-84a0-b6d3ca8e35ea"));

            migrationBuilder.AlterColumn<string>(
                name: "PersonNumber",
                table: "NaturalPerson",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "GasometerType",
                table: "NaturalPerson",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "GasometerNumber",
                table: "NaturalPerson",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "Attachment",
                table: "NaturalPerson",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "PersonNumber",
                table: "LegalPerson",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "GasometerNumber",
                table: "LegalPerson",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "UserNumber",
                table: "Installer",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.InsertData(
                table: "City",
                columns: new[] { "Id", "CityName", "CountryId", "IdCity", "InsertDateTime" },
                values: new object[,]
                {
                    { new Guid("c57e2047-50f3-4266-bfcb-68e1bafc3ddb"), "تهران", null, new Guid("16bcbb89-9dcf-4742-82eb-474013215322"), new DateTime(2021, 6, 7, 2, 49, 14, 122, DateTimeKind.Local).AddTicks(7650) },
                    { new Guid("4c94018b-0804-4ab8-835c-5a6f388eac55"), "اصفهان", null, new Guid("a1d501b1-dbb0-478e-8b54-5aea1497bbfb"), new DateTime(2021, 6, 7, 2, 49, 14, 122, DateTimeKind.Local).AddTicks(8740) },
                    { new Guid("447be69d-9d5f-4c99-bddd-d14bfdefd314"), "كرمان", null, new Guid("5b59b32a-ce68-406a-9eef-1390de1fff51"), new DateTime(2021, 6, 7, 2, 49, 14, 122, DateTimeKind.Local).AddTicks(8770) }
                });

            migrationBuilder.InsertData(
                table: "Country",
                columns: new[] { "Id", "CountryName", "IdCountry", "InsertDateTime" },
                values: new object[] { new Guid("2b2f7a3b-c1b1-4bfe-9ca6-52b270b7848a"), "ایران", new Guid("00bc82fd-6896-4cf2-9180-53b1ed4b2c69"), new DateTime(2021, 6, 7, 2, 49, 14, 116, DateTimeKind.Local).AddTicks(7930) });

            migrationBuilder.InsertData(
                table: "State",
                columns: new[] { "Id", "CityId", "IdState", "InsertDateTime", "StateName" },
                values: new object[,]
                {
                    { new Guid("98955c0c-2667-4b48-9272-44aa6d36d01b"), null, new Guid("e6ee89f6-37f2-4828-bb20-5b400cef42c6"), new DateTime(2021, 6, 7, 2, 49, 14, 123, DateTimeKind.Local).AddTicks(1780), "بم" },
                    { new Guid("56a410b6-cb38-428d-a4c4-73db5dd9b47b"), null, new Guid("31ce0e88-f6a1-4138-a9bd-2cf23d576f33"), new DateTime(2021, 6, 7, 2, 49, 14, 123, DateTimeKind.Local).AddTicks(2830), "ايمانشهر" },
                    { new Guid("4e1aa7b7-71b2-444d-945a-2f9d1c776bdf"), null, new Guid("11143dd9-f4c2-4da8-8440-b4e9191b81ba"), new DateTime(2021, 6, 7, 2, 49, 14, 123, DateTimeKind.Local).AddTicks(2870), "البرز" }
                });
        }
    }
}
