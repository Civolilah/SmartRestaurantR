using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartRestaurant.Model.ViewModels
{
    public class NoviProizvodVM
    {
        public List<JedinicaKolicine> JedinicaKolicine { get; set; }
        public List<PodKategorijeProizvoda> KategorijaProizvoda { get; set; }
        public List<Skladiste> Skladiste { get; set; }
    }
}
