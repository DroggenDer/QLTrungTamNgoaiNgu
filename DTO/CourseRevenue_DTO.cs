using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class CourseRevenue_DTO
    {
        private int _id;
        private string _name;
        private DateTime _startD;
        private DateTime _endD;
        private int _totalrevenue;
        private int _fee;

        public int Id { get => _id; set => _id = value; }
        public string Name { get => _name; set => _name = value; }
        public DateTime StartD { get => _startD; set => _startD = value; }
        public DateTime EndD { get => _endD; set => _endD = value; }
        public int Totalrevenue { get => _totalrevenue; set => _totalrevenue = value; }
        public int Fee { get => _fee; set => _fee = value;  }
        
    }
}
