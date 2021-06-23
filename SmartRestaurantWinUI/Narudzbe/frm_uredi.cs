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

namespace SmartRestaurantWinUI.Narudzbe
{
    public partial class frm_uredi : Form
    {
        private int _id { get; set; }
        APIService _aPIService = new APIService("NarudzbeUpravljanje");

        public frm_uredi(int id)
        {
            InitializeComponent();
            _id = id;
        }

        private async void frm_uredi_Load(object sender, EventArgs e)
        {
            var obj= await _aPIService.GetNarudzbu<UrediNarudzbuVM>(_id);
            dgv_proizvodi.AutoGenerateColumns = false;
            dgv_proizvodi.DataSource = obj.listaproizvoda;
            cmb_mjestaposluzivanja.DisplayMember = "BrojMjestaPosluzivanja";
            cmb_mjestaposluzivanja.ValueMember = "MjestoPosluzivanjaID";
            cmb_mjestaposluzivanja.DataSource = obj.listamjestaposluzivanja;
        }

        private async void btn_snimi_Click(object sender, EventArgs e)
        {
            IzvrsiUredjivanjeNarudzbeVM objekat = new IzvrsiUredjivanjeNarudzbeVM();

            objekat.NarudzbaID = _id;
            List<UrediNarudzbuProizvodVM> lista = new List<UrediNarudzbuProizvodVM>();
            int brojacredova = 0;
            int brojackolona = 0;
            foreach (var item in dgv_proizvodi.Rows)
            {
                UrediNarudzbuProizvodVM urediobjekat = new UrediNarudzbuProizvodVM();
                if(bool.Parse(dgv_proizvodi.Rows[brojacredova].Cells[1].Value.ToString())==true)
                {
                    urediobjekat.ProizvodID = int.Parse(dgv_proizvodi.Rows[brojacredova].Cells[brojackolona].Value.ToString());
                    brojackolona++;
                    urediobjekat.Narucen = bool.Parse(dgv_proizvodi.Rows[brojacredova].Cells[brojackolona].Value.ToString());
                    brojackolona++;
                    urediobjekat.NazivProizvoda = dgv_proizvodi.Rows[brojacredova].Cells[brojackolona].Value.ToString();
                    brojackolona++;
                    urediobjekat.Cijena = double.Parse(dgv_proizvodi.Rows[brojacredova].Cells[brojackolona].Value.ToString());
                    brojackolona++;
                    urediobjekat.Opis = dgv_proizvodi.Rows[brojacredova].Cells[brojackolona].Value.ToString();
                    brojackolona = 0;
                    lista.Add(urediobjekat);
                }
                brojacredova++;
            }
            objekat.listaproizvoda = lista;
            objekat.BrojMjestaNarudzbeID = int.Parse(cmb_mjestaposluzivanja.Text);

            await _aPIService.UrediNarudzbu<Narudzba>(objekat);

            MessageBox.Show("Uspješno promjenjen sadržaj narudžbe!", "Uredi narudžbu", MessageBoxButtons.OK);

            this.Close();
        }

        private void dgv_proizvodi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (e.RowIndex >= 0 && e.ColumnIndex == 1)
            {
                int idreda = e.RowIndex;
                if (bool.Parse(dgv_proizvodi.Rows[idreda].Cells[1].Value.ToString()) == true)
                    dgv_proizvodi.Rows[idreda].Cells[1].Value = false;
                else
                    dgv_proizvodi.Rows[idreda].Cells[1].Value = true;
            }
        }
    }
}
