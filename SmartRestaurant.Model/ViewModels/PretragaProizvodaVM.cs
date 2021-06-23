using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartRestaurant.Model.ViewModels
{
    public class PretragaProizvodaVM
    {
        public int ProizvodID { get; set; }
        public string Naziv { get; set; }
        public double Cijena { get; set; }
        public string NazivSkladista { get; set; }
        public byte[] Slika { get; set; }
        public string Aktivan { get; set; }
    }
}
