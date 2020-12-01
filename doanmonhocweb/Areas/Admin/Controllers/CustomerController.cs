using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using doanmonhocweb.Areas.Admin.Models;
using doanmonhocweb.Models;

namespace doanmonhocweb.Areas.Admin.Controllers
{

    public class CustomerController : Controller
    {
        // GET: Admin/Costomer
        dataMeBookEntities dbo = new dataMeBookEntities();
        
        public ActionResult KhachHang()
        {
            return View(dbo.Khach_Hang.ToList());
        }
        [HttpGet]
        public ActionResult Edit(int? Ma_Khach_Hang)
        {
            Khach_Hang Khach_Hang = dbo.Khach_Hang.SingleOrDefault(n => n.Ma_Khach_Hang == Ma_Khach_Hang);
            return View(Khach_Hang);
        }
        [HttpPost]
        public ActionResult Edit(Khach_Hang Khach_Hang)
        {
            dbo.Entry(Khach_Hang).State = System.Data.Entity.EntityState.Modified;
            dbo.SaveChanges();
            return RedirectToAction("KhachHang");
        }
        //public ActionResult Delete(int? Ma_Khach_Hang)
        //{
        //    Khach_Hang a = dbo.Khach_Hang.SingleOrDefault(n => n.Ma_Khach_Hang == Ma_Khach_Hang);
        //    dbo.Khach_Hang.Remove(a);
        //    dbo.SaveChanges();
        //    return RedirectToAction("KhachHang");
        //}
        [HttpGet]
        public ActionResult Details(int? Ma_Khach_Hang)
        {
            Khach_Hang Khach_Hang = dbo.Khach_Hang.SingleOrDefault(n => n.Ma_Khach_Hang == Ma_Khach_Hang);
            return View(Khach_Hang);
        }
        //[HttpPost]
        //public ActionResult Details(info_costomer khach_Hang)
        //{
        //    Khach_Hang a = new Khach_Hang();
        //    khach_Hang.HoKH = a.HoKH;
        //    khach_Hang.TenKH = a.TenKH;
        //   // khach_Hang.NgaySinh = a.NgaySinh;
        //    khach_Hang.DienThoai = a.DienThoai;
        //    khach_Hang.DiaChi = a.DiaChi;
        //    khach_Hang.TenDangNhap = a.TenDangNhap;
        //    khach_Hang.MaKhachHang = a.Ma_Khach_Hang;
            
        //    return View();
        //}
        
    }
}