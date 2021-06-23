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

namespace SmartRestaurantWinUI.Izvjestaj
{
    public partial class frm_izvjestaj : Form
    {
        APIService _aPIService = new APIService("Izvjestaj");
        private UkupniIzvjestajVM _izvjestajVM;
        public frm_izvjestaj()
        {
            InitializeComponent();
        }

        private async void frm_izvjestaj_Load(object sender, EventArgs e)
        {
            IzvjestajFilterVM search = new IzvjestajFilterVM
            {
                OD=dtp_od.Value,
                DO=dtp_do.Value,
                NazivProizvoda=txt_nazivproizvoda.Text
            };
            var obj = await _aPIService.GetIzvjestaj<UkupniIzvjestajVM>(search);
            dgv_izvjestaj.DataSource = obj.tabela;
            txt_ukupnazarada.Text = obj.UkupnaZarada;
            txt_brojnarudzbi.Text = obj.UkupnoNarudzbi.ToString();
            txt_proizvodinaruceni.Text = obj.BrojNarudzbiProizvoda.ToString();
            txt_procenatnarudzbe.Text = obj.ProcenatNarudzbe;

            _izvjestajVM = obj;
        }

        private async void btn_osvjezi_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                IzvjestajFilterVM search = new IzvjestajFilterVM
                {
                    OD = dtp_od.Value,
                    DO = dtp_do.Value,
                    NazivProizvoda = txt_nazivproizvoda.Text
                };
                var obj = await _aPIService.GetIzvjestaj<UkupniIzvjestajVM>(search);
                dgv_izvjestaj.DataSource = obj.tabela;
                txt_ukupnazarada.Text = obj.UkupnaZarada;
                txt_brojnarudzbi.Text = obj.UkupnoNarudzbi.ToString();
                txt_proizvodinaruceni.Text = obj.BrojNarudzbiProizvoda.ToString();
                txt_procenatnarudzbe.Text = obj.ProcenatNarudzbe;

                _izvjestajVM = obj;
            }
        }

        private void btn_kreirajizvjestaj_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                frm_prikazizvjestaja izvjesta = new frm_prikazizvjestaja();
                izvjesta._izvjestaj = _izvjestajVM;
                izvjesta.Show();
            }
        }

        private void txt_nazivproizvoda_Validating(object sender, CancelEventArgs e)
        {
            if (ValidationNaziv(txt_nazivproizvoda.Text) == false)
            {
                errorProvider1.SetError(txt_nazivproizvoda, "Obavezno polje, maksimalan broj karaktera je 20 te polje moze da sadrzi slova,brojeve i razmake!");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txt_nazivproizvoda, null);
            }
        }

        private void dtp_od_Validating(object sender, CancelEventArgs e)
        {
            if (DateValidation(dtp_od.Value) == false || dtp_od.Value > dtp_do.Value)
            {
                errorProvider1.SetError(dtp_od, "Obavezno polje, vrijednost godine ne može biti manja od 2020 niti veća od 2050 te datum do kojeg filtirate podatke ne možete biti manji od stratnog datuma!");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(dtp_od, null);
            }
        }

        private void dtp_do_Validating(object sender, CancelEventArgs e)
        {
            if (DateValidation(dtp_do.Value) == false || dtp_od.Value>dtp_do.Value)
            {
                errorProvider1.SetError(dtp_do, "Obavezno polje, vrijednost godine ne može biti manja od 2020 niti veća od 2050 te datum do kojeg filtirate podatke ne možete biti manji od stratnog datuma!");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(dtp_do, null);
            }
        }

        private bool DateValidation(DateTime d)
        {
            if (d.Year < 2020 || d.Year > 2050 || d == null)
                return false;
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
                if (isAlphaBet == false && isnumberBet == false && pretraga[i] != ' ')
                    return false;
            }
            return true;
        }
    }
}
