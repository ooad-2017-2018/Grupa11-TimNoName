using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace WebApplication1.Models
{
    public class CinemaContext : DbContext
    {
        public CinemaContext() : base("DefaultConnection") { }

        public DbSet<RegistrovaniKorisnik> RegistrovaniKorisnik { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

        public System.Data.Entity.DbSet<WebApplication1.Models.Film> Films { get; set; }
    }
}