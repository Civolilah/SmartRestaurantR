using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartRestaurant.Model.ViewModels
{
    public class IzvrsiUredjivanjeNarudzbeVM
    {
        public int NarudzbaID { get; set; }
        public List<UrediNarudzbuProizvodVM> listaproizvoda { get; set; }
        public int BrojMjestaNarudzbeID { get; set; }
    }
}
