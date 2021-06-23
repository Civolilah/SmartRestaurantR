using MobileApps.ViewModels;
using SmartRestaurant.Model;
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
    public partial class PlatiOnlinePage : ContentPage
    {
        private PlatiOnlineVM model = null;

        bool IsDigitsOnly(string str)
        {
            foreach (char c in str)
            {
                if (c < '0' || c > '9')
                    return false;
            }

            return true;
        }

        public PlatiOnlinePage()
        {
            InitializeComponent();
            BindingContext = model = new PlatiOnlineVM();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            ErrorLabel_CardNumber.IsVisible = false;
            ErrorLabel_Cvv.IsVisible = false;
            ErrorLabel_Month.IsVisible = false;
            ErrorLabel_Year.IsVisible = false;
            model.Inicijalizuj();
        }

        private void Number_changed(object sender, TextChangedEventArgs e)
        {
            if (Number.Text.Length > 16)
            {
                ErrorLabel_CardNumber.IsVisible = true;
                ErrorLabel_CardNumber.Text = "Broj kartice mora imati 16 brojeva!";
            }
            else if (Number.Text.Length < 1)
            {
                ErrorLabel_CardNumber.IsVisible = true;
                ErrorLabel_CardNumber.Text = "Obavezno polje!";
            }
            else
            {
                ErrorLabel_CardNumber.IsVisible = false;
            }
        }

        private void Number_unfocused(object sender, TextChangedEventArgs e)
        {
            if (Number.Text == null)
            {
                ErrorLabel_CardNumber.IsVisible = true;
                ErrorLabel_CardNumber.Text = "Obavezno polje!";
            }
            else
            {
                ErrorLabel_CardNumber.IsVisible = false;
            }
        }

        private void Month_changed(object sender, TextChangedEventArgs e)
        {
            if (Month.Text.Length != 2)
            {
                ErrorLabel_Month.IsVisible = true;
                ErrorLabel_Month.Text = "Ovo polje treba da sadržava 2 broja!";
            }
            else if (Month.Text == null)
            {
                ErrorLabel_Month.IsVisible = true;
                ErrorLabel_Month.Text = "Obavezno polje!";
            }
            else
            {
                ErrorLabel_Month.IsVisible = false;
            }
        }

        private void Month_unfocused(object sender, TextChangedEventArgs e)
        {
            if (Month.Text == null)
            {
                ErrorLabel_Month.IsVisible = true;
                ErrorLabel_Month.Text = "Obavezno polje!";
            }
            else
            {
                ErrorLabel_Month.IsVisible = false;
            }
        }

        private void Year_changed(object sender, TextChangedEventArgs e)
        {
            if (Year.Text.Length != 2)
            {
                ErrorLabel_Year.IsVisible = true;
                ErrorLabel_Year.Text = "Ovo polje treba da sadržava 2 broja!";
            }
            else if (Year.Text == null)
            {
                ErrorLabel_Year.IsVisible = true;
                ErrorLabel_Year.Text = "Obavezno polje!";
            }
            else
            {
                ErrorLabel_Year.IsVisible = false;
            }
        }

        private void Year_unfocused(object sender, TextChangedEventArgs e)
        {
            if (Year.Text == null)
            {
                ErrorLabel_Year.IsVisible = true;
                ErrorLabel_Year.Text = "Obavezno polje!";
            }
            else
            {
                ErrorLabel_Year.IsVisible = false;
            }
        }

        private void Cvv_changed(object sender, TextChangedEventArgs e)
        {
            if (Cvv.Text.Length != 3)
            {
                ErrorLabel_Cvv.IsVisible = true;
                ErrorLabel_Cvv.Text = "Ovo polje treba da sadržava 3 broja!";
            }
            else if (Cvv.Text == null)
            {
                ErrorLabel_Cvv.IsVisible = true;
                ErrorLabel_Cvv.Text = "Obavezno polje!";
            }
            else
            {
                ErrorLabel_Cvv.IsVisible = false;
            }
        }

        private void Cvv_unfocused(object sender, TextChangedEventArgs e)
        {
            if (Cvv.Text == null)
            {
                ErrorLabel_Cvv.IsVisible = true;
                ErrorLabel_Cvv.Text = "Obavezno polje!";
            }
            else
            {
                ErrorLabel_Cvv.IsVisible = false;
            }
        }
    }
}
