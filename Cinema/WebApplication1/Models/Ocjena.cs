using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel;



namespace WebApplication1.Models
{
    public class Ocjena
    {
        public int Id { get; set; }

        [Required]
        [DisplayName("Ocjena")]
        [Range(1,5)]
        public int BrojOcjena { get; set; }

        [Required]
        [DisplayName("Komentar")]
        public String Komentar { get; set; }

        [Required]
        [DisplayName("Film")]
        public Film Film { get; set; }

        public RegistrovaniKorisnik Korisnik { get; }
    }
}