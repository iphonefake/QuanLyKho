using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BaiVeNhaQuanLyKhoHang.Models
{
    public class KhoLuuTru : BaseEntity
    {
        public string MaTen { get; set; }
        public int? IdCha { get; set; }
        public bool HoatDong { get; set; }

        [ForeignKey("IdCha")]
        public virtual KhoLuuTru GetKhoLuuTru { get; set; }
    }
}
