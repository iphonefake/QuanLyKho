using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BaiVeNhaQuanLyKhoHang.Models
{
    public class ChiTietKiemHang : BaseEntity
    {
        
        public int MaHang { get; set; }
        public int SoLuong { get; set; }
        public int IdPhieu { get; set; }
        public int IdLuuTru { get; set; }

        [ForeignKey("MaHang")]
        public virtual HangHoa GetHangHoa { get; set; }

        [ForeignKey("IdLuuTru")]
        public virtual KhoLuuTru GetKhoLuuTru { get; set; }

        [ForeignKey("IdPhieu")]
        public virtual KiemHang GetKiemHang { get; set; }



    }
}
