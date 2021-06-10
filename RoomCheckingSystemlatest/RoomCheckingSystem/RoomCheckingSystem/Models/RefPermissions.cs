using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RoomCheckingSystem.Models
{
    public class RefPermissions
    {
        [Key]
        public int intSeqID { get; set; }
        public string UserrightTitle { get; set; }
        public bool isActive { get; set; }

    }
}
