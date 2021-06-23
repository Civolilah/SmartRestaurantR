using MobileApps.ViewModels;
using Nest;
using Plugin.Geolocator;
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
    public partial class NovaNarudzbaPage : ContentPage
    {
        private ProizvodiMainVM model = null;
        private Kucnadostavavm _obj = null;
        public NovaNarudzbaPage(Kucnadostavavm objekat=null)
        {
            InitializeComponent();
            BindingContext = model = new ProizvodiMainVM();
            _obj = objekat;
        }
        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.Init();
            model.SetKucnaDostava(_obj);
        }
        private void CheckBox_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            var objname = (ProizvodiVM)((CheckBox)sender).BindingContext;
            int kolicina=model.GetKolicina(objname.ProizvodID);
            if (e.Value == true)
            {
                model.DodajProizvod(objname.ProizvodID, kolicina, objname.Cijena);
            }
            else
            {
                model.IzbrisiProizvod(objname.ProizvodID, objname.Cijena);
            }
        }

        private void Picker_SelectedIndexChanged(object sender, EventArgs e)
        {
            Picker objeec = sender as Picker;

            if(((Picker)sender).BindingContext != null)
            {
                var objname = (ProizvodiVM)((Picker)sender).BindingContext;
                var ObjekatProizvod = (ProizvodiVM)((Picker)sender).BindingContext;
                model.PromijeniKolicinu(objname.ProizvodID, int.Parse(objeec.SelectedItem.ToString()), objname.Cijena);
            }
            
        }
    }
}