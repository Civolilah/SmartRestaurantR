using SmartRestaurant.Model.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartRestaurantWinUI.Proizvodi
{
    public partial class frm_noviproizvod : Form
    {
        APIService _aPIService = new APIService("Proizvod");
        public frm_noviproizvod()
        {
            InitializeComponent();
        }

        private void frm_noviproizvod_Load(object sender, EventArgs e)
        {
            UcitajCMB();
        }

        private InsertProizvodaVM noviproizvod = new InsertProizvodaVM();

        private async void UcitajCMB()
        {
            var obj = await _aPIService.GetNoviProizvod<NoviProizvodVM>();

            cmb_jedinicakolicine.DisplayMember = "NazivJedinice";
            cmb_jedinicakolicine.ValueMember = "JedinicaKolicineID";
            cmb_jedinicakolicine.DataSource = obj.JedinicaKolicine;

            cmb_skladiste.DisplayMember = "NazivSkladista";
            cmb_skladiste.ValueMember = "SkladisteID";
            cmb_skladiste.DataSource = obj.Skladiste;

            cmb_kategorijaproizvoda.DisplayMember = "Naziv";
            cmb_kategorijaproizvoda.ValueMember = "ID";
            cmb_kategorijaproizvoda.DataSource = obj.KategorijaProizvoda;
        }

        private void btn_ucitajsliku_Click(object sender, EventArgs e)
        {
            var rez=openFileDialog1.ShowDialog();

            if(rez== DialogResult.OK)
            {
                var fileroute = openFileDialog1.FileName;
                string filr = fileroute.ToString();
                if (filr.Contains(".jpg") || filr.Contains(".JPG") || filr.Contains(".PNG") || filr.Contains(".png") || filr.Contains(".jpeg") || filr.Contains(".JPEG"))
                {
                    var file = File.ReadAllBytes(fileroute);

                    noviproizvod.Slika = file;

                    Image image = Image.FromFile(fileroute);

                    pictureBox.Image = image;
                }
                else
                {
                    MessageBox.Show("Jedini podržani formati su jpg i png!", "Učitavanje slike", MessageBoxButtons.OK);
                }
            }
        }

        private async void btn_snimiproizvod_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                noviproizvod.JedinicaKolicine = cmb_jedinicakolicine.Text;
                noviproizvod.Skladiste = cmb_skladiste.Text;
                noviproizvod.KategorijaProizvoda = cmb_kategorijaproizvoda.Text;
                noviproizvod.Naziv = txt_naziv.Text;
                noviproizvod.Kolicina = (double)inputkolicina.Value;
                noviproizvod.Cijena = (double)inputcijena.Value;
                noviproizvod.KolicinaNaSkladistu = (int)insert_kolicinanaskladistu.Value;
                noviproizvod.Opis = txt_opis.Text;
                noviproizvod.Aktivan = check_aktivan.Checked;
                noviproizvod.NabavnaCijena = (double)inputnabavnacijena.Value;
                noviproizvod.IstekRoka = dtp_istekroka.Value;
                await _aPIService.InsertNovogProizvoda<InsertProizvodaVM>(noviproizvod);

                MessageBox.Show("Uspješno dodan novi proizvod!", "Novi proizvod", MessageBoxButtons.OK);
                this.Close();
            }
        }

        private void txt_naziv_Validating(object sender, CancelEventArgs e)
        {
            if (ValidationNaziv(txt_naziv.Text) == false)
            {
                errorProvider1.SetError(txt_naziv, "Obavezno polje, maksimalan broj karaktera je 20 te polje moze da sadrzi slova,brojeve i razmake!");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txt_naziv, null);
            }
        }

        private void txt_opis_Validating(object sender, CancelEventArgs e)
        {
            if (Validation(txt_opis.Text) == false)
            {
                errorProvider1.SetError(txt_opis, "Obavezno polje, maksimalan broj karaktera je 200 te polje moze da sadrzi slova, brojeve, tačke i uzvičnike!");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txt_opis, null);
            }
        }

        private void inputcijena_Validating(object sender, CancelEventArgs e)
        {
            if (inputcijena.Value<=0)
            {
                errorProvider1.SetError(inputcijena, "Obavezno polje, vrijednost ne može biti negativna!");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(inputcijena, null);
            }
        }

        private void inputnabavnacijena_Validating(object sender, CancelEventArgs e)
        {
            if (inputnabavnacijena.Value <= 0)
            {
                errorProvider1.SetError(inputnabavnacijena, "Obavezno polje, vrijednost ne može biti negativna!");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(inputnabavnacijena, null);
            }
        }

        private void inputkolicina_Validating(object sender, CancelEventArgs e)
        {
            if (inputkolicina.Value <= 0)
            {
                errorProvider1.SetError(inputkolicina, "Obavezno polje, vrijednost ne može biti negativna!");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(inputkolicina, null);
            }
        }

        private void insert_kolicinanaskladistu_Validating(object sender, CancelEventArgs e)
        {
            if (insert_kolicinanaskladistu.Value <= 0)
            {
                errorProvider1.SetError(insert_kolicinanaskladistu, "Obavezno polje, vrijednost ne može biti negativna!");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(insert_kolicinanaskladistu, null);
            }
        }

        private void dtp_istekroka_Validating(object sender, CancelEventArgs e)
        {
            if (DateValidation(dtp_istekroka.Value) == false)
            {
                errorProvider1.SetError(dtp_istekroka, "Obavezno polje, vrijednost godine ne može biti manja od 2020 niti veća od 2050!");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(dtp_istekroka, null);
            }
        }

        private void btn_ucitajsliku_Validating(object sender, CancelEventArgs e)
        {
            if (pictureBox.Image == null)
            {
                errorProvider1.SetError(btn_ucitajsliku, "Obavezno polje, vrijednost ne može biti negativna!");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(btn_ucitajsliku, null);
            }
            
        }

        private bool Validation(string pretraga)
        {
            bool isAlphaBet = false;
            bool isnumberBet = false;
            if (pretraga == null)
                return false;
            if (pretraga.Length > 200)
                return false;
            for (int i = 0; i < pretraga.Length; i++)
            {
                isAlphaBet = Regex.IsMatch(pretraga[i].ToString(), "[a-zA-Z]", RegexOptions.IgnoreCase);
                isnumberBet = Regex.IsMatch(pretraga[i].ToString(), "[0-9]", RegexOptions.IgnoreCase);
                if (isAlphaBet == false && isnumberBet == false && pretraga[i]!=' ' && pretraga[i]!=',' && pretraga[i] != '.' && pretraga[i] != '!')
                    return false;
            }
            return true;
        }

        private bool ValidationNaziv(string pretraga)
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
                if (isAlphaBet == false && isnumberBet == false && pretraga[i]!=' ')
                    return false;
            }
            return true;
        }

        private bool DateValidation(DateTime d)
        {
            if (d.Year < 2020 || d.Year > 2050 || d==null)
                return false;
            return true;
        }
    }
}
