using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Regis_DTO
    {
        private int _id;
        private string _tthp;
        private DateTime _dateregis;

        public int Id { get => _id; set => _id = value; }
        public string TTHP { get => _tthp; set => _tthp = value; }
        public DateTime DateRegis { get => _dateregis; set => _dateregis = value; }
        public Course_DTO CourseName { get; set; }
        public Student_DTO Student { get; set; }
    }
}
