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
        [HttpGet]
        public new ActionResult Profile()
        {
            Giver giver = new Giver();
            return View(giver);

        }
        [HttpPost]
        public new ActionResult Profile(Giver model)
        {
            try
            {
                ApplicationDbContext db = new ApplicationDbContext();

                Giver profile = new Giver();
                profile.FirstName = model.FirstName;
                profile.LastName = model.LastName;
                profile.Address = model.Address;
                profile.AboutMe = model.AboutMe;

                db.Givers.Add(profile);

                db.SaveChanges();

            }
            catch(Exception ex)
            {
                throw ex;
            }
            return RedirectToAction("Profile");
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
