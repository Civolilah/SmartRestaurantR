using MobileApps.ViewModels;
using SmartRestaurant.Model.ViewModels;
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
    public partial class KucnaDostava : ContentPage
    {
        private KucnaDostavaVM model = null;
        private int brojac = 0;
        private int brojac1 = 0;
        private int brojac2 = 0;
        public KucnaDostava()
        {
            InitializeComponent();
            BindingContext = model = new KucnaDostavaVM();
        }

        private async void Button_Pressed(object sender, EventArgs e)
        {
            Kucnadostavavm obj = model.GetValues();
            if (brojac != 0 || brojac1!=0 || brojac2!=0)
            {
                if (ValidationKorisnickoIme(obj.Imeiprezime) == true && ValidationAdresa(obj.Adresa) == true && ValidationBrojTelefona(obj.BrojTelefona) == true)
                {
                    await Navigation.PushAsync(new NovaNarudzbaPage(obj));
                }
            }
        }

        private void Entry_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (brojac != 0)
            {
                if (ValidationKorisnickoIme(KucnaDostavaVM.GetKorisnickoIme()) == false)
                {
                    model.PromijeniKorisnickoImeValidation(true);
                }
                else
                {
                    model.PromijeniKorisnickoImeValidation(false);
                }
            }
            else
                brojac++;
        }

        private void Entry_TextChanged_1(object sender, TextChangedEventArgs e)
        {
            if (brojac1 != 0)
            {
                if (ValidationAdresa(KucnaDostavaVM.GetAdresa()) == false)
                {
                    model.PromijeniAdresaValidation(true);
                }
                else
                {
                    model.PromijeniAdresaValidation(false);
                }
            }
            else
                brojac1++;
        }

        private void Entry_TextChanged_2(object sender, TextChangedEventArgs e)
        {
            if (brojac2 != 0)
            {
                if (ValidationBrojTelefona(KucnaDostavaVM.GetBrojTelefona()) == false)
                {
                    model.PromijeniBrojTelefonaValidation(true);
                }
                else
                {
                    model.PromijeniBrojTelefonaValidation(false);
                }
            }
            else
                brojac2++;
        }

        private bool ValidationKorisnickoIme(string parameter)
        {
            if (parameter == null || parameter == "" || parameter.Length > 40)
                return false;
            for (int i = 0; i < parameter.Length; i++)
            {
                if ((parameter[i] < 'a' || parameter[i] > 'z') && (parameter[i] < 'A' || parameter[i] > 'Z') && parameter[i].ToString() != " ")
                    return false;
            }
            return true;
        }

        private bool ValidationAdresa(string parameter)
        {
            if (parameter == null || parameter == "" || parameter.Length > 40)
                return false;
            for (int i = 0; i < parameter.Length; i++)
            {
                if ((parameter[i] < 'a' || parameter[i] > 'z') && (parameter[i] < 'A' || parameter[i] > 'Z') && (parameter[i] < '0' || parameter[i] > '9') && parameter[i] != '-' && parameter[i] != '.' && parameter[i] != '/' && parameter[i].ToString() != " ")
                    return false;
            }
            return true;
        }

        private bool ValidationBrojTelefona(string parameter)
        {
            if (parameter == null || parameter == "" || parameter.Length>15)
                return false;
            for (int i = 0; i < parameter.Length; i++)
            {
                if ((parameter[i] < '0' || parameter[i] > '9') && parameter[i] != '-'&& parameter[i] != '/' && parameter[i].ToString() != " ")
                    return false;
            }
            return true;
        }
    }
}