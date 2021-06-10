using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RoomCheckingSystem.Models
{
    [Keyless]
    public class sploadmenu
    {
        public Int64? ID { get; set; }
        public Int64? intSeqID { get; set; }
        public bool isSupperAdmin { get; set; }
        public bool isHandoverNotes { get; set; }
        public bool isRoomStatus { get; set; }
        public bool isUsers { get; set; }
        public bool isWhoIsOnline { get; set; }
        public bool isBuilding { get; set; }
        public bool isUserGroup { get; set; }
        public bool isActivityLog { get; set; }
        public bool isShift { get; set; }
        public bool isBuildingRoom { get; set; }
        public bool isHandoverNotesReports { get; set; }
        public bool isTimestationManagement { get; set; }
        public bool isBuildingRoomCsvSetup { get; set; }
        public bool isRoomWork { get; set; }
    }
}
