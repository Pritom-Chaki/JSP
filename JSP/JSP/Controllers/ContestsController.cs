﻿using JSP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JSP.Controllers
{
    public class ContestsController : Controller
    {
        // GET: Contests
        public ActionResult Index()
        {
            var aContest = new Contest();
            return View(aContest);
        }
    }
}