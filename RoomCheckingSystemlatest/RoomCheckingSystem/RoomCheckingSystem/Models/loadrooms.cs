using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RoomCheckingSystem.Models
{
    [Keyless]
    public class loadrooms
    {
    
        public int RoomID { get; set; }
        public int BuildingID { get; set; }
        public string RoomName { get; set; }
        public string Buildingtitle { get; set; }
        public string RoomFloor { get; set; }
        public string RoomType { get; set; }
        public Boolean roomstatus { get; set; }
        public Boolean buildingstatus { get; set; }
        public string? dtCreationDate { get; set; }
        public List<Rooms> listofroome { get; set; }
    }
}
