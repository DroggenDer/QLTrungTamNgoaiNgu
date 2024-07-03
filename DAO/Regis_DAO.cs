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
    public class Regis_DAO
    {
        static SqlConnection con;
        public static Regis_DTO LayDK(int madk)
        {
            string query = @"select * from Register where ID = '" + madk + "'";
            con = DataProvider.MoKetNoi();

            //DataTable chứa dữ liệu lấy về
            DataTable dt = DataProvider.TruyVanLayDuLieu(query, con);

            //Không có dữ liệu
            if (dt.Rows.Count == 0)
            {
                return null;
            }

            //Có dữ liệu thì chuyển dữ liệu từ Database qua dữ liệu đã định dạng DTO
            Regis_DTO nd = new Regis_DTO();
            nd.Id = Convert.ToInt32(dt.Rows[0]["ID"]);
            nd.CourseName = Course_DAO.LayKHDangKy(Convert.ToInt32(dt.Rows[0]["IDCourse"]));
            nd.Student = Student_DAO.LayHocVien(Convert.ToInt32(dt.Rows[0]["IDStudent"]));
            nd.DateRegis = DateTime.Parse(dt.Rows[0]["DateRegis"].ToString());
            nd.TTHP = dt.Rows[0]["TTHP"].ToString();
            return nd;
        }

        public static Regis_DTO LayRegisByUsername(string username)
        {
            string query = @"Select * From Register, Student, Course where Register.IDStudent = Student.ID and Register.IDCourse = Course.ID and Student.Username = '" + username + "'";
            con = DataProvider.MoKetNoi();

            //DataTable chứa dữ liệu lấy về
            DataTable dt = DataProvider.TruyVanLayDuLieu(query, con);

            //Không có dữ liệu
            if (dt.Rows.Count == 0)
            {
                return null;
            }

            //Có dữ liệu thì chuyển dữ liệu từ Database qua dữ liệu đã định dạng DTO
            Regis_DTO nd = new Regis_DTO();
            nd.Id = Convert.ToInt32(dt.Rows[0]["ID"]);
            nd.CourseName = Course_DAO.LayKH(Convert.ToInt32(dt.Rows[0]["IDCourse"]));
            nd.Student = Student_DAO.LayHocVien(Convert.ToInt32(dt.Rows[0]["IDStudent"]));
            nd.DateRegis = DateTime.Parse(dt.Rows[0]["DateRegis"].ToString());
            nd.TTHP = dt.Rows[0]["TTHP"].ToString();
            return nd;
        }
        public static bool Xoa(int id)
        {
            string sTruyVan = String.Format(@"DELETE from Register where ID = {0}", id);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }

        public static List<Regis_DTO> LayDS()
        {
            string query = @"Select * from Register where An = 0";


            con = DataProvider.MoKetNoi();

            //DataTable chứa dữ liệu lấy về
            DataTable dt = DataProvider.TruyVanLayDuLieu(query, con);

            if (dt.Rows.Count == 0)
            {
                return null;
            }
            //Có dữ liệu thì chuyển dữ liệu từ Database qua dữ liệu đã định dạng DTO
            List<Regis_DTO> listKH = new List<Regis_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Regis_DTO nd = new Regis_DTO();
                nd.Id = Convert.ToInt32(dt.Rows[i]["ID"]);
                nd.CourseName = Course_DAO.LayKHDangKy(Convert.ToInt32(dt.Rows[i]["IDCourse"]));
                nd.Student = Student_DAO.LayHocVien(Convert.ToInt32(dt.Rows[i]["IDStudent"]));
                nd.DateRegis = DateTime.Parse(dt.Rows[0]["DateRegis"].ToString());
                nd.TTHP = dt.Rows[i]["TTHP"].ToString();
                listKH.Add(nd);
            }
            return listKH;
        }
        public static bool Sua(int Id, Regis_DTO ncc)
        {
            string sTruyVan = String.Format(@"EXEC UPDATE_REGIS N'{0}',N'{1}',N'{2}',N'{3}',N'{4}'",
                                                             Id, ncc.CourseName.Id, ncc.Student.Id, ncc.DateRegis, ncc.TTHP);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }
        public static bool Them(Regis_DTO ncc)
        {
            string sTruyVan = String.Format(@"EXEC ADD_REGISTER N'{0}',N'{1}',N'{2}',N'{3}'",
                                                             ncc.CourseName.Id, ncc.Student.Id, ncc.DateRegis, ncc.TTHP);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }

        public static List<Regis_DTO> LayDKTuNgay(DateTime d1, DateTime d2)
        {
            string sTruyVan = string.Format(
                @"SELECT *
                FROM Register
                WHERE DateRegis >= N'{0}' AND DateRegis <= N'{1}'",
                d1, d2); 
            SqlConnection conn = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, conn);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<Regis_DTO> lst = new List<Regis_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Regis_DTO temp = new Regis_DTO();
                temp.Id = int.Parse(dt.Rows[i][0].ToString());
                temp.CourseName = Course_DAO.LayKH(Convert.ToInt32(dt.Rows[i][1]));
                temp.Student = Student_DAO.LayHocVien(Convert.ToInt32(dt.Rows[i][2]));
                temp.DateRegis = DateTime.Parse(dt.Rows[i][3].ToString());
                temp.TTHP = dt.Rows[i][4].ToString();
                lst.Add(temp);
            }
            return lst;
        }

        public static bool LayDoanhThuKH(int id)
        {
            string sTruyVan = String.Format(@"SELECT SUM(Course.Fee) AS TotalRevenue
                                              FROM Register
                                              INNER JOIN Course ON Course.ID = Register.IDCourse
                                              WHERE Register.IDCourse = {0}", id);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }
    }
}
