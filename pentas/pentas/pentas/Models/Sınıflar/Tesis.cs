using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace pentas.Models.Sınıflar
{
    public class Tesis
    {
        [Key]
        public int ID { get; set; }
        public string Ad { get; set; }
        public string Aciklama { get; set; }
        public string Adres { get; set; }
        public string Telefon { get; set; }
        public string Email { get; set; }
        public string MapURL { get; set; }
        public string FotoURL { get; set; }
    }
}