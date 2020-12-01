using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace doanmonhocweb.Areas.Admin.Models
{
    public class info_Book
    {
        [Key]
        public int MaSach { get; set; }
        public string TenSach { get; set; }
        public string TacGia { get; set; }
        public float Gia { get; set; }
        public float GiaCuaHang { get; set; }
        public string DonViTinh { get; set; }
        public int MaNXB { get; set; }
        public DateTime NgayCapNhat { get; set; }
        public int Machude { get; set; }
        public string Mota { get; set; }
        public int? Soluongban { get; set; }
        public int SolanXem { get; set; }
        public int Soluongton { get; set; }
        public string HinhAnh { get; set; }
        public string NhaPhanPhoi { get; set; }
        public int Sotrang { get; set; }
        public string Loai { get; set; }
        public string LoaiBia { get; set; }
        
    }
}