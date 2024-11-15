using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using DAL;
using System.Data;
using System.Data.SqlClient;

namespace BLL
{
    //internal (cái cũ)  ----> public (quan trọng)
    public class bll_Login
    {
        KetNoi kn = null;
        public bll_Login()
        {
            kn = new KetNoi();
        }
        public DataTable Login(string taikhoan, string matkhau)
        {
            return kn.LayDataTable("sp_Login", new SqlParameter("@taikhoan", taikhoan),
                                                   new SqlParameter("@matkhau", matkhau));
        }
    }
}
