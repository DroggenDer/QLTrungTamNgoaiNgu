using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class Student_BUS
    {
        public static List<Student_DTO> LayDS()
        {
            return Student_DAO.LayDS();
        }

        public static Student_DTO LayInfo(string username)
        {
            return Student_DAO.LayStudentByUsername(username);
        }

        public static List<Student_DTO> LayInfo2(string username)
        {
            return Student_DAO.LayInfo(username);
        }
        public static bool Them(Student_DTO tenTT)
        {
            return Student_DAO.Them(tenTT);
        }

        public static bool Sua(int id, Student_DTO ncc)
        {
            return Student_DAO.Sua(id, ncc);
        }

        public static bool SuaBangUsername(String username)
        {
            return Student_DAO.SuaBangUsername(username);
        }

        public static bool Xoa(int id)
        {
            return Student_DAO.Xoa(id);
        }
    }
}
