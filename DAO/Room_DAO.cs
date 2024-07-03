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
    public class Room_DAO
    {
        static SqlConnection con;
        public static Room_DTO LayPhong(int Id)
        {
            string query = @"select * from Room where ID = '" + Id + "'";
            con = DataProvider.MoKetNoi();

            //DataTable chứa dữ liệu lấy về
            DataTable dt = DataProvider.TruyVanLayDuLieu(query, con);

            //Không có dữ liệu
            if (dt.Rows.Count == 0)
            {
                return null;
            }

            //Có dữ liệu thì chuyển dữ liệu từ Database qua dữ liệu đã định dạng DTO
            Room_DTO nd = new Room_DTO();
            nd.Id = Convert.ToInt32(dt.Rows[0]["ID"]);
            nd.RoomName = dt.Rows[0]["Name"].ToString();
            return nd;
        }

        public static bool Xoa(int id)
        {
            string sTruyVan = String.Format(@"delete Room where Id = '{0}'", id);
            con = DataProvider.MoKetNoi();

            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);

            DataProvider.DongKetNoi(con);
            return kq;
        }

        public static List<Room_DTO> LayDS()
        {
            string query = @"Select * from Room";


            con = DataProvider.MoKetNoi();

            //DataTable chứa dữ liệu lấy về
            DataTable dt = DataProvider.TruyVanLayDuLieu(query, con);

            if (dt.Rows.Count == 0)
            {
                return null;
            }

            //Có dữ liệu thì chuyển dữ liệu từ Database qua dữ liệu đã định dạng DTO
            List<Room_DTO> listChucVu = new List<Room_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Room_DTO nv = new Room_DTO();
                nv.Id = Convert.ToInt32(dt.Rows[i]["ID"]);
                nv.RoomName = dt.Rows[i]["Name"].ToString();

                listChucVu.Add(nv);
            }

            return listChucVu;
        }

        public static bool Sua(int Id, string tenmoi)
        {
            string sTruyVan = String.Format(@"update Room set Name = N'{0}' where ID = '{1}'", tenmoi, Id);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }

        public static bool Them(string tenTT)
        {
            string sTruyVan = String.Format(@"insert into Room values(N'{0}')", tenTT);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }

        public static bool KiemTra(string tenTT)
        {
            string sTruyVan = String.Format(@"select 1 from Room where Name = N'{0}'", tenTT);
            con = DataProvider.MoKetNoi();
            DataTable kq = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq.Rows.Count > 0;
        }
    }
}
