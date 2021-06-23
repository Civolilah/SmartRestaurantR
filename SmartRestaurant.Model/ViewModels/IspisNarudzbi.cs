using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartRestaurant.Model.ViewModels
{
    public class IspisNarudzbi
    {
        public int NarudzbaID { get; set; }

        public string NazivNarudzbe { get; set; }

        public DateTime VrijemeKreiranjaNarudzbe { get; set; }

        public string StatusNarudzbe { get; set; }

        public string MjestoPosluzivanja { get; set; }

    }
}
