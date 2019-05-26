using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BaiVeNhaQuanLyKhoHang.Models
{
    public class XuatHang : BaseEntity
    {
        public string MaPhieu { get; set; }
        public DateTime NgayXuat { get; set; }
        public int NguoiXuat { get; set; }
        public int ChuSoHuu { get; set; }
        public string GhiChu { get; set; }


        [ForeignKey("NguoiXuat")]
        public virtual QuanTri GetQuanTri { get; set; }

        [ForeignKey("ChuSoHuu")]
        public virtual ChuSoHuu GetChuSoHuu { get; set; }
    }
}
