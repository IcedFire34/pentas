using pentas.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace pentas.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext() : base(ConfigurationManager.ConnectionStrings["pentasDBEntities"].ConnectionString)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Tesisler> Tesisler { get; set; }
    }
}