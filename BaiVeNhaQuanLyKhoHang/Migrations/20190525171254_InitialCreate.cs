using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BaiVeNhaQuanLyKhoHang.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "XuatHang",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDate",
                table: "XuatHang",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "NhapHang",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDate",
                table: "NhapHang",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "KiemHang",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDate",
                table: "KiemHang",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "KhoLuuTru",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDate",
                table: "KhoLuuTru",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "HangHoa",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDate",
                table: "HangHoa",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "DanhMucHang",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDate",
                table: "DanhMucHang",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "ChuSoHuu",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDate",
                table: "ChuSoHuu",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "ChiTietXuatHang",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDate",
                table: "ChiTietXuatHang",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "ChiTietNhapHang",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDate",
                table: "ChiTietNhapHang",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "ChiTietKiemHang",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDate",
                table: "ChiTietKiemHang",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "XuatHang");

            migrationBuilder.DropColumn(
                name: "ModifiedDate",
                table: "XuatHang");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "NhapHang");

            migrationBuilder.DropColumn(
                name: "ModifiedDate",
                table: "NhapHang");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "KiemHang");

            migrationBuilder.DropColumn(
                name: "ModifiedDate",
                table: "KiemHang");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "KhoLuuTru");

            migrationBuilder.DropColumn(
                name: "ModifiedDate",
                table: "KhoLuuTru");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "HangHoa");

            migrationBuilder.DropColumn(
                name: "ModifiedDate",
                table: "HangHoa");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "DanhMucHang");

            migrationBuilder.DropColumn(
                name: "ModifiedDate",
                table: "DanhMucHang");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "ChuSoHuu");

            migrationBuilder.DropColumn(
                name: "ModifiedDate",
                table: "ChuSoHuu");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "ChiTietXuatHang");

            migrationBuilder.DropColumn(
                name: "ModifiedDate",
                table: "ChiTietXuatHang");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "ChiTietNhapHang");

            migrationBuilder.DropColumn(
                name: "ModifiedDate",
                table: "ChiTietNhapHang");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "ChiTietKiemHang");

            migrationBuilder.DropColumn(
                name: "ModifiedDate",
                table: "ChiTietKiemHang");
        }
    }
}
