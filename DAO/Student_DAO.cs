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
    public class Student_DAO
    {
        static SqlConnection con;
        public static Student_DTO LayHocVien(int mahv)
        {
            string query = @"select * from Student where ID = '" + mahv + "'";
            con = DataProvider.MoKetNoi();

            //DataTable chứa dữ liệu lấy về
            DataTable dt = DataProvider.TruyVanLayDuLieu(query, con);

            //Không có dữ liệu
            if (dt.Rows.Count == 0)
            {
                return null;
            }

            //Có dữ liệu thì chuyển dữ liệu từ Database qua dữ liệu đã định dạng DTO
            Student_DTO nd = new Student_DTO();
            nd.Id = Convert.ToInt32(dt.Rows[0]["ID"]);
            nd.Lastname = dt.Rows[0]["LastName"].ToString();
            nd.Name = dt.Rows[0]["Name"].ToString();
            nd.Date = DateTime.Parse(dt.Rows[0]["Date"].ToString());
            nd.Email = dt.Rows[0]["Email"].ToString();
            nd.Address = dt.Rows[0]["Address"].ToString();
            nd.Phonenumber = dt.Rows[0]["PhoneNumber"].ToString();
            nd.Sex = dt.Rows[0]["Sex"].ToString();
            return nd;
        }


        public static bool Xoa(int id)
        {
            string sTruyVan = String.Format(@"DELETE from Student where ID = {0}", id);           
            con = DataProvider.MoKetNoi();           
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }

        public static List<Student_DTO> LayDS()
        {
            string query = @"Select * from Student where An = 0";


            con = DataProvider.MoKetNoi();

            //DataTable chứa dữ liệu lấy về
            DataTable dt = DataProvider.TruyVanLayDuLieu(query, con);

            if (dt.Rows.Count == 0)
            {
                return null;
            }

            //Có dữ liệu thì chuyển dữ liệu từ Database qua dữ liệu đã định dạng DTO
            List<Student_DTO> listTinhTrang = new List<Student_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Student_DTO nd = new Student_DTO();
                nd.Id = Convert.ToInt32(dt.Rows[i]["ID"]);
                nd.Username = dt.Rows[i]["UserName"].ToString();
                nd.Lastname = dt.Rows[i]["LastName"].ToString();
                nd.Name = dt.Rows[i]["Name"].ToString();
                nd.Date = DateTime.Parse(dt.Rows[i]["Date"].ToString());
                nd.Email = dt.Rows[0]["Email"].ToString();
                nd.Address = dt.Rows[i]["Address"].ToString();
                nd.Phonenumber = dt.Rows[i]["PhoneNumber"].ToString();
                nd.Sex = dt.Rows[i]["Sex"].ToString();
                listTinhTrang.Add(nd);
            }

            return listTinhTrang;
        }


        public static Student_DTO LayStudentByUsername(string username)
        {
            string query = @"select * from Student where Username = '" + username + "'";
            con = DataProvider.MoKetNoi();

            //DataTable chứa dữ liệu lấy về
            DataTable dt = DataProvider.TruyVanLayDuLieu(query, con);

            //Không có dữ liệu
            if (dt.Rows.Count == 0)
            {
                return null;
            }

            //Có dữ liệu thì chuyển dữ liệu từ Database qua dữ liệu đã định dạng DTO
            Student_DTO nd = new Student_DTO();
            nd.Id = Convert.ToInt32(dt.Rows[0]["ID"]);
            nd.Lastname = dt.Rows[0]["LastName"].ToString();
            nd.Name = dt.Rows[0]["Name"].ToString();
            nd.Date = DateTime.Parse(dt.Rows[0]["Date"].ToString());
            nd.Email = dt.Rows[0]["Email"].ToString();
            nd.Address = dt.Rows[0]["Address"].ToString();
            nd.Phonenumber = dt.Rows[0]["PhoneNumber"].ToString();
            nd.Sex = dt.Rows[0]["Sex"].ToString();
            return nd;
        }


        public static List<Student_DTO> LayInfo(string username)
        {
            string query = String.Format(@"Select * from Student where Username = {0}", username);


            con = DataProvider.MoKetNoi();

            //DataTable chứa dữ liệu lấy về
            DataTable dt = DataProvider.TruyVanLayDuLieu(query, con);

            if (dt.Rows.Count == 0)
            {
                return null;
            }

            //Có dữ liệu thì chuyển dữ liệu từ Database qua dữ liệu đã định dạng DTO
            List<Student_DTO> listTinhTrang = new List<Student_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Student_DTO nd = new Student_DTO();
                nd.Id = Convert.ToInt32(dt.Rows[i]["ID"]);
                nd.Username = dt.Rows[i]["UserName"].ToString();
                nd.Lastname = dt.Rows[i]["LastName"].ToString();
                nd.Name = dt.Rows[i]["Name"].ToString();
                nd.Date = DateTime.Parse(dt.Rows[i]["Date"].ToString());
                nd.Email = dt.Rows[0]["Email"].ToString();
                nd.Address = dt.Rows[i]["Address"].ToString();
                nd.Phonenumber = dt.Rows[i]["PhoneNumber"].ToString();
                nd.Sex = dt.Rows[i]["Sex"].ToString();
                listTinhTrang.Add(nd);
            }

            return listTinhTrang;
        }
        public static bool Sua(int Id, Student_DTO ncc)
        {
            string sTruyVan = "";
            if (string.IsNullOrEmpty(ncc.Username))
            {
                sTruyVan = String.Format(@"EXEC UPDATE_HOCVIEN N'{0}', {1},N'{2}',N'{3}',N'{4}',N'{5}',N'{6}',N'{7}',N'{8}'", Id, "NULL", ncc.Lastname, ncc.Name, ncc.Date.ToString("MM/dd/yyyy"), ncc.Email, ncc.Address, ncc.Phonenumber, ncc.Sex);
            }
            else
                sTruyVan = String.Format(@"EXEC UPDATE_HOCVIEN N'{0}',N'{1}',N'{2}',N'{3}',N'{4}',N'{5}',N'{6}',N'{7}',N'{8}'", Id, ncc.Username, ncc.Lastname, ncc.Name, ncc.Date.ToString("MM/dd/yyyy"), ncc.Email, ncc.Address, ncc.Phonenumber, ncc.Sex);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }

        public static bool SuaBangUsername(string username)
        {
            string sTruyVan = String.Format("UPDATE [Student] SET Username = NULL WHERE Username = N'{0}'", username);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }

        public static bool Them(Student_DTO ncc)
        {
            string sTruyVan = String.Format(@"EXEC ADD_STUDENT N'{0}',N'{1}',N'{2}',N'{3}',N'{4}',N'{5}',N'{6}'",
                                                                ncc.Lastname, ncc.Name, ncc.Date.ToString("MM/dd/yyyy"), 
                                                                ncc.Email, ncc.Address, ncc.Phonenumber, ncc.Sex);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }
    }
}
