using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class Regis_BUS
    {
        public static List<Regis_DTO> LayDS()
        {
            return Regis_DAO.LayDS();
        }

        public static Regis_DTO LayRegis(string username)
        {
            return Regis_DAO.LayRegisByUsername(username);
        }
        public static bool Them(Regis_DTO tenTT)
        {
            return Regis_DAO.Them(tenTT);
        }

        public static bool Sua(int id, Regis_DTO ncc)
        {
            return Regis_DAO.Sua(id, ncc);
        }

        public static bool Xoa(int id)
        {
            return Regis_DAO.Xoa(id);
        }

        public static bool LayDoanhThu(int id)
        {
            return Regis_DAO.LayDoanhThuKH(id); 
        }

        public static List<Regis_DTO> LayDKTuNgay(DateTime from, DateTime to)
        {
            return Regis_DAO.LayDKTuNgay(from, to);
        }
    }
}
