﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Web.Controllers
{
    public class ReportsController : Controller
    {
        //
        // GET: /Reports/

        public ActionResult graphs()
        {
            return View();
        }

    }
}
