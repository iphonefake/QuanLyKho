using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BaiVeNhaQuanLyKhoHang.Migrations
{
    public partial class BuildDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ChuSoHuu",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Ten = table.Column<string>(nullable: true),
                    TenVietTat = table.Column<string>(nullable: true),
                    NguoiDaiDien = table.Column<string>(nullable: true),
                    DiaChi = table.Column<string>(nullable: true),
                    SoDienThoai = table.Column<string>(nullable: true),
                    TrangThai = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChuSoHuu", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DanhMucHang",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Ten = table.Column<string>(nullable: true),
                    IdCha = table.Column<int>(nullable: true),
                    HoatDong = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DanhMucHang", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DanhMucHang_DanhMucHang_IdCha",
                        column: x => x.IdCha,
                        principalTable: "DanhMucHang",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "KhoLuuTru",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    MaTen = table.Column<string>(nullable: true),
                    IdCha = table.Column<int>(nullable: true),
                    HoatDong = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KhoLuuTru", x => x.Id);
                    table.ForeignKey(
                        name: "FK_KhoLuuTru_KhoLuuTru_IdCha",
                        column: x => x.IdCha,
                        principalTable: "KhoLuuTru",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "QuanTri",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Username = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    HoTen = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Phone = table.Column<string>(nullable: true),
                    RoleLever = table.Column<int>(nullable: false),
                    UserToken = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuanTri", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HangHoa",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Ten = table.Column<string>(nullable: true),
                    MoTa = table.Column<string>(nullable: true),
                    ChieuDai = table.Column<double>(nullable: false),
                    ChieuRong = table.Column<double>(nullable: false),
                    ChieuCao = table.Column<double>(nullable: false),
                    HinhAnh = table.Column<string>(nullable: true),
                    LoaiDanhMuc = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HangHoa", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HangHoa_DanhMucHang_LoaiDanhMuc",
                        column: x => x.LoaiDanhMuc,
                        principalTable: "DanhMucHang",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "KiemHang",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    MaPhieu = table.Column<string>(nullable: true),
                    NgayKiem = table.Column<DateTime>(nullable: false),
                    NguoiKiem = table.Column<int>(nullable: false),
                    GhiChu = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KiemHang", x => x.Id);
                    table.ForeignKey(
                        name: "FK_KiemHang_QuanTri_NguoiKiem",
                        column: x => x.NguoiKiem,
                        principalTable: "QuanTri",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "NhapHang",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    MaPhieu = table.Column<string>(nullable: true),
                    NgayNhap = table.Column<DateTime>(nullable: false),
                    NguoiNhap = table.Column<int>(nullable: false),
                    ChuSoHuu = table.Column<int>(nullable: false),
                    GhiChu = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NhapHang", x => x.Id);
                    table.ForeignKey(
                        name: "FK_NhapHang_ChuSoHuu_ChuSoHuu",
                        column: x => x.ChuSoHuu,
                        principalTable: "ChuSoHuu",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_NhapHang_QuanTri_NguoiNhap",
                        column: x => x.NguoiNhap,
                        principalTable: "QuanTri",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "XuatHang",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    MaPhieu = table.Column<string>(nullable: true),
                    NgayXuat = table.Column<DateTime>(nullable: false),
                    NguoiXuat = table.Column<int>(nullable: false),
                    ChuSoHuu = table.Column<int>(nullable: false),
                    GhiChu = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_XuatHang", x => x.Id);
                    table.ForeignKey(
                        name: "FK_XuatHang_ChuSoHuu_ChuSoHuu",
                        column: x => x.ChuSoHuu,
                        principalTable: "ChuSoHuu",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_XuatHang_QuanTri_NguoiXuat",
                        column: x => x.NguoiXuat,
                        principalTable: "QuanTri",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ChiTietKiemHang",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    MaHang = table.Column<int>(nullable: false),
                    SoLuong = table.Column<int>(nullable: false),
                    IdPhieu = table.Column<int>(nullable: false),
                    IdLuuTru = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChiTietKiemHang", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ChiTietKiemHang_KhoLuuTru_IdLuuTru",
                        column: x => x.IdLuuTru,
                        principalTable: "KhoLuuTru",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ChiTietKiemHang_KiemHang_IdPhieu",
                        column: x => x.IdPhieu,
                        principalTable: "KiemHang",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ChiTietKiemHang_HangHoa_MaHang",
                        column: x => x.MaHang,
                        principalTable: "HangHoa",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ChiTietNhapHang",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    MaHang = table.Column<int>(nullable: false),
                    SoLuong = table.Column<int>(nullable: false),
                    IdPhieu = table.Column<int>(nullable: false),
                    IdLuuTru = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChiTietNhapHang", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ChiTietNhapHang_KhoLuuTru_IdLuuTru",
                        column: x => x.IdLuuTru,
                        principalTable: "KhoLuuTru",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ChiTietNhapHang_NhapHang_IdPhieu",
                        column: x => x.IdPhieu,
                        principalTable: "NhapHang",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ChiTietNhapHang_HangHoa_MaHang",
                        column: x => x.MaHang,
                        principalTable: "HangHoa",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ChiTietXuatHang",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    MaHang = table.Column<int>(nullable: false),
                    SoLuong = table.Column<int>(nullable: false),
                    IdPhieu = table.Column<int>(nullable: false),
                    IdLuuTru = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChiTietXuatHang", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ChiTietXuatHang_KhoLuuTru_IdLuuTru",
                        column: x => x.IdLuuTru,
                        principalTable: "KhoLuuTru",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ChiTietXuatHang_XuatHang_IdPhieu",
                        column: x => x.IdPhieu,
                        principalTable: "XuatHang",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ChiTietXuatHang_HangHoa_MaHang",
                        column: x => x.MaHang,
                        principalTable: "HangHoa",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietKiemHang_IdLuuTru",
                table: "ChiTietKiemHang",
                column: "IdLuuTru");

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietKiemHang_IdPhieu",
                table: "ChiTietKiemHang",
                column: "IdPhieu");

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietKiemHang_MaHang",
                table: "ChiTietKiemHang",
                column: "MaHang");

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietNhapHang_IdLuuTru",
                table: "ChiTietNhapHang",
                column: "IdLuuTru");

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietNhapHang_IdPhieu",
                table: "ChiTietNhapHang",
                column: "IdPhieu");

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietNhapHang_MaHang",
                table: "ChiTietNhapHang",
                column: "MaHang");

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietXuatHang_IdLuuTru",
                table: "ChiTietXuatHang",
                column: "IdLuuTru");

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietXuatHang_IdPhieu",
                table: "ChiTietXuatHang",
                column: "IdPhieu");

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietXuatHang_MaHang",
                table: "ChiTietXuatHang",
                column: "MaHang");

            migrationBuilder.CreateIndex(
                name: "IX_DanhMucHang_IdCha",
                table: "DanhMucHang",
                column: "IdCha");

            migrationBuilder.CreateIndex(
                name: "IX_HangHoa_LoaiDanhMuc",
                table: "HangHoa",
                column: "LoaiDanhMuc");

            migrationBuilder.CreateIndex(
                name: "IX_KhoLuuTru_IdCha",
                table: "KhoLuuTru",
                column: "IdCha");

            migrationBuilder.CreateIndex(
                name: "IX_KiemHang_NguoiKiem",
                table: "KiemHang",
                column: "NguoiKiem");

            migrationBuilder.CreateIndex(
                name: "IX_NhapHang_ChuSoHuu",
                table: "NhapHang",
                column: "ChuSoHuu");

            migrationBuilder.CreateIndex(
                name: "IX_NhapHang_NguoiNhap",
                table: "NhapHang",
                column: "NguoiNhap");

            migrationBuilder.CreateIndex(
                name: "IX_XuatHang_ChuSoHuu",
                table: "XuatHang",
                column: "ChuSoHuu");

            migrationBuilder.CreateIndex(
                name: "IX_XuatHang_NguoiXuat",
                table: "XuatHang",
                column: "NguoiXuat");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ChiTietKiemHang");

            migrationBuilder.DropTable(
                name: "ChiTietNhapHang");

            migrationBuilder.DropTable(
                name: "ChiTietXuatHang");

            migrationBuilder.DropTable(
                name: "KiemHang");

            migrationBuilder.DropTable(
                name: "NhapHang");

            migrationBuilder.DropTable(
                name: "KhoLuuTru");

            migrationBuilder.DropTable(
                name: "XuatHang");

            migrationBuilder.DropTable(
                name: "HangHoa");

            migrationBuilder.DropTable(
                name: "ChuSoHuu");

            migrationBuilder.DropTable(
                name: "QuanTri");

            migrationBuilder.DropTable(
                name: "DanhMucHang");
        }
    }
}
