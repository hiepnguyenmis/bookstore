using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using doanmonhocweb.Models;

namespace doanmonhocweb.Controllers
{
    public class ProductsController : Controller
    {
        dataMeBookEntities dbo = new dataMeBookEntities();
        // GET: Products
        [HttpGet]
        public ActionResult Single_products(int? Ma_Sach)
        {
            Sach Sach = dbo.Saches.SingleOrDefault(n => n.Ma_Sach == Ma_Sach);
            return View(Sach);
        }
    }
}