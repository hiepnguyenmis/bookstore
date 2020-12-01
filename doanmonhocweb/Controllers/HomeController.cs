using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using doanmonhocweb.Models;


namespace doanmonhocweb.Controllers
{
    public class HomeController : Controller
    {
        dataMeBookEntities dbo = new dataMeBookEntities();
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
    }

}
