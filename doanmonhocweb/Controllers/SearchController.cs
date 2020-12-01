using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PagedList;
using PagedList.Mvc;
using doanmonhocweb.Models;

namespace doanmonhocweb.Controllers
{
    public class SearchController : Controller
    {
        // GET: TimKiem
        dataMeBookEntities dbo = new dataMeBookEntities();
        [HttpPost]
        public ActionResult KetQua( FormCollection f,int? page)
        {
            string TuKhoa = f["sreach"].ToString();
            ViewBag.Tukhoa = TuKhoa;
            List<Sach> lstkqtk = dbo.Saches.Where(n => n.Ten_Sach.Contains(TuKhoa)).ToList();
            int pageNumber = (page ?? 1);
            int pageSize = 8;
            if (lstkqtk.Count == 0)
            {
                ViewBag.Thongbao = "Không tìm thấy sản phẩm nào";
            }

            ViewBag.Thongbao = "Đã tìm thấy " + lstkqtk.Count + "Ket Qua";
            return View(lstkqtk.OrderBy(n=>n.Ten_Sach).ToPagedList(pageNumber,pageSize));
        }
        [HttpGet]
        public ActionResult KetQua(  int? page, string TuKhoa)
        {
            
            List<Sach> lstkqtk = dbo.Saches.Where(n => n.Ten_Sach.Contains(TuKhoa)).ToList();
            int pageNumber = (page ?? 1);
            int pageSize = 8;
            if (lstkqtk.Count == 0)
            {
                ViewBag.Thongbao = "Không tìm thấy sản phẩm nào";
            }
            ViewBag.Thongbao = "Đã tìm thấy " + lstkqtk.Count + "Ket Qua";


            return View(lstkqtk.OrderBy(n=>n.Ten_Sach).ToPagedList(pageNumber,pageSize));
        }

    }
}