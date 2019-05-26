using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BaiVeNhaQuanLyKhoHang.Models
{
    public class KiemHang : BaseEntity
    {
        public string MaPhieu { get; set; }
        public DateTime NgayKiem { get; set; }
        public int NguoiKiem { get; set; }
        public string GhiChu { get; set; }

        [ForeignKey("NguoiKiem")]
        public virtual QuanTri GetQuanTri { get; set; }

    }
}
