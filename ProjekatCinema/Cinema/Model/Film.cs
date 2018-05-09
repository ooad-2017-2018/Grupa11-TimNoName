using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.Model
{
    public class Film
    {
        int id;
        string naslov;
        string trailer;
        string redatelj;
        string zanr;
        int ocjena;

        public Film()
        {
        }

        public int Id { get => id; set => id = value; }
        public string Naslov { get => naslov; set => naslov = value; }
        public string Trailer { get => trailer; set => trailer = value; }
        public string Redatelj { get => redatelj; set => redatelj = value; }
        public string Zanr { get => zanr; set => zanr = value; }
        public int Ocjena { get => ocjena; set => ocjena = value; }
    }
}
