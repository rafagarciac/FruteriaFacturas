using System;
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
    public partial class CreacionCliente : Form
    {

        Conexion conexion;

        public CreacionCliente()
        {
            InitializeComponent();
            conexion = new Conexion();
            
         // PONGO EL DNI POR DEFECTO
            cbDNI.SelectedIndex = 0;
        }
        
    // METODO EVENTO DE CAMBIO DE VALOR EN EL COMBOBOX
        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {

            if (cbDNI.SelectedItem.ToString().Equals("DNI"))
            {
                this.txtCIF.Visible = false;
                this.mtxtDNI.Visible = true;
            }
            else if (cbDNI.SelectedItem.ToString().Equals("CIF"))
            {
                this.mtxtDNI.Visible = false;
                this.txtCIF.Visible = true;
            }

        }

    // METODO ALTA CLIENTE
        private void btnAltaCliente_Click(object sender, EventArgs e)
        {
            String dni_cif = "";
            if(this.txtCIF.Equals(""))
                dni_cif = this.txtCIF.Text;
            else if(this.mtxtDNI != null)
                dni_cif = this.mtxtDNI.Text;

            if (!textBoxVacios())
                conexion.insertarCliente(dni_cif, this.txtNombre.Text, this.txtDomicilio.Text, this.txtPoblacion.Text);
            else
                MessageBox.Show("Rellena todos los campos!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

    // METODO PARA VALIDAR LOS TEXTBOX VACIOS
        public bool textBoxVacios()
        {
            bool vacio = false;
            foreach (Control c in this.Controls)
            {
                if (c.Text.Equals(""))
                    vacio = true;
            }

            return vacio;
        }

    }
}
