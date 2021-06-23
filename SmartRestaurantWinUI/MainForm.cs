using SmartRestaurant.Model;
using SmartRestaurant.Model.ViewModels;
using SmartRestaurantWinUI.Izvjestaj;
using SmartRestaurantWinUI.Korisnici;
using SmartRestaurantWinUI.Narudzbe;
using SmartRestaurantWinUI.Proizvodi;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SmartRestaurantWinUI
{                
    
    public partial class MainForm : Form
    {
        private int childFormNumber = 0;
        APIService _aPIService = new APIService("Narudzbe");
        APIService _aPIServicee = new APIService("Korisnici");
        public MainForm()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private async void btn_osvjezipretragu_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                PretragaNarudzbiVM search = new PretragaNarudzbiVM
                {
                    NazivNarudzbe = tx_pretraga.Text
                };

                var result = await _aPIService.Get<IList<IspisNarudzbi>>(search);
            
                dg_narudzbe.AutoGenerateColumns = false;
            
                dg_narudzbe.DataSource = result;
            }
        }

        private void dg_narudzbe_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0 && e.ColumnIndex==5)
            {
                int idreda = dg_narudzbe.CurrentCell.RowIndex;
                DataGridViewRow red = dg_narudzbe.Rows[e.RowIndex];
                string idd = red.Cells[0].Value.ToString();
                int id = int.Parse(idd);
                frm_Detalji nova = new frm_Detalji(id);
                nova.Show();
            }

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0 && e.ColumnIndex == 6)
            {
                int idreda = dg_narudzbe.CurrentCell.RowIndex;
                DataGridViewRow red = dg_narudzbe.Rows[e.RowIndex];
                string idd = red.Cells[0].Value.ToString();
                int id = int.Parse(idd);
                frm_uredi nova = new frm_uredi(id);
                nova.Show();
            }

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0 && e.ColumnIndex == 7)
            {
                int idreda = dg_narudzbe.CurrentCell.RowIndex;
                DataGridViewRow red = dg_narudzbe.Rows[e.RowIndex];
                string idd = red.Cells[0].Value.ToString();
                int id = int.Parse(idd);
                Narudzbe.frm_uredistatus nova = new Narudzbe.frm_uredistatus(id);
                nova.Show();
            }
        }

        private async void dodajKorisnikaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                IList <Uloge> obj = null;
                obj = await _aPIServicee.GetUloge<IList<Uloge>>();

                frm_novikorisnik nova = new frm_novikorisnik();
                nova.Show();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Niste autorizovani za ovu akciju!", "Autentifikacija", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void noviProizvodToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_noviproizvod nova = new frm_noviproizvod();
            nova.Show();
        }

        private void pretragaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Pretraga nova = new frm_Pretraga();
            nova.Show();
        }

        private async void kreirajIzvještajToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                IList<Uloge> obj = null;
                obj = await _aPIServicee.GetUloge<IList<Uloge>>();

                frm_izvjestaj nova = new frm_izvjestaj();
                nova.Show();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Niste autorizovani za ovu akciju!", "Autentifikacija", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_pregled_Click(object sender, EventArgs e)
        {
            frm_Pregled novaforma = new frm_Pregled();
            novaforma.Show();
        }
        
        private async void MainForm_Load(object sender, EventArgs e)
        {
            PretragaNarudzbiVM search = new PretragaNarudzbiVM
            {
                NazivNarudzbe = tx_pretraga.Text
            };

            var result = await _aPIService.Get<IList<IspisNarudzbi>>(search);

            dg_narudzbe.AutoGenerateColumns = false;

            dg_narudzbe.DataSource = result;
        }

        private void tx_pretraga_Validating(object sender, CancelEventArgs e)
        {
            if (PretragaValidation(tx_pretraga.Text)==false)
            {
                errorProvider1.SetError(tx_pretraga, "Maksimalan broj karaktera je 30 te polje moze da sadrzi slova, brojeve i _ !");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(tx_pretraga, null);
            }
        }

        private bool PretragaValidation(string pretraga)
        {
            bool isAlphaBet = false;
            bool isnumberBet = false;
            if (pretraga.Length > 30)
                return false;
            for (int i = 0; i < pretraga.Length; i++)
            {
                isAlphaBet= Regex.IsMatch(pretraga[i].ToString(), "[a-zA-Z]", RegexOptions.IgnoreCase);
                isnumberBet = Regex.IsMatch(pretraga[i].ToString(), "[0-9]", RegexOptions.IgnoreCase);
                if (isAlphaBet == false&&isnumberBet==false&&pretraga[i].ToString()!="_")
                    return false;
            }
            return true;
        }  

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            frm_login.pokrenuti = false;
        }
    }
}
