using Microsoft.EntityFrameworkCore.Migrations;

namespace DatingApp.API.Migrations
{
    public partial class TestSeedingData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "DumpModel",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Monaco" },
                    { 25, "Ecuador" },
                    { 26, "Saint Kitts and Nevis" },
                    { 27, "Sierra Leone" },
                    { 28, "Brunei Darussalam" },
                    { 29, "Christmas Island" },
                    { 30, "Vatican City State (Holy See)" },
                    { 31, "Tokelau" },
                    { 32, "Botswana" },
                    { 24, "Puerto Rico" },
                    { 33, "Trinidad and Tobago" },
                    { 35, "Bahamas" },
                    { 36, "Qatar" },
                    { 37, "Comoros" },
                    { 38, "American Samoa" },
                    { 39, "Solomon Islands" },
                    { 40, "Bahrain" },
                    { 41, "Venezuela" },
                    { 42, "Slovenia" },
                    { 34, "Jordan" },
                    { 23, "South Africa" },
                    { 22, "Angola" },
                    { 21, "Gambia" },
                    { 2, "S. Georgia and S. Sandwich Isls." },
                    { 3, "Malawi" },
                    { 4, "Micronesia" },
                    { 5, "Turkmenistan" },
                    { 6, "Mexico" },
                    { 7, "United Arab Emirates" },
                    { 8, "France, Metropolitan" },
                    { 9, "Namibia" },
                    { 10, "New Zealand" },
                    { 11, "Oman" },
                    { 12, "Heard and McDonald Islands" },
                    { 13, "Tuvalu" },
                    { 14, "Germany" },
                    { 15, "Australia" },
                    { 16, "Sao Tome and Principe" },
                    { 17, "Northern Mariana Islands" },
                    { 18, "Czech Republic" },
                    { 19, "Bhutan" },
                    { 20, "Virgin Islands (US)" },
                    { 43, "Burkina Faso" },
                    { 44, "Montserrat" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "DumpModel",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "DumpModel",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "DumpModel",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "DumpModel",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "DumpModel",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "DumpModel",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "DumpModel",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "DumpModel",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "DumpModel",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "DumpModel",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "DumpModel",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "DumpModel",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "DumpModel",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "DumpModel",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "DumpModel",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "DumpModel",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "DumpModel",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "DumpModel",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "DumpModel",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "DumpModel",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "DumpModel",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "DumpModel",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "DumpModel",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "DumpModel",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "DumpModel",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "DumpModel",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "DumpModel",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "DumpModel",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "DumpModel",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "DumpModel",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "DumpModel",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "DumpModel",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "DumpModel",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "DumpModel",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "DumpModel",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "DumpModel",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "DumpModel",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "DumpModel",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "DumpModel",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "DumpModel",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "DumpModel",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "DumpModel",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "DumpModel",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "DumpModel",
                keyColumn: "Id",
                keyValue: 44);
        }
    }
}
