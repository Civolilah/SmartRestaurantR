using SmartRestaurant.Model;
using SmartRestaurant.Model.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft;
using System.Text.RegularExpressions;
using SmartRestaurantWinUI.Narudzbe;

namespace SmartRestaurantWinUI.Korisnici
{
    public partial class frm_login : Form
    {
        APIService _apiservice = new APIService("Narudzbe");
        public static bool pokrenuti = false;
        private List<Narudzba> lista = null;
        public static bool _notifikacija = false;
        private System.Windows.Forms.Timer timer1;
        
        public frm_login()
        {
            InitializeComponent();
        }

        private async void btn_potvrda_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                APIService.Username = txt_username.ToString();
                APIService.Password = txt_password.ToString();
                try
                {
                    await _apiservice.Get<IList<IspisNarudzbi>>(null);
                    MainForm nova = new MainForm();
                    nova.Show();
                    pokrenuti = true;
                }
                catch (Exception ex)
                {                                                                                                                                                                                                                                                                                  
                    MessageBox.Show("Vaši pristupni podaci nisu validni!", "Autentifikacija", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txt_username_Validating(object sender, CancelEventArgs e)
        {
            if (Validation(txt_username.Text) == false)
            {
                errorProvider1.SetError(txt_username, "Obavezno polje, maksimalan broj karaktera je 20 te polje moze da sadrzi slova ili brojeve!");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txt_username, null);
            }
        }

        private void txt_password_Validating(object sender, CancelEventArgs e)
        {
            if (Validation(txt_password.Text) == false)
            {
                errorProvider1.SetError(txt_password, "Obavezno polje, maksimalan broj karaktera je 30 te polje moze da sadrzi slova, brojeve!");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txt_password, null);
            }
        }

        private bool Validation(string pretraga)
        {
            bool isAlphaBet = false;
            bool isnumberBet = false;
            if (pretraga == null)
                return false;
            if (pretraga.Length > 20)
                return false;
            for (int i = 0; i < pretraga.Length; i++)
            {
                isAlphaBet = Regex.IsMatch(pretraga[i].ToString(), "[a-zA-Z]", RegexOptions.IgnoreCase);
                isnumberBet = Regex.IsMatch(pretraga[i].ToString(), "[0-9]", RegexOptions.IgnoreCase);
                if (isAlphaBet == false && isnumberBet == false)
                    return false;
            }
            return true;
        }

        private async void DodajBroj(object sender, EventArgs e)
        {
            if (_notifikacija == false && pokrenuti == true)
            {
                lista = await _apiservice.GetBezPrihvatanja<List<Narudzba>>();

                if (lista.Count > 0)
                {
                    Narudzba narudzba = lista.FirstOrDefault();
                    _notifikacija = true;
                    frm_notifikacije notifikacija = new frm_notifikacije(narudzba);
                    notifikacija.Show();
                }
            }
        }

        private void frm_login_Load(object sender, EventArgs e)
        {
            timer1 = new System.Windows.Forms.Timer();
            timer1.Tick += new EventHandler(DodajBroj);
            timer1.Interval = 1000;
            timer1.Start();
        }
    }
}
