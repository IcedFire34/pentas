using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace pentas.Models.Sınıflar
{
    public class Hizmet
    {
        [Key]
        public int ID { get; set; }
        public string Ad { get; set; }
        public string KapakFotoURL { get; set; }
        public string Tesisler { get; set; }
    }
}