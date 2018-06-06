using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace WebApplication1.Models
{
    public class RezervacijaKarte
    {

        public int Id { get; set; }

        public int KodNarudzbe { get; set; }

        public String NacinPlacanja { get; set; }


        public Karta KartaFilm { get; set;}

        public RegistrovaniKorisnik Korisnik { get; set; }

    }
}