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
    public partial class LoginMainPage : ContentPage
    {
        private LoginVM model = null;
        private int brojac = 0;
        private int brojac1 = 0;
        public LoginMainPage()
        {
            InitializeComponent();
            BindingContext = model = new LoginVM();
        }

        private void Entry_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (brojac != 0)
            {
                if (Validation(LoginVM.GetUserName()) == false)
                {
                    model.PromijeniUserNameValidation(true);
                }
                else
                {
                    model.PromijeniUserNameValidation(false);
                }
            }
            else
                brojac++;
        }

        private bool Validation(string parameter)
        {
            if (parameter == null||parameter=="")
                return false;
            for (int i = 0; i < parameter.Length; i++)
            {
                if ((parameter[i] < 'a' || parameter[i] > 'z') && (parameter[i] < 'A' || parameter[i] > 'Z') && (parameter[i] < '0' || parameter[i] > '9'))
                    return false;
            }
            return true;
        }

        private void Entry_TextChanged_1(object sender, TextChangedEventArgs e)
        {
            if (brojac1 != 0)
            {
                if (Validation(LoginVM.GetPassword()) == false)
                {
                    model.PromijeniPasswordValidation(true);
                }
                else
                {
                    model.PromijeniPasswordValidation(false);
                }
            }
            else
                brojac1++;
        }
    }
}