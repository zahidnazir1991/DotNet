using Microsoft.EntityFrameworkCore;
using RoomCheckingSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RoomCheckingSystem.Repo
{
    public class DBContext :  DbContext
    {

        public DBContext(DbContextOptions<DBContext> options) :base(options) { 
        
        }

                
        // first class name and second table name
        public DbSet<User> Users { get; set; }
        public DbSet<UserGroup> tblUserGroup { get; set; }
        public DbSet<RefPermissions> tbl_ref_userrights { get; set; }
        public DbSet<Shift> tblShift { get; set; }
        public DbSet<Building> tblBuilding { get; set; }
        public DbSet<Rooms> tblRooms { get; set; }
        public DbSet<loadrooms> spLoadRooms { get; set; }
        public DbSet<sploadbuildings> spLoadDashboard { get; set; }
        public DbSet<sploadrooms> spLoadDashboardrooms { get; set; }
        public DbSet<RoomStatus> tblRoomStatus { get; set; }
        public DbSet<StatusDetails> tblStatusDetails { get; set; }
        public DbSet<spLoadRoomsstatus> spLoadRoomsstatus { get; set; }
        public DbSet<sploadmenu> spLoadMenu { get; set; }
        public DbSet<spNextStatus> spLoadnextRoomsstatus { get; set; }
    }
}
