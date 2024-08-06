using pentas.Data;
using pentas.Models;
using System.Linq;
using System.Web.Mvc;

namespace pentas.Controllers
{
    public class AccountController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AccountController()
        {
            _context = new ApplicationDbContext();
        }

        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Verify(User user)
        {
            if (ModelState.IsValid)
            {
                var validUser = _context.Users
                    .Where(u => u.email == user.email && u.paswd == user.paswd)
                    .FirstOrDefault();

                if (validUser != null)
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    ModelState.AddModelError("", "Geçersiz giriş");
                }
            }
            return View("Login");
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Tesisler()
        {
            var tesisler = _context.Tesisler.ToList();
            return View(tesisler);
        }
    }
}
