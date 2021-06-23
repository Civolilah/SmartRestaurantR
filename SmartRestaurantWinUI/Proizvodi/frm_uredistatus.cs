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

namespace SmartRestaurantWinUI.Proizvodi
{
    public partial class frm_uredistatus : Form
    {
        APIService _aPIService = new APIService("ProizvodiUpravljanje");
        private int _id;
        public frm_uredistatus(int id)
        {
            InitializeComponent();
            _id = id;
        }

        private async void btn_snimi_Click(object sender, EventArgs e)
        {
            bool _aktivan = false;
            if (cmb_statusi.Text == "Aktivan")
            {
                _aktivan = true;
            }
            PromjenaStatusaVM obj = new PromjenaStatusaVM
            {
                proizvodid = _id,
                aktivan=_aktivan
            };
            await _aPIService.PromjenaStatusa<Proizvod>(obj);
            MessageBox.Show("Uspješno promjenjen status proizvoda!", "Status proizvoda", MessageBoxButtons.OK);
            this.Close();
        }

        private async Task<UrediStatusVM> Inicijaliziraj(int id)
        {
            var obj = await _aPIService.GetStatusNarudzbe<UrediStatusVM>(id);

            return obj;
        }

        private async void frm_uredistatus_Load(object sender, EventArgs e)
        {
            var objekat = await Inicijaliziraj(_id);
            var obj = objekat;
            txt_nazivnarudzbe.Text = obj.NazivNarudzbe;
            cmb_statusi.DataSource = obj.Status;
        }
    }
}
