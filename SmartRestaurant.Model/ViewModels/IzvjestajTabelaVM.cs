using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartRestaurant.Model.ViewModels
{
    public class IzvjestajTabelaVM
    {
        public string NazivProizvoda { get; set; }
        public int PutaProdan { get; set; }
        public double Cijena { get; set; }
        public string TrenutnoStanje { get; set; }
    }
}
