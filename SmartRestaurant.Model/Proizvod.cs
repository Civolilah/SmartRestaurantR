using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SmartRestaurant.Model
{
    public class Proizvod
    {
        [Key]
        public int ProizvodID { get; set; }

        public string Naziv { get; set; }

        public double Cijena { get; set; }

        public byte[] Slika { get; set; }

        public double Količina { get; set; }

        public bool Aktivan { get; set; }

        [ForeignKey("JedinicaKolicineID")]

        public JedinicaKolicine JedinicaKolicine { get; set; }

        public int JedinicaKolicineID { get; set; }

        [ForeignKey("PodKategorijeProizvodaID")]

        public PodKategorijeProizvoda PodKategorijeProizvoda { get; set; }

        public int PodKategorijeProizvodaID { get; set; }

        [ForeignKey("SkladisteID")]

        public Skladiste Skladiste { get; set; }

        public int SkladisteID { get; set; }

        [ForeignKey("ProizvodDetaljiID")]

        public ProizvodDetalji ProizvodDetalji { get; set; }

        public int ProizvodDetaljiID { get; set; }

        public DateTime IstekRoka { get; set; }

        public double NabavnaCijena { get; set; }
    }
}
