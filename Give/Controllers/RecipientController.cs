﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Give.Models;

namespace Give.Controllers
{
    public class RecipientController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Recipients
        public ActionResult Index()
        {
            return View();
            //var recipients = db.Recipients.Include(r => r.User);
            //return View(recipients.ToList());
        }
        public ActionResult RecipientIndex() //produces list of all recipient profiles
        {
            return View(db.Recipients.ToList());
        }

        public ActionResult ProfileComplete()
        {
            return View();
        }
        // GET: Recipients/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Recipient recipient = db.Recipients.Find(id);
            if (recipient == null)
            {
                return HttpNotFound();
            }
            return View(recipient);
        }

        // GET: Recipients/Create
        public ActionResult Create()
        {
            ViewBag.ApplicationUserId = new SelectList(db.ApplicationUsers, "Id", "Email");
            return View();
        }

        // POST: Recipients/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,FirstName,LastName,Address,HouseHoldSize,AboutMe,ApplicationUserId")] Recipient recipient)
        {
            if (ModelState.IsValid)
            {
                db.Recipients.Add(recipient);
                db.SaveChanges();
                return RedirectToAction("ProfileComplete");
            }

            ViewBag.ApplicationUserId = new SelectList(db.ApplicationUsers, "Id", "Email", recipient.ApplicationUserId);
            return View(recipient);
        }

        // GET: Recipients/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Recipient recipient = db.Recipients.Find(id);
            if (recipient == null)
            {
                return HttpNotFound();
            }
            ViewBag.ApplicationUserId = new SelectList(db.ApplicationUsers, "Id", "Email", recipient.ApplicationUserId);
            return View(recipient);
        }

        // POST: Recipients/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,FirstName,LastName,Address,HouseHoldSize,AboutMe,ApplicationUserId")] Recipient recipient)
        {
            if (ModelState.IsValid)
            {
                db.Entry(recipient).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ApplicationUserId = new SelectList(db.ApplicationUsers, "Id", "Email", recipient.ApplicationUserId);
            return View(recipient);
        }

        // GET: Recipients/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Recipient recipient = db.Recipients.Find(id);
            if (recipient == null)
            {
                return HttpNotFound();
            }
            return View(recipient);
        }

        // POST: Recipients/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Recipient recipient = db.Recipients.Find(id);
            db.Recipients.Remove(recipient);
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
