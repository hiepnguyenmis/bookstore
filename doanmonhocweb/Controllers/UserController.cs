using doanmonhocweb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using doanmonhocweb.Models.Websach.dao;
using System.Text;
using System.Security.Cryptography;

namespace doanmonhocweb.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult signup()
        {
            return View();
        }
        [HttpPost]
        public ActionResult signup(signup p)/*DangKy*/
        {
            if (ModelState.IsValid)
            {
                var userdao = new UserDAO();
                if (userdao.checkUsername(p.Username))
                {
                    ModelState.AddModelError(string.Empty,"");
                    ViewBag.ErrSigupUserName="Email đã tồn tại!";
                }
                else if (userdao.checkUsername(p.Email))
                {
                    ModelState.AddModelError(string.Empty, "");
                    ViewBag.ErrSigupEmail="Email đã tồn tại!";

                }
                else
                {
                    dataMeBookEntities dbo = new dataMeBookEntities();
                    Khach_Hang a = new Khach_Hang();
                    a.TenDangNhap = p.Username;
                    a.Email = p.Email;
                    a.MatKhau = Encryptor.MD5Hash(p.Password1);
                    a.DienThoai = p.phone;
                    dbo.Khach_Hang.Add(a);
                    dbo.SaveChanges();

                }
                return Redirect("/");
            }
            return View();
        }
        
        public ActionResult signin()
        {

            return View();
        }
        [HttpPost]
        public ActionResult signin(signin p)
        {
            if (ModelState.IsValid)
            {
                string password = Encryptor.MD5Hash(p.Password);
                
                dataMeBookEntities dbo = new dataMeBookEntities();
                QuanTriVien qtv = dbo.QuanTriViens.SingleOrDefault(x => x.TenDagNhapQTV == p.Username && x.MatKhauQTV == password);
                if (qtv!=null)
                {
                    Session["MaQTV"] = qtv.Ma_QTV;
                    Session["TenDangNhapQTV"] = qtv.TenDagNhapQTV;
                    Session["TenQTV"] = qtv.TenQTV;
                    Session["Avatar"] = qtv.Avatar;
                    HttpCookie CK_TKAD = new HttpCookie("TaiKhoanAdmin");
                    CK_TKAD.Value = qtv.TenDagNhapQTV;
                    CK_TKAD.Expires = DateTime.Now.AddDays(1);
                    HttpContext.Response.Cookies.Add(CK_TKAD);
                    return Redirect("~/Admin");
                }
                Khach_Hang a = dbo.Khach_Hang.SingleOrDefault(x => x.TenDangNhap == p.Username && x.MatKhau ==password);
                HttpCookie CK_TK = new HttpCookie("TaiKhoan");
                CK_TK.Value = p.Username;
                CK_TK.Expires = DateTime.Now.AddMinutes(15);
                HttpContext.Response.Cookies.Add(CK_TK);
                if (a!= null)
                {
                    Session["TaiKhoan"] = a;
                    Session["MaKhachHang"] = a.Ma_Khach_Hang;
                    Session["HoKhachHang"] = a.HoKH;
                    Session["TenKhachHang"] = a.TenKH;
                    Session["TenDangNhap"] = a.TenDangNhap;
                    return Redirect("/");
                }
                else
                {
                    ViewBag.Errsignup = "Đang Nhập Sai Vui Lòng Đăng Nhập Lại";
                }
            }
            else
            {
                ViewBag.Errsignup = "Đang Nhập Sai Vui Lòng Kiểm Tra Tài Khoản Mật Khẩu";
            }
            return View();
        }
        public ActionResult signout()
        {

            Session.Clear();
            return RedirectToAction("Index","Home");
        }
    }
}