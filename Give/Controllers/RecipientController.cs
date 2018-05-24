using Give.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

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
        public new ActionResult Profile(Recipient model)
        {
            try
            {
                ApplicationDbContext db = new ApplicationDbContext();

                Recipient recipient = new Recipient();
                recipient.FirstName = model.FirstName;
                recipient.LastName = model.LastName;
                recipient.Address = model.Address;
                recipient.HouseHoldSize = model.HouseHoldSize;
                recipient.AboutMe = model.AboutMe;

                db.Recipients.Add(recipient);

                db.SaveChanges();

            }
            catch(Exception ex)
            {
                throw ex;
            }
            return RedirectToAction("Index");
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
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Recipient/Edit/5
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

        // GET: Recipient/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Recipient/Delete/5
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
