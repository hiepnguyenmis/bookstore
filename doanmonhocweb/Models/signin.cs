using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace doanmonhocweb.Models
{
    public class signin
    {
        [Required(ErrorMessage ="Chưa nhập Tên Đăng Nhập")]
        [StringLength(50,ErrorMessage ="Chỉ nhập 50 Ký Tự")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Chưa nhập Mật Khẩu")]
        [StringLength(8, ErrorMessage = "Chỉ nhập 8 Ký Tự")]
        public string Password { get; set; }
    }
}