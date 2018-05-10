using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.Model
{
    
    public class Film
    {
        String id;
        int idFilma;
        string naslov;
        string trailer;
        string redatelj;
        string zanr;
        int ocjena;

        public Film()
        {
        }

        public String Id { get => id; set => id = value; }
        public string Naslov { get => naslov; set { if (value == "") throw new Exception("Pogrešan unos naslova"); naslov = value; } }
        public string Trailer { get => trailer; set { if (value == "") throw new Exception("Pogrešan unos trailera"); trailer = value; } }
        public string Redatelj { get => redatelj; set { if (value == "") throw new Exception("Pogrešan unos redatelja"); redatelj = value; } }
        public string Zanr { get => zanr;
            set { if (value == "" || (value!="komedija" && value!="triler" && value!="dokumentarac" && value!="sciFi" && value!="akcija" && value!="drama" && value!="horor" && value!="romansa"))
                    throw new Exception("Žanr može biti samo jedan od sljedećih: komedija, triler, dokumentarac, sciFi, akcija, drama, horor, romansa!");
                zanr = value; } }
        public int Ocjena { get => ocjena; set => ocjena = value; }
        public int IdFilma { get => idFilma; set => idFilma = value; }
    }
}
