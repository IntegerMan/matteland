﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AniWebApp.Controllers
{
    public class AniController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Forecasts()
        {
            return View();
        }
        public ActionResult Traffic()
        {
            return View();
        }
    }
}