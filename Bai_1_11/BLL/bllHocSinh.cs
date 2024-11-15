using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class bllHocSinh
    {
        KetNoi kn;
        public bllHocSinh()
        {
            kn = new KetNoi();
        }
        public DataTable DSHocSinh()
        {
            return kn.LayDataTable("sp_XemHocSinh", null);
        }
        public DataTable Load_Lop()
        {
            return kn.LayDataTable("sp_DSLop", null);
        }
        public DataTable Load_Hocsinh_TheoLop(int malop)
        {
            return kn.LayDataTable("sp_DSHocSinhTheoLop", new SqlParameter("sp_ThemHocSinh@malop", malop));
        }
        public DataTable ThemMonHoc(string HoHS, string TenHS, bool Phai, DateTime NgaySinh, string QueQuan, int MaLop)
        {
            return kn.LayDataTable("sp_ThemHocSinh", 
                                                    new SqlParameter("@HoHS", HoHS),
                                                    new SqlParameter("@TenHS", TenHS),
                                                    new SqlParameter("@Phai", Phai),
                                                    new SqlParameter("@NgaySinh", NgaySinh),
                                                    new SqlParameter("@QueQuan", QueQuan),
                                                    new SqlParameter("@MaLop", MaLop));
        }
        public DataTable SuaMonHoc(int MaHS, string HoHS, string TenHS, bool Phai, DateTime NgaySinh, string QueQuan, int MaLop)
        {
            return kn.LayDataTable("sp_CapNhatHocSinh",
                                                    new SqlParameter("@MaHS", MaHS),
                                                    new SqlParameter("@HoHS", HoHS),
                                                    new SqlParameter("@TenHS", TenHS),
                                                    new SqlParameter("@Phai", Phai),
                                                    new SqlParameter("@NgaySinh", NgaySinh),
                                                    new SqlParameter("@QueQuan", QueQuan),
                                                    new SqlParameter("@MaLop", MaLop));
        }

    }
}
