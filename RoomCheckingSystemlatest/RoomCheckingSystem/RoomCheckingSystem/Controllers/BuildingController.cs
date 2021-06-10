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
    public class BuildingController : Controller
    {

        private readonly DBContext dBContext;
        public BuildingController(DBContext dBContext)
        {
            this.dBContext = dBContext;
        }

        // GET: BuildingController
        public ActionResult Index()
        {
            var listofbuilding = dBContext.tblBuilding.ToList();
            return View(listofbuilding);

            
        }

        public ActionResult Buildingadd() {

            return View();
        }
        [HttpPost]
        public ActionResult Buildingadd(Building building)
        {
            if (ModelState.IsValid)
            {
                dBContext.tblBuilding.Add(building);
                dBContext.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(building);
        }
        // GET: BuildingController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: BuildingController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BuildingController/Create
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

        // GET: BuildingController/Edit/5
        public ActionResult Edit(int id)
        {
            var shift = dBContext.tblBuilding.Where(x => x.intSeqID == id).SingleOrDefault();
            return View(shift);
        }

        [HttpPost]
        public ActionResult Edit(Building building)
        {
            var data = dBContext.tblBuilding.Find(building.intSeqID);
            if (data != null)
            {
                //building.dtCreationDate = DateTime.Now.ToString();
                dBContext.Entry(data).CurrentValues.SetValues(building);
                dBContext.SaveChanges();
            }

            return RedirectToAction("Index");
        }




        // GET: BuildingController/Delete/5
        public ActionResult Delete(int id)
        {

            var user = dBContext.tblBuilding.Where(x => x.intSeqID == id).SingleOrDefault();
            if (user != null)
            {
                dBContext.tblBuilding.Remove(user);
                dBContext.SaveChanges();
            }
            return RedirectToAction("Index");
            
        }

        // POST: BuildingController/Delete/5
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
