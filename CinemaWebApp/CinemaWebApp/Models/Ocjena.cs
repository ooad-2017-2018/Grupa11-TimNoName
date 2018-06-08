namespace CinemaWebApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Ocjena")]
    public partial class Ocjena
    {
        public int Id { get; set; }

        public int BrojOcjena { get; set; }

        [Required]
        public string Komentar { get; set; }

        public int Film_Id { get; set; }

        public int? Korisnik_Id { get; set; }

        public virtual Film Film { get; set; }

        public virtual RegistrovaniKorisnik RegistrovaniKorisnik { get; set; }
    }
}
