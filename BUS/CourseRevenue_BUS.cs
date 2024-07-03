using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;
namespace BUS
{
    public class CourseRevenue_BUS
    {
        public static List<CourseRevenue_DTO> LayDoanhThuKH(DateTime d1, DateTime d2)
        {
            return CourseRevenue_DAO.LayDoanhThuKH(d1, d2);
        }
    }
}
