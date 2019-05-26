﻿// <auto-generated />
using System;
using BaiVeNhaQuanLyKhoHang.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BaiVeNhaQuanLyKhoHang.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BaiVeNhaQuanLyKhoHang.Models.ChiTietKiemHang", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedDate");

                    b.Property<int>("IdLuuTru");

                    b.Property<int>("IdPhieu");

                    b.Property<int>("MaHang");

                    b.Property<DateTime>("ModifiedDate");

                    b.Property<int>("SoLuong");

                    b.HasKey("Id");

                    b.HasIndex("IdLuuTru");

                    b.HasIndex("IdPhieu");

                    b.HasIndex("MaHang");

                    b.ToTable("ChiTietKiemHang");
                });

            modelBuilder.Entity("BaiVeNhaQuanLyKhoHang.Models.ChiTietNhapHang", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedDate");

                    b.Property<int>("IdLuuTru");

                    b.Property<int>("IdPhieu");

                    b.Property<int>("MaHang");

                    b.Property<DateTime>("ModifiedDate");

                    b.Property<int>("SoLuong");

                    b.HasKey("Id");

                    b.HasIndex("IdLuuTru");

                    b.HasIndex("IdPhieu");

                    b.HasIndex("MaHang");

                    b.ToTable("ChiTietNhapHang");
                });

            modelBuilder.Entity("BaiVeNhaQuanLyKhoHang.Models.ChiTietXuatHang", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedDate");

                    b.Property<int>("IdLuuTru");

                    b.Property<int>("IdPhieu");

                    b.Property<int>("MaHang");

                    b.Property<DateTime>("ModifiedDate");

                    b.Property<int>("SoLuong");

                    b.HasKey("Id");

                    b.HasIndex("IdLuuTru");

                    b.HasIndex("IdPhieu");

                    b.HasIndex("MaHang");

                    b.ToTable("ChiTietXuatHang");
                });

            modelBuilder.Entity("BaiVeNhaQuanLyKhoHang.Models.ChuSoHuu", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedDate");

                    b.Property<string>("DiaChi");

                    b.Property<DateTime>("ModifiedDate");

                    b.Property<string>("NguoiDaiDien");

                    b.Property<string>("SoDienThoai");

                    b.Property<string>("Ten");

                    b.Property<string>("TenVietTat");

                    b.Property<bool>("TrangThai");

                    b.HasKey("Id");

                    b.ToTable("ChuSoHuu");
                });

            modelBuilder.Entity("BaiVeNhaQuanLyKhoHang.Models.DanhMucHang", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedDate");

                    b.Property<bool>("HoatDong");

                    b.Property<int?>("IdCha");

                    b.Property<DateTime>("ModifiedDate");

                    b.Property<string>("Ten");

                    b.HasKey("Id");

                    b.HasIndex("IdCha");

                    b.ToTable("DanhMucHang");
                });

            modelBuilder.Entity("BaiVeNhaQuanLyKhoHang.Models.HangHoa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("ChieuCao");

                    b.Property<double>("ChieuDai");

                    b.Property<double>("ChieuRong");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<string>("HinhAnh");

                    b.Property<int>("LoaiDanhMuc");

                    b.Property<string>("MoTa");

                    b.Property<DateTime>("ModifiedDate");

                    b.Property<string>("Ten");

                    b.HasKey("Id");

                    b.HasIndex("LoaiDanhMuc");

                    b.ToTable("HangHoa");
                });

            modelBuilder.Entity("BaiVeNhaQuanLyKhoHang.Models.KhoLuuTru", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedDate");

                    b.Property<bool>("HoatDong");

                    b.Property<int?>("IdCha");

                    b.Property<string>("MaTen");

                    b.Property<DateTime>("ModifiedDate");

                    b.HasKey("Id");

                    b.HasIndex("IdCha");

                    b.ToTable("KhoLuuTru");
                });

            modelBuilder.Entity("BaiVeNhaQuanLyKhoHang.Models.KiemHang", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedDate");

                    b.Property<string>("GhiChu");

                    b.Property<string>("MaPhieu");

                    b.Property<DateTime>("ModifiedDate");

                    b.Property<DateTime>("NgayKiem");

                    b.Property<int>("NguoiKiem");

                    b.HasKey("Id");

                    b.HasIndex("NguoiKiem");

                    b.ToTable("KiemHang");
                });

            modelBuilder.Entity("BaiVeNhaQuanLyKhoHang.Models.NhapHang", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ChuSoHuu");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<string>("GhiChu");

                    b.Property<string>("MaPhieu");

                    b.Property<DateTime>("ModifiedDate");

                    b.Property<DateTime>("NgayNhap");

                    b.Property<int>("NguoiNhap");

                    b.HasKey("Id");

                    b.HasIndex("ChuSoHuu");

                    b.HasIndex("NguoiNhap");

                    b.ToTable("NhapHang");
                });

            modelBuilder.Entity("BaiVeNhaQuanLyKhoHang.Models.QuanTri", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email");

                    b.Property<string>("HoTen");

                    b.Property<string>("Password");

                    b.Property<string>("Phone");

                    b.Property<int>("RoleLever");

                    b.Property<string>("UserToken");

                    b.Property<string>("Username");

                    b.HasKey("Id");

                    b.ToTable("QuanTri");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "justin@gmail.com",
                            HoTen = "Justin",
                            Password = "admin123",
                            Phone = "0941827691",
                            RoleLever = 1,
                            Username = "admin"
                        },
                        new
                        {
                            Id = 2,
                            Email = "liv@gmail.com",
                            HoTen = "Liv",
                            Password = "user123",
                            Phone = "0987654321",
                            RoleLever = 2,
                            Username = "user"
                        });
                });

            modelBuilder.Entity("BaiVeNhaQuanLyKhoHang.Models.XuatHang", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ChuSoHuu");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<string>("GhiChu");

                    b.Property<string>("MaPhieu");

                    b.Property<DateTime>("ModifiedDate");

                    b.Property<DateTime>("NgayXuat");

                    b.Property<int>("NguoiXuat");

                    b.HasKey("Id");

                    b.HasIndex("ChuSoHuu");

                    b.HasIndex("NguoiXuat");

                    b.ToTable("XuatHang");
                });

            modelBuilder.Entity("BaiVeNhaQuanLyKhoHang.Models.ChiTietKiemHang", b =>
                {
                    b.HasOne("BaiVeNhaQuanLyKhoHang.Models.KhoLuuTru", "GetKhoLuuTru")
                        .WithMany()
                        .HasForeignKey("IdLuuTru")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("BaiVeNhaQuanLyKhoHang.Models.KiemHang", "GetKiemHang")
                        .WithMany()
                        .HasForeignKey("IdPhieu")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("BaiVeNhaQuanLyKhoHang.Models.HangHoa", "GetHangHoa")
                        .WithMany()
                        .HasForeignKey("MaHang")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("BaiVeNhaQuanLyKhoHang.Models.ChiTietNhapHang", b =>
                {
                    b.HasOne("BaiVeNhaQuanLyKhoHang.Models.KhoLuuTru", "GetKhoLuuTru")
                        .WithMany()
                        .HasForeignKey("IdLuuTru")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("BaiVeNhaQuanLyKhoHang.Models.NhapHang", "GetNhapHang")
                        .WithMany()
                        .HasForeignKey("IdPhieu")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("BaiVeNhaQuanLyKhoHang.Models.HangHoa", "GetHangHoa")
                        .WithMany()
                        .HasForeignKey("MaHang")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("BaiVeNhaQuanLyKhoHang.Models.ChiTietXuatHang", b =>
                {
                    b.HasOne("BaiVeNhaQuanLyKhoHang.Models.KhoLuuTru", "GetKhoLuuTru")
                        .WithMany()
                        .HasForeignKey("IdLuuTru")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("BaiVeNhaQuanLyKhoHang.Models.XuatHang", "GetXuatHang")
                        .WithMany()
                        .HasForeignKey("IdPhieu")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("BaiVeNhaQuanLyKhoHang.Models.HangHoa", "GetHangHoa")
                        .WithMany()
                        .HasForeignKey("MaHang")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("BaiVeNhaQuanLyKhoHang.Models.DanhMucHang", b =>
                {
                    b.HasOne("BaiVeNhaQuanLyKhoHang.Models.DanhMucHang", "GetDanhMucHang")
                        .WithMany()
                        .HasForeignKey("IdCha")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("BaiVeNhaQuanLyKhoHang.Models.HangHoa", b =>
                {
                    b.HasOne("BaiVeNhaQuanLyKhoHang.Models.DanhMucHang", "GetDanhMucHang")
                        .WithMany()
                        .HasForeignKey("LoaiDanhMuc")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("BaiVeNhaQuanLyKhoHang.Models.KhoLuuTru", b =>
                {
                    b.HasOne("BaiVeNhaQuanLyKhoHang.Models.KhoLuuTru", "GetKhoLuuTru")
                        .WithMany()
                        .HasForeignKey("IdCha");
                });

            modelBuilder.Entity("BaiVeNhaQuanLyKhoHang.Models.KiemHang", b =>
                {
                    b.HasOne("BaiVeNhaQuanLyKhoHang.Models.QuanTri", "GetQuanTri")
                        .WithMany()
                        .HasForeignKey("NguoiKiem")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("BaiVeNhaQuanLyKhoHang.Models.NhapHang", b =>
                {
                    b.HasOne("BaiVeNhaQuanLyKhoHang.Models.ChuSoHuu", "GetChuSoHuu")
                        .WithMany()
                        .HasForeignKey("ChuSoHuu")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("BaiVeNhaQuanLyKhoHang.Models.QuanTri", "GetQuanTri")
                        .WithMany()
                        .HasForeignKey("NguoiNhap")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("BaiVeNhaQuanLyKhoHang.Models.XuatHang", b =>
                {
                    b.HasOne("BaiVeNhaQuanLyKhoHang.Models.ChuSoHuu", "GetChuSoHuu")
                        .WithMany()
                        .HasForeignKey("ChuSoHuu")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("BaiVeNhaQuanLyKhoHang.Models.QuanTri", "GetQuanTri")
                        .WithMany()
                        .HasForeignKey("NguoiXuat")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
