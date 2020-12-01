using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace doanmonhocweb.Models.Websach.dao
{
    public class UserDAO
    {
        dataMeBookEntities dbo = null;
        public UserDAO()
        {
            dbo =new dataMeBookEntities();
        }

        public bool checkUsername(string userName)
        {
            return dbo.Khach_Hang.Count(x => x.TenDangNhap == userName) > 0;
        }public bool checkMail(string Email)
        {
            return dbo.Khach_Hang.Count(x => x.Email == Email) > 0;
        }
    }
    
}