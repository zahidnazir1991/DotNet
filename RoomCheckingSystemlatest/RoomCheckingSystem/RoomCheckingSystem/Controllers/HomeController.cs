using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RoomCheckingSystem.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.Data.SqlClient;
using RoomCheckingSystem.Repo;
using Microsoft.EntityFrameworkCore;
using System.Data;
using Microsoft.AspNetCore.Http;

namespace RoomCheckingSystem.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IConfiguration configuration;
        private readonly DBContext dBContext;
        

        //public HomeController(ILogger<HomeController> logger)
        //{
        //    _logger = logger;
        //}
        //public HomeController(IConfiguration configuration)
        //{
        //    this.configuration = configuration;
        //}
        public HomeController(DBContext dBContext, IConfiguration configuration)
        {
            this.dBContext = dBContext;
            this.configuration = configuration;
            //this.session = httpContextAccessor.HttpContext.Session;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Image()
        {
            return View();
        }

        public ActionResult ModalPopUp()
        {
            return View();
        }

        private List<User> GEtusers() {
           var getRecoredS =  dBContext.Users.ToList();

            List<User> customers = (from User in this.dBContext.Users.Take(10)
                                    select User).ToList();
            return customers;

        }
        public IActionResult LoginwithPin() {
            return View();
        }
        public ActionResult logout()
        {
            HttpContext.Session.ClearSession();
            HttpContext.Session.CommitAsync();
            HttpContext.Session.LoadAsync();
            return RedirectToAction("LoginwithPin");
        }

        [HttpPost]
        public IActionResult LoginwithPin(User user)
        {
            String ConnectionString = configuration.GetConnectionString("roomcheckingconnection");
            SqlConnection connection = new SqlConnection(ConnectionString);
            connection.Open();
            SqlCommand command = new SqlCommand("select * from Users where isActive = 1 and isAllowpin = 1 and pinCode =" + user.PinCode, connection);
            DataTable dt = new DataTable();
            dt.Load(command.ExecuteReader());
            User sessionuser = null;
            foreach (DataRow row in dt.Rows) {
                sessionuser = new User();
                sessionuser.ID = Convert.ToInt32(row["ID"]);
                sessionuser.FullName = row["FullName"].ToString();
                sessionuser.FirstName = row["FirstName"].ToString();
                sessionuser.Email = row["Email"].ToString();
                sessionuser.Phone = row["Phone"].ToString();
                break;
            }
            if (sessionuser != null)
            {
                HttpContext.Session.SetComplexData("UserProfile", sessionuser);
                ViewBag.error = "";
                return RedirectToAction("Dashboard", "Dashboard", new { area = "" });
            }
            else {
                ViewBag.error = "Invalid PIN";
            }


            // var data = HttpContext.Session.GetComplexData<User>("UserProfile");
        


            connection.Close();
            return View();
        }

        
        public IActionResult Login() {

            return View();
        }
        [HttpPost]
        public IActionResult Login(User user)
        {
            String ConnectionString = configuration.GetConnectionString("roomcheckingconnection");
            SqlConnection connection = new SqlConnection(ConnectionString);
            connection.Open();
            SqlCommand command = new SqlCommand("select * from Users where isActive = 1 and Email = '" + user.Email + "' and UserPassword = '" + user.UserPassword + "'", connection);
            DataTable dt = new DataTable();
            dt.Load(command.ExecuteReader());
            User sessionuser = null;
            foreach (DataRow row in dt.Rows)
            {
                sessionuser = new User();
                sessionuser.ID = Convert.ToInt32(row["ID"]);
                sessionuser.FullName = row["FullName"].ToString();
                sessionuser.FirstName = row["FirstName"].ToString();
                sessionuser.Email = row["Email"].ToString();
                sessionuser.Phone = row["Phone"].ToString();
                break;
            }
            if (sessionuser != null)
            {
                HttpContext.Session.SetComplexData("UserProfile", sessionuser);
                ViewBag.error = "";
                return RedirectToAction("Dashboard", "Dashboard", new { area = "" });
            }
            else
            {
                ViewBag.error = "Invalid login details";
            }


            //ViewBag.data = HttpContext.Session.GetComplexData<User>("UserProfile");
            connection.Close();

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
