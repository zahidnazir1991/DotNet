using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RoomCheckingSystem.Models
{
    public class RoomStatus
    {
        [Key]
        public int intSeqID { get; set; }
        public int intParentID { get; set; }
        public string StatusName { get; set; }
        public string StatusColor { get; set; }
        public int intIconType { get; set; }
        public string icon { get; set; }
        public string TaskScore { get; set; }
        public Boolean isActive { get; set; }
        public Boolean isShowCount { get; set; }
        public Boolean isRunningCount { get; set; }
        public Boolean isTimeSpent { get; set; }
        public Boolean isPriority { get; set; }
        public Boolean isCheckoutTime { get; set; }
        public Boolean isReception { get; set; }
        public Boolean isHouseKeeping { get; set; }
        public Boolean isSupervisor { get; set; }
        public Boolean isMaintenance { get; set; }
        public string? dtUpdationDate { get; set; }
        public string? dtCreationDate { get; set; }
        public int? isCreatedBy { get; set; }
        public int? isUpdatedBy { get; set; }
        public int? intCat { get; set; }
        [NotMapped]
        public string? text { get; set; }
        [NotMapped]
        public string? color { get; set; }
    }
}
