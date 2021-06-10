using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RoomCheckingSystem.Controllers
{
    public class TimeStation : Controller
    {
        // GET: TimeStation
        public ActionResult Index()
        {
            return View();
        }

        // GET: TimeStation
        public ActionResult GetTimeStation()
        {
            return View();
        }

        // GET: TimeStation/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: TimeStation/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TimeStation/Create
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

        // GET: TimeStation/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: TimeStation/Edit/5
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

        // GET: TimeStation/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: TimeStation/Delete/5
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
