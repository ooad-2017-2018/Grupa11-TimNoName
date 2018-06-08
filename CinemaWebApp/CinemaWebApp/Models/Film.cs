namespace CinemaWebApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Film")]
    public partial class Film
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Film()
        {
            Karta = new HashSet<Karta>();
            Ocjena1 = new HashSet<Ocjena>();
        }

        public int Id { get; set; }

        [Required]
        public string Naslov { get; set; }

        [Required]
        public string Trailer { get; set; }

        [Required]
        public string Redatelj { get; set; }

        [Required]
        public string Zanr { get; set; }

        public int Ocjena { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Karta> Karta { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Ocjena> Ocjena1 { get; set; }
    }
}
