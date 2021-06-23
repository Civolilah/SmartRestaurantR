using MobileApps.Views;
using SmartRestaurant.Model;
using SmartRestaurant.Model.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace MobileApps.ViewModels
{
    public class LoginVM : BaseViewModel
    {
        private readonly APIService _apiService = new APIService("Narudzbe");
        
        public LoginVM()
        {
            Command = new Command(async () =>
             {
                 await Login();
             });
        }
        static string _userName = string.Empty;
        public string UserName
        {
            get { return _userName; }
            set { SetProperty(ref _userName, value); }
        }

        static string _password = string.Empty;
        public string PassWord
        {
            get { return _password; }
            set { SetProperty(ref _password, value); }
        }

        public string _passwordvalidation = string.Empty;
        public string PassWordValidation
        {
            get { return _passwordvalidation; }
            set { SetProperty(ref _passwordvalidation, value); }
        }

        public string _usernameValidation = string.Empty;
        public string UserNameValidation
        {
            get { return _usernameValidation; }
            set { SetProperty(ref _usernameValidation, value); }
        }

        public ICommand Command { get; set; }

        async Task Login()
        {
            if(Validation(UserName) && Validation(PassWord))
            {
                IsBusy = true;

                APIService.Username = UserName;
                APIService.Password = PassWord;

                try
                {
                    _apiService.GetBezNotifikacije<List<Narudzba>>(APIService.Username);
                    Application.Current.MainPage = new AppShell(true);
                }
                catch (Exception ex)
                {
                    await Application.Current.MainPage.DisplayAlert("Greška", "Pogrešni ulazni podaci!", "OK");
                }
            }
            else
            {
                if (Validation(UserName) == false)
                {
                    UserNameValidation = "Polje je obavezno i treba da sadrži brojeve i slova!";
                }
                else
                {
                    UserNameValidation = "";
                }

                if (Validation(PassWord) == false)
                {
                    PassWordValidation = "Polje je obavezno i treba da sadrži brojeve i slova!";
                }
                else
                {
                    PassWordValidation = "";
                }
            }
        }

        private bool Validation(string parameter)
        {
            if (parameter == null || parameter=="")
                return false;
            for (int i = 0; i < parameter.Length; i++)
            {
                if ((parameter[i] < 'a' || parameter[i] > 'z') && (parameter[i] < 'A' || parameter[i] > 'Z') && (parameter[i] < '0' || parameter[i] > '9'))
                    return false;
            }
            return true;
        }

        public static string GetUserName()
        {
            return _userName;
        }

        public static string GetPassword()
        {
            return _password;
        }

        public void PromijeniUserNameValidation(bool vrijednost)
        {
            if (vrijednost == true)
                UserNameValidation = "Polje je obavezno i treba da sadrži brojeve i slova!";
            else
                UserNameValidation = "";
        }

        public void PromijeniPasswordValidation(bool vrijednost)
        {
            if (vrijednost == true)
                PassWordValidation = "Polje je obavezno i treba da sadrži brojeve i slova!";
            else
                PassWordValidation = "";
        }

    }
}
