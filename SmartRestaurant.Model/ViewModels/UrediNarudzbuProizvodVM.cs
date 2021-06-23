using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartRestaurant.Model.ViewModels
{
    public class UrediNarudzbuProizvodVM
    {
        public int ProizvodID { get; set; }
        public bool Narucen { get; set; }
        public string NazivProizvoda { get; set; }
        public double Cijena { get; set; }
        public string Opis { get; set; }
    }
}
