using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RoomCheckingSystem.Models
{
    public class Rooms
    {
        [Key]
        public int intSeqID { get; set; }
        public int BuildingID { get; set; }
        public string RoomName { get; set; }
        public string RoomFloor { get; set; }
        public string RoomType { get; set; }
        public string RoomDescription { get; set; }
        public Boolean isActive { get; set; }
        public string dtUpdationDate { get; set; }
        public string dtCreationDate { get; set; }
        public int? isCreatedBy { get; set; }
        public int? isUpdatedBy { get; set; }
    }
}
