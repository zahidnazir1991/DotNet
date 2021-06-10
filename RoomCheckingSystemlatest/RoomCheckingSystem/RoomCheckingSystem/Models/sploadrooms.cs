using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RoomCheckingSystem.Models
{
    [Keyless]
    public class sploadrooms
    {
        public int RoomID { get; set; }
        public string RoomName { get; set; }
        public IEnumerable<spLoadRoomsstatus> listofRooms { get; set; }

    }
}
