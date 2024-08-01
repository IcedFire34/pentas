using System;
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
        public ActionResult Admin()
        {
            return View();
        }       
        public ActionResult Otoparklar()
        {
            return View();
        }
        public ActionResult test()
        {
            return View();
        }
        public ActionResult Organizasyon()
        {
            return View();
        }
        public ActionResult Pegmer()
        {
            return View();
        }

    }
}