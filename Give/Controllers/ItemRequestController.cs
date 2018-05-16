using Give.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Give.Controllers
{
    public class ItemRequestController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        // GET: ItemRequest
        public ActionResult Index()
        {
            return View();
        }

        // GET: ItemRequest/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ItemRequest/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ItemRequest/Create
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

        // GET: ItemRequest/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ItemRequest/Edit/5
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

        // GET: ItemRequest/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ItemRequest/Delete/5
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
