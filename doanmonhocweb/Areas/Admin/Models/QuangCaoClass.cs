using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace doanmonhocweb.Areas.Admin.Models
{
    public class QuangCaoClass
    {
        [Key]
        public int MaQC { get; set; }
        public string TieuDeQC { get; set; }
        public string HinhQC { get; set; }
        public DateTime NgayThemQC { get; set; }
    }
}