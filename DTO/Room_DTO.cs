using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Room_DTO
    {
        private int _Id;
        private string _RoomName;

        public int Id { get => _Id; set => _Id = value; }
        public string RoomName { get => _RoomName; set => _RoomName = value; }
    }
}
