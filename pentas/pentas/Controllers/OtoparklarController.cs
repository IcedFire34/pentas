using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace pentas.Controllers
{
    public class OtoparklarController : Controller
    {
        // GET: Otoparklar
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Havaalani_Otoparki()
        {
            return View();
        }
        public ActionResult Merkez_Sahil_Otoparki()
        {
            return View();
        }
    }
}