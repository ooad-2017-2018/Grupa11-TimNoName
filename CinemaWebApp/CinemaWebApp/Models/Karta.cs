namespace CinemaWebApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Karta")]
    public partial class Karta
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Karta()
        {
            RezervacijaKarte = new HashSet<RezervacijaKarte>();
        }

        public int Id { get; set; }

        public DateTime DatumPrikazivanja { get; set; }

        public double UkupnaCijena { get; set; }

        public int? FilmKarta_Id { get; set; }

        [Required]
        public string NazivFilma { get; set; }

        public int BrojSjedista { get; set; }

        public virtual Film Film { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RezervacijaKarte> RezervacijaKarte { get; set; }
    }
}
