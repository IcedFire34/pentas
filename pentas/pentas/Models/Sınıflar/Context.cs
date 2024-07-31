using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace pentas.Models.Sınıflar
{
    public class Context:DbContext
    {
        public DbSet<Admin> Admins { get; set; }
        public DbSet<AnaSayfa> AnaSayfas { get; set; }
        public DbSet<Hizmet> Hizmets { get; set; }
        public DbSet<IK> IKs { get; set; }
        public DbSet<Iletisim> Iletisims { get; set; }
        public DbSet<Tesis> Tesis_s { get; set; }

    }
}