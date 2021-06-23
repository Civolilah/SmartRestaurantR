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
    public partial class frm_Pretraga : Form
    {
        APIService _aPIService = new APIService("Proizvod");
        public frm_Pretraga()
        {
            InitializeComponent();
        }

        private async void frm_Pretraga_Load(object sender, EventArgs e)
        {
            cmb_vrstaproizvoda.Items.Add("Svi");
            cmb_vrstaproizvoda.Items.Add("Aktivni");
            cmb_vrstaproizvoda.Items.Add("Neaktivni");
            cmb_vrstaproizvoda.SelectedIndex = 0;
            dg_Proizvodi.AutoGenerateColumns = false;
            dg_Proizvodi.DataSource = await _aPIService.GetByStatus<List<PretragaProizvodaVM>>("Svi");

            for (int i = 0; i < dg_Proizvodi.Rows.Count; i++)
            {
                dg_Proizvodi.Rows[i].Height = 100;
            }
        }

        private async void btn_Osvjezi_Click(object sender, EventArgs e)
        {
            var obj = cmb_vrstaproizvoda.Text;
            dg_Proizvodi.AutoGenerateColumns = false;
            dg_Proizvodi.DataSource = await _aPIService.GetByStatus<List<PretragaProizvodaVM>>(obj);

            for (int i = 0; i < dg_Proizvodi.Rows.Count; i++)
            {
                dg_Proizvodi.Rows[i].Height = 100;
            }
        }

        private void dg_Proizvodi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0 && e.ColumnIndex == 6)
            {
                DataGridViewRow red = dg_Proizvodi.Rows[e.RowIndex];
                string idd = red.Cells[0].Value.ToString();
                int id = int.Parse(idd);
                frm_detalji nova = new frm_detalji(id);
                nova.Show();
            }

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0 && e.ColumnIndex == 7)
            {
                DataGridViewRow red = dg_Proizvodi.Rows[e.RowIndex];
                string idd = red.Cells[0].Value.ToString();
                int id = int.Parse(idd);
                frm_uredistatus nova = new frm_uredistatus(id);
                nova.Show();
            }
        }
    }
}
