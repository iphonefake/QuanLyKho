using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BaiVeNhaQuanLyKhoHang.Models
{
    public class QuanTri
    {
        [Key]
        
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string HoTen { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public int RoleLever { get; set; }
        public string UserToken { get; set; }
    }
}
