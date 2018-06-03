using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel;


namespace WebApplication1.Models
{
    public class Karta
    {
        public int Id { get; set; }

        [Required]
        [DisplayName("Broj karata")]
        public int BrojKarata { get; set; }

        [Required]
        [DisplayName("Datum prikazivanja")]
        public DateTime DatumPrikazivanja { get; set; }

        [Required]
        [DisplayName("Sjedište")]
        public List<int> BrojSjedista { get; set; }

        public Double UkupnaCijena { get; set; }

        public Film FilmKarta { get; set; }

    }
}