using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using doanmonhocweb.Models;
using  System.ComponentModel.DataAnnotations;

namespace doanmonhocweb.Controllers
{
    public class TestController : Controller
    {

        dataMeBookEntities dbo = new dataMeBookEntities();
        [HttpGet]
        public ActionResult test(int id)
        {
            Khach_Hang a = dbo.Khach_Hang.SingleOrDefault(n => n.Ma_Khach_Hang == id);
            return View();
        }
        [HttpPost]
        public ActionResult test(Khach_Hang Khachang)
        {
            dbo.Entry(Khachang).State = System.Data.Entity.EntityState.Modified;
            dbo.SaveChanges();
            return Redirect("/");
        }
    }
}