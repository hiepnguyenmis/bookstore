using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using doanmonhocweb.Models;
using System.Data.Entity;

namespace doanmonhocweb.Controllers
{
    public class CartController : Controller
    {
        dataMeBookEntities dbo =new dataMeBookEntities();
        // GET: Cart
        public List<Cart> getCart()
        {
            List<Cart> lstCart = Session["GioHang"] as List<Cart>;
            //Khoi  tạo gio hàng neu chưa có
            if (lstCart == null)
            {
                lstCart = new List<Cart>();
                Session["GioHang"] = lstCart;
            }
            return lstCart;
        }
        public ActionResult AddCart(int MaSach, string Re_Url)
        {
            
            Sach sach = dbo.Saches.SingleOrDefault(n => n.Ma_Sach == MaSach);
            if (sach == null)
            {
                Response.StatusCode = 404;
                return null;
            }
            List<Cart> lstCart = getCart();
            Cart SP = lstCart.Find(n => n.Ma_Sach == MaSach);
            string soluongdat = Request["txt_Soluongdat"];
            //kiem tra gio hang da ton tai trong session

            if (SP==null)
            {
                SP = new Cart(MaSach);
                lstCart.Add(SP);
                return Redirect(Re_Url);
            }
            else
            {
                SP.SoLuong++;
                return Redirect(Re_Url);
            }
        }
        //Cap Nhat gio hang
        public ActionResult UpdateCart(int MaSP, FormCollection f)
        {
            Sach sach = dbo.Saches.SingleOrDefault(n => n.Ma_Sach == MaSP);
            if (sach == null)
            {
                Response.StatusCode = 404;
                return null;
            }
            List<Cart> lstCart = getCart();
            Cart SP = lstCart.SingleOrDefault(n => n.Ma_Sach == MaSP);
            if (SP != null)
            {
                SP.SoLuong = int.Parse(f["txt_Soluong"].ToString());
            }
            return RedirectToAction("GioHang");
        }
        public ActionResult DeleteCart(int MaSP)
        {
            Sach sach = dbo.Saches.SingleOrDefault(n => n.Ma_Sach == MaSP);
            if (sach == null)
            {
                Response.StatusCode = 404;
                return null;
            }
            List<Cart> lstCart = getCart();
            Cart SP = lstCart.SingleOrDefault(n => n.Ma_Sach == MaSP);
            if (SP != null)
            {
                lstCart.RemoveAll(n => n.Ma_Sach == MaSP);
            }
            if (lstCart.Count == 0)
            {
                Session["GioHang"] = null;
                return RedirectToAction("Index","Home");
            }
            return RedirectToAction("GioHang");
        }
        //Xay dung trang gio hang
        public ActionResult GioHang()
        {
            if (Session["GioHang"] == null)
            {
                return RedirectToAction("Index", "Home");

            }
            List<Cart> lstCart = getCart();
            ViewBag.TongTien = TongTien();
            return View(lstCart);
        }
        private double TongSoLuong()
        { 
            int TongSL = 0;
            List<Cart> lstCart = Session["GioHang"] as List<Cart>;
            if (lstCart != null)
            {
                TongSL = lstCart.Sum(n => n.SoLuong);
            }
            return TongSL;
        }
        private double? TongTien()
        {
            double? TongTien = 0;
            List<Cart> lstCart = Session["GioHang"] as List<Cart>;
            if (lstCart != null)
            {
                TongTien = lstCart.Sum(n => n.ThanhTien);
            }
            return TongTien;
        }
        public ActionResult PartialCart()
        {
            if (TongSoLuong()==0)
            {
                return PartialView();
            }
            ViewBag.TongSoLuong = TongSoLuong();
            
            return PartialView();
        }
        public ActionResult EditCart()
        {
            if (Session["GioHang"] == null)
            {
                return RedirectToAction("Index", "Home");
            }
            List<Cart> lstCart = getCart();
            return View(lstCart);
        }
        public ActionResult DetailOrder()
        {
            return View();
        }
        /*Dat Hang*/
        [HttpPost]
        public ActionResult DetailOrder( Chitetdathang p)
        {
            if (Session["MaKhachHang"] == null || Session["TenDangNhap"] == null)
            {
                return RedirectToAction("Signin", "User");
            }
            if (Session["GioHang"] == null)
            {
                return RedirectToAction("Index", "Home");
            }
            return View();
        }
        public ActionResult Order()
        {
            if(Session["MaKhachHang"]==null || Session["TenDangNhap"] == null)
            {
                return RedirectToAction("Signin", "User");
            }
            if (Session["GioHang"] == null)
            {
                return RedirectToAction("Index", "Home");
            }
            Chitetdathang p= new Chitetdathang();
            DATHANG DH = new DATHANG();
            Khach_Hang KH =(Khach_Hang)Session["TaiKhoan"];
            List<Cart> GH = getCart();
            DH.Ma_KhachHang = KH.Ma_Khach_Hang;
            DH.NgayDatHang = DateTime.Now;
            DH.TenNguoiNhan = KH.HoKH +" "+ KH.TenKH;
            if (DH.TenNguoiNhan == null)
            {
                DH.TenNguoiNhan = KH.TenDangNhap;
            }
            DH.SoDienThoai = Request["Sodienthoai"];
            DH.DiaChiNhan = Request["DiachiNhan"];
            DH.HinhThucThanhToan = Request["Hinhthucthanhtoan"];
            DH.TriGia = TongTien();
            dbo.DATHANGs.Add(DH);
            dbo.SaveChanges();
            foreach (var item in GH)
            {
                CTDATHANG CTDH = new CTDATHANG();
                
                CTDH.SoHD = item.SoHD;
                CTDH.SoHD = DH.SoHD;
                CTDH.MaHangHoa = item.Ma_Sach;
                CTDH.SoLuong = item.SoLuong;
                CTDH.DonGia = (decimal)item.DonGia;
                CTDH.ThanhTien = (decimal)item.ThanhTien;
                Sach sl = dbo.Saches.Find(item.Ma_Sach);
                sl.SoLuongTon = sl.SoLuongTon - item.SoLuong;
                sl.SoLuongBan = 0;
                sl.SoLuongBan = sl.SoLuongBan + item.SoLuong;
                if (sl.SoLuongTon >= 0)
                {
                    
                    dbo.Entry(sl).State = EntityState.Modified;
                }
                else
                {
                    sl.SoLuongTon = 0;
                    ViewBag.sltErr = sl.SoLuongTon;
                    dbo.Entry(sl).State = EntityState.Modified;
                }
                
                dbo.CTDATHANGs.Add(CTDH);
            }
            dbo.SaveChanges();
            Session["GioHang"] = null;
            return RedirectToAction("Index","Home");
        }
    }
}