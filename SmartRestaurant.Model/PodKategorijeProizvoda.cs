using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartRestaurant.Model
{
    public class PodKategorijeProizvoda
    {
        public int ID { get; set; }
        public string Naziv { get; set; }

        [ForeignKey("KategorijaProizvodaID")]

        public KategorijaProizvoda KategorijaProizvoda { get; set; }

        public int KategorijaProizvodaID { get; set; }
    }
}
