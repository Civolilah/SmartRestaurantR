using SmartRestaurant.Model;
using SmartRestaurant.Model.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace MobileApps.ViewModels
{
    public class ProizvodDetaljiVM : BaseViewModel
    {
        private readonly APIService _apiService = new APIService("ProizvodiUpravljanje");
        public ObservableCollection<DetaljiProizvodaVM> ListaDetalja { get; set; } = new ObservableCollection<DetaljiProizvodaVM>();
        private int _id;
        public int TrenutnaOcjena { get; set; } = 5;
        public ProizvodDetaljiVM()
        {
            Command = new Command(async () =>
            {
                 await GetDetalji(_id);
            });
        }
        public DetaljiProizvodaVM _opis = null;
        public DetaljiProizvodaVM DetaljiProizvodaVMObj
        {
            get { return _opis; }
            set { SetProperty(ref _opis, value); }
        }

        public string _ocjenjen = null;
        public string Ocjena
        {
            get { return _ocjenjen; }
            set { SetProperty(ref _ocjenjen, value); }
        }
        public ICommand Command { get; set; }

        public async Task GetDetalji(int id)
        {
            _id = id;
            var obj = await _apiService.GetDetaljiProizvoda<DetaljiProizvodaVM>(id);
            obj.KolicinaNaSkladistu = "Količina: " + obj.KolicinaProizvoda + " " + obj.JedinicaMjere;
            DetaljiProizvodaVMObj = obj;
            if (obj.Ocjena == 0)
            {
                Ocjena = "Proizvod još niste ocijenili!";
            }
            else
            {
                Ocjena = "Proizvod je ocjenjen sa " + obj.Ocjena + ", ocjenu možete da promijenite ponovnim ocjenjivanjem!";
            }
        }

        public void PromijeniTrenutnuOcjenu(int ocjena)
        {

            TrenutnaOcjena = ocjena;
        }

        public async void OcijeniProizvod()
        {
            OcjenaProizvodaVM obj = new OcjenaProizvodaVM
            {
                ProizvodID = _id,
                Ocjena=TrenutnaOcjena,
                Korisnik=APIService.Username
            };

            await _apiService.OcijeniProizvod<Proizvod>(obj);

            await Application.Current.MainPage.DisplayAlert("Ocjena", "Uspješno ste ocijenili proizvod!", "OK");

            Application.Current.MainPage = new AppShell(true);
        }
    }
}
