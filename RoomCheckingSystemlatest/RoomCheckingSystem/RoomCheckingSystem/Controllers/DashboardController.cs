using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using RoomCheckingSystem.Models;
using RoomCheckingSystem.Repo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace RoomCheckingSystem.Controllers
{
    public class DashboardController : BaseController
    {

        private IConfiguration configuration;
        private readonly DBContext dBContext;
        public DashboardController(IConfiguration configuration, DBContext dBContext)
        {
            this.configuration = configuration;
            this.dBContext = dBContext;
        }
        // GET: DashboardController
        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult LoadMenu()
        {
            SqlParameter[] parameters = { new SqlParameter("@userID", 7),
            new SqlParameter("@groupID", 2)
            };
            var Listrooms = dBContext.spLoadMenu
         .FromSqlRaw("EXECUTE dbo.spLoadMenu  @userID,@groupID", parameters)
.ToList();

            return PartialView("LoadMenu", Listrooms);
        }
        // GET: DashboardController
        public ActionResult Dashboard(int? id)
        {

            
            return View();
        }



        public PartialViewResult Housekeepingdata(int? id)
        {
            ViewBag.dialog = 2;
            if (id == null)
            {
                id = 1;
            }
            int usertype = 1;
            HttpContext.Session.SetcatData("stafftype", id.ToString());
            SqlParameter[] parms = { new SqlParameter("@userType", usertype) };
            var Listbulidings = dBContext.spLoadDashboard
    .FromSqlRaw("EXECUTE dbo.spLoadDashboard @userType", parms)
    .ToList();


            foreach (sploadbuildings obj in Listbulidings)
            {
                SqlParameter[] parameters =
                   { new SqlParameter("@buildingID", obj.BuildingID) ,
                     new SqlParameter("@userType", usertype)};
                var Listrooms = dBContext.spLoadDashboardrooms
             .FromSqlRaw("EXECUTE dbo.spLoadDashboardrooms  @buildingID, @userType", parameters)
   .ToList();
                foreach (sploadrooms roomdetails in Listrooms)
                {
                    SqlParameter[] parametersstatus = { new SqlParameter("@buildingID", obj.BuildingID),
                    new SqlParameter("@roomID", roomdetails.RoomID),
                     new SqlParameter("@CatID", Convert.ToInt32(HttpContext.Session.GetCatData("stafftype")))
                    };
                    var Listroomsstatus = dBContext.spLoadRoomsstatus
                 .FromSqlRaw("EXECUTE dbo.spLoadRoomsstatus  @buildingID, @roomID,@CatID", parametersstatus)
       .ToList();
                    roomdetails.listofRooms = Listroomsstatus;
                }

                obj.listofRooms = Listrooms;
            }

            return PartialView("Housekeepingdata", Listbulidings);
        }
        public ActionResult Createdialog()
        {
            Statusdropdown();
            ChildStatusdropdown(0);

            return PartialView("Createdialog");
        }

        public JsonResult updatenextStatus(int? id , int? stid)
        {
            string securedInfo = "";

            String ConnectionString = configuration.GetConnectionString("roomcheckingconnection");
            SqlConnection connection = new SqlConnection(ConnectionString);
            connection.Open();
            SqlCommand command = new SqlCommand(" update tblStatusDetails set intStatusID  = '"+ stid + "' , intChildStatus = '" + stid + "' where intSeqID = '" + id + "'", connection);
            try
            {
                command.ExecuteNonQuery();
                
            }
            catch (Exception)
            {
                
            }
            finally
            {
                connection.Close();
            }

            return Json(securedInfo);
        }


            public PartialViewResult mobdialog(int? id)
        {

            SqlParameter[] parms = { new SqlParameter("@currentstatusID", id) };
            var nextstatus = dBContext.spLoadnextRoomsstatus
    .FromSqlRaw("EXECUTE dbo.spLoadnextRoomsstatus @currentstatusID", parms)
    .ToList();

            return PartialView("mobdialog", nextstatus);
        }

        public JsonResult SaveSelectedStatus(string statusDetails, int? id)
        {
            string securedInfo = "";



            StatusDetails reqObj = JsonConvert.DeserializeObject<StatusDetails>(statusDetails);

            if (id < 0)
            {
                int? intIdt = dBContext.tblStatusDetails.Max(u => (int?)u.intSeqID);
                if (intIdt == null || intIdt == 0)
                {
                    intIdt = 1;
                }
                else
                {
                    intIdt = intIdt + 1;
                }
                reqObj.intSeqID = (int)intIdt;
                reqObj.dtDate = DateTime.Now;
                reqObj.intCatID = 1;
                //shift.dtCreationDate = DateTime.Now.ToString();
                dBContext.tblStatusDetails.Add(reqObj);
                dBContext.SaveChanges();
            }
            else
            {

                var data = dBContext.tblStatusDetails.Find(id);
                if (data != null)
                {
                    //reqObj.intCatID = 1;
                    //reqObj.dtDate = Convert.ToDateTime(dt);
                    reqObj.intSeqID = (int)id;
                    reqObj.dtDate = data.dtDate;
                    reqObj.intCatID = 1;
                    dBContext.Entry(data).CurrentValues.SetValues(reqObj);
                    dBContext.SaveChanges();
                }

            }
            securedInfo = "Saved Successfully";



            return Json(securedInfo);
        }

        public ActionResult Maintenance(int? id)
        {
   //         if (id == null)
   //         {
   //             id = 2;
   //         }
   //         HttpContext.Session.SetcatData("stafftype", id.ToString());

   //         var Listbulidings = dBContext.spLoadDashboard
   // .FromSqlRaw("EXECUTE dbo.spLoadDashboard")
   // .ToList();


   //         foreach (sploadbuildings obj in Listbulidings)
   //         {
   //             SqlParameter[] parameters = { new SqlParameter("@buildingID", obj.BuildingID) };
   //             var Listrooms = dBContext.spLoadDashboardrooms
   //          .FromSqlRaw("EXECUTE dbo.spLoadDashboardrooms  @buildingID", parameters)
   //.ToList();
   //             foreach (sploadrooms roomdetails in Listrooms)
   //             {
   //                 SqlParameter[] parametersstatus = { new SqlParameter("@buildingID", obj.BuildingID),
   //                 new SqlParameter("@roomID", roomdetails.RoomID),
   //                 new SqlParameter("@CatID", Convert.ToInt32(HttpContext.Session.GetCatData("stafftype")))
   //                 };
   //                 var Listroomsstatus = dBContext.spLoadRoomsstatus
   //              .FromSqlRaw("EXECUTE dbo.spLoadRoomsstatus  @buildingID, @roomID,@CatID", parametersstatus)
   //    .ToList();
   //                 roomdetails.listofRooms = Listroomsstatus;
   //             }

   //             obj.listofRooms = Listrooms;
   //         }
   //         icontypedropdown();

            return View();
        }


       public PartialViewResult Maintenancedata(int? id) {

            if (id == null)
            {
                id = 2;
            }
            HttpContext.Session.SetcatData("stafftype", id.ToString());

            var Listbulidings = dBContext.spLoadDashboard
    .FromSqlRaw("EXECUTE dbo.spLoadDashboard")
    .ToList();


            foreach (sploadbuildings obj in Listbulidings)
            {
                SqlParameter[] parameters = { new SqlParameter("@buildingID", obj.BuildingID) };
                var Listrooms = dBContext.spLoadDashboardrooms
             .FromSqlRaw("EXECUTE dbo.spLoadDashboardrooms  @buildingID", parameters)
   .ToList();
                foreach (sploadrooms roomdetails in Listrooms)
                {
                    SqlParameter[] parametersstatus = { new SqlParameter("@buildingID", obj.BuildingID),
                    new SqlParameter("@roomID", roomdetails.RoomID),
                    new SqlParameter("@CatID", Convert.ToInt32(HttpContext.Session.GetCatData("stafftype")))
                    };
                    var Listroomsstatus = dBContext.spLoadRoomsstatus
                 .FromSqlRaw("EXECUTE dbo.spLoadRoomsstatus  @buildingID, @roomID,@CatID", parametersstatus)
       .ToList();
                    roomdetails.listofRooms = Listroomsstatus;
                }

                obj.listofRooms = Listrooms;
            }
            icontypedropdown();

            return PartialView("Maintenancedata", Listbulidings);
            }

        

        public ActionResult CreateMaintenancedialog()
        {
            Statusmaintenancedropdown();
            //ChildStatusdropdown(0);
            icontypedropdown();
           
            return PartialView("CreateMaintenancedialog");
        }

        public void Statusdropdown()
        {
            var dropdownlist = util.SelectListstatus(loadDropdown(), "Value", "Text", "-Select main status-");
            var obj = dropdownlist.ElementAt(1);
            obj.Selected = true;
            ViewBag.statusList = dropdownlist;

        }

        public void Statusmaintenancedropdown()
        {
            List<SelectListItem> list = new List<SelectListItem>();
            DataTable dt = loadMaintenanceDropdown();
            DataRow[] parentrows = dt.Select("intParentID =-1");
            PopulateTreeView(parentrows, false, list, "-Select Status-", dt);
            ViewBag.statusmainList = new SelectList(list, "Value", "Text"); ;

        }
        public void icontypedropdown()
        {
            var dropdownlist = util.TostatusprorityhList();
            var obj = dropdownlist.ElementAt(0);
            obj.Selected = true;
            ViewBag.proritylist = dropdownlist;

        }

        public SelectList ChildStatusdropdown(int? parentid)
        {
            var dropdownlist = util.SelectListstatus(loadchildDropdown(parentid), "Value", "Text", "-Select main status first-");
            var obj = dropdownlist.ElementAt(0);
            obj.Selected = true;

            ViewBag.childstatusList = dropdownlist;
            return dropdownlist;

        }


        public JsonResult deleterow(int id)
        {
            var del = dBContext.tblStatusDetails.Where(x => x.intSeqID == id).SingleOrDefault();
            if (del != null)
            {
                dBContext.tblStatusDetails.Remove(del);
                dBContext.SaveChanges();
            }
            
            return Json("Deleted");
        }

        public JsonResult GetList(int customerID)
        {
            var list = loadchildDropdown(customerID);
            List<RoomStatus> datalist = new List<RoomStatus>();
            foreach (DataRow dataRow in list.Rows)
            {
                datalist.Add(new RoomStatus { intSeqID = Convert.ToInt32(dataRow["Value"]), text = dataRow["Text"].ToString(), isPriority = Convert.ToBoolean(dataRow["priorty"]), isCheckoutTime = Convert.ToBoolean(dataRow["cleaningtime"]), color = dataRow["scolor"].ToString() });
            }
            return Json(datalist);
        }
        public JsonResult GetparentList(int? id)
        {
            var list = loadDropdown();
            List<RoomStatus> datalist = new List<RoomStatus>();
            foreach (DataRow dataRow in list.Rows)
            {
                datalist.Add(new RoomStatus { intSeqID = Convert.ToInt32(dataRow["Value"]), text = dataRow["Text"].ToString(), isPriority = Convert.ToBoolean(dataRow["priorty"]), isCheckoutTime = Convert.ToBoolean(dataRow["cleaningtime"]), color = dataRow["scolor"].ToString() });
            }
            DataTable dtd = datalist.ToDataTable();
            return Json(datalist);
        }
        public JsonResult GetmainparentList(int? id)
        {
            List<RoomStatus> datalist = new List<RoomStatus>();
            DataTable dt = loadMaintenanceDropdown();
            DataRow[] parentrows = dt.Select("intParentID =-1");
            PopulateDatatable(parentrows, datalist, dt);
            //ViewBag.statusmainList = new SelectList(list, "Value", "Text"); ;
            //DataTable dtd = datalist.ToDataTable();

            return Json(datalist);
        }


       

        public JsonResult SaveSelectedMaintenanceStatus(string statusDetails,int? statusid,string dt)
        {
            string securedInfo = "";
            List<StatusDetails> reqObj = JsonConvert.DeserializeObject<List<StatusDetails>>(statusDetails);
            int? groupid = dBContext.tblStatusDetails.Max(u => (int?)u.isGroupID);
            if (groupid == null || groupid == 0)
            {
                groupid = 1;
            }
            else
            {
                groupid = groupid + 1;
            }
            foreach (StatusDetails obj in reqObj) {
                if (statusid == -1 || statusid == 0)
                {
                    int? primarykey = dBContext.tblStatusDetails.Max(u => (int?)u.intSeqID);
                    if (primarykey == null || primarykey == 0)
                    {
                        primarykey = 1;
                    }
                    else
                    {
                        primarykey = primarykey + 1;
                    }

                    obj.intSeqID = (int)primarykey;
                    obj.intCatID = 2;
                    obj.dtDate = DateTime.Now;
                    obj.isGroupID = groupid;
                    dBContext.tblStatusDetails.Add(obj);
                    dBContext.SaveChanges();


                }
                else {
                    var data = dBContext.tblStatusDetails.Find(statusid);
                    if (data != null)
                    {
                        groupid = data.isGroupID;
                        obj.intCatID = 2;
                        obj.dtDate = data.dtDate;

                        obj.intSeqID = (int)statusid;
                        dBContext.Entry(data).CurrentValues.SetValues(obj);
                        //dBContext.SaveChanges();
                    }
                    else {
                        int? primarykey = dBContext.tblStatusDetails.Max(u => (int?)u.intSeqID);
                        if (primarykey == null || primarykey == 0)
                        {
                            primarykey = 1;
                        }
                        else
                        {
                            primarykey = primarykey + 1;
                        }

                        obj.intSeqID = (int)primarykey;
                        obj.intCatID = 2;
                        obj.dtDate = DateTime.Now;
                        obj.isGroupID = groupid;
                        dBContext.tblStatusDetails.Add(obj);
                        dBContext.SaveChanges();
                    }
                }
                
            }
            
            
            securedInfo = "Saved Successfully";



            return Json(securedInfo);
        }



        private List<RoomStatus> GetCampaigns(int customerID)
        {
            List<RoomStatus> campaigns = new List<RoomStatus>();
            campaigns.Add(new RoomStatus { intSeqID = 1, text = "Camp1", intParentID = 1 });
            campaigns.Add(new RoomStatus { intSeqID = 2, text = "Camp2", intParentID = 1 });
            campaigns.Add(new RoomStatus { intSeqID = 3, text = "Camp3", intParentID = 1 });
            campaigns.Add(new RoomStatus { intSeqID = 4, text = "Camp4", intParentID = 1 });
            campaigns.Add(new RoomStatus { intSeqID = 5, text = "Camp5", intParentID = 1 });
            campaigns.Add(new RoomStatus { intSeqID = 6, text = "Camp6", intParentID = 1 });

            return campaigns.Where(x => x.intParentID == customerID).ToList();
        }

        public DataTable loadDropdown()
        {
            String ConnectionString = configuration.GetConnectionString("roomcheckingconnection");
            SqlConnection connection = new SqlConnection(ConnectionString);
            connection.Open();
            SqlCommand command = new SqlCommand("select intSeqid as Value, StatusName as Text, isnull(isPriority,0) as priorty, isnull(isCheckoutTime,0) as cleaningtime,isnull(StatusColor,'#292b2c') as scolor  from tblRoomStatus where intCat ='" + HttpContext.Session.GetCatData("stafftype") + "' and isnull(intParentID,-1) = -1", connection);
            DataTable dt = new DataTable();
            dt.Load(command.ExecuteReader());
            return dt;

        }
        public DataTable loadMaintenanceDropdown()
        {
            String ConnectionString = configuration.GetConnectionString("roomcheckingconnection");
            SqlConnection connection = new SqlConnection(ConnectionString);
            connection.Open();
            SqlCommand command = new SqlCommand("select intSeqid as Value, StatusName as Text, isnull(isPriority,0) as priorty, isnull(isCheckoutTime,0) as cleaningtime,isnull(StatusColor,'#292b2c') as scolor,intParentID  from tblRoomStatus where intCat ='" + HttpContext.Session.GetCatData("stafftype") + "' order by intSeqid", connection);
            DataTable dt = new DataTable();
            dt.Load(command.ExecuteReader());
            return dt;

        }

        private void PopulateDatatable(DataRow[] row, List<RoomStatus> datalist, DataTable dt)
        {
            foreach (DataRow newrow in row)
            {
                RoomStatus item = new RoomStatus();
               
                item.intSeqID = Convert.ToInt32(newrow["Value"]);
                item.text = newrow["Text"].ToString();
                item.isPriority = Convert.ToBoolean(newrow["priorty"]);
                item.isCheckoutTime = Convert.ToBoolean(newrow["cleaningtime"]);
                item.color = newrow["scolor"].ToString();
                datalist.Add(item);
                DataRow[] foundchildsRows = dt.Select("intParentID =" + Convert.ToInt32(item.intSeqID) + "");
                if (foundchildsRows.Length != 0)
                {
                    PopulateDatatable(foundchildsRows, datalist, dt);
                }

            }

        }


        

        private void PopulateTreeView(DataRow[] row, Boolean isParent, List<SelectListItem> list, string defaulttext, DataTable dt)
        {
            if (defaulttext.Length > 0)
            {
                SelectListItem item = new SelectListItem();
                item.Text = defaulttext;
                item.Value = "-1";
                list.Add(item);
            }
            for(int i = 0; i < row.Length; i++)
            {

                SelectListItem item = new SelectListItem();
                item.Text = row[i]["Text"].ToString();
                item.Value = row[i]["Value"].ToString();
                if (isParent == true)
                {
                    list.Add(item);
                    
                }
                else
                {
                    item.Text = item.Text; 
                   
                    list.Add(item);
                }
               // DataTable dtChild = loadDropdownchilds(Convert.ToInt32(item.Value));
                DataRow[] foundchildsRows = dt.Select("intParentID =" + Convert.ToInt32(item.Value) + "");
                if (foundchildsRows.Length != 0) {
                    PopulateTreeView(foundchildsRows, false, list, "",dt);
                }
                
            }

        }

        public DataTable loadDropdownchilds(int parentid)
        {
            String ConnectionString = configuration.GetConnectionString("roomcheckingconnection");
            SqlConnection connection = new SqlConnection(ConnectionString);
            connection.Open();
            SqlCommand command = new SqlCommand("select intSeqid as Value, StatusName as Text from tblRoomStatus where intCat ='" + HttpContext.Session.GetCatData("stafftype") + "' and intParentID = " + parentid + "", connection);
            DataTable dt = new DataTable();
            dt.Load(command.ExecuteReader());
            return dt;

        }

        public DataTable loadchildDropdown(int? parentid)
        {
            String ConnectionString = configuration.GetConnectionString("roomcheckingconnection");
            SqlConnection connection = new SqlConnection(ConnectionString);
            connection.Open();
            SqlCommand command = new SqlCommand("select intSeqid as Value, StatusName as Text, isnull(isPriority,0) as priorty, isnull(isCheckoutTime,0) as cleaningtime,isnull(StatusColor,'#292b2c') as scolor  from tblRoomStatus where intCat ='" + HttpContext.Session.GetCatData("stafftype") + "' and intParentID = '" + parentid + "'", connection);
            DataTable dt = new DataTable();
            dt.Load(command.ExecuteReader());
            return dt;

        }

        // GET: DashboardController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: DashboardController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DashboardController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: DashboardController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: DashboardController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: DashboardController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: DashboardController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
