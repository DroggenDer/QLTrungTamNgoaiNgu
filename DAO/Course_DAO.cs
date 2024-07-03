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
    public class Course_DAO
    {
        static SqlConnection con;
        public static Course_DTO LayKH(int makh)
        {
            string query = @"select * from Course where ID = '" + makh + "'";
            con = DataProvider.MoKetNoi();

            //DataTable chứa dữ liệu lấy về
            DataTable dt = DataProvider.TruyVanLayDuLieu(query, con);

            //Không có dữ liệu
            if (dt.Rows.Count == 0)
            {
                return null;
            }

            //Có dữ liệu thì chuyển dữ liệu từ Database qua dữ liệu đã định dạng DTO
            Course_DTO nd = new Course_DTO();
            nd.Id = Convert.ToInt32(dt.Rows[0]["ID"]);
            nd.Coursecode = dt.Rows[0]["CourseCode"].ToString();
            nd.NameCourse = dt.Rows[0]["Name"].ToString();
            nd.StartD = DateTime.Parse(dt.Rows[0]["StartDay"].ToString());
            nd.EndD = DateTime.Parse(dt.Rows[0]["EndDay"].ToString());
            nd.Time = dt.Rows[0]["TimeLearning"].ToString();
            nd.Fee = Convert.ToInt32(dt.Rows[0]["Fee"]);
            nd.Phong = Room_DAO.LayPhong(Convert.ToInt32(dt.Rows[0]["IDRoom"]));
            nd.GiaoVien = Teacher_DAO.LayGVchoKH(Convert.ToInt32(dt.Rows[0]["IDTeacher"]));
            nd.Curri = dt.Rows[0]["Curriculum"].ToString();
            nd.Number = Convert.ToInt32(dt.Rows[0]["Number"]);
            return nd;
        }

        public static Course_DTO LayKHDangKy(int makh)
        {
            string query = @"select * from Course where ID = '" + makh + "'";
            con = DataProvider.MoKetNoi();

            //DataTable chứa dữ liệu lấy về
            DataTable dt = DataProvider.TruyVanLayDuLieu(query, con);

            //Không có dữ liệu
            if (dt.Rows.Count == 0)
            {
                return null;
            }

            //Có dữ liệu thì chuyển dữ liệu từ Database qua dữ liệu đã định dạng DTO
            Course_DTO nd = new Course_DTO();
            nd.Id = Convert.ToInt32(dt.Rows[0]["ID"]);
            nd.NameCourse = dt.Rows[0]["Name"].ToString();
            return nd;
        }

        public static bool Xoa(int id)
        {
            string sTruyVan = String.Format(@"DELETE from Course where ID = {0}", id);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }

        public static List<Course_DTO> LayDS()
        {
            string query = @"Select * from Course where An = 0";


            con = DataProvider.MoKetNoi();

            //DataTable chứa dữ liệu lấy về
            DataTable dt = DataProvider.TruyVanLayDuLieu(query, con);

            if (dt.Rows.Count == 0)
            {
                return null;
            }

            //Có dữ liệu thì chuyển dữ liệu từ Database qua dữ liệu đã định dạng DTO
            List<Course_DTO> listKH = new List<Course_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Course_DTO nd = new Course_DTO();
                nd.Id = Convert.ToInt32(dt.Rows[i]["ID"]);
                nd.Coursecode = dt.Rows[i]["CourseCode"].ToString();
                nd.NameCourse = dt.Rows[i]["Name"].ToString();
                nd.StartD = DateTime.Parse(dt.Rows[i]["StartDay"].ToString());
                nd.EndD = DateTime.Parse(dt.Rows[i]["EndDay"].ToString());
                nd.Time = dt.Rows[i]["TimeLearning"].ToString();
                nd.Fee = Convert.ToInt32(dt.Rows[i]["Fee"]);
                nd.Phong = Room_DAO.LayPhong(Convert.ToInt32(dt.Rows[i]["IDRoom"]));
                nd.GiaoVien = Teacher_DAO.LayGVchoKH(Convert.ToInt32(dt.Rows[i]["IDTeacher"]));
                nd.Curri = dt.Rows[i]["Curriculum"].ToString();
                nd.Number = Convert.ToInt32(dt.Rows[i]["Number"]);
                listKH.Add(nd);
            }
            return listKH;

        }

        public static bool Sua(int Id, Course_DTO kh)
        {
            string sTruyVan = String.Format(@"EXEC UPDATE_COURSE     N'{0}',N'{1}',
                                                                     N'{2}',N'{3}',
                                                                     N'{4}',N'{5}',
                                                                     N'{6}',N'{7}',
                                                                     N'{8}',N'{9}',N'{10}'",
                                                                     Id, kh.Coursecode, kh.NameCourse,
                                                                     kh.StartD.ToString("MM/dd/yyyy"), kh.EndD.ToString("MM/dd/yyyy"),
                                                                     kh.Time, kh.Fee,
                                                                     kh.Phong.Id, kh.GiaoVien.Id,
                                                                     kh.Curri, kh.Number);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }

        public static bool Them(Course_DTO kh)
        {
            string sTruyVan = String.Format(@"EXEC ADD_COURSE        N'{0}',N'{1}',
                                                                     N'{2}',N'{3}',
                                                                     N'{4}','{5}',
                                                                     N'{6}',N'{7}',
                                                                     N'{8}','{9}'",
                                                                     kh.Coursecode, kh.NameCourse,
                                                                     kh.StartD.ToString("MM/dd/yyyy"), kh.EndD.ToString("MM/dd/yyyy"),
                                                                     kh.Time, kh.Fee,
                                                                     kh.Phong.Id, kh.GiaoVien.Id,
                                                                     kh.Curri, kh.Number);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }

        
    }
}
