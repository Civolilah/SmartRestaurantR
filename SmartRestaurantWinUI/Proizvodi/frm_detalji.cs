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

namespace SmartRestaurantWinUI.Proizvodi
{
    public partial class frm_detalji : Form
    {
        APIService _aPIService = new APIService("ProizvodiUpravljanje");

        private int _id;
        public frm_detalji(int id)
        {
            InitializeComponent();

            _id = id;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async Task<DetaljiProizvodaVM> Inicijaliziraj(int id)
        {
            var obj= await _aPIService.GetDetaljiProizvoda<DetaljiProizvodaVM>(_id);

            return obj;
        }

        private async void frm_detalji_Load(object sender, EventArgs e)
        {
            var objekat = await Inicijaliziraj(_id);
            
            txt_opis.Text = objekat.Opis;
            txt_kolicinaskladiste.Text = objekat.KolicinaNaSkladistu;
            txt_kategorijaproizvoda.Text = objekat.KategorijaProizvoda;
            txt_jedinicakolicine.Text = objekat.JedinicaMjere;
        }
    }
}
