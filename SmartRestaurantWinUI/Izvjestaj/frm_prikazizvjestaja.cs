using Microsoft.Reporting.WinForms;
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

namespace SmartRestaurantWinUI.Izvjestaj
{
    public partial class frm_prikazizvjestaja : Form
    {
        public UkupniIzvjestajVM _izvjestaj;
        public frm_prikazizvjestaja()
        {
            InitializeComponent();
        }

        private void frm_prikazizvjestaja_Load(object sender, EventArgs e)
        {
            ReportDataSource source = new ReportDataSource("ukupniizvjestaj",_izvjestaj.tabela);
            this.reportViewer1.LocalReport.DataSources.Add(source);
            this.reportViewer1.LocalReport.SetParameters(new ReportParameter("UkupnaZarada", _izvjestaj.UkupnaZarada));
            this.reportViewer1.LocalReport.SetParameters(new ReportParameter("BrojNarudzbi", _izvjestaj.UkupnoNarudzbi.ToString()));
            this.reportViewer1.LocalReport.SetParameters(new ReportParameter("BrojNarucenihProizvoda", _izvjestaj.BrojNarudzbiProizvoda.ToString()));
            this.reportViewer1.LocalReport.SetParameters(new ReportParameter("ProcenatNarudzbe", _izvjestaj.ProcenatNarudzbe));

            this.reportViewer1.RefreshReport();
        }
    }
}
