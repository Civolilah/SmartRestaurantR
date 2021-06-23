using MobileApps.ViewModels;
using Plugin.Geolocator;
using SmartRestaurant.Model;
using SmartRestaurant.Model.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MobileApps.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProizvodiPage : ContentPage
    {
        private ProizvodiMainVM model = null;
        private List<Narudzba> lista = null;
        private bool prihvacena = false;
        private int brojac = 0;
        private Narudzba obradi = null;
        public ProizvodiPage()
        {
            InitializeComponent();
            BindingContext = model = new ProizvodiMainVM();
            
        }
        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.Init();

            Device.StartTimer(new TimeSpan(0, 0, 1), () =>
            {
                if (AppShell._pokreni)
                {
                    lista = model.GetNarudzbeBezNotifikacije();
                    obradi = null;

                    if (lista.Count > 0)
                    {
                        obradi = lista.FirstOrDefault();
                    }
                    if (lista.Count > 0 && obradi.PrihvacenaNotifikacija == false)
                    {
                        if (prihvacena == false)
                        {
                            prihvacena = true;
                            Device.BeginInvokeOnMainThread(() =>
                            {
                                Application.Current.MainPage = new NotifikacijaPager(obradi.StatusNarudzbe.NazivStatusa, obradi.NarudzbaID);
                            });
                        }
                    }
                }
                return true;
            });

        }
      
        private async void Button_Pressed(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NovaNarudzbaPage());
            
        }

        private async void Button_Pressed_1(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new KucnaDostava());
        }

        private async void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var objname = (ProizvodiVM)e.SelectedItem;
            await Navigation.PushAsync(new ProizvodDetalji(objname.ProizvodID));
        }

        private async void Button_Pressed_2(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PlatiOnlinePage());
        }
    }
}