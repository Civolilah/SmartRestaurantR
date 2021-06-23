using MobileApps.Views;
using SmartRestaurant.Model.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace MobileApps.ViewModels
{
    public class KucnaDostavaVM : BaseViewModel
    {
        
        public KucnaDostavaVM()
        {
            Command = new Command( () =>
            {
                 NarudzbaPage();
            });
        }
        static string _imeiprezime = string.Empty;
        public string ImeIprezime
        {
            get { return _imeiprezime; }
            set { SetProperty(ref _imeiprezime, value); }
        }

        static string _adresa = string.Empty;
        public string Adresa
        {
            get { return _adresa; }
            set { SetProperty(ref _adresa, value); }
        }

        static string _brojtelefona = string.Empty;
        public string BrojTelefona
        {
            get { return _brojtelefona; }
            set { SetProperty(ref _brojtelefona, value); }
        }

        string _korisnickoimevalidation = string.Empty;
        public string KorisnickoImeValidation
        {
            get { return _korisnickoimevalidation; }
            set { SetProperty(ref _korisnickoimevalidation, value); }
        }

        string _adresavalidation = string.Empty;
        public string AdresaValidation
        {
            get { return _adresavalidation; }
            set { SetProperty(ref _adresavalidation, value); }
        }

        string _brojtelefonavalidation = string.Empty;
        public string BrojTelefonaValidation
        {
            get { return _brojtelefonavalidation; }
            set { SetProperty(ref _brojtelefonavalidation, value); }
        }

        public ICommand Command { get; set; }

        async void NarudzbaPage()
        {
            Kucnadostavavm objekat = new Kucnadostavavm
            {
                Imeiprezime=_imeiprezime,
                Adresa=_adresa,
                BrojTelefona=_brojtelefona
            };
        }

        public Kucnadostavavm GetValues()
        {
            Kucnadostavavm objekat = new Kucnadostavavm
            {
                Imeiprezime = _imeiprezime,
                Adresa = _adresa,
                BrojTelefona = _brojtelefona
            };

            return objekat;
        }

        public void PromijeniKorisnickoImeValidation(bool vrijednost)
        {
            if (vrijednost == true)
                KorisnickoImeValidation = "Polje je obavezno i treba da sadrži slova!";
            else
                KorisnickoImeValidation = "";
        }

        public void PromijeniAdresaValidation(bool vrijednost)
        {
            if (vrijednost == true)
                AdresaValidation = "Polje je obavezno i treba da sadrži brojeve ili slova!";
            else
                AdresaValidation = "";
        }

        public void PromijeniBrojTelefonaValidation(bool vrijednost)
        {
            if (vrijednost == true)
                BrojTelefonaValidation = "Polje je obavezno i treba da sadrži brojeve ili - ili /!";
            else
                BrojTelefonaValidation = "";
        }

        public static string GetKorisnickoIme()
        {
            return _imeiprezime;
        }
        public static string GetAdresa()
        {
            return _adresa;
        }
        public static string GetBrojTelefona()
        {
            return _brojtelefona;
        }
    }
}
