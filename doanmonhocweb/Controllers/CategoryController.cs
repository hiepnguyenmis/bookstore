using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using doanmonhocweb.Models;
using PagedList;
using PagedList.Mvc;
namespace doanmonhocweb.Controllers
{
    public class CategoryController : Controller
    {
        // GET: Category
        dataMeBookEntities dbo = new dataMeBookEntities();
        public ActionResult tatcasach(int? page)
        {
            int pageNumber = (page ?? 1);
            int pageSize = 8;

            return View(dbo.Saches.ToList().OrderByDescending(n => n.NgayCapNhat).Where(n => n.Loai == "Việt Nam").ToPagedList(pageNumber, pageSize));
        }
        public ActionResult Sach_Moi_Phat_Hanh(int? page)
        {
            int pageNumber = (page ?? 1);
            int pageSize = 8;

            return View(dbo.Saches.ToList().OrderByDescending(n => n.NgayCapNhat).Where(n => n.Loai == "Việt Nam").ToPagedList(pageNumber, pageSize));
        }

        public ActionResult Sach_Thieu_Nhi(int? page)
        {
            int pageNumber = (page ?? 1);
            int pageSize = 8;
            return View(dbo.Saches.ToList().OrderByDescending(n => n.NgayCapNhat).Where(n => n.Ma_CD == 7  || n.Ma_CD==8 && n.Loai == "Việt Nam").ToPagedList(pageNumber, pageSize));
        }
        public ActionResult Sach_Van_Hoc(int? page)
        {
            int pageNumber = (page ?? 1);
            int pageSize = 8;
            return View(dbo.Saches.ToList().OrderByDescending(n => n.NgayCapNhat).Where(n => n.Ma_CD == 3 && n.Loai == "Việt Nam").ToPagedList(pageNumber, pageSize));
        }
        public ActionResult Sach_Kinh_Te(int? page)
        {
            int pageNumber = (page ?? 1);
            int pageSize = 8;
            return View(dbo.Saches.ToList().OrderByDescending(n => n.NgayCapNhat).Where(n => n.Ma_CD == 2 && n.Loai == "Việt Nam").ToPagedList(pageNumber, pageSize));
        }
        public ActionResult Sach_Ky_Nang_Song(int? page)
        {
            int pageNumber = (page ?? 1);
            int pageSize = 8;
            return View(dbo.Saches.ToList().OrderByDescending(n => n.NgayCapNhat).Where(n => n.Ma_CD == 9 && n.Loai == "Việt Nam").ToPagedList(pageNumber, pageSize));
        }

        public ActionResult Truyen_Tranh(int? page)
        {
            int pageNumber = (page ?? 1);
            int pageSize = 8;
            return View(dbo.Saches.ToList().OrderByDescending(n => n.NgayCapNhat).Where(n => n.Ma_CD == 8 && n.Loai == "Việt Nam").ToPagedList(pageNumber, pageSize));
        }
        public ActionResult Sach_Giao_Khoa(int? page)
        {
            int pageNumber = (page ?? 1);
            int pageSize = 8;
            return View(dbo.Saches.ToList().OrderByDescending(n => n.NgayCapNhat).Where(n => n.Ma_CD == 11 && n.Loai == "Việt Nam").ToPagedList(pageNumber, pageSize));
        }
        public ActionResult Tat_Ca_Ngoai_Van(int? page)
        {
            int pageNumber = (page ?? 1);
            int pageSize = 8;
            return View(dbo.Saches.ToList().OrderByDescending(n => n.NgayCapNhat).Where(n => n.Loai == "Nước Ngoài").ToPagedList(pageNumber, pageSize));
        }

        public ActionResult Sach_Ngoai_Van_Van_Hoc(int? page)
        {
            int pageNumber = (page ?? 1);
            int pageSize = 8;
            return View(dbo.Saches.ToList().OrderByDescending(n => n.NgayCapNhat).Where(n => n.Ma_CD == 3 && n.Loai == "Nước Ngoài").ToPagedList(pageNumber, pageSize));
        }

        public ActionResult Sach_Ngoai_Van_Thieu_Nhi(int? page)
        {
            int pageNumber = (page ?? 1);
            int pageSize = 8;
            return View(dbo.Saches.ToList().OrderByDescending(n => n.NgayCapNhat).Where(n => n.Ma_CD == 7 && n.Ma_CD == 8 && n.Loai == "Nước Ngoài").ToPagedList(pageNumber, pageSize));
        }
        public ActionResult Sach_Ngoai_Van_Kinh_Doanh(int? page)
        {
            int pageNumber = (page ?? 1);
            int pageSize = 8;
            return View(dbo.Saches.ToList().OrderByDescending(n => n.NgayCapNhat).Where(n => n.Ma_CD == 2 && n.Loai == "Nước Ngoài").ToPagedList(pageNumber, pageSize));
        }

        public ActionResult Sach_Ngoai_Van_Giao_Duc(int? page)
        {
            int pageNumber = (page ?? 1);
            int pageSize = 8;
            return View(dbo.Saches.ToList().OrderByDescending(n => n.NgayCapNhat).Where(n => n.Ma_CD == 4 && n.Loai == "Nước Ngoài").ToPagedList(pageNumber, pageSize));
        }
        public ActionResult Tu_Dien(int? page)
        {
            int pageNumber = (page ?? 1);
            int pageSize = 8;
            return View(dbo.Saches.ToList().OrderByDescending(n => n.NgayCapNhat).Where(n => n.Ma_CD == 10 && n.Loai == "Nước Ngoài").ToPagedList(pageNumber, pageSize));
        }

    }
}