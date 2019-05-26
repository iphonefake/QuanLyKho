using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BaiVeNhaQuanLyKhoHang.Models
{
    public class HangHoa : BaseEntity
    {
        public string Ten { get; set; }
        public string MoTa { get; set; }
        public double ChieuDai { get; set; }
        public double ChieuRong { get; set; }
        public double ChieuCao { get; set; }
        public string HinhAnh { get; set; }
        public int LoaiDanhMuc { get; set; }

        [ForeignKey("LoaiDanhMuc")]
        public virtual DanhMucHang GetDanhMucHang { get; set; }
    }
}
