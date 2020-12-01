using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace doanmonhocweb.Areas.Admin.Models
{
    public class AdminLogin
    {
        [Key]
        public int MaQTV { get; set; }
        [StringLength(20,MinimumLength =5,ErrorMessage ="Độ dài Tên Đăng Nhập không quá 20 ký tự")]
        public string TenDangNhap { get; set; }
        [StringLength(8, ErrorMessage = "Độ dài Tên Đăng Nhập không quá 8 ký tự bao gòm 1 chữ in Hoa Ký tự Đặt biệt và số")]
        public string MatKhau { get; set; }
        public DateTime NgaySinh { get; set; }
        public string Email { get; set; }
        public string QuyenQT { get; set; }
        public string DiaChi { get; set; }
        public int TenQTV { get; set; }
        public string HoQTV { get; set; }
        public bool Gioitinh { get; set; }
    }
}