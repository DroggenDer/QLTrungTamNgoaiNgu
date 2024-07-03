using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class Teacher_BUS
    {
        public static List<Teacher_DTO> LayDS()
        {
            return Teacher_DAO.ListGVchoKH();
        }
    }
}
