using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SmartRestaurant.Model
{
    public class Narudzba
    {
        [Key]
        public int NarudzbaID { get; set; }

        public string NazivNarudzbe { get; set; }

        public DateTime VrijemeKreiranjaNarudzbe { get; set; }

        public DateTime VrijemeOdgovoraNaNarudzbu { get; set; }

        [ForeignKey("StatusNarudzbeID")]

        public StatusNarudzbe StatusNarudzbe { get; set; }

        public int StatusNarudzbeID { get; set; }

        [ForeignKey("NarudzbaDetaljiID")]

        public NarudzbaDetalji NarudzbaDetalji { get; set; }

        public int NarudzbaDetaljiID { get; set; }

        [ForeignKey("MjestoPosluzivanjaID")]

        public MjestoPosluzivanja MjestoPosluzivanja { get; set; }

        public int MjestoPosluzivanjaID { get; set; }

        public string ImeNarucioca { get; set; }

        public string AdresaNarucioca { get; set; }

        public string BrojTelefonaNarucioca { get; set; }

        public bool Prihvacena { get; set; }

        public bool PrihvacenaNotifikacija { get; set; }

        public bool PromjenaStatusa { get; set; }
    }
}
