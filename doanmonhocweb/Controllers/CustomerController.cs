using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using doanmonhocweb.Models;

namespace doanmonhocweb.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Costomer
        public ActionResult Customer()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Customer(int? Ma_Khach_Hang)
        {
            dataMeBookEntities dbo = new dataMeBookEntities();
            Khach_Hang Khach_Hang = dbo.Khach_Hang.SingleOrDefault(n => n.Ma_Khach_Hang == Ma_Khach_Hang);
            return View(Khach_Hang);
        }

        [HttpPost]
        public ActionResult Customer(Khach_Hang Khach_Hang, info_costomer p)
        {
            try
            {
               var b = Request["Ngaysinh"];
                DateTime date = DateTime.Parse(b);
                p.NgaySinh = date;
                
                

            }
            catch
            {
                var x= "1/1/1990";
                var dateErr = DateTime.Parse(x);
                Khach_Hang.NgaySinh = dateErr;
            }
            var d = Request["Gioitinh"];
            Khach_Hang.Gioi_tinh = d;
            Khach_Hang.NgaySinh = p.NgaySinh;
            dataMeBookEntities dbo = new dataMeBookEntities();
                dbo.Entry(Khach_Hang).State = System.Data.Entity.EntityState.Modified;
                dbo.SaveChanges();
                
                return RedirectToAction("InfomationCustomer","Customer", new { Ma_Khach_Hang=Khach_Hang.Ma_Khach_Hang});
        }
        public ActionResult InfomationCustomer()
        {

            return View();
        }
        [HttpGet]
        public ActionResult InfomationCustomer(int? Ma_Khach_Hang)
        {
            dataMeBookEntities dbo = new dataMeBookEntities();
            Khach_Hang Khach_Hang = dbo.Khach_Hang.SingleOrDefault(n => n.Ma_Khach_Hang == Ma_Khach_Hang);
            return View(Khach_Hang);
        }
    }
}