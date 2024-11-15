using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Data;
using Mananer = System.Configuration.ConfigurationManager;
namespace DAL
{
    public class KetNoi
    {
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable tb;
        public KetNoi()
        {
            conn = new SqlConnection(Mananer.AppSettings.Get("strconn"));
        }
        public void MoKetNoi()
        {
            try
            {
                conn.Open();
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }  
        public void DongKetNoi()
        {
            try
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }

        }
        public DataTable LayDataTable(string sql, params SqlParameter[] param)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                    MoKetNoi();
                cmd = new SqlCommand(sql, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                if(param != null)
                {
                    foreach(SqlParameter p in param )
                    {
                        cmd.Parameters.Add(p);
                    }
                }
                da = new SqlDataAdapter(cmd);
                tb = new DataTable();
                da.Fill(tb);
                return tb;
            }
            catch(Exception ex)
            {
                //err = "Lỗi: " + ex.Message.ToString();
                return null;
            }
            finally
            {
                DongKetNoi();
            }
        }
    }
}

