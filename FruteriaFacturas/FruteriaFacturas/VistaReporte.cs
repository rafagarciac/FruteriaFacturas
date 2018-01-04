using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;

namespace FruteriaFacturas
{
    public partial class VistaReporte : Form
    {

        ReportDocument crystalrpt;
        String idAlbaran, idFactura;

        public VistaReporte(ReportDocument crystalrpt, String idAlbaran, String idFactura)
        {
            InitializeComponent();
            this.crystalrpt = crystalrpt;
            this.idAlbaran = idAlbaran;
            this.idFactura = idFactura;
        }

        private void VistaReporte_Load(object sender, EventArgs e)
        {
            if (!idAlbaran.Equals(""))
            {
                ListadoAlbaran listadoAlbaran = new ListadoAlbaran();
                listadoAlbaran.SetParameterValue("@idAlbaran", idAlbaran);
                this.crystalReportViewer1.ReportSource = listadoAlbaran;
                this.crystalReportViewer1.Refresh();
            }
            else if (!idFactura.Equals(""))
            {
                ListadoFactura listadoFactura = new ListadoFactura();
                listadoFactura.SetParameterValue("@idFactura", idFactura);
                this.crystalReportViewer1.ReportSource = listadoFactura;
                this.crystalReportViewer1.Refresh();
            }
            else
            {
                this.crystalReportViewer1.ReportSource = crystalrpt;
                this.crystalReportViewer1.Refresh();
            }
        }

    }
}
