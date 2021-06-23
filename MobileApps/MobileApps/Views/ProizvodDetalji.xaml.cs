using MobileApps.ViewModels;
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
    public partial class ProizvodDetalji : ContentPage
    {
        private int _id;
        private ProizvodDetaljiVM model = new ProizvodDetaljiVM();
        public ProizvodDetalji(int id)
        {
            _id = id;
            InitializeComponent();
            BindingContext = model = new ProizvodDetaljiVM();
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.GetDetalji(_id);
        }

        private void Button_Pressed(object sender, EventArgs e)
        {
            model.OcijeniProizvod();
        }

        private void Picker_SelectedIndexChanged(object sender, EventArgs e)
        {
            int ocjena = 0;
            if (((Picker)sender).BindingContext != null)
            {
                Picker objeec = sender as Picker;
                ocjena = int.Parse(objeec.SelectedItem.ToString());
                model.PromijeniTrenutnuOcjenu(ocjena);
            }
        }
    }
}