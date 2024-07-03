using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class DataProvider
    {
        public static SqlConnection MoKetNoi()
        {
            string s = @"Data Source=LAPTOP-KLFNM45V;Initial Catalog=QLTTTiengAnh;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
            SqlConnection KetNoi = new SqlConnection(s);
            KetNoi.Open();
            return KetNoi;
        }
        // Thực hiện truy vấn trả về bảng dữ liệu
        public static DataTable TruyVanLayDuLieu(string query, SqlConnection KetNoi)
        {
            SqlDataAdapter da = new SqlDataAdapter(query, KetNoi);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        // Thực hiện truy vấn không trả về dữ liệu
        public static bool TruyVanKhongLayDuLieu(string query, SqlConnection KetNoi)
        {
            try
            {
                SqlCommand cm = new SqlCommand(query, KetNoi);
                cm.ExecuteNonQuery();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static void DongKetNoi(SqlConnection KetNoi)
        {
            KetNoi.Close();
        }

        public static SqlConnection MoKetNoiMaster()
        {
            string connectionString = @"Data Source=LAPTOP-KLFNM45V;Initial Catalog=QLTTTiengAnh;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";

            // Tạo kết nối với database master
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            return conn;

        }

        public static bool SaoLuuDuLieu(string sDuongDan)
        {
            string sTen = sDuongDan + @"\QLTTTiengAnh(" + DateTime.Now.Day.ToString() + "_" +
             DateTime.Now.Month.ToString() + "_" +
             DateTime.Now.Year.ToString() + "_" +
             DateTime.Now.Hour.ToString() + "_" +
             DateTime.Now.Minute.ToString() + ").bak";
            string sql = @"
                BACKUP DATABASE QLTTTiengAnh 
                TO DISK = N'" + sTen + "'" +
                "WITH INIT, COMPRESSION";
            SqlConnection con = MoKetNoi();
            bool kq = TruyVanKhongLayDuLieu(sql, con);
            DongKetNoi(con);
            return kq;
        }

        public static bool PhucHoiDuLieu(string sDuongDan)
        {

            string sql = @"
                RESTORE DATABASE QLTTTiengAnh
                FROM DISK = N'{0}'
                WITH REPLACE, RECOVERY;
            ";
            SqlConnection.ClearAllPools();
            sql = string.Format(sql, sDuongDan);
            SqlConnection con = MoKetNoiMaster();
            bool kq = TruyVanKhongLayDuLieu(sql, con);
            DongKetNoi(con);
            return kq;
        }
    }
}
