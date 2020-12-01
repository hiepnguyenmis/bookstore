using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using doanmonhocweb.Areas.Admin.Models;
using doanmonhocweb.Models;

namespace doanmonhocweb.Areas.Admin.Controllers
{
    public class LoginController : Controller
    {
        // GET: Admin/Login
        //public ActionResult Index()
        //{
        //    return View();
        //}
        //[HttpPost]
        //public ActionResult Index(AdminLogin a)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        dataMeBookEntities dbo = new dataMeBookEntities();
        //        QuanTriVien p = dbo.QuanTriViens.SingleOrDefault(m => m.TenDagNhapQTV == a.TenDangNhap && m.MatKhauQTV == a.MatKhau);
        //        if (p != null)
        //        {
                    
        //            Session["MaQTV"] = p.Ma_QTV;
        //            Session["TenDangNhapQTV"] = p.TenDagNhapQTV;
        //            Session["TenQTV"] = p.TenQTV;
        //            Session["Avatar"] =p.Avatar;
        //            HttpCookie CK_TKAD = new HttpCookie("TaiKhoanAdmin");
        //            CK_TKAD.Value = p.TenDagNhapQTV;
        //            CK_TKAD.Expires = DateTime.Now.AddDays(1);
        //            HttpContext.Response.Cookies.Add(CK_TKAD);
        //            return Redirect("~/Admin");
        //        }
        //        else
        //        {
        //            Session["MaQTV"] = null;
        //            ViewBag.ErrLoginAd = "Đăng Nhập Sai! Vui lòng đăng nhập lại ^^";
                    
        //        }
        //    }
        //    return View();

        //}
        public ActionResult AdLogout()
        {
            Session["MaQTV"] = null;
            Session["TenDangNhapQTV"] = null;
            Session["TenQTV"] = null;
            Session["Avatar"] =null;
            return Redirect("~/User/signin");
        }
    }
}