using Microsoft.EntityFrameworkCore.Migrations;

namespace BaiVeNhaQuanLyKhoHang.Migrations
{
    public partial class InitDataUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "QuanTri",
                columns: new[] { "Id", "Email", "HoTen", "Password", "Phone", "RoleLever", "UserToken", "Username" },
                values: new object[] { 1, "justin@gmail.com", "Justin", "admin123", "0941827691", 1, null, "admin" });

            migrationBuilder.InsertData(
                table: "QuanTri",
                columns: new[] { "Id", "Email", "HoTen", "Password", "Phone", "RoleLever", "UserToken", "Username" },
                values: new object[] { 2, "liv@gmail.com", "Liv", "user123", "0987654321", 2, null, "user" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "QuanTri",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "QuanTri",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
