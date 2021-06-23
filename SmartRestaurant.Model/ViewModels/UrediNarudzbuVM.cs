using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartRestaurant.Model.ViewModels
{
    public class UrediNarudzbuVM
    {
        public List<UrediNarudzbuProizvodVM> listaproizvoda { get; set; }
        public List<MjestoPosluzivanja> listamjestaposluzivanja { get; set; }
    }
}
