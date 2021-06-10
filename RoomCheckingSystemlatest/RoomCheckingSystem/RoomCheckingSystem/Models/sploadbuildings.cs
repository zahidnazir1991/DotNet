using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RoomCheckingSystem.Models
{
    [Keyless]
    public class sploadbuildings
    {
        public int BuildingID { get; set; }
        public string BuildingName { get; set; }
        public IEnumerable<sploadrooms> listofRooms { get; set; }
    }
}
