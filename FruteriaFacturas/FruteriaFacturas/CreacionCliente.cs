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
    public partial class CreacionCliente : Form
    {

        Conexion conexion;
        ArrayList clientesArray;

        public CreacionCliente(ArrayList clientesArray)
        {
            InitializeComponent();
            conexion = new Conexion();

        //MUESTRO EL DATAGRIDVIEW
            conexion.listarClientesGridView(this.dgvListadoClientes);

        // VARIABLE DE TIPO REFERENCIADO (ARRAYLIST DE CLIENTES)
            this.clientesArray = clientesArray;
            
         // PONGO EL DNI POR DEFECTO
            cbDNI.SelectedIndex = 0;
        }

    //LOAD FORM CREAR CLIENTE
        private void CreacionCliente_Load(object sender, EventArgs e)
        {
            alternarColorFilasDataGridView(this.dgvListadoClientes);
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
            if(!this.txtCIF.Text.Equals(""))
                dni_cif = this.txtCIF.Text;
            
            if(!this.mtxtDNI.Text.Equals("        -"))
                dni_cif = this.mtxtDNI.Text;


            if (!textBoxVacios() && !dni_cif.Equals(""))
            {
                bool repetido = false;
            //COMPRUEBO QUE EL DNI / CIF NO ESTA REPETIDO
                foreach (Cliente cl in clientesArray)
                {
                    if (cl.getDni_Cif().ToString().Equals(dni_cif))
                    {
                        MessageBox.Show("El cliente Insertado Ya Existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        repetido = true;
                    }
                }
                if (!repetido)
                {
                   //INSERTO EN BBDD Y EN ARRAYLIST
                    conexion.insertarCliente(dni_cif, this.txtNombre.Text, this.txtDomicilio.Text, this.txtPoblacion.Text);
                    clientesArray.Add(new Cliente(dni_cif, this.txtNombre.Text, this.txtDomicilio.Text, this.txtPoblacion.Text));
                    MessageBox.Show("Cliente Insertado Correctamente", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
                MessageBox.Show("Rellena todos los campos!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            limpiarControles();

        }

    // METODO PARA VALIDAR LOS TEXTBOX VACIOS
        public bool textBoxVacios()
        {
            bool vacio = false;
            foreach (Control c in this.Controls)
            {
                if (c is TextBox && c.Text.Equals("") && c.Name != "txtCIF")
                    vacio = true;
            }

            return vacio;
        }

    // METODO PARA LIMPIAR LOS TEXTBOX
        public void limpiarControles()
        {
            foreach (Control c in this.Controls)
            {
                if (c is TextBox || c is RichTextBox || c is MaskedTextBox)
                    c.ResetText();
            }
        }

    // ALTERNAR COLORES FILAS DATAGRIDVIEW
        public void alternarColorFilasDataGridView(DataGridView dgv)
        {
            dgv.RowsDefaultCellStyle.BackColor = Color.LightBlue;
            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
        }



    }
}
