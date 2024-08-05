using pentas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using pentas.Models;
using System.Data.SqlClient;

namespace pentas.Controllers
{
    public class AccountController : Controller
    {
        SqlConnection _connection = new SqlConnection();
        SqlCommand _command = new SqlCommand();
        SqlDataReader _reader;

        [HttpGet]
        public ActionResult Login()
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
            _connection.Open();
            _command.Connection = _connection;
            // Parametreli sorgu oluşturun
            _command.CommandText = "SELECT * FROM [User] WHERE email = @Email AND paswd = @Password";

            // Parametreleri ekleyin
            _command.Parameters.AddWithValue("@Email", user.email);
            _command.Parameters.AddWithValue("@Password", user.paswd);

            // Komutu çalıştırın
            _reader = _command.ExecuteReader();


            if (_reader.Read()) 
            {
                _connection.Close();
                return View("Index");
            }
            else
            {
                _connection.Close();
                return View("Login");
            }

                       
        }



    }
}