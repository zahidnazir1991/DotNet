using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RoomCheckingSystem.Models
{
    public class ChatMaster
    {
        [Key]
        public int intSeqID { get; set; }
        public int intUserID { get; set; }
        public int intStatusID { get; set; }
        public int intRoomID { get; set; }
        public int intBuildingID { get; set; }
        public int intGroupID { get; set; }
        public IEnumerable<tblChatDetails> listchatdetails { get; set; }


    }
}
