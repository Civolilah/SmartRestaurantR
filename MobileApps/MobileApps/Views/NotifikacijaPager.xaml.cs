using MobileApps.ViewModels;
using SmartRestaurant.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MobileApps.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NotifikacijaPager : ContentPage
    {
        private APIService _narudzbeService = new APIService("Narudzbe");
        private NotifikacijaVM model = null;
        private string _nazivstanja=null;
        private int _idnarudzbe;
        public NotifikacijaPager(string nazivstanja,int idnarudzbe)
        {
            _nazivstanja = nazivstanja;
            InitializeComponent();
            BindingContext = model = new NotifikacijaVM();
            _idnarudzbe = idnarudzbe;
        }
        protected async override void OnAppearing()
        {
            base.OnAppearing();
            model.Init(_nazivstanja);
        }

        private async void Button_Pressed(object sender, EventArgs e)
        {
            await _narudzbeService.PromijeniStatusNotifikacije<Narudzba>(_idnarudzbe);
            
            Application.Current.MainPage = new AppShell(true);
        }
    }
}