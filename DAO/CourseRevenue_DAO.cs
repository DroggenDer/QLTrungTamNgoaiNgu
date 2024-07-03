using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class CourseRevenue_DAO
    {
        public static List<CourseRevenue_DTO> LayDoanhThuKH(DateTime d1, DateTime d2)
        {
            string sTruyVan = string.Format(
            @"SELECT 
				c.ID,	
                c.Name, 
                c.StartDay, 
                c.EndDay,
				c.Fee,
                SUM(c.Fee) AS TotalRevenue
            FROM 
                Course c
            JOIN 
                Register r ON c.ID = r.IDCourse
            WHERE 
                c.StartDay BETWEEN N'{0}' AND N'{1}'
            GROUP BY 
				c.ID,
                c.Name, 
                c.StartDay, 
                c.EndDay,
				c.Fee;", d1, d2);
            SqlConnection conn = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, conn);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<CourseRevenue_DTO> lst = new List<CourseRevenue_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                CourseRevenue_DTO temp = new CourseRevenue_DTO();
                temp.Id = Convert.ToInt32(dt.Rows[i][0]);
                temp.Name = dt.Rows[i][1].ToString();
                temp.StartD = DateTime.Parse(dt.Rows[i][2].ToString());
                temp.EndD = DateTime.Parse(dt.Rows[i][3].ToString());
                temp.Fee = Convert.ToInt32(dt.Rows[i][4]);
                temp.Totalrevenue = Convert.ToInt32(dt.Rows[i][5]);
                
            lst.Add(temp);
            }
            return lst;



        }
    }
}
