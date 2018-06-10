using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class PonudaFilmova
    {
        public List<Film> Filmovi { get; set; }
        public int BrojFilmova { get; set; }

        public List<Film> DostupniFilmovi() {
            return Filmovi;
        }
        public Film FilmNaPoziciji(int i) {
            return Filmovi[i];
        }
    }
}