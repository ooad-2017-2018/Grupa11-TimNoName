namespace CinemaWebApp.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class CinemaModel : DbContext
    {
        public CinemaModel()
            : base("name=CinemaModel")
        {
        }

        public virtual DbSet<Film> Film { get; set; }
        public virtual DbSet<Karta> Karta { get; set; }
        public virtual DbSet<Ocjena> Ocjena { get; set; }
        public virtual DbSet<RegistrovaniKorisnik> RegistrovaniKorisnik { get; set; }
        public virtual DbSet<RezervacijaKarte> RezervacijaKarte { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Film>()
                .HasMany(e => e.Karta)
                .WithOptional(e => e.Film)
                .HasForeignKey(e => e.FilmKarta_Id);

            modelBuilder.Entity<Film>()
                .HasMany(e => e.Ocjena1)
                .WithRequired(e => e.Film)
                .HasForeignKey(e => e.Film_Id);

            modelBuilder.Entity<Karta>()
                .HasMany(e => e.RezervacijaKarte)
                .WithOptional(e => e.Karta)
                .HasForeignKey(e => e.KartaFilm_Id);

            modelBuilder.Entity<RegistrovaniKorisnik>()
                .HasMany(e => e.Ocjena)
                .WithOptional(e => e.RegistrovaniKorisnik)
                .HasForeignKey(e => e.Korisnik_Id);

            modelBuilder.Entity<RegistrovaniKorisnik>()
                .HasMany(e => e.RezervacijaKarte)
                .WithOptional(e => e.RegistrovaniKorisnik)
                .HasForeignKey(e => e.Korisnik_Id);
        }
    }
}
