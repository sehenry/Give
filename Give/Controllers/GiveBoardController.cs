using Give.Models;
using System;
using System.Collections.Generic;
using System.Linq;
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
            return View();
        }
        public ActionResult PostToBoard(GiveBoard model)
        {
            try
            {
                ApplicationDbContext db = new ApplicationDbContext();

                GiveBoard postToBoard = new GiveBoard();
                postToBoard.GiverName = model.GiverName;
                postToBoard.ItemName = model.ItemName;
                postToBoard.ItemDescription = model.ItemDescription;
                postToBoard.ItemLocation = model.ItemLocation;

                db.GiveBoards.Add(postToBoard);

                db.SaveChanges();


            }
            catch(Exception ex)
            {
                throw ex;
            }
            return RedirectToAction("PostToBoard");
        }
        public ActionResult SearchBoard(GiveBoard model)
        {
            return View();
        }

        // GET: GiveBoard/Details/5
        public ActionResult Details(int id)
        {
            return View();
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

        // GET: GiveBoard/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: GiveBoard/Delete/5
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
