﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace pentas.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Kurumsal()
        {
            return View();
        }
        public ActionResult Tesisler()
        {
            return View();
        }
        public ActionResult Guzelyali_Sosyal_Tesisleri()
        {
            return View();
        }
    }
}