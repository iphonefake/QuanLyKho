using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BaiVeNhaQuanLyKhoHang.Models
{
    public class DataContext : DbContext
    {
        //public virtual DbSet<BaseEntity> BaseEntities { get; set; }
        public virtual DbSet<QuanTri> QuanTris { get; set; }
        public virtual DbSet<ChuSoHuu> ChuSoHuus { get; set; }
        public virtual DbSet<KhoLuuTru> KhoLuuTrus { get; set; }
        public virtual DbSet<DanhMucHang> DanhMucHangs { get; set; }
        public virtual DbSet<HangHoa> HangHoas { get; set; }
        public virtual DbSet<NhapHang> NhapHangs { get; set; }
        public virtual DbSet<XuatHang> XuatHangs { get; set; }
        public virtual DbSet<KiemHang> KiemHangs { get; set; }
        public virtual DbSet<ChiTietKiemHang> ChiTietKiemHangs { get; set; }
        public virtual DbSet<ChiTietXuatHang> ChiTietXuatHangs { get; set; }
        public virtual DbSet<ChiTietNhapHang> ChiTietNhapHangs { get; set; }

        public DataContext(DbContextOptions options) : base(options) { }
        public DataContext() { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<QuanTri>().ToTable("QuanTri").HasKey(k => k.Id);
            modelBuilder.Entity<ChuSoHuu>().ToTable("ChuSoHuu").HasKey(k => k.Id);
            modelBuilder.Entity<KhoLuuTru>().ToTable("KhoLuuTru").HasKey(k => k.Id);
            modelBuilder.Entity<DanhMucHang>().ToTable("DanhMucHang").HasKey(k => k.Id);
            modelBuilder.Entity<HangHoa>().ToTable("HangHoa").HasKey(k => k.Id);
            modelBuilder.Entity<NhapHang>().ToTable("NhapHang").HasKey(k => k.Id);
            modelBuilder.Entity<XuatHang>().ToTable("XuatHang").HasKey(k => k.Id);
            modelBuilder.Entity<KiemHang>().ToTable("KiemHang").HasKey(k => k.Id);
            modelBuilder.Entity<ChiTietKiemHang>().ToTable("ChiTietKiemHang").HasKey(k => k.Id);
            modelBuilder.Entity<ChiTietNhapHang>().ToTable("ChiTietNhapHang").HasKey(k => k.Id);
            modelBuilder.Entity<ChiTietXuatHang>().ToTable("ChiTietXuatHang").HasKey(k => k.Id);

            modelBuilder.Entity<DanhMucHang>().HasOne(d => d.GetDanhMucHang).WithMany().HasForeignKey(d => d.IdCha).OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<KhoLuuTru>().HasOne(k => k.GetKhoLuuTru).WithMany().HasForeignKey(k => k.IdCha);

            modelBuilder.Entity<HangHoa>().HasOne(h => h.GetDanhMucHang).WithMany().HasForeignKey(h => h.LoaiDanhMuc);

            modelBuilder.Entity<NhapHang>().HasOne(n => n.GetQuanTri).WithMany().HasForeignKey(n => n.NguoiNhap);
            modelBuilder.Entity<NhapHang>().HasOne(n => n.GetChuSoHuu).WithMany().HasForeignKey(n => n.ChuSoHuu);

            modelBuilder.Entity<XuatHang>().HasOne(x => x.GetQuanTri).WithMany().HasForeignKey(x => x.NguoiXuat);
            modelBuilder.Entity<XuatHang>().HasOne(x => x.GetChuSoHuu).WithMany().HasForeignKey(x => x.ChuSoHuu);

            modelBuilder.Entity<KiemHang>().HasOne(k => k.GetQuanTri).WithMany().HasForeignKey(k => k.NguoiKiem);

            modelBuilder.Entity<ChiTietNhapHang>().HasOne(nh => nh.GetNhapHang).WithMany().HasForeignKey(nh => nh.IdPhieu);
            modelBuilder.Entity<ChiTietNhapHang>().HasOne(nh => nh.GetKhoLuuTru).WithMany().HasForeignKey(nh => nh.IdLuuTru);
            modelBuilder.Entity<ChiTietNhapHang>().HasOne(nh => nh.GetHangHoa).WithMany().HasForeignKey(nh => nh.MaHang);

            modelBuilder.Entity<ChiTietXuatHang>().HasOne(xh => xh.GetXuatHang).WithMany().HasForeignKey(xh => xh.IdPhieu);
            modelBuilder.Entity<ChiTietXuatHang>().HasOne(xh => xh.GetKhoLuuTru).WithMany().HasForeignKey(xh => xh.IdLuuTru);
            modelBuilder.Entity<ChiTietXuatHang>().HasOne(xh => xh.GetHangHoa).WithMany().HasForeignKey(xh => xh.MaHang);

            modelBuilder.Entity<ChiTietKiemHang>().HasOne(kh => kh.GetKiemHang).WithMany().HasForeignKey(kh => kh.IdPhieu);
            modelBuilder.Entity<ChiTietKiemHang>().HasOne(kh => kh.GetKhoLuuTru).WithMany().HasForeignKey(kh => kh.IdLuuTru);
            modelBuilder.Entity<ChiTietKiemHang>().HasOne(kh => kh.GetHangHoa).WithMany().HasForeignKey(kh => kh.MaHang);

            // Them du lieu mau
            
            modelBuilder.Entity<QuanTri>().HasData(new QuanTri() {Id = 1, Username = "admin", Password = "admin123", HoTen = "Justin", Email = "justin@gmail.com", Phone = "0941827691", RoleLever = 1 });
            modelBuilder.Entity<QuanTri>().HasData(new QuanTri() {Id = 2, Username = "user", Password = "user123", HoTen = "Liv", Email = "liv@gmail.com", Phone = "0987654321", RoleLever = 2 });
            
            base.OnModelCreating(modelBuilder);
        }

    }
}
