using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace doanmonhocweb.Models
{
    public class Cart
    {

        dataMeBookEntities dbo =new dataMeBookEntities();
        public int SoHD { get; set; }
        public int Ma_Sach { get; set; }
        public string TenSanPham { get; set; }
        public double? DonGia { get; set; }
        public string HinhAnh { get; set; }
        [StringLength (4,ErrorMessage ="Số Lượng Không Quá 9999")]
        [RegularExpression("([0-9]+)", ErrorMessage = "không nhập ký tự chữ")]
        public int SoLuong { get; set; }
        public double? ThanhTien {
            get { return SoLuong * DonGia; }
        }
        //khoi tao gio hang
        public Cart(int MaSach)
        {
            Ma_Sach = MaSach;
            Sach sach = dbo.Saches.Single(n => n.Ma_Sach == Ma_Sach);
            TenSanPham = sach.Ten_Sach;
            HinhAnh = sach.HinhAnh;
            DonGia = sach.GiaCuaHang;
            SoLuong = 1;
        }
    }
}