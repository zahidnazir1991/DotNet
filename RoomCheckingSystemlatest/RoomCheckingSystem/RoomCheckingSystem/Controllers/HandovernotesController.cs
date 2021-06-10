using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RoomCheckingSystem.Controllers
{
    public class HandovernotesController : Controller
    {
        // GET: HandovernotesController
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Handoverlist()
        {
            return View();
        }

        public ActionResult CreateNote()
        {
            return View();
        }
        // GET: HandovernotesController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: HandovernotesController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: HandovernotesController/Create
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

        // GET: HandovernotesController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: HandovernotesController/Edit/5
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

        // GET: HandovernotesController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: HandovernotesController/Delete/5
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
