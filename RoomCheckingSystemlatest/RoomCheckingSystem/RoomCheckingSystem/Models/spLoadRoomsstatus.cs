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
        public int statusid { get; set; }
        public string StatusColor { get; set; }
        public string Description { get; set; }
        public string Cleaningtime { get; set; }
        public string StatusName { get; set; }
        public string icon { get; set; }
        public Boolean prority { get; set; }
        public int pStatus { get; set; }
        public int cStatus { get; set; }
        public int isGroupID { get; set; }
        public DateTime dtDate { get; set; }
        public int stID { get; set; }
        public string catname { get; set; }
    }
}
