using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RoomCheckingSystem.Models
{
    [Keyless]
    public class spLoadRoomsstatus
    {
        public string StatusColor { get; set; }
        public string Cleaningtime { get; set; }
        public string StatusName { get; set; }
        public string icon { get; set; }
        public Boolean prority { get; set; }
        public int pStatus { get; set; }
        public int cStatus { get; set; }
    }
}
