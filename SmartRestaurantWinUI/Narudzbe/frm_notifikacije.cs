using SmartRestaurant.Model;
using SmartRestaurantWinUI.Korisnici;
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
    public partial class frm_notifikacije : Form
    {
        private Narudzba _narudzba = null;
        APIService _aPIService = new APIService("Narudzbe");

        public frm_notifikacije(Narudzba n)
        {
            InitializeComponent();
            _narudzba = n;
        }

        private void frm_notifikacije_Load(object sender, EventArgs e)
        {
            txt_mjestoposluzivanja.Text = _narudzba.MjestoPosluzivanja.BrojMjestaPosluzivanja.ToString();
            txt_nazivnarudzbe.Text = _narudzba.NazivNarudzbe.ToString();
        }

        private async void btn_prihvati_Click(object sender, EventArgs e)
        {
            await _aPIService.PromjenaStatusPrihvatanja<Narudzba>(_narudzba.NarudzbaID);
            frm_login._notifikacija = false;
            this.Close();
        }
    }
}
