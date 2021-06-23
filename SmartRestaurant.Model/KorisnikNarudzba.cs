using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartRestaurant.Model
{
    public class KorisnikNarudzba
    {
        [Key]
        public int NarudzbaKorisnikID { get; set; }
        [ForeignKey("NarudzbaID")]

        public Narudzba Narudzba { get; set; }

        public int NarudzbaID { get; set; }

        [ForeignKey("KorisnikID")]

        public Korisnici Korisnici { get; set; }

        public int KorisnikID { get; set; }
    }
}
