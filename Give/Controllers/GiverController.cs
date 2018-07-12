using Give.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
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
        public ActionResult ProfileComplete()
        {
            return View(db.Givers.ToList());
        }
        [HttpGet]
        public ActionResult CreateProfile()
        {           
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateProfile([Bind(Include = "FirstName, LastName, Address, AboutMe")]Giver giver)
        {
            if (ModelState.IsValid)
            {
                db.Givers.Add(giver);
                db.SaveChanges();
                return RedirectToAction("ProfileComplete");
            }

            return View(giver);
            //try
            //{
            //    ApplicationDbContext db = new ApplicationDbContext();

            //    Giver profile = new Giver();
            //    profile.FirstName = model.FirstName;
            //    profile.LastName = model.LastName;
            //    profile.Address = model.Address;
            //    profile.AboutMe = model.AboutMe;

            //    db.Givers.Add(profile);

            //    db.SaveChanges();

            //}
            //catch(Exception ex)
            //{
            //    throw ex;
            //}
            //return View(model);
        }
        public ActionResult ItemRequests()
        {
            return View();
        }
        public ActionResult Messages(Message model)
        {
            try
            {
                ApplicationDbContext db = new ApplicationDbContext();

                Message message = new Message();
                message.ReceivedMessage = model.ReceivedMessage;
                message.SentMessage = model.SentMessage;
                message.DateTime = model.DateTime;
                message.MessageContent = model.MessageContent;


                db.Messages.Add(message);

                db.SaveChanges();

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return RedirectToAction("Messages");
        }

        public ActionResult RecipientProfiles()
        {
            return View();
        }

        // GET: Giver/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Giver giver = db.Givers.Find(id);
            if (giver == null)
            {
                return HttpNotFound();
            }
            return View(giver);
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
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Giver giver = db.Givers.Find(id);
            if (giver == null)
            {
                return HttpNotFound();
            }
            return View(giver);
        }

        // POST: Giver/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "SuperheroID,Name,Power,Age")] Giver giver)
        {
            if (ModelState.IsValid)
            {
                db.Entry(giver).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(giver);
        }

        // GET: Giver/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Giver giver = db.Givers.Find(id);
            if (giver == null)
            {
                return HttpNotFound();
            }
            return View(giver);
        }

        // POST: Giver/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Giver giver = db.Givers.Find(id);
            db.Givers.Remove(giver);
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
