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
    public partial class frm_Detalji : Form
    {
        APIService _aPIService = new APIService("Narudzbe");
        private int _id;

        public frm_Detalji(int id)
        {
            InitializeComponent();

            _id = id;
        }
    
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void frm_Detalji_Load(object sender, EventArgs e)
        {
            var objekat = await _aPIService.GetNarudzbaDetalji<DetaljiNarudzbeVM>(_id);
            var obj = objekat;
            dtg_proizvodi.AutoGenerateColumns = false;
            txt_Cijena.Text = obj.Cijena;
            dtg_proizvodi.DataSource = obj.listaproizvoda;

            if (objekat.ImeIPrezimeNarucioca != null)
            {
                txt_imeiprezimenar.Text = objekat.ImeIPrezimeNarucioca;
                txt_brojtelefonanar.Text = objekat.BrojTelefonaNarucioca;
                txt_adresanar.Text = objekat.AdresaNarucioca;
            }
            else
            {
                txt_imeiprezimenar.Text = "Nepoznato!";
                txt_brojtelefonanar.Text = "Nepoznato!";
                txt_adresanar.Text = "Nepoznato!";
            }
        }
    }
}
