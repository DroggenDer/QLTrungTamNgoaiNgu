using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class Room_BUS
    {
        public static List<Room_DTO> LayDS()
        {
            return Room_DAO.LayDS();
        }

        public static bool Them(string tenTT)
        {
            return Room_DAO.Them(tenTT);
        }

        public static bool Sua(int Id, string tenmoi)
        {
            return Room_DAO.Sua(Id, tenmoi);
        }

        public static bool KiemTra(string tenTT)
        {
            return Room_DAO.KiemTra(tenTT);
        }

        public static bool Xoa(int id)
        {
            return Room_DAO.Xoa(id);
        }
    }
}
