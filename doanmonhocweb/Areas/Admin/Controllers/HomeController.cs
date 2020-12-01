using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace doanmonhocweb.Areas.Admin.Controllers
{
    public class HomeController : Controller
    {
        // GET: Admin/Home
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult manageCostomer()
        {
            if (ModelState.IsValid)
            {
                Redirect("Index");
            }
            return View();
        }
    }
}