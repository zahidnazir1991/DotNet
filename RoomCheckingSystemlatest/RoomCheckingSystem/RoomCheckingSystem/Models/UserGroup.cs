using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RoomCheckingSystem.Models
{
    public class UserGroup
    {

        [Key]
        public Int64? intSeqID { get; set; }
        public string GroupTitle { get; set; }
        public bool isActive { get; set; }
        public bool isSupperAdmin { get; set; }
        public bool isTimeline { get; set; }
        public bool isChat { get; set; }
        public bool isTask { get; set; }
        public string dtUpdationDate { get; set; }
        public string dtCreationDate { get; set; }
        public int? isCreatedBy { get; set; }
        public int? isUpdatedBy { get; set; }
        public bool  isHandoverNotes { get; set; }
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
        public int? intHandovernotessetting { get; set; }
        public bool? iswhocanreadmessage { get; set; }
        public bool? isdownloadlockednotes { get; set; }
    }
}
