using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartRestaurant.Model.ViewModels
{
    public class InsertProizvodaVM
    {
        public string Naziv { get; set; }
        public double Cijena { get; set; }
        public double Kolicina { get; set; }
        public string JedinicaKolicine { get; set; }
        public string KategorijaProizvoda { get; set; }
        public string Skladiste { get; set; }
        public int KolicinaNaSkladistu { get; set; }
        public string Opis { get; set; }
        public byte[] Slika { get; set; }
        public bool Aktivan { get; set; }
        public DateTime IstekRoka { get; set; }
        public double NabavnaCijena { get; set; }
    }
}
