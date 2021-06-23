using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartRestaurant.Model.ViewModels
{
    public class DetaljiNarudzbeVM
    {
        public int NarudzbaID { get; set; }

        public List<ProizvodNarudzbaDetaljiVM> listaproizvoda { get; set; }

        public string Cijena { get; set; }

        public string ImeIPrezimeNarucioca { get; set; }

        public string BrojTelefonaNarucioca { get; set; }

        public string AdresaNarucioca { get; set; }
    }
}
