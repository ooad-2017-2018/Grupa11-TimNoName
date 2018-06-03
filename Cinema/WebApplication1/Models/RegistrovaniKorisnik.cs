using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace WebApplication1.Models
{
    public class RegistrovaniKorisnik
    {
        public int Id { get; set; }
        
        [Required]
        [DisplayName("Ime")]
        public string Ime { get; set; }

        [Required]
        [DisplayName("Prezime")]
        public string Prezime { get; set; }

        [Required]
        [DisplayName("Username")]
        public string Username { get; set; }

        [Required]
        [DisplayName("Password")]
        public string Password { get; set; }

        [Required]
        [DisplayName("Datum rođenja")]
        public string DatumRođenja { get; set; }

        [Required]
        [DisplayName("Broj kartice")]
        public string BrojKartice { get; set; }

        [Required]
        [DisplayName("Email")]
        public string Email { get; set; }


    }
}