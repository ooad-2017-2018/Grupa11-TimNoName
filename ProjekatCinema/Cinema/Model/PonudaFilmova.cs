using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.Model
{
    public class PonudaFilmova
    {
        private List<Film> filmoviUPonudi;
        private int brojFilmova;

        public int BrojFilmova { get => brojFilmova; set => brojFilmova = value; }
        internal List<Film> FilmoviUPonudi { get => filmoviUPonudi; set => filmoviUPonudi = value; }
    }
}
