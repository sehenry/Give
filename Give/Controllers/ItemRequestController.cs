﻿using Give.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using System.Net;

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
        public ActionResult ItemRequest()
        {
            return View(db.ItemRequests.ToList());
        }
        [HttpGet]
        public ActionResult CreateItemRequest()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateItemRequest([Bind(Include = "DateTime, UserName, ItemName,ItemRequestMessage,Location")]ItemRequest itemRequest)
        {
            if (ModelState.IsValid)
            {
                db.ItemRequests.Add(itemRequest);
                db.SaveChanges();
                return RedirectToAction("ListOfItemRequests");
            }

            return View(itemRequest);
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

        // GET: Recipient/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ItemRequest itemRequest = db.ItemRequests.Find(id);
            if (itemRequest == null)
            {
                return HttpNotFound();
            }
            return View(itemRequest);
        }

        // POST: Recipient/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "DateTime, UserName, ItemName,ItemRequestMessage,Location")] ItemRequest itemRequest)
        {
            if (ModelState.IsValid)
            {
                db.Entry(itemRequest).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(itemRequest);
        }

        // GET: Recipient/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ItemRequest itemRequest = db.ItemRequests.Find(id);
            if (itemRequest == null)
            {
                return HttpNotFound();
            }
            return View(itemRequest);
        }

        // POST: Recipient/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ItemRequest itemrequest = db.ItemRequests.Find(id);
            db.ItemRequests.Remove(itemrequest);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
