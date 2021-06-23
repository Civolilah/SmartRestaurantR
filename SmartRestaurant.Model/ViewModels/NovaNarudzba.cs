using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartRestaurant.Model.ViewModels
{
    public class NovaNarudzba
    {
        public string UserName { get; set; }
        public string NazivNarudzbe { get; set; }
        public DateTime VrijemeKreiranja { get; set; }
        public string Status { get; set; }
        public NarudzbaDetalji Detalji { get; set; }
        public string MjestoPosluzivanja { get; set; }
        public List<int> ListaProizvodID { get; set; }
        public List<int> ListaKolicina { get; set; }
        public Kucnadostavavm KucnaDostava { get; set; }
    }
}
