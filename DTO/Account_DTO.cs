using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Account_DTO
    {
        private string _type;
        private string _username;
        private string _password;

        public string Type { get => _type; set => _type = value; }
        public string Username { get => _username; set => _username = value; }
        public string Password { get => _password; set => _password = value; }

        public Teacher_DTO Teacher { get; set; }
        public Student_DTO Student { get; set; }

    }
}
