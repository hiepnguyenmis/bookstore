using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using doanmonhocweb.Models;
using doanmonhocweb.Areas.Admin.Models;

namespace doanmonhocweb.Areas.Class
{
    public class AdminClass
    {
        public DateTime ChangeDate(string date)
        {
            string d = date;
            DateTime b = DateTime.Parse(d);
            return b;
        }
    }
}