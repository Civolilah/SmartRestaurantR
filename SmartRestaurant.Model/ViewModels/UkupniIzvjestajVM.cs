using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartRestaurant.Model.ViewModels
{
    public class UkupniIzvjestajVM
    {
        public List<IzvjestajTabelaVM> tabela { get; set; }
        public string UkupnaZarada { get; set; }
        public int UkupnoNarudzbi { get; set; }
        public int BrojNarudzbiProizvoda { get; set; }
        public string ProcenatNarudzbe { get; set; }
    }
}
