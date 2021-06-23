using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartRestaurant.Model.ViewModels
{
    public class DetaljiProizvodaVM
    {
        public string Opis { get; set; }
        public string KolicinaNaSkladistu { get; set; }
        public string JedinicaMjere { get; set; }
        public string KategorijaProizvoda { get; set; }
        public double KolicinaProizvoda { get; set; }
        public byte[] Slika { get; set; }
        public int Ocjena { get; set; }
    }
}
