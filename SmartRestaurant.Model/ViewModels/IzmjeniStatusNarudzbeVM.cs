using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartRestaurant.Model.ViewModels
{
    public class IzmjeniStatusNarudzbeVM
    {

        public string NazivNarudzbe { get; set; }
        public List<StatusNarudzbe> listastatusa { get; set; }
    }
}
