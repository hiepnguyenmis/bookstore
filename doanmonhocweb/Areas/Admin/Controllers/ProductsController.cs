using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using doanmonhocweb.Models;
using doanmonhocweb.Areas.Admin.Models;
using doanmonhocweb.Areas.Class;
using PagedList;
using PagedList.Mvc;
using System.IO;
using System.Data.Entity;
using OfficeOpenXml;

namespace doanmonhocweb.Areas.Admin.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Admin/Products
        dataMeBookEntities dbo = new dataMeBookEntities();
       
        public ActionResult Book(int? page)
        {

            int pageNumber = (page ?? 1);
            int pageSize = 10;
            return View(dbo.Saches.ToList().OrderByDescending(n=>n.NgayCapNhat).ToPagedList(pageNumber,pageSize));
        }
        public ActionResult AddBook()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddBook(info_Book p, HttpPostedFileBase Postimgbook)
        {
            Sach a = new Sach();
            a.Ten_Sach = p.TenSach;
            a.Gia = p.Gia;
            a.GiaCuaHang = p.GiaCuaHang;
            var i = Request["NXB"];
            var j = Request["ChuDe"];
            var k = Request["XuatXu"];
            int n = int.Parse(i);
            int m = int.Parse(j); 
            a.Ma_NXB = n;
            a.Ma_CD = m;
            a.Loai = k;
            a.Don_Vi_Tinh = Request["DonViTinh"];
            a.NgayCapNhat = DateTime.Now.Date;
            a.Mota = Request["Mota"];
            a.SoLanXem = p.SolanXem;
            a.Tac_Gia = p.TacGia;
            a.SoLuongTon = p.Soluongton;
            a.LoaiBia = Request["LoaiBia"];
            a.SoTrang = p.Sotrang;
            a.NhaPhanPhoi = p.NhaPhanPhoi;
            
            if (Postimgbook != null)
            {
                var fileName = Path.GetFileName(Postimgbook.FileName);
                var filePath = Path.Combine(Server.MapPath("~/Content/ImgBook"), fileName);
                Postimgbook.SaveAs(filePath);
                a.HinhAnh = Postimgbook.FileName;
                dbo.SaveChanges();
            }

            else
            {
                dbo.Saches.Add(a);
                dbo.SaveChanges();
            }
            dbo.Saches.Add(a);
            dbo.SaveChanges();
            return View();
        }
        [HttpGet]
        public ActionResult Detail(int? Ma_Sach) {
            Sach sach = dbo.Saches.SingleOrDefault(n => n.Ma_Sach == Ma_Sach);
            return View(sach);
        }
        [HttpGet]
        public ActionResult Edit(int? Ma_Sach)
        {
            Sach sach = dbo.Saches.SingleOrDefault(n => n.Ma_Sach == Ma_Sach);
            
            return View(sach);
        }
       
        [HttpPost]
        public ActionResult Edit(Sach sach,HttpPostedFileBase Postfile )
        {

            var i= Request["NXB"];
            var j= Request["NXB"];
            int n = int.Parse(i);
            int m = int.Parse(i);
            sach.Ma_NXB = n;
            sach.Ma_CD = n;
            sach.Don_Vi_Tinh = Request["DonViTinh"];
            sach.LoaiBia = Request["LoaiBia"];
            sach.Loai = Request["XuatXu"];
            sach.NgayCapNhat = DateTime.Now.Date;
            /***/
            if (Postfile != null)
            {
                var fileName = Path.GetFileName(Postfile.FileName);
                var filePath = Path.Combine(Server.MapPath("~/Content/ImgBook"),fileName);
                if (System.IO.File.Exists(filePath))
                {
                    sach.HinhAnh = Postfile.FileName;
                    dbo.Entry(sach).State = EntityState.Modified;
                    dbo.SaveChanges();
                }
                else
                {
                    Postfile.SaveAs(filePath);
                    sach.HinhAnh = Postfile.FileName;
                    dbo.Entry(sach).State = EntityState.Modified;
                    dbo.SaveChanges();
                }
            }
            else
            {
                dbo.Entry(sach).State = EntityState.Modified;
                dbo.SaveChanges();
            }
           /**/
            dbo.Entry(sach).State = EntityState.Modified;
            dbo.SaveChanges();
            return RedirectToAction("Book");
        }
        [HttpGet]
        public ActionResult Delete(int? Ma_Sach)
        {
            Sach sach = dbo.Saches.SingleOrDefault(n => n.Ma_Sach == Ma_Sach);
            return View(sach);
        }
        [HttpPost, ActionName("Delete")]
        public ActionResult ConfirmDelete(int? Ma_Sach)
        {
            Sach sach = dbo.Saches.SingleOrDefault(a => a.Ma_Sach == Ma_Sach);
            if (sach == null)
            {
                Response.StatusCode = 404;
                return null;
            }
            dbo.Saches.Remove(sach);
            dbo.SaveChanges();
            return RedirectToAction("Book");
        }
        //[HttpPost]
        //public ActionResult InportFile()
        //{
        //    String massge = string.Empty;
        //    int count = 0;
        //    InportData(out count);
        //    return RedirectToAction("Book");
        //}

        //private bool InportData(out int count)
        //{
        //    var result = false;
        //    count = 0;
        //    try
        //    {
        //        String path = Server.MapPath("/") + "\\Content\\Inport\\Book1.xlxs";
        //        var package =new ExcelPackage();
        //        int StartCol = 1;
        //        int StartRow = 2;
        //        ExcelWorksheet workSheet = package.Workbook.Worksheets[1];
        //        object data = null;
        //        while (data==null)
        //        {
        //            data = workSheet.Cells[StartRow, StartCol ].Value;
        //            object className = workSheet.Cells[StartRow, StartCol+1].Value;
        //            if (data != null && className!=null)
        //            {
        //                var isSuccess = luuSach(className.ToString(),dbo);
        //                if (isSuccess)
        //                {
        //                    count++;
        //                }
        //            }
        //            StartRow++;
        //        }
        //    }
        //    catch
        //    {

        //    }
        //    return result;
        //}
        //public bool luuSach(String tenSach, dataMeBookEntities dbo)
        //{
        //     var result = false;
        //    try
        //    {
        //        if (dbo.Saches.Where(t => t.Ten_Sach.Equals(tenSach)).Count() == 0)
        //        {
                   
        //            var item = new Sach();
        //            item.Ten_Sach = tenSach;
        //            dbo.Saches.Add(item);
        //            dbo.SaveChanges();
        //            result= true;
        //        }
        //    }
        //    catch
        //    {

        //    }
        //    return result;
        //}
    }
}
