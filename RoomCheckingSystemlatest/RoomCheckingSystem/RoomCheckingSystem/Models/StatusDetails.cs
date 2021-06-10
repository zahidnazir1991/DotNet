using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RoomCheckingSystem.Models
{
    public class StatusDetails
    {
        [Key]
        public int intSeqID { get; set; }
        public int intBuildingID { get; set; }
        public int intRoomID { get; set; }
        public int intStatusID { get; set; }
        public int? intParentStatus { get; set; }
        public int? intChildStatus { get; set; }
        public string? Cleaningtime { get; set; }
        public Boolean isproritysetting { get; set; }
        public string? Description { get; set; }
        public int? isGroupID { get; set; }
        public int? intCatID { get; set; }
    }
}
