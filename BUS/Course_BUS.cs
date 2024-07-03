using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class Course_BUS
    {
        public static List<Course_DTO> LayDS()
        {
            return Course_DAO.LayDS();
        }

        public static bool Them(Course_DTO tenTT)
        {
            return Course_DAO.Them(tenTT);
        }

        public static bool Sua(int id, Course_DTO ncc)
        {
            return Course_DAO.Sua(id, ncc);
        }

        public static bool Xoa(int id)
        {
            return Course_DAO.Xoa(id);
        }

        
    }
}
