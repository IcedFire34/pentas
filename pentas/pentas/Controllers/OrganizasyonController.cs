using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace pentas.Controllers
{
    public class OrganizasyonController : Controller
    {
        // GET: Organizasyon
        public ActionResult Yunus_Emre_Kultur_ve_Sanat_Merkezi()
        {
            return View();
        }
        public ActionResult PENCR_Bahce()
        {
            return View();
        }
        public ActionResult Görseller()
        {
            return View();
        }
    }
}