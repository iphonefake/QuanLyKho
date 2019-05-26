using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BaiVeNhaQuanLyKhoHang.Models
{
    public class ChuSoHuu : BaseEntity
    {
        public string Ten { get; set; }
        public string TenVietTat { get; set; }
        public string NguoiDaiDien { get; set; }
        public string DiaChi { get; set; }
        public string SoDienThoai { get; set; }
        public bool TrangThai { get; set; }

    }
}
