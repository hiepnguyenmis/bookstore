using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace doanmonhocweb.Models
{
    public class Export
    {
        public int Ma_Sach { get; set; }
        public string Ten_Sach { get; set; }
        public string Tac_Gia { get; set; }
        public double Gia { get; set; }
        public double GiaCuaHang { get; set; }
        public string Don_Vi_Tinh { get; set; }
        public int Ma_NXB { get; set; }
        public DateTime NgayCapNhat { get; set; }
        public int Ma_CD { get; set; }
        public string Mota { get; set; }
        public int SoLuongTon { get; set; }
        public int SoLuongBan { get; set; }
        public int SoLanXem { get; set; }
        public string HinhAnh { get; set; }
        public string Loai { get; set; }
        public string LoaiBia { get; set; }
        public int SoTrang { get; set; }
        public string NhaPhanPhoi { get; set; }
        public string Tieude { get; set; }
    }
}