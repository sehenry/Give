using Give.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using System.Net;

namespace Give.Controllers
{
    public class RecipientController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        // GET: Recipient
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult ProfileComplete()
        {
            return View(db.Recipients.ToList());
        }
        [HttpGet]
        public ActionResult CreateProfile()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateProfile([Bind(Include = "FirstName, LastName, Address, AboutMe, HouseHoldSize")]Recipient recipient)
        {
            if (ModelState.IsValid)
            {
                db.Recipients.Add(recipient);
                db.SaveChanges();
                return RedirectToAction("ProfileComplete");
            }

            return View(recipient);
        }
        //public new ActionResult Profile(Recipient model)
        //{
        //    try
        //    {
        //        ApplicationDbContext db = new ApplicationDbContext();

        //        Recipient recipient = new Recipient();
        //        recipient.FirstName = model.FirstName;
        //        recipient.LastName = model.LastName;
        //        recipient.Address = model.Address;
        //        recipient.HouseHoldSize = model.HouseHoldSize;
        //        recipient.AboutMe = model.AboutMe;

        //        db.Recipients.Add(recipient);

        //        db.SaveChanges();

        //    }
        //    catch(Exception ex)
        //    {
        //        throw ex;
        //    }
        //    return RedirectToAction("Profile");
        //}
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
        public ActionResult ItemRequest(ItemRequest model)
        {
            try
            {
                ApplicationDbContext db = new ApplicationDbContext();

                ItemRequest item = new ItemRequest();
                item.DateTime = model.DateTime;
                item.ItemName = model.ItemName;
                item.UserName = model.UserName;
                item.ItemRequestMessage = model.ItemRequestMessage;

                db.ItemRequests.Add(item);

                db.SaveChanges();
               

            }
            catch(Exception ex)
            {
                throw ex;
            }
            return RedirectToAction("ItemRequest");
        }
        // GET: Recipient/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Recipient/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Recipient/Create
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
            Recipient recipient = db.Recipients.Find(id);
            if (recipient == null)
            {
                return HttpNotFound();
            }
            return View(recipient);
        }

        // POST: Recipient/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "FirstName, LastName, Address, AboutMe, HouseHoldSize")] Recipient recipient)
        {
            if (ModelState.IsValid)
            {
                db.Entry(recipient).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(recipient);
        }

        // GET: Recipient/Delete/5
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

        // POST: Recipient/Delete/5
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
