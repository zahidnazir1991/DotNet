using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RoomCheckingSystem.Models
{
    public class Building
    {
        [Key]
        public int intSeqID { get; set; }
        public string Buildingtitle { get; set; }
        public string BuildingDescription { get; set; }
        public Boolean isActive { get; set; }
        public string dtUpdationDate { get; set; }
        public string dtCreationDate { get; set; }
        public int? isCreatedBy { get; set; }
        public int? isUpdatedBy { get; set; }
    }
}
