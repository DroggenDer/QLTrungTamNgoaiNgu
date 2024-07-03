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
    public class Teacher_DAO
    {
        static SqlConnection con;
        public static Teacher_DTO LayGVchoKH(int Id)
        {
            string query = @"select * from Teacher where ID = '" + Id + "'";
            con = DataProvider.MoKetNoi();

            //DataTable chứa dữ liệu lấy về
            DataTable dt = DataProvider.TruyVanLayDuLieu(query, con);

            //Không có dữ liệu
            if (dt.Rows.Count == 0)
            {
                return null;
            }

            //Có dữ liệu thì chuyển dữ liệu từ Database qua dữ liệu đã định dạng DTO
            Teacher_DTO nd = new Teacher_DTO();
            nd.Id = Convert.ToInt32(dt.Rows[0]["ID"]);
            nd.Name = dt.Rows[0]["Name"].ToString();
            return nd;
        }

        public static List<Teacher_DTO> ListGVchoKH()
        {
            string query = @"Select * from Teacher";


            con = DataProvider.MoKetNoi();

            //DataTable chứa dữ liệu lấy về
            DataTable dt = DataProvider.TruyVanLayDuLieu(query, con);

            if (dt.Rows.Count == 0)
            {
                return null;
            }

            //Có dữ liệu thì chuyển dữ liệu từ Database qua dữ liệu đã định dạng DTO
            List<Teacher_DTO> listChucVu = new List<Teacher_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Teacher_DTO nv = new Teacher_DTO();
                nv.Id = Convert.ToInt32(dt.Rows[i]["Id"]);
                nv.Name = dt.Rows[i]["Name"].ToString();
                listChucVu.Add(nv);
            }
            return listChucVu;
        }
    }
}
