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
    public partial class ConsultaCliente : Form
    {
        Conexion conexion;
        ArrayList clientesArray;

        public ConsultaCliente(ArrayList clientesArray)
        {
            InitializeComponent();
            this.clientesArray = clientesArray;
            conexion = new Conexion();

        //LISTO CLIENTES EN EL LISTVIEW
            listarClientesLV();
            // MessageBox.Show(clientesArray.Count.ToString());
        }

        
    // METODO PARA LISTAR LOS CLIENTES EN EL LISTVIEW
        public void listarClientesLV()
        {

            //clientesArray.Clear();
            //clientesArray = conexion.cargarClientes();

            foreach(Cliente cl in clientesArray){

                ListViewItem item = lvListado.Items.Add("cliente", cl.getDni_Cif(), 0);
                item.SubItems.Add(cl.getNombre());
                item.SubItems.Add(cl.getDomicilio());
                item.SubItems.Add(cl.getPoblacion());

            }
        }

    // METODO DE EVENTO CLICK EN ITEM EN LISTVIEW
        private void lvListado_Click(object sender, EventArgs e)
        {
        //RECOGO EL ITEM PULSADO
            if (lvListado.SelectedItems.Count > 0)
            {
                ListViewItem listItem = lvListado.SelectedItems[0];

                foreach (Cliente cl in clientesArray)
                {
                    // MessageBox.Show(listItem.SubItems[0].Text);
                    if (cl.getDni_Cif().Equals(listItem.SubItems[0].Text))
                    {
                        this.txtDni_Cif.Text = cl.getDni_Cif();
                        this.txtNombre.Text = cl.getNombre();
                        this.txtDomicilio.Text = cl.getDomicilio();
                        this.txtPoblacion.Text = cl.getPoblacion();
                    }
                }
            }
            else
            {
                MessageBox.Show("Selecciona un Cliente en el Listado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    //METODO DE BOTON BORRADO
        private void btnBorrarCliente_Click(object sender, EventArgs e)
        {
            if (!textBoxVacios())
            {
            // BORRO CLIENTE DE LA BBDD, DEL ARRAYLIST Y DEL LISTVIEW
                Cliente clBorrar = new Cliente();
                foreach (Cliente cl in clientesArray)
                {
                    if (cl.getDni_Cif().Equals(this.txtDni_Cif.Text))
                        clBorrar = cl;
                }

                clientesArray.Remove(clBorrar);

                conexion.borrarCliente(this.txtDni_Cif.Text);
                ListViewItem listItem = lvListado.SelectedItems[0];
                lvListado.Items.Remove(listItem);
                limpiarTextBox();

                MessageBox.Show("Cliente Eliminado Correctamente", "Ayuda", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
                MessageBox.Show("Selecciona un Cliente en el Listado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
 
        }

    // METODO DE BOTON MODIFICAR
        private void button1_Click(object sender, EventArgs e)
        {
            if (!textBoxVacios())
            {
             // MODIFICO EN BBDD Y EN ARRAYLIST EL CLIENTE Y LE PASO POR PARAMETROS A LA CLASE CONEXION EL ID NUEVO Y EL ANTIGUO
                
                if (lvListado.SelectedItems.Count > 0)
                {
                    ListViewItem listItem = lvListado.SelectedItems[0];

                    foreach (Cliente cl in clientesArray)
                    {
                        if (cl.getDni_Cif().Equals(listItem.SubItems[0].Text))
                        {
                            cl.setDni_Cif(this.txtDni_Cif.Text);
                            cl.setNombre(this.txtNombre.Text);
                            cl.setDomicilio(this.txtDomicilio.Text);
                            cl.setPoblacion(this.txtPoblacion.Text);
                        }
                    }

                    conexion.modificarCliente(listItem.SubItems[0].Text, this.txtDni_Cif.Text, this.txtNombre.Text, this.txtDomicilio.Text, this.txtPoblacion.Text);
                    MessageBox.Show("Cliente Modificado Correctamente", "Ayuda", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lvListado.Items.Clear();
                    limpiarTextBox();

                    listarClientesLV();
                }
            }
            else
                MessageBox.Show("Selecciona un Cliente en el Listado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

    // COMPROBAR QUE LOS TEXTBOX ESTÁN VACIOS
        public bool textBoxVacios()
        {
            bool vacio = false;
            foreach (Control c in this.Controls)
            {
                if (c is TextBox && c.Text.Equals(""))
                    vacio = true;
            }

            return vacio;
        }

    // LIMPIAR TEXTBOX
        public void limpiarTextBox()
        {
            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                    c.ResetText();
            }
        }

    }
}
