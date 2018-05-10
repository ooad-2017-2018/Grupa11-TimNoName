using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.Model
{
    public class RegistrovaniKorisnik
    {
        private String id;
        private string ime;
        private string prezime;
        private string username;
        private string password;
        private DateTime datumRodjenja;
        private string brojKartice;
        private string eMail;

        public RegistrovaniKorisnik()
        {
        }

        public String Id { get => id; set => id = value; }
        public string Ime { get => ime; set { if (value == "") throw new Exception("Pogresan unos"); ime = value; } }
        public string Prezime { get => prezime; set { if (value == "") throw new Exception("Pogresan unos"); prezime = value; } }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set { if(value.Length<5) throw new Exception("Pogresan unos"); password = value; } }
        public DateTime DatumRodjenja { get => datumRodjenja; set {
                try { datumRodjenja = Convert.ToDateTime(value); }
                catch (Exception ex){ throw new Exception("Neispravan datum"); }
                datumRodjenja = value; } }
        public string BrojKartice { get => brojKartice; set => brojKartice = value; }
        public string EMail { get => eMail; set => eMail = value; }
    }
}
