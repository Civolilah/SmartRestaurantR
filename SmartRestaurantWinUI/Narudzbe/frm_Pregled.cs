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

namespace SmartRestaurantWinUI.Narudzbe
{
    public partial class frm_Pregled : Form
    {
        APIService _aPIService = new APIService("NarudzbeUpravljanje");
        public frm_Pregled()
        {
            InitializeComponent();
        }

        private async void frm_Pregled_Load(object sender, EventArgs e)
        {
            FilterPregledVM obj = new FilterPregledVM{ 
                OD=dtp_OD.Value,
                DO=dtp_DO.Value
            };

            var objekat = await _aPIService.PregledNarudzbi<IList<PregledVM>>(obj);
            dgv_preglednarudzbi.AutoGenerateColumns = false;
            dgv_preglednarudzbi.DataSource = objekat;
        }

        private async void btn_osvjezi_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                FilterPregledVM obj = new FilterPregledVM
                {
                    OD = dtp_OD.Value,
                    DO = dtp_DO.Value,
                    Status=txt_status.Text,
                    NazivNarudzbe=txt_nazivnarudzbe.Text,
                    IDMjestaPosluzivanja=txt_mjestoposluzivanja.Text
                };

                var objekat = await _aPIService.PregledNarudzbi<IList<PregledVM>>(obj);
                dgv_preglednarudzbi.AutoGenerateColumns = false;
                dgv_preglednarudzbi.DataSource = objekat;
            }
        }

        private void dgv_preglednarudzbi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0 && e.ColumnIndex == 5)
            {
                int idreda = dgv_preglednarudzbi.CurrentCell.RowIndex;
                DataGridViewRow red = dgv_preglednarudzbi.Rows[e.RowIndex];
                string idd = red.Cells[0].Value.ToString();
                int id = int.Parse(idd);
                frm_brisanje nova = new frm_brisanje(id);
                nova.Show();
            }
        }

        private void txt_mjestoposluzivanja_Validating(object sender, CancelEventArgs e)
        {
            if (Validation(txt_mjestoposluzivanja.Text) == false)
            {
                errorProvider1.SetError(txt_mjestoposluzivanja, "Maksimalan broj karaktera je 30 te polje moze da sadrzi slova, brojeve, razmake i _ !");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txt_mjestoposluzivanja, null);
            }
        }

        private void txt_nazivnarudzbe_Validating(object sender, CancelEventArgs e)
        {
            if (Validation(txt_nazivnarudzbe.Text) == false)
            {
                errorProvider1.SetError(txt_nazivnarudzbe, "Maksimalan broj karaktera je 30 te polje moze da sadrzi slova, brojeve, razmake i _ !");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txt_nazivnarudzbe, null);
            }
        }

        private void txt_status_Validating(object sender, CancelEventArgs e)
        {
            if (Validation(txt_status.Text) == false)
            {
                errorProvider1.SetError(txt_status, "Maksimalan broj karaktera je 30 te polje moze da sadrzi slova, brojeve, razmake i _ !");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txt_status, null);
            }
        }

        private void dtp_OD_Validating(object sender, CancelEventArgs e)
        {
            if (DateValidation(dtp_OD.Value) == false || dtp_OD.Value > dtp_DO.Value)
            {
                errorProvider1.SetError(dtp_OD, "Obavezno polje, vrijednost godine ne može biti manja od 2020 niti veća od 2050 te datum do kojeg filtirate podatke ne možete biti manji od stratnog datuma!");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(dtp_OD, null);
            }
        }

        private void dtp_DO_Validating(object sender, CancelEventArgs e)
        {
            if (DateValidation(dtp_DO.Value) == false || dtp_OD.Value > dtp_DO.Value)
            {
                errorProvider1.SetError(dtp_DO, "Obavezno polje, vrijednost godine ne može biti manja od 2020 niti veća od 2050 te datum do kojeg filtirate podatke ne možete biti manji od stratnog datuma!");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(dtp_DO, null);
            }
        }

        private bool DateValidation(DateTime d)
        {
            if (d.Year < 2020 || d.Year > 2050 || d == null)
                return false;
            return true;
        }

        private bool Validation(string pretraga)
        {
            bool isAlphaBet = false;
            bool isnumberBet = false;
            
            if (pretraga.Length > 30)
                return false;
            for (int i = 0; i < pretraga.Length; i++)
            {
                isAlphaBet = Regex.IsMatch(pretraga[i].ToString(), "[a-zA-Z]", RegexOptions.IgnoreCase);
                isnumberBet = Regex.IsMatch(pretraga[i].ToString(), "[0-9]", RegexOptions.IgnoreCase);
                if (isAlphaBet == false && isnumberBet == false && pretraga[i] != ' ' && pretraga[i] != '_')
                    return false;
            }
            return true;
        }
    }
}
