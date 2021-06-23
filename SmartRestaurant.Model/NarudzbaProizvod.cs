using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SmartRestaurant.Model
{
    public class NarudzbaProizvod
    {
        [Key]
        public int NarudzbaProizvodID { get; set; }
        [ForeignKey("NarudzbaID")]

        public Narudzba Narudzba { get; set; }

        public int NarudzbaID { get; set; }

        [ForeignKey("ProizvodID")]

        public Proizvod Proizvod { get; set; }

        public int ProizvodID { get; set; }
    }
}
