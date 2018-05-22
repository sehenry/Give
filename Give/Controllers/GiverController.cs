using Give.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Give.Controllers
{
    public class GiverController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        // GET: Giver
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult ItemRequests()
        {
            return View();
        }
        public ActionResult Messages()
        {
            return View();
        }
        public ActionResult RecipientProfiles()
        {
            return View();
        }

        // GET: Giver/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Giver/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Giver/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Giver/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Giver/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Giver/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Giver/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
