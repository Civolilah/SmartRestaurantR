using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartRestaurant.Model
{
    public class KorisnikOcjena
    {
        public int ID { get; set; }
        [ForeignKey("KorisniciID")]

        public Korisnici Korisnici { get; set; }

        public int KorisniciID { get; set; }

        [ForeignKey("ProizvodID")]

        public Proizvod Proizvod { get; set; }

        public int ProizvodID { get; set; }

        public int Ocjena { get; set; }
    }
}
