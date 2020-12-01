using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace doanmonhocweb.Models
{
    public class info_costomer
    {
        [Key]
        public int MaKhachHang { get; set; }
        [StringLength(20,MinimumLength =2,ErrorMessage ="Họ không quá 20 ký tự ")]
        public String HoKH { get; set; }
        [StringLength(50,ErrorMessage ="Tên không quá 50 ký tự")]
        public String TenKH { get; set; }
        [StringLength(50,ErrorMessage ="Tên đăng nhập không quá 50 ký tự ")]
        public String TenDangNhap { get; set; }
        public DateTime NgaySinh { get; set; }
        public String GioiTinh { get; set; }
        [EmailAddress()]
        public String Email { get; set; }
        [StringLength(12,ErrorMessage ="Sai số điện thoại")]
        public String DienThoai { get; set; }
        public String DiaChi { get; set; }
    }
}