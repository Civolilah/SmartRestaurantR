using SmartRestaurant.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace MobileApps.ViewModels
{
    public class NotifikacijaVM : BaseViewModel
    {
        
        private readonly APIService _narudzbeService = new APIService("Narudzbe");
        public string _nazivstanja = string.Empty;
        public string NazivStanja
        {
            get { return _nazivstanja; }
            set { SetProperty(ref _nazivstanja, value); }
        }

        public void Init(string naziv)
        {
            NazivStanja = naziv;
        }

        internal List<Narudzba> GetNarudzbeBezNotifikacije()
        {
            List<Narudzba> n = _narudzbeService.GetBezNotifikacije<List<Narudzba>>(NazivStanja);

            return n;
        }
    }
}
