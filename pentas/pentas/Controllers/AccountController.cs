using pentas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using System.Data.SqlClient;

namespace pentas.Controllers
{
    public class AccountController : Controller
    {
        SqlConnection _connection = new SqlConnection();
        SqlCommand _command = new SqlCommand();        

        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }
        public ActionResult Index()
        {
            return View();
        }

        void connectionString() 
        {
            _connection.ConnectionString = "data source=DESKTOP-DFQMG2T; database=pentasDB; integrated security = SSPI";            
        }

        [HttpPost]
        public ActionResult Verify(User user)
        {
            connectionString();
            using (var connection = new SqlConnection(_connection.ConnectionString))
            {
                connection.Open();
                using (var command = new SqlCommand("SELECT * FROM [User] WHERE email = @Email AND paswd = @Password", connection))
                {
                    command.Parameters.AddWithValue("@Email", user.email);
                    command.Parameters.AddWithValue("@Password", user.paswd);
                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return View("Index");
                        }
                        else
                        {
                            return View("Account/Login");
                        }
                    }
                }
            }
        }

    }
}