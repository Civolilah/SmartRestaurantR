using SmartRestaurant.Model;
using SmartRestaurant.Model.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartRestaurantWinUI.Korisnici
{
    public partial class frm_novikorisnik : Form
    {

        APIService _aPIService = new APIService("Korisnici");

        public frm_novikorisnik()
        {
            InitializeComponent();
        }

        private void frm_novikorisnik_Load(object sender, EventArgs e)
        {
            UcitajUloge();
        }

        private async void UcitajUloge()
        {
            var obj = await _aPIService.GetUloge<IList<Uloge>>();

            cmb_uloge.DisplayMember = "NazivUloge";
            cmb_uloge.ValueMember = "UlogaID";
            cmb_uloge.DataSource = obj;
        }

        private async void btn_snimi_Click(object sender, EventArgs e)
        {
            if(this.ValidateChildren())
            {
                if (txt_password.Text == txt_passwordpotvrda.Text)
                {
                    Uloge ulogaa = new Uloge
                    {
                        UlogaID= Convert.ToInt32(cmb_uloge.SelectedValue),
                        NazivUloge =cmb_uloge.DisplayMember
                    };
                    InsertNovogKorisnikaVM novi = new InsertNovogKorisnikaVM
                    {
                        NazivKorisnika=txt_nazivkorisnika.Text,
                        Password=txt_password.Text,
                        PasswordPotvrda=txt_passwordpotvrda.Text,
                        Uloge=ulogaa
                    };

                    await _aPIService.Insert<SmartRestaurant.Model.Korisnici>(novi);

                    MessageBox.Show("Uspješno dodan novi korisnik!","Novi korisnik", MessageBoxButtons.OK);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Password i password potvrda moraju biti isti!", "Novi korisnik", MessageBoxButtons.OK);
                }
            }
        }

        private void txt_nazivkorisnika_Validating(object sender, CancelEventArgs e)
        {
            if (Validation(txt_nazivkorisnika.Text) == false)
            {
                errorProvider1.SetError(txt_nazivkorisnika, "Obavezno polje, maksimalan broj karaktera je 20 te polje moze da sadrzi slova ili brojeve!");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txt_nazivkorisnika, null);
            }
        }

        private void txt_password_Validating(object sender, CancelEventArgs e)
        {
            if (ValidationPassword(txt_password.Text) == false)
            {
                errorProvider1.SetError(txt_password, "Obavezno polje, maksimalan broj karaktera je 20 te polje mora da sadrzi barem jedno veliko slovo te moze da sadrzi mala slova ili brojeve!");
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

        private bool ValidationPassword(string pretraga)
        {
            bool isAlphaBet = false;
            bool isnumberBet = false;
            if (ImaVeliko(pretraga) == false)
                return false;
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

        private bool ImaVeliko(string pretraga)
        {
            bool isvelikoslovo = false;
            for (int i = 0; i < pretraga.Length; i++)
            {
                if (pretraga[i] >= 'A' && pretraga[i] <= 'Z')
                    isvelikoslovo = true;
                if (isvelikoslovo)
                    return true;
            }

            return false;
        }

        private void txt_passwordpotvrda_Validating(object sender, CancelEventArgs e)
        {
            if (ValidationPassword(txt_passwordpotvrda.Text) == false)
            {
                errorProvider1.SetError(txt_passwordpotvrda, "Obavezno polje, maksimalan broj karaktera je 20 te polje mora da sadrzi barem jedno veliko slovo te moze da sadrzi mala slova ili brojeve!");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txt_passwordpotvrda, null);
            }
        }
    }
}
