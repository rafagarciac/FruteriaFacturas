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

        public VistaReporte(ReportDocument crystalrpt)
        {
            InitializeComponent();
            this.crystalrpt = crystalrpt;
        }

        private void VistaReporte_Load(object sender, EventArgs e)
        {
            this.crystalReportViewer1.ReportSource = crystalrpt;
            this.crystalReportViewer1.Refresh();
        }

    }
}
