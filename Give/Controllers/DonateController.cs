﻿using Give.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Give.Controllers
{
    public class DonateController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        // GET: Donate
        public ActionResult Index()
        {
            return View();
        }

        // GET: Donate/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Donate/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Donate/Create
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

        // GET: Donate/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Donate/Edit/5
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

        // GET: Donate/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Donate/Delete/5
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
