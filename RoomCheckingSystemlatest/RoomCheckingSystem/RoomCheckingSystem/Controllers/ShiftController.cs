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
    public class ShiftController : BaseController
    {
        private readonly DBContext dBContext;
        public ShiftController(DBContext dBContext)
        {
            this.dBContext = dBContext;
        }

        // GET: ShiftController
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Shiftlist()
        {
            
            var shiftlist = dBContext.tblShift.ToList();
            return View(shiftlist);
        }


            public ActionResult Shiftadd()
        {
           
            return View();
        }

        [HttpPost]
        public ActionResult Shiftadd(Shift shift)
        {
            if (ModelState.IsValid)
            {
                shift.dtCreationDate = DateTime.Now.ToString();
                dBContext.tblShift.Add(shift);
                dBContext.SaveChanges();
                return RedirectToAction("Shiftlist");
            }
            return View(shift);
        }


        // GET: ShiftController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ShiftController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ShiftController/Create
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

        // GET: ShiftController/Edit/5
        public ActionResult Edit(int id)
        {
            var shift = dBContext.tblShift.Where(x => x.intSeqID == id).SingleOrDefault();
            return View(shift);

            
        }

        [HttpPost]
        public ActionResult Edit(Shift shift)
        {
            var data = dBContext.tblShift.Find(shift.intSeqID);
            if (data != null)
            {
                shift.dtCreationDate = DateTime.Now.ToString();
                dBContext.Entry(data).CurrentValues.SetValues(shift);
                dBContext.SaveChanges();
            }

            return RedirectToAction("Shiftlist");
        }

        public ActionResult Delete(int id)
        {
            var shift = dBContext.tblShift.Where(x => x.intSeqID == id).SingleOrDefault();
            if (shift != null)
            {
                dBContext.tblShift.Remove(shift);
                dBContext.SaveChanges();
            }
            return RedirectToAction("Shiftlist");
        }

        // POST: ShiftController/Edit/5


       

        // POST: ShiftController/Delete/5
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
