using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
namespace BUS
{
    public class DataConsole_BUS
    {
        public static bool SaoLuu(string sDuongDan)
        {
            return DataProvider.SaoLuuDuLieu(sDuongDan);
        }

        public static bool PhucHoi(string sDuongDan)
        {
            return DataProvider.PhucHoiDuLieu(sDuongDan);
        }
    }
}
