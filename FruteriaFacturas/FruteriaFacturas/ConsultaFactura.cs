using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FruteriaFacturas
{
    public partial class ConsultaFactura : Form
    {

        ArrayList facturasArray, albaranesArray, clientesArray;
        Conexion conexion;

        public ConsultaFactura(ArrayList facturasArray, ArrayList albaranesArray, ArrayList clientesArray)
        {
            InitializeComponent();
            conexion = new Conexion();

            this.facturasArray = facturasArray;
            this.albaranesArray = albaranesArray;
            this.clientesArray = clientesArray;
        }
    }
}
