using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RoomCheckingSystem.Models
{
    public class Shift
    {
        [Key]
        public int intSeqID { get; set; }
        public string ShiftTitle { get; set; }
        [DataType(DataType.Time)]
        [DisplayFormat(DataFormatString = "{0:HH:mm}", ApplyFormatInEditMode = true)]
        public DateTime ShiftTimeIn { get; set; }
        [DataType(DataType.Time)]
        [DisplayFormat(DataFormatString = "{0:HH:mm}", ApplyFormatInEditMode = true)]
        public DateTime ShiftTimeOut { get; set; }
        public Boolean isActive { get; set; }
        public string dtUpdationDate { get; set; }
        public string dtCreationDate { get; set; }
        public int? isCreatedBy { get; set; }
        public int? isUpdatedBy { get; set; }
        

    }
}
