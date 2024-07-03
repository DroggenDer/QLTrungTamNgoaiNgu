using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Course_DTO
    {
        private int _id;
        private string _coursecode;
        private string _name;
        private DateTime _startD;
        private DateTime _endD;
        private string _time;
        private int _fee;
        private string _curri;
        private int _number;

        public int Id { get => _id; set => _id = value; }
        public string Coursecode { get => _coursecode; set => _coursecode = value; }
        public string NameCourse { get => _name; set => _name = value; }
        public DateTime StartD { get => _startD; set => _startD = value; }
        public DateTime EndD { get => _endD; set => _endD = value; }
        public string Time { get => _time; set => _time = value; }
        public int Fee { get => _fee; set => _fee = value; }
        public string Curri { get => _curri; set => _curri = value; }
        public int Number { get => _number; set => _number = value; }

        public Teacher_DTO GiaoVien { get; set; }
        public Room_DTO Phong { get; set; }
    }
}
