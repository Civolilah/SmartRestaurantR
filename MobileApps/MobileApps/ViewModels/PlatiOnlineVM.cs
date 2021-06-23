using Acr.UserDialogs;
using SmartRestaurant.Model;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using Stripe;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Input;
using MobileApps.Models;
using Application = Xamarin.Forms.Application;
using SmartRestaurant.Model.ViewModels;

namespace MobileApps.ViewModels
{
    public class PlatiOnlineVM:BaseViewModel
    {
        private readonly APIService _narudzbeService = new APIService("Narudzbe");

        bool IsDigitsOnly(string str)
        {
            foreach (char c in str)
            {
                if (c < '0' || c > '9')
                {
                    if(str.Length>10 && c!=' ')
                        return false;
                }
            }

            return true;
        }

        public PlatiOnlineVM()
        {
            SubmitCommand = new Command(async () => await PlatiNarudzbu());

        }
       
        public Narudzba Narudzba { get; set; }

        private string StripeTestApiKey = "pk_test_51J46QQBKw0uvUnBzKV9Uyr8CGp3espxBMlvtK7HI3Vq1nGiUinOj8YX9WOdRe3E2BRbLdSsGd45sd6DdCpzUigX100lYJQCeuz";

        private CreditCard _creditCardModel;
        private TokenService Tokenservice;
        private Token stripeToken;
        private bool _isCarcValid;
        private bool _isTransectionSuccess;
        private string _expMonth;
        private string _expYear;
        private string _title;
        private string _number;
        private string _cvc;
        private PlatiNarudzbuVM _narudzba;
        

        static string _nazivnarudzbe = string.Empty;
        public string NazivNarudzbe
        {
            get { return _nazivnarudzbe; }
            set { SetProperty(ref _nazivnarudzbe, value); }
        }
        static string _ukupnacijena = string.Empty;
        public string Cijena
        {
            get { return _ukupnacijena; }
            set { SetProperty(ref _ukupnacijena, value); }
        }
        public string Number
        {
            get { return _number; }
            set { SetProperty(ref _number, value); }
        }
        public string Cvc
        {
            get { return _cvc; }
            set { SetProperty(ref _cvc, value); }
        }
        public string ExpMonth
        {
            get { return _expMonth; }
            set { SetProperty(ref _expMonth, value); }
        }
        public bool IsCarcValid
        {
            get { return _isCarcValid; }
            set { SetProperty(ref _isCarcValid, value); }
        }
        public bool IsTransectionSuccess
        {
            get { return _isTransectionSuccess; }
            set { SetProperty(ref _isTransectionSuccess, value); }
        }
        public string ExpYear
        {
            get { return _expYear; }
            set { SetProperty(ref _expYear, value); }
        }
        public CreditCard CreditCardModel
        {
            get { return _creditCardModel; }
            set { SetProperty(ref _creditCardModel, value); }
        }

        public ICommand SubmitCommand { get; set; }

        private async Task<string> CreateTokenAsync()
        {
            try
            {
                StripeConfiguration.ApiKey = StripeTestApiKey;
                string imeiprezime = "Nepoznatno";
                if (_narudzba.ImeNarucioca != null) {
                    imeiprezime = _narudzba.ImeNarucioca;
                }
                var Tokenoptions = new TokenCreateOptions()
                {
                    Card = new TokenCardOptions()
                    {
                        Number = CreditCardModel.Number,
                        ExpYear = int.Parse(ExpYear),
                        ExpMonth = int.Parse(ExpMonth),
                        Cvc = CreditCardModel.Cvc,
                        Name = imeiprezime,
                        AddressLine1 = "3. Mart bb.",
                        AddressLine2 = "56",
                        AddressCity = "Konjic",
                        AddressZip = "88400",
                        AddressState = "Konjic2",
                        AddressCountry = "Bosna i Hercegovina",
                        Currency = "usd",
                    }
                };

                Tokenservice = new TokenService();
                stripeToken = Tokenservice.Create(Tokenoptions);
                return stripeToken.Id;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async void Inicijalizuj()
        {
            List<PlatiNarudzbuVM> neplacenenarudzbe = await _narudzbeService.GetNeplacene<List<PlatiNarudzbuVM>>(APIService.Username);
            if (neplacenenarudzbe.Count == 0)
            {
                Cijena = "-";
                await App.Current.MainPage.DisplayAlert("Information", "Sve narudžbe su plaćene!", "OK");
            }
            else
            {
                PlatiNarudzbuVM narudzba= neplacenenarudzbe[0];
                _narudzba = narudzba;
                NazivNarudzbe = narudzba.NazivNarudzbe;
                Cijena = narudzba.Cijena.ToString();
            }
        }

        public async Task<bool> MakePaymentAsync(string token)
        {
            try
            {
                StripeConfiguration.ApiKey = "sk_test_51J46QQBKw0uvUnBzBpfZdoU1Dz3IoAaJFI1iJuwlhc2VB10FDwUH3WWoZPhvKXfG9GzkQtqKdC2CYpuxijQJ5Ju600u1BLVYy5";

                var options = new ChargeCreateOptions();
                
                options.Amount = (long?)(Convert.ToInt64(_narudzba.Cijena) * 0.61 * 100);
                options.Currency = "usd";
                options.Description = _narudzba.NazivNarudzbe;
                options.Source = stripeToken.Id;
                options.StatementDescriptor = "Deskripcija";
                options.Capture = true;
                var service = new ChargeService();
                Charge charge = service.Create(options);
                return true;
            }
            catch (Exception ex)
            {
                Console.Write(_narudzba.NazivNarudzbe + ex.Message);
                throw ex;
            }
        }

        public async Task PlatiNarudzbu()
        {
            List<PlatiNarudzbuVM> neplacenenarudzbe = await _narudzbeService.GetNeplacene<List<PlatiNarudzbuVM>>(APIService.Username);
            

            if (neplacenenarudzbe.Count==0)
            {
                await App.Current.MainPage.DisplayAlert("Informacija", "Sve narudžbe su plaćene!", "OK");
            }
            else
            {
                PlatiNarudzbuVM narudzbaa = neplacenenarudzbe[0];
                if (ExpMonth == null || ExpMonth == "" || ExpYear == null || ExpYear == "" || Number == null || Number == "" || Cvc == null || Cvc == "")
                {
                    UserDialogs.Instance.Alert("Trebate da popunite sva polja!!", "Plaćanje neuspješno!", "OK");
                    return;
                }
                if (ExpMonth != null || ExpMonth != "" || ExpYear != null || ExpYear != "" || Number != null || Number != "" || Cvc != null || Cvc != "")
                {
                    if (!IsDigitsOnly(ExpMonth) || !IsDigitsOnly(ExpMonth) || !IsDigitsOnly(Number) || !IsDigitsOnly(Cvc))
                    {
                        UserDialogs.Instance.Alert("Ne možete koristiti slova!", "Plaćanje neuspješno!", "OK");
                        return;
                    }
                }
                CreditCardModel = new CreditCard();
                var expm = int.Parse(ExpMonth);
                var expY = int.Parse(ExpYear);
                CreditCardModel.ExpMonth = expm;
                CreditCardModel.ExpYear = expY;
                CreditCardModel.Number = Number;
                CreditCardModel.Cvc = Cvc;
                CancellationTokenSource tokenSource = new CancellationTokenSource();
                CancellationToken token = tokenSource.Token;
                try
                {
                    UserDialogs.Instance.ShowLoading("Procesiranje plaćanja ...");
                    await Task.Run(async () =>
                    {
                        var Token = CreateTokenAsync();
                        Console.Write(_narudzba.NazivNarudzbe + "Token :" + Token);
                        if (Token.ToString() != null)
                        {
                            IsTransectionSuccess = await MakePaymentAsync(Token.Result);
                        }
                        else
                        {
                            UserDialogs.Instance.Alert("Niste unijeli validne podatke!", null, "OK");
                        }
                    });
                }
                catch (Exception ex)
                {
                    UserDialogs.Instance.HideLoading();
                    UserDialogs.Instance.Alert(ex.Message, null, "OK");
                }
                finally
                {
                    if (IsTransectionSuccess)
                    {
                        Narudzba n = _narudzbeService.PlatiNarudzbu<Narudzba>(narudzbaa.NarudzbaID);
                        UserDialogs.Instance.Alert("Uspješno plaćeno!", "Information", "OK");
                        Application.Current.MainPage = new AppShell(true);
                        UserDialogs.Instance.HideLoading();
                    }
                    else
                    {
                        UserDialogs.Instance.HideLoading();
                        UserDialogs.Instance.Alert(_narudzba.NazivNarudzbe + "Plaćanje neuspješno pokušajte sa drugim podacima!", "Information","OK");
                    }
                }
            }
        }
    }
}
