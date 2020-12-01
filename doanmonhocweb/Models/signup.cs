using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace doanmonhocweb.Models
{
    public class signup
    {

        [Key]
        public int Ma_KhachHang { get; set; }

        [Required(ErrorMessage ="Nhập Vào Tên Đăng Nhập")]
        [StringLength(50,ErrorMessage ="Tên Đăng Nhập Không Quá 50 Ký tự")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Nhập Vào Email")]
        [EmailAddress(ErrorMessage = "Sai địa chỉ Email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Nhập Vào Mật Khẩu")]
        [StringLength(10, ErrorMessage = "Mật Khẩu Không Quá 50 Ký tự")]

        public string Password1 { get; set; }

        [Required(ErrorMessage = "Nhập Lại Mật Khẩu")]

        public string Password2 { get; set; }
        [Required(ErrorMessage = "Nhập Lại số điện thoại")]

        public string phone { get; set; }
    }
}