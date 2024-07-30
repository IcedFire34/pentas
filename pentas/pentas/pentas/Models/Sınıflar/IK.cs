using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace pentas.Models.Sınıflar
{
    public class IK
    {
        [Key]
        public int ID { get; set; }
        public string Acıklama { get; set; }
        public string FotoURL { get; set; }
        public string BasvuruURL { get; set; }
    }
}