using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RoomCheckingSystem.Models;
using RoomCheckingSystem.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RoomCheckingSystem.Controllers
{
    public class UsersController : Controller
    {
        private readonly DBContext dBContext;
        public UsersController(DBContext dBContext)
        {
            this.dBContext = dBContext;
        }
        // GET: Users
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult UserManagement()
        {
            var listofusers = dBContext.Users.ToList();
            return View(listofusers);
        }

        public ActionResult NewUser()
        {
            ViewBag.CityList = util.ToSelectList();
            return View();
        }

        public ActionResult UserEdit(int? id)
        {
            ViewBag.CityList = util.ToSelectList();
            var user = dBContext.Users.Where(x => x.ID== id).SingleOrDefault();
            return View(user);
        }


        
        public ActionResult Delete(int id)
        {
            var user = dBContext.Users.Where(x => x.ID== id).SingleOrDefault();
            if (user != null)
            {
                dBContext.Users.Remove(user);
                dBContext.SaveChanges();
            }
            return RedirectToAction("UserManagement");
        }



        [HttpPost]
        public ActionResult UserEdit(User objuser)
        {
            var data = dBContext.Users.Find(objuser.ID);
            if (data != null)
            {
                objuser.UserName = objuser.Email;
                objuser.FullName = objuser.FirstName + " " + objuser.LastName;
                dBContext.Entry(data).CurrentValues.SetValues(objuser);
                dBContext.SaveChanges();
            }

            return RedirectToAction("UserManagement");
        }


        [HttpPost]
        public ActionResult NewUser(User user)
        {
            if (ModelState.IsValid)
            {
                user.UserName = user.Email;
                user.FullName = user.FirstName + " " + user.LastName;
                dBContext.Users.Add(user);
                dBContext.SaveChanges();
                return RedirectToAction("UserManagement");
                
            }
            ViewBag.CityList = util.ToSelectList();

            return View(user);
        }

        public ActionResult UserGrouplist()
        {
            var userGroups = dBContext.tblUserGroup.ToList();
            return View(userGroups);
        }

        public ActionResult NewUserGroup()
        {
            return View();
        }
        [HttpPost]
        public ActionResult NewUserGroup(UserGroup usergroup)
        {
            if (ModelState.IsValid)
            {
                dBContext.tblUserGroup.Add(usergroup);
                dBContext.SaveChanges();
                return RedirectToAction("UserGrouplist");
            }

            return View();
        }


        // GET: Users/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Users/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Users/Create
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

        // GET: Users/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Users/Edit/5
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

        // GET: Users/Delete/5
        

        // POST: Users/Delete/5
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
