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
        public string Naslov { get => naslov; set { if (value == "") throw new Exception("Pogrešan unos"); naslov = value; } }
        public string Trailer { get => trailer; set { if (value == "") throw new Exception("Pogrešan unos"); trailer = value; } }
        public string Redatelj { get => redatelj; set { if (value == "") throw new Exception("Pogrešan unos"); redatelj = value; } }
        public string Zanr { get => zanr; set { if (value == "") throw new Exception("Pogrešan unos"); zanr = value; } }
        public int Ocjena { get => ocjena; set => ocjena = value; }
    }
}
