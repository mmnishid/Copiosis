﻿using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using System.Transactions;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using DotNetOpenAuth.AspNet;
using Microsoft.Web.WebPages.OAuth;
using WebMatrix.WebData;
using Copiosis_Application.Filters;
using Copiosis_Application.Models;
using Copiosis_Application.DB_Data;

namespace Copiosis_Application.Controllers
{
    [Authorize(Roles="ADMIN")]
    public class AdminController : Controller
    {
        //
        // GET: /Admin/
        [HttpGet]
        public ActionResult Index()
        {
            return RedirectToAction("Overview");
        }

        //
        // GET: /Admin/Overview
        // See which items in the system are still using the default item class.
        [HttpGet]
        public ActionResult Overview()
        {
            return View();
        }

        //
        // GET: /Admin/AddClass
        // Add a new item class to Copiosis.
        [HttpGet]
        public ActionResult AddClass()
        {
            return View();
        }

        //
        // POST: /Admin/AddClass
        // Add a new item class to Copiosis.
        [HttpPost]
        public ActionResult AddClass(AddClassModel m)
        {
            return View();
        }

        //
        // POST: /Admin/ChangeClass
        // Change the class of an item already in Copiosis.
        [HttpPost]
        public ActionResult ChangeClass()
        {
            return Json(new { success = true });
        }

        //
        // GET: /Admin/Rejected
        // View all transactions that have been rejected in Copiosis.
        [HttpGet]
        public ActionResult Rejected()
        {
            return View();
        }

    }
}