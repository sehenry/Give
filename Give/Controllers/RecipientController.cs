﻿using Give.Models;
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
        public new ActionResult Profile()
        {
            return View();
        }
        public ActionResult Messages()
        {
            return View();
        }
        public ActionResult ItemRequest()
        {
            return View();
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
