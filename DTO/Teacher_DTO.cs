using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Teacher_DTO
    {
        private int _id;
        private string _username;
        private string _lastname;
        private string _name;
        private string _sex;
        private string _description;
        private DateTime _date;
        private string _email;
        private string _address;
        private int _phonenumber;
        private string _quali;

        public int Id { get => _id; set => _id = value; }
        public string Username { get => _username; set => _username = value; }
        public string Lastname { get => _lastname; set => _lastname = value; }
        public string Name { get => _name; set => _name = value; }
        public string Sex { get => _sex; set => _sex = value; }
        public string Description { get => _description; set => _description = value; }
        public DateTime Date { get => _date; set => _date = value; }
        public string Email { get => _email; set => _email = value; }
        public string Address { get => _address; set => _address = value; }
        public int Phonenumber { get => _phonenumber; set => _phonenumber = value; }
        public string Quali { get => _quali; set => _quali = value; }
    }
}
