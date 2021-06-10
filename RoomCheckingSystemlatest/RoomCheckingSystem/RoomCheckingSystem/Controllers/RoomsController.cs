using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using RoomCheckingSystem.Models;
using RoomCheckingSystem.Repo;

using System.Linq;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace RoomCheckingSystem.Controllers
{
    public class RoomsController : Controller
    {
        private IConfiguration configuration;
        private readonly DBContext dBContext;
        public RoomsController(IConfiguration configuration, DBContext dBContext)
        {
            this.configuration = configuration;
            this.dBContext = dBContext;
        }

        // GET: RoomsController
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Roomslist()
        {

            var List = dBContext.spLoadRooms
    .FromSqlRaw("EXECUTE dbo.spLoadRooms")
    .ToList();
            return View(List);
        }


        public ActionResult Roomsadd()
        {
            ViewBag.RoomsList = util.SelectList(loadDropdown(), "Value", "Text","");

            return View();
        }

        [HttpPost]
        public ActionResult Roomsadd(Rooms room)
        {

//            SqlParameter[] parameters =
//{
//            new SqlParameter("@empid",empid),
//             new SqlParameter("@FromDate",dtf),
//             new SqlParameter("@ToDate",dtt),
//             new SqlParameter("@Locid",intlocid),

//            };

            //var List = dataContext.Database.SqlQuery<Models.spLoadAttendanceSummary_Result>("[dbo].[spLoadAttendanceSummary] @empid , @FromDate, @ToDate, @Locid", parameters).ToList();

    //        var List = dBContext.spLoadRooms
    //.FromSqlRaw("EXECUTE dbo.spLoadRooms",parameters)
    //.ToList();

            ViewBag.RoomsList = util.SelectList(loadDropdown(), "Value", "Text","");
            if (ModelState.IsValid)
            {
                room.dtCreationDate = DateTime.Now.ToString();
                dBContext.tblRooms.Add(room);
                dBContext.SaveChanges();
                return RedirectToAction("Roomslist");

            }
            return View();
        }


        public DataTable loadDropdown() {
            String ConnectionString = configuration.GetConnectionString("roomcheckingconnection");
            SqlConnection connection = new SqlConnection(ConnectionString);
            connection.Open();
            SqlCommand command = new SqlCommand("select intSeqID as Value,Buildingtitle as Text from tblBuilding", connection);
            DataTable dt = new DataTable();
            dt.Load(command.ExecuteReader());
            return dt;

        }


        // GET: RoomsController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: RoomsController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: RoomsController/Create
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

        // GET: RoomsController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: RoomsController/Edit/5
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

        // GET: RoomsController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: RoomsController/Delete/5
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
