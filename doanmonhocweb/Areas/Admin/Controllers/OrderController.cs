using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using doanmonhocweb.Models;
using PagedList;
using PagedList.Mvc;

namespace doanmonhocweb.Areas.Admin.Controllers
{
    public class OrderController : Controller
    {
        // GET: Admin/Order
        dataMeBookEntities dbo = new dataMeBookEntities();

        public ActionResult Order(int? page)
        {

            int pageNumber = (page ?? 1);
            int pageSize = 10;
            return View(dbo.DATHANGs.ToList().OrderByDescending(n => n.NgayDatHang).ToPagedList(pageNumber, pageSize));
        }
        [HttpGet]
        public ActionResult Detail(int? SoHD)
        {
            {
                DATHANG DH = dbo.DATHANGs.SingleOrDefault(n => n.SoHD == SoHD);
                return View(DH);
            }
        }
        [HttpGet]
        public ActionResult Delete(int? SoHD)
        {
            DATHANG DH = dbo.DATHANGs.SingleOrDefault(n => n.SoHD == SoHD);
            return View(DH);
        }
        [HttpPost, ActionName("Delete")]
        public ActionResult ConfirmDelete(int? SoHD)
        {
            DATHANG DH = dbo.DATHANGs.SingleOrDefault(n => n.SoHD == SoHD);
            List<CTDATHANG> CTDH = dbo.CTDATHANGs.Where(n =>n.SoHD == SoHD).ToList();
            if (DH == null)
            {
                Response.StatusCode = 404;
                return null;
            }
            foreach(var item in CTDH)
            {
                dbo.CTDATHANGs.Remove(item);
            }
            
            dbo.DATHANGs.Remove(DH);
            dbo.SaveChanges();
            return RedirectToAction("Order");
        }

    }
}