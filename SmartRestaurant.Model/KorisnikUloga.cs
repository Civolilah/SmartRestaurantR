using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SmartRestaurant.Model
{
    public class KorisnikUloga
    {
        [Key]
        public int KorisnikUlogaID { get; set; }

        [ForeignKey("KorisniciID")]

        public Korisnici Korisnici { get; set; }

        public int KorisniciID { get; set; }

        [ForeignKey("UlogeID")]

        public Uloge Uloge { get; set; }

        public int UlogeID { get; set; }
    }
}
