using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartRestaurant.Model.ViewModels
{
    public class PregledVM
    {
        public int NarudzbaID { get; set; }
        public string IDMjestaPosluzivanja { get; set; }
        public string NazivNarudzbe { get; set; }
        public string Status { get; set; }
        public DateTime VrijemeKreiranjaNarudzbe { get; set; }
    }
}
