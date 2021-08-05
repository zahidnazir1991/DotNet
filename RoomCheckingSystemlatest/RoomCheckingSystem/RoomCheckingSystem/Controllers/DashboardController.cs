using Microsoft.AspNetCore.Hosting;
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
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;



namespace RoomCheckingSystem.Controllers
{

    public class DashboardController : BaseController
    {

        private IConfiguration configuration;
        private readonly DBContext dBContext;
        private readonly IWebHostEnvironment _webHostEnvironment;
        string ImageFolder = "uploadimages";
        public DashboardController(IConfiguration configuration, DBContext dBContext, IWebHostEnvironment webHostEnvironment)
        {
            this.configuration = configuration;
            this.dBContext = dBContext;
            this._webHostEnvironment = webHostEnvironment;
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

        public JsonResult updatenextStatus(int? id, int? stid)
        {
            string securedInfo = "";

            String ConnectionString = configuration.GetConnectionString("roomcheckingconnection");
            SqlConnection connection = new SqlConnection(ConnectionString);
            connection.Open();
            SqlCommand command = new SqlCommand(" update tblStatusDetails set intStatusID  = '" + stid + "' , intChildStatus = '" + stid + "' where intSeqID = '" + id + "'", connection);
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

        public JsonResult getChat(int? id, int? type)
        {
            string returnmessage = "";
            var data = HttpContext.Session.GetComplexData<User>("UserProfile");
            SqlParameter[] parms = { new SqlParameter("@intGroupID", id),
            new SqlParameter("@type", type),
            new SqlParameter("@userid", data.ID)
            };
            var listofmessages = dBContext.sploadchat
    .FromSqlRaw("EXECUTE dbo.sploadchat @intGroupID,@type,@userid", parms)
    .ToList();

            //var path = Path.Combine(_webHostEnvironment.WebRootPath, ImageFolder);
            if (listofmessages.Count() > 0) {

                //listofmessages.ElementAt(0).img = path + listofmessages.ElementAt(0).img;
                return Json(listofmessages);
            }

            return Json(returnmessage);
        }

        public JsonResult deleteChat(int? id, int? type)
        {
            string returnmessage = "";
            String ConnectionString = configuration.GetConnectionString("roomcheckingconnection");
            SqlConnection connection = new SqlConnection(ConnectionString);
                
                SqlCommand command = new SqlCommand("spdeletechat", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@intID", id);
                command.Parameters.AddWithValue("@type", type);
                try
                {
                    connection.Open();
                    //string result = command.ExecuteScalar().ToString();
                    int count = command.ExecuteNonQuery();
                    if (count > 0)
                    {
                        connection.Close();
                    returnmessage = "Record Deleted Sucessfully";
                    }

                }
                catch (Exception ex)
                {
                    string ms = ex.Message.ToString();
                }
                finally
                {
                    connection.Close();
                }
           

            return Json(returnmessage);
        }




        public void SaveImage(string base64img, string outputImgFilename = "image.jpg")
        {
          
            string webRootPath = _webHostEnvironment.WebRootPath;
            var folderPath = System.IO.Path.Combine(webRootPath, "uploadimages");
            if (!System.IO.Directory.Exists(folderPath))
            {
                System.IO.Directory.CreateDirectory(folderPath);
            }
            System.IO.File.WriteAllBytes(Path.Combine(folderPath, outputImgFilename), Convert.FromBase64String(base64img));
        }

        public JsonResult saveChat(int? statusID, int? GroupID, int? type, int? roomId, int? buildingID,string description)
        {
       
            string webRootPath = _webHostEnvironment.WebRootPath;
            string contentRootPath = _webHostEnvironment.ContentRootPath;
            string path = "";
            path = Path.Combine(webRootPath, "uploadimages");
            string image = "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";
            string guid = Guid.NewGuid().ToString();
            string imagename = guid + "." + "png";

            SaveImage(image, imagename);

            string securedInfo = "";
            String ConnectionString = configuration.GetConnectionString("roomcheckingconnection");
            SqlConnection connection = new SqlConnection(ConnectionString);
            var data = dBContext.tblChatMaster.Where(x => x.intGroupID== GroupID).SingleOrDefault();
            if (data == null)
            {
                var max = dBContext.tblChatMaster.DefaultIfEmpty().Max(r => r == null ? 1 : r.intSeqID);



                SqlCommand command = new SqlCommand("spInsertChatMaster", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@intSeqId", max);
                command.Parameters.AddWithValue("@currentstatusID", statusID);
                command.Parameters.AddWithValue("@groupID", GroupID);
                command.Parameters.AddWithValue("@type", type);
                command.Parameters.AddWithValue("@userId", type);
                command.Parameters.AddWithValue("@roomid", roomId);
                command.Parameters.AddWithValue("@buildingid", buildingID);
                try
                {
                    connection.Open();
                    //string result = command.ExecuteScalar().ToString();
                    int count = command.ExecuteNonQuery();
                    if (count > 0)
                    {
                        //connection.Close();

                        SqlCommand cmd = new SqlCommand("spInsertChatDetails", connection);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@currentstatusID", statusID);
                        cmd.Parameters.AddWithValue("@varDescription", description);
                        cmd.Parameters.AddWithValue("@varImage", imagename);
                        cmd.Parameters.AddWithValue("@type", 1);
                        cmd.Parameters.AddWithValue("@userId", 7);
                        cmd.Parameters.AddWithValue("@parentID", max);
                        int detail = cmd.ExecuteNonQuery();
                        if (detail > 0)
                        {
                            connection.Close();
                        }

                    }

                }
                catch (Exception ex)
                {
                    string ms = ex.Message.ToString();
                }
                finally
                {
                    connection.Close();
                }
            }


            else {

                try
                {
                 SqlCommand cmd = new SqlCommand("spInsertChatDetails", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@currentstatusID", statusID);
                cmd.Parameters.AddWithValue("@varDescription", description);
                cmd.Parameters.AddWithValue("@varImage", imagename);
                cmd.Parameters.AddWithValue("@type", 1);
                cmd.Parameters.AddWithValue("@userId", 7);
                cmd.Parameters.AddWithValue("@parentID", data.intSeqID);
                    connection.Open();
                    int detail = cmd.ExecuteNonQuery();
                if (detail > 0)
                {
                    connection.Close();
                }

            }
                catch (Exception ex)
            {
                string ms = ex.Message.ToString();
            }
            finally
            {
                connection.Close();
            }

        }

            return Json(securedInfo);
        }



        public JsonResult updatenextMaintenanceStatus(int? id, int? stid)
        {
            string securedInfo = "";

            String ConnectionString = configuration.GetConnectionString("roomcheckingconnection");
            SqlConnection connection = new SqlConnection(ConnectionString);
            connection.Open();
            SqlCommand command = new SqlCommand("update tblStatusDetails set intStatusID  = '" + stid + "' , intParentStatus = '" + stid + "' where intSeqID = '" + id + "'", connection);
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

            return View();
        }


        public PartialViewResult Maintenancedata(int? id)
        {

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


                    parametersstatus.ElementAt(2).Value = 1;
                    var Listhousekeepingstatus = dBContext.spLoadRoomsstatus
              .FromSqlRaw("EXECUTE dbo.spLoadRoomsstatus  @buildingID, @roomID,@CatID", parametersstatus)
               .ToList();

                    roomdetails.HousekeepingRooms = Listhousekeepingstatus;
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

        public ActionResult CreateMaintenancedialogmob(int? Groupid, int? CurrentStatusID)
        {

            string webRootPath = _webHostEnvironment.WebRootPath;
            string contentRootPath = _webHostEnvironment.ContentRootPath;
            string path = "";
            path = Path.Combine(webRootPath, "uploadimages");
            ViewBag.Groupid = Groupid;
            ViewBag.CurrentSt = CurrentStatusID;
           

            return PartialView("CreateMaintenancedialogmob");
        }
        public JsonResult getDetailsofStatus(int? group, int? statusid)
        {
            int stid = (int)statusid;
            int groupid = (int)group;
            SqlParameter[] parametersstatus = {
                    new SqlParameter("@currentstatusID", stid),
                    new SqlParameter("@groupID", groupid)
                    };
            var Listroomsstatus = dBContext.spLoadRoomsstatus
         .FromSqlRaw("EXECUTE dbo.spLoadstatusdetails  @currentstatusID, @groupID", parametersstatus)
.ToList();
            string mystring = "<div>";
            mystring += "<div class='pad bg-gray mb-2' style='padding-top:10px; padding-left:10px;'>Room Status</div>";


            // Test purpose using 3 loops after geting time will remove this work
            foreach (var roomdetails in Listroomsstatus)
            {
                mystring += "<div class='row cxm-no-gutters cxm-bg-white mb-2'><div class='col-6' style='padding:10px;'><div class='pad text-uppercase text-sm' style='font-size: 12px;color: #000;'>" + roomdetails.catname + "</div></div>";
                mystring += "<div class='col-6'><div class='pad cxm-bg-purple text-sm fc1' style='font-size: 12px;padding:10px;background-color:" + roomdetails.StatusColor + " !important; color:#FFFFFF !important;'><span class='" + roomdetails.icon + "'></span>&nbsp;&nbsp;" + roomdetails.StatusName + "</div></div></div>";
            }
            mystring += "<div class='pad bg-gray mb-2' style='padding-top:10px; padding-left:10px;'>Job Description</div>";

            foreach (var roomdetails in Listroomsstatus.Where(x => x.isGroupID != -1).ToList())
            {
                mystring += "<div class='row cxm-no-gutters mb-2 cxm-bg-white' onclick='Maintenance_combo_multi_task("+ roomdetails.statusid + ");' style='cursor: pointer;'>";
                mystring += "<div class='col-9'><div class='cxm1-p-1 vertical-center'style='font-size: 12px;color: #000;'>" + roomdetails.Description + "</div></div><div class='col-3'><div class='text-center cxm1-p-1 fc1' style='background-color:" + roomdetails.StatusColor + " !important; color:#FFFFFF !important;'><span class='" + roomdetails.icon + "'></span><div class='text-sm' style='font-size: 12px;'> " + roomdetails.StatusName + "</div></div></div></div>";
                mystring += "</div>";

            }

            mystring += "<div class='js-model_status_area' id='js-maintenance_next_status_btns' style='margin-top:100px;position: absolute;bottom:0;left:0;width: 100%;'>";
            foreach (var roomdetails in Listroomsstatus.Where(x => x.isGroupID != -1).ToList())
            {

                SqlParameter[] parms = { new SqlParameter("@currentstatusID", roomdetails.stID) };
                var nextstatus = dBContext.spLoadnextRoomsstatus
        .FromSqlRaw("EXECUTE dbo.spLoadnextmaintenancestatus @currentstatusID", parms)
        .ToList();

                int nextstatusid = -1;
                if (nextstatus.Count() > 0)
                {
                    nextstatusid = nextstatus.ElementAt(0).ID;
                }
                else
                {
                    nextstatusid = -1;
                }

                if (nextstatus.Count() > 0) { 
                mystring += "<div id = 'groupt-" + roomdetails.statusid + "' class='js-status_btn_groups' onclick='changestatus(" + roomdetails.statusid + "," + nextstatusid + ");' style='display:none;'>";
                mystring += "<div id = 'group-" + roomdetails.statusid + "' class='pad cxm-bg-purple fc1 btn-block text-center js-room_status_btns' data-group_id='" + roomdetails.statusid + "' data-value='" + nextstatusid + "' is-last='0' style='background-color: " + nextstatus.ElementAt(0).StatusColor + " !important;; cursor: pointer;height: 50px; font-size: 20px;width:100%;padding:10px;' data-before_after='{&quot;enabled&quot;:0}'>" + nextstatus.ElementAt(0).StatusName + "&nbsp;&nbsp; <span class='" + nextstatus.ElementAt(0).icon + "'></span></div></div>";
            }

            }
            mystring += "</div>";









            return new JsonResult(mystring);
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




        public JsonResult SaveSelectedMaintenanceStatus(string statusDetails, int? statusid, string dt)
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
            foreach (StatusDetails obj in reqObj)
            {
                if (obj.intSeqID == -1 || obj.intSeqID == 0)
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
                else
                {
                    var data = dBContext.tblStatusDetails.Find(obj.intSeqID);
                    if (data != null)
                    {
                        groupid = data.isGroupID;
                        obj.intCatID = 2;
                        obj.dtDate = data.dtDate;

                        obj.intSeqID = obj.intSeqID;
                        dBContext.Entry(data).CurrentValues.SetValues(obj);
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
            for (int i = 0; i < row.Length; i++)
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
                if (foundchildsRows.Length != 0)
                {
                    PopulateTreeView(foundchildsRows, false, list, "", dt);
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
