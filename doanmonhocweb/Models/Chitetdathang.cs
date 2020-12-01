using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace doanmonhocweb.Models
{
    public class Chitetdathang
    {
        [Required(ErrorMessage ="Nhập Vào Địa Chỉ Người Nhận")]
        public string DiaChiNhan { get; set; }
        [Required(ErrorMessage = "Nhập Vào Số Điện Thoại")]
        public string SoDienThoai { get; set; }
        public string Hinhthucnhan { get; set; }
    }
}