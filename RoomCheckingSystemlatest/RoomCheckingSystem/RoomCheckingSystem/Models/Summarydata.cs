using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RoomCheckingSystem.Models
{
    [Keyless]
    public class Summarydata
    {

        public string? statusname { get; set; }
        public int? totaljobs { get; set; }
        public string? colourname { get; set; }
    }
}
