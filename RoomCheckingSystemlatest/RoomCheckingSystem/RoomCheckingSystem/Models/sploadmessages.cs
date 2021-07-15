using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RoomCheckingSystem.Models
{

    [Keyless]
    public class sploadmessages
    {

        public int? MasterID { get; set; }
        public int? detailid { get; set; }
        public string? varDescription { get; set; }
        public string? dtDate { get; set; }
        public string? name { get; set; }
        public string? img { get; set; }
    }
}
