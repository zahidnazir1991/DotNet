using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using RoomCheckingSystem.Models;
using RoomCheckingSystem.Repo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace RoomCheckingSystem.Controllers
{
    public class StatusController : Controller
    {
        private IConfiguration configuration;
        private readonly DBContext dBContext;
        int dashes = 6;
        string str = "";
        public StatusController(IConfiguration configuration, DBContext dBContext)
        {
            this.configuration = configuration;
            this.dBContext = dBContext;
        }

        public IActionResult Index(int? id)
        {
            if (id == 1)
            {
                ViewBag.titlepage = "HOUSE-KEEPING";
              
            }
            else {
               
                ViewBag.titlepage = "MAINTENANCE";
            }
            HttpContext.Session.SetcatData("stafftype", id.ToString());

            return View(loadDropdownnew());
        }

        private void  PopulateTreechart(DataTable dtdate, Boolean isParent)
        {
            foreach (DataRow row in dtdate.Rows)
            {

                SelectListItem item = new SelectListItem();
                item.Text = row["Text"].ToString();
                item.Value = row["Value"].ToString();
                if (isParent == true)
                {
                    str += "<li>";
                    str += " <span class='tf-nc'>";
                    str += ""+ item.Value + "";
                    str += "</ span >";
                    str += "<ul>";
                    str += "<li>";
                    str += " <span class='tf-nc'>";
                    str += "" + item.Value + "";
                    str += "</ span >";
                    str += " </li>";
                    str += "<li>";
                    str += " <span class='tf-nc'>";
                    str += "" + item.Value + "";
                    str += "</ span >";
                    str += " </li>";
                    str += "</ul>";
                    str += " </li>";

                }
                DataTable dtChild = loadDropdownchilds(Convert.ToInt32(item.Value));
                if (dtChild.Rows.Count != 0) { 
                }
                    //PopulateTreechart(dtChild, false);
            }
            



        }

        public void Statusdropdown() {
            var dropdownlist = util.SelectListstatus(loadDropdown(), "Value", "Text", "Main Status");
            var obj = dropdownlist.ElementAt(0);
            obj.Selected = true;

            ViewBag.statusList = dropdownlist;

        }

        public void icontypedropdown()
        {
            var dropdownlist = util.TostatustypeList();
            var obj = dropdownlist.ElementAt(1);
            obj.Selected = true;

            ViewBag.icontypelist = dropdownlist;

        }

        // GET: ShiftController/Edit/5
        public ActionResult Edit(int id)
        {
            List<SelectListItem> list = new List<SelectListItem>();
            PopulateTreeView(loadDropdown(), true, list, "Main Status");
            ViewBag.statusList = new SelectList(list, "Value", "Text");
           
            icontypedropdown();
            var roomstatus = dBContext.tblRoomStatus.Where(x => x.intSeqID == id && x.intCat == Convert.ToInt32(HttpContext.Session.GetCatData("stafftype"))).SingleOrDefault();
            return View(roomstatus);


        }
        [HttpPost]
        public ActionResult Edit(RoomStatus roomStatus)
        {
            var data = dBContext.tblRoomStatus.Find(roomStatus.intSeqID);
            if (data != null)
            {
                if (roomStatus.intParentID == 0)
                {
                    roomStatus.intParentID = -1;
                }
                roomStatus.intCat =  Convert.ToInt32(HttpContext.Session.GetCatData("stafftype"));
                roomStatus.dtUpdationDate = DateTime.Now.ToString();
                dBContext.Entry(data).CurrentValues.SetValues(roomStatus);
                dBContext.SaveChanges();
            }
            return RedirectToAction("Index");


        }

        public ActionResult Delete(int id)
        {
            var roomstatus = dBContext.tblRoomStatus.Where(x => x.intSeqID == id).SingleOrDefault();
            if (roomstatus != null)
            {
                dBContext.tblRoomStatus.Remove(roomstatus);
                dBContext.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        public IActionResult AddNewStatus(int? id)
        {
            List<SelectListItem> list = new List<SelectListItem>();
            PopulateTreeView(loadDropdown(), true, list, "Main Status");
            ViewBag.statusList = new SelectList(list, "Value" ,"Text");
            //Statusdropdown();
            icontypedropdown();


            return View();
        }
        [HttpPost]
        public IActionResult AddNewStatus(RoomStatus roomStatus)
        {
            Statusdropdown();
            icontypedropdown();
            if (roomStatus != null) {
                if (roomStatus.intParentID == 0)
                {
                    roomStatus.intParentID = -1;
                }
                roomStatus.intCat =  Convert.ToInt32(HttpContext.Session.GetCatData("stafftype"));
               
            }
            if (ModelState.IsValid)
            {
                roomStatus.dtCreationDate = DateTime.Now.ToString();
                dBContext.tblRoomStatus.Add(roomStatus);
                dBContext.SaveChanges();
                return RedirectToAction("Index", new { id = Convert.ToInt32(HttpContext.Session.GetCatData("stafftype"))});

            }
           

            return View();
        }

        public DataTable loadDropdown()
        {
            String ConnectionString = configuration.GetConnectionString("roomcheckingconnection");
            SqlConnection connection = new SqlConnection(ConnectionString);
            connection.Open();
            SqlCommand command = new SqlCommand("select intSeqid as Value, StatusName as Text from tblRoomStatus where intCat ='" + HttpContext.Session.GetCatData("stafftype") + "' and isnull(intParentID,-1) = -1", connection);
            DataTable dt = new DataTable();
            dt.Load(command.ExecuteReader());
            return dt;

        }

        public DataTable loadDropdownnew()
        {
            String ConnectionString = configuration.GetConnectionString("roomcheckingconnection");
            SqlConnection connection = new SqlConnection(ConnectionString);
            connection.Open();
            
            SqlCommand command = new SqlCommand("select *, isnull(isReception,0) as Rec,isnull(isHouseKeeping,0) as housekeeping,isnull(isSupervisor,0) as superv,isnull(isMaintenance,0) as maintenance, cast('' as nvarchar(max)) as html from tblRoomStatus where intCat ='"+ HttpContext.Session.GetCatData("stafftype") + "'", connection);
            DataTable dt = new DataTable();
            dt.Load(command.ExecuteReader());
            dt.Columns["html"].ReadOnly = false;
            foreach (DataRow row in dt.Rows)
            {
                setting(row);
            }
            return dt;

        }
        public void setting(DataRow row) {
            string html = "";
            
            if (row != null) {
                if (Convert.ToBoolean(row["isRunningCount"]))
                {
                    html += "<span style=\"color:#00FF00;margin-right: 2px;\" title =\"Count in running and total boxes of dashboard : YES\"><i class=\"fa fa-suitcase\" aria-hidden=\"true\"></i></span>";
                }
                else {
                    html += "<center><span style=\"color:#FF0000;margin-right: 2px\" title =\"Count in running and total boxes of dashboard : NO\"><i class=\"fa fa-suitcase\" aria-hidden=\"true\"></i></span>";
                }
                if (Convert.ToBoolean(row["isTimeSpent"]))
                {
                    html += "<span style=\"color:#00FF00;margin-right: 2px\" title =\"Note time spent : YES\"><i class=\"fa fa-clock-o\" aria-hidden=\"true\"></i></span>";
                }
                else
                {
                    html += "<span style=\"color:#FF0000;margin-right: 2px\" title =\"Note time spent : No\"><i class=\"fa fa-clock-o\" aria-hidden=\"true\"></i></span>";
                }

                if (Convert.ToBoolean(row["isShowCount"]))
                {
                    html += "<span style=\"color:#00FF00;margin-right: 2px;\" title=\"Show count box in dashboard summary area: YES\"><i class=\"fas fa-tachometer-alt\"></i></span>";
                }
                else
                {
                    html += "<span style=\"color:#FF0000;margin-right: 2px;\" title=\"Show count box in dashboard summary area: NO\"><i class=\"fas fa-tachometer-alt\"></i></span>";
                }
                if (Convert.ToBoolean(row["isPriority"]))
                {
                    html += "<span style=\"color:#00FF00;margin-right: 2px;\" title=\"Note priority in this status: YES\"><i class=\"fab fa-free-code-camp\" aria-hidden=\"true\"></i></span>";
                }
                else
                {
                    html += "<span style=\"color:#FF0000;margin-right: 2px;\" title=\"Note priority in this status: NO\"><i class=\"fab fa-free-code-camp\" aria-hidden=\"true\"></i></span>";
                }
                if (Convert.ToBoolean(row["isCheckoutTime"]))
                {
                    html += " <span style=\"color:#00FF00;margin-right: 2px;\" title=\"Note checkout time in this status: YES\"><i class=\"fab fa-accessible-icon\" aria-hidden=\"true\"></i></span>";
                }
                else
                {
                    html += " <span style=\"color:#FF0000;margin-right: 2px;\" title=\"Note checkout time in this status: NO\"><i class=\"fab fa-accessible-icon\" aria-hidden=\"true\"></i></span>";
                }
                html += "<span style=\"color:#FF0000;margin-right: 2px;\" title=\"Image or doc required before moving the room to this status: NO\"><i class=\"fas fa-arrows-alt\" aria-hidden=\"true\"></i></span>";
                if (Convert.ToBoolean(row["isActive"]))
                {
                    html += "<img src=\"/images/t.png\" title=\"Is Active: YES\" /></center>";
                }
                else
                {
                    html += "<img src=\"/images/cross.png\" title=\"Is Active: NO\" />";
                }

                row["html"] = html;



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

        private string pading(int total) {
            string padded = "";
            for (int i = 0; i <= total; i++) {
                padded = padded + "-";
                if (total > 100) {
                    break;
                        }
            }

            return padded;
        }

       // public List<SelectListItem> list = new List<SelectListItem>();
        private void PopulateTreeView(DataTable dtdate, Boolean isParent, List<SelectListItem> list, string defaulttext)
        {
            if (defaulttext.Length > 0)
            {
                SelectListItem item = new SelectListItem();
                item.Text = defaulttext;
                item.Value = "-1";
                list.Add(item);
            }
            foreach (DataRow row in dtdate.Rows)
            {
                
                SelectListItem item = new SelectListItem();
                item.Text = row["Text"].ToString();
                item.Value = row["Value"].ToString();
                if (isParent == true)
                {
                    list.Add(item);
                    dashes = 6;
                }
                else
                {
                    item.Text = pading(dashes) + " " +  item.Text;
                    dashes = dashes + 6;
                    list.Add(item);
                }
                DataTable dtChild = loadDropdownchilds(Convert.ToInt32(item.Value));
                if (dtChild.Rows.Count != 0)
                    PopulateTreeView(dtChild, false,list,"");
            }

        }

      

    }
}
