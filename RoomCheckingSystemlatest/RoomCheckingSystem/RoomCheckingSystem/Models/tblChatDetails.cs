using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RoomCheckingSystem.Models
{
    public class tblChatDetails
    {
        [Key]
        public int intSeqID { get; set; }
        public string varDescription { get; set; }
        public int intParentID { get; set; }
        public string? dtDate { get; set; }
        public bool? isActive { get; set; }
        public bool? isViewed { get; set; }
        public string varImage { get; set; }
        public string? dtUpdationDate { get; set; }
        public string? dtCreationDate { get; set; }
        public int? isCreatedBy { get; set; }
        public int? isUpdatedBy { get; set; }
        
    }
}
