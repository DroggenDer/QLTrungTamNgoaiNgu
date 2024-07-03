using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class Account_DAO
    {
        static SqlConnection con;

        public static Account_DTO layTaiKhoan( string sTen, string sMatKhau)
        {
            //string query = @"select * from User where  Type = '" + sType + "' and UserName = '" + sTen + "' and PassWord = '" + sMatKhau + "'";
            string query = string.Format("SELECT * FROM [USER] WHERE UserName = '{0}' AND PassWord = '{1}'", sTen, sMatKhau);
            con = DataProvider.MoKetNoi();


            //DataTable chứa dữ liệu lấy về
            DataTable dt = DataProvider.TruyVanLayDuLieu(query, con);

            //Không có dữ liệu
            if (dt.Rows.Count == 0)
            {
                return null;
            }

            //Có dữ liệu thì chuyển dữ liệu từ Database qua dữ liệu đã định dạng DTO
            Account_DTO nd = new Account_DTO();
            nd.Type = dt.Rows[0]["Type"].ToString();
            nd.Username = dt.Rows[0]["UserName"].ToString();
            nd.Password = dt.Rows[0]["PassWord"].ToString();
            //nd.Teacher = Teacher_DTO.LayGiaoVien(dt.Rows[0]["Id"].ToString());

            return nd;
        }

        public static bool DoiMatKhau(Account_DTO nd, string mkMoi)
        {
            string query = @"update User set PassWord = '" + mkMoi + "' where Username = '" + nd.Username + "'";
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(query, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }

        public static bool Them(Account_DTO ncc)
        {
            string sTruyVan = String.Format(@"EXEC ADD_ACCOUNT N'{0}',N'{1}',N'{2}'", ncc.Username, ncc.Password, ncc.Type);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }

        public static bool XoaTaiKhoan(string tenTK)
        {
            string sTruyVan = string.Format(
                @"DELETE FROM [User] WHERE Username=N'{0}'",
                tenTK);
            SqlConnection conn = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, conn);
            DataProvider.DongKetNoi(conn);
            return kq;
        }


    }
}
