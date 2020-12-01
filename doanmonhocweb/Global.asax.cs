using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace doanmonhocweb
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }
        protected void Session_Start()
        {
            Session["MaQTV"] = null;
            Session["TenDangNhapQTV"] = null;
            Session["TenQTV"] = null;
            Session["Avatar"] = null;
            Session["MaKhachHang"] = null;
            Session["TenKhachHang"] = null;
            Session["HoKhachHang"] = null;
            Session["TenDangNhap"] = null;
            Session["GioHang"] = null;
            Session["TaiKhoan"] = null;
        }
    }
}
