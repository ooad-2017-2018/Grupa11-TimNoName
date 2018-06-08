namespace CinemaWebApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RezervacijaKarte")]
    public partial class RezervacijaKarte
    {
        public int Id { get; set; }

        public int KodNarudzbe { get; set; }

        public string NacinPlacanja { get; set; }

        public int? KartaFilm_Id { get; set; }

        public int? Korisnik_Id { get; set; }

        public virtual Karta Karta { get; set; }

        public virtual RegistrovaniKorisnik RegistrovaniKorisnik { get; set; }
    }
}
