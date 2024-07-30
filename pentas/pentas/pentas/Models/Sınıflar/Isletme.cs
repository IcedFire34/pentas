using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace pentas.Models.Sınıflar
{
    public class Isletme
    {
        
        public string Adres {  get; set; }
        public string Email { get; set; }
        public string Telefon { get; set; }
        public string MapURL { get; set; }
    }
}