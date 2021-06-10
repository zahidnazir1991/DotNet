using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RoomCheckingSystem.Controllers
{
    public class LoginActivity : Controller
    {
        // GET: LoginActivity
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult GetAtivitylist() {

            return View();
        }

        public ActionResult GetWhois()
        {

            return View();
        }

        // GET: LoginActivity/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: LoginActivity/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: LoginActivity/Create
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

        // GET: LoginActivity/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: LoginActivity/Edit/5
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

        // GET: LoginActivity/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: LoginActivity/Delete/5
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
