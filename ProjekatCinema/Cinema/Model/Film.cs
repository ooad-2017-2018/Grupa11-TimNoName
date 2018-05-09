using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.Model
{
    public class Film
    {
        public int id { get; set; }
        public string naslov { get; set; }
        public string trailer { get; set; }
        public string redatelj { get; set; }
        public string zanr { get; set; }
        public int ocjena { get; set; }

        public Film()
        {
        }

        /*public int Id { get => id; set => id = value; }
        public string Naslov { get => naslov; set => naslov = value; }
        public int Trailer { get => trailer; set => trailer = value; }
        public string Redatelj { get => redatelj; set => redatelj = value; }
        public Zanr Zanr { get => zanr; set => zanr = value; }
        public int Ocjena { get => ocjena; set => ocjena = value; }*/
    }
}
