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
    public class GiveBoardController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        // GET: GiveBoard
        public ActionResult Index()
        {
            return View(db.GiveBoards.ToList());
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreatePost([Bind(Include = "GiverName, ItemName, ItemDescription, ItemLocation")] GiveBoard giveBoardPost)
        {
            if (ModelState.IsValid)
            {
                db.GiveBoards.Add(giveBoardPost);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(giveBoardPost);
        }
        [HttpGet]
        public ActionResult CreatePost()
        {
            return View();
        }
        public ActionResult SearchBoard(GiveBoard model)
        {
            return View("Index");
        }

        // GET: GiveBoard/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            GiveBoard giveboard = db.GiveBoards.Find(id);
            if (giveboard == null)
            {
                return HttpNotFound();
            }
            return View(giveboard);
        }

        // GET: GiveBoard/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: GiveBoard/Create
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

        // GET: GiveBoard/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: GiveBoard/Edit/5
        [HttpPost]
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            GiveBoard giveBoardPost = db.GiveBoards.Find(id);
            if (giveBoardPost == null)
            {
                return HttpNotFound();
            }
            return View(giveBoardPost);
        }

        // POST: GiveBoards/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "SuperheroID,Name,Power,Age")] GiveBoard giveBoardPost)
        {
            if (ModelState.IsValid)
            {
                db.Entry(giveBoardPost).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(giveBoardPost);
        }

        // GET: GiveBoards/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            GiveBoard giveBoardPost = db.GiveBoards.Find(id);
            if (giveBoardPost == null)
            {
                return HttpNotFound();
            }
            return View(giveBoardPost);
        }

        // POST: GiveBoards/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            GiveBoard giveBoardPost = db.GiveBoards.Find(id);
            db.GiveBoards.Remove(giveBoardPost);
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
