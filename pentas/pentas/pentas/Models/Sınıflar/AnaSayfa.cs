using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace pentas.Models.Sınıflar
{
    public class AnaSayfa    
    {
        [Key]
        public int ID { get; set; }
        public Hizmet[] Hizmetler {  get; set; }
        public string[] Slider { get; set; }
    }
}