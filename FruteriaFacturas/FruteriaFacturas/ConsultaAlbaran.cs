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
    public partial class ConsultaAlbaran : Form
    {

        Conexion conexion;
        ArrayList albaranesArray;
        ArrayList clientesArray;
        ArrayList facturasArray;

        public ConsultaAlbaran(ArrayList albaranesArray, ArrayList clientesArray, ArrayList facturasArray)
        {
            InitializeComponent();

            conexion = new Conexion();

            this.albaranesArray = albaranesArray;
            this.clientesArray = clientesArray;
            this.facturasArray = facturasArray;

            // CARGO LOS ALBARANES EN EL LISTVIEW
            cargarAlbaranesLV();

            // EL CONTROL DEL IDALBARAN NO PUEDE SER MAYOR QUE LOS ALBARANES QUE HAY EN EL ARRAYLIST
            this.nudIdFactura.Maximum = facturasArray.Count;
        }

    // METODO QUE RESPONDE AL EVENTO DE SELECCIONAR ALBARAN EN EL LISVIEW
        private void lvListadoAlbaran_Click(object sender, EventArgs e)
        {
            //RECOGO EL ITEM PULSADO
            if (lvListadoAlbaran.SelectedItems.Count > 0)
            {
                ListViewItem listItem = lvListadoAlbaran.SelectedItems[0];
                foreach (Albaran al in albaranesArray)
                {
                    if (al.getIdAlbaran().ToString().Equals(listItem.SubItems[0].Text))
                    {
                        //CODIGO AQUI PARA MOSTRAR EN TEXTBOX
                        this.nudIdAlbaran.Value = al.getIdAlbaran();
                        this.dtpFechaAlbaran.Value = al.getFechaAlbaran();
                        this.cbClientes.Items.Clear();
                        cargarClientesComboBox();
                        this.cbClientes.Text = al.getDni_Cif().ToString();
                        this.txtSubtotal.Text = al.getSubtotal().ToString();
                        this.txtTotal.Text = al.getTotal().ToString();
                        this.nudIdFactura.Value = al.getIdFactura();

                    }
                }
            }
            else
            {
                MessageBox.Show("Selecciona un Albaran en el Listado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    // CARGO LOS ALBARANES EN EL LISTVIEW
        public void cargarAlbaranesLV()
        {
            this.lvListadoAlbaran.Items.Clear();
            this.albaranesArray.Clear();
            this.albaranesArray = conexion.cargarAlbaranes();
            foreach(Albaran al in albaranesArray){

                ListViewItem item = lvListadoAlbaran.Items.Add(al.getIdAlbaran().ToString(), "albaran");
                item.SubItems.Add(al.getFechaAlbaran().ToShortDateString());
                item.SubItems.Add(al.getDni_Cif().ToString());
                item.SubItems.Add(al.getSubtotal().ToString() + " €");
                item.SubItems.Add(al.getTotal().ToString() + " €");
                item.SubItems.Add(al.getIdFactura().ToString());

            }
        }

    // CARGO LOS CLIENTES EN EL COMBOBOX
        public void cargarClientesComboBox()
        {
            foreach (Cliente cl in clientesArray)
            {
                this.cbClientes.Items.Add(cl.getNombre() + " .- " + cl.getDni_Cif());
            }
        }

    // METODO QUE RESPONDE A LOS 3 BOTONES --> BORRAR, MODIFICAR Y MODIFICAR LINEAS
        private void botonesForm(object sender, EventArgs e)
        {
            Button btnSeleccionado = (Button) sender;

            if (lvListadoAlbaran.SelectedItems.Count > 0)
            {
                ListViewItem listItem = lvListadoAlbaran.SelectedItems[0];

            // BOTON BORRAR
                if (btnSeleccionado.Name.Equals(btnBorrarAlbaran.Name))
                {
                    ArrayList lineasAlbaran = conexion.cargarLineasAlbaran(listItem.SubItems[0].Text);

                    //  BORRO DE LA BBDD, ARRAYLIST Y LISTVIEW
                    if (lineasAlbaran.Count == 0)
                    {
                        conexion.borrarAlbaran(listItem.SubItems[0].Text);

                        Albaran alBorrado = new Albaran();
                        foreach(Albaran al in albaranesArray){
                            if(al.getIdAlbaran().ToString().Equals(listItem.SubItems[0].Text))
                                alBorrado = al;
                        }

                        albaranesArray.Remove(alBorrado);

                        this.lvListadoAlbaran.Items.Remove(listItem);

                        limpiarControles();
                        MessageBox.Show("Albaran Borrado Correctamente", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }else
                        MessageBox.Show("No se puede Borrar porque contiene " + lineasAlbaran.Count.ToString() + " Lineas Asociadas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            // BOTON MODIFICAR
                else if (btnSeleccionado.Name.Equals(btnModificarAlbaran.Name))
                {
                    ArrayList lineasAlbaran = conexion.cargarLineasAlbaran(listItem.SubItems[0].Text);

                    //  MODIFICO DE LA BBDD, ARRAYLIST Y LISTVIEW
                    if (lineasAlbaran.Count == 0)
                    {
                        String dni_cifAlbaran = "";
                        foreach (Albaran al in albaranesArray)
                        {
                            if (al.getIdAlbaran().ToString().Equals(listItem.SubItems[0].Text))
                            {
                                if (this.cbClientes.SelectedIndex >= 0)
                                {

                                    al.setFechaAlbaran(this.dtpFechaAlbaran.Value);
                                    Cliente c = (Cliente)clientesArray[this.cbClientes.SelectedIndex];
                                    dni_cifAlbaran = c.getDni_Cif().ToString();
                                    al.setDni_Cif(dni_cifAlbaran);
                                    al.setSubtotal(Convert.ToDouble(this.txtSubtotal.Text.Replace('.', ',')));
                                    al.setTotal(Convert.ToDouble(this.txtTotal.Text.Replace('.', ',')));
                                    al.setIdFactura(Convert.ToInt32(this.nudIdFactura.Value));
                                }          
                            }
                        }

                        if (this.cbClientes.SelectedIndex >= 0)
                        {

                            //UPDATE Albaranes SET fechaAlbaran = '02-12-1998', idFactura = 3, dni_cif = '518541KD', subtotal = 23.2, total = 120.2 WHERE idAlbaran = 13;
                            conexion.modificarAlbaran(this.dtpFechaAlbaran.Value, Convert.ToInt32(this.nudIdFactura.Value), dni_cifAlbaran, this.txtSubtotal.Text.Replace(',', '.'), this.txtTotal.Text.Replace(',', '.'), listItem.SubItems[0].Text);
                            MessageBox.Show("Albaran Modificado Correctamente", "Ayuda", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            lvListadoAlbaran.Items.Clear();
                            limpiarControles();

                            cargarAlbaranesLV();
                        }
                        else
                            MessageBox.Show("Elige Cliente en el Desplegable", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    

                    }
                    else
                        MessageBox.Show("No se puede Borrar porque contiene " + lineasAlbaran.Count.ToString() + " Lineas Asociadas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            // BOTON MODIFICAR LINEAS
                else if (btnSeleccionado.Name.Equals(btnModificarLineas.Name))
                {
                    Albaran albaran = new Albaran();
                    foreach (Albaran al in albaranesArray)
                    {
                        if (al.getIdAlbaran().ToString().Equals(listItem.SubItems[0].Text))
                            albaran = al;
                    }
                        
                    CreacionAlbaran modificarLineasAlbaran = new CreacionAlbaran(albaran, listItem.SubItems[2].Text);
                    modificarLineasAlbaran.Show();
                }
            }
            else
            {
                MessageBox.Show("Selecciona un Albaran en el Listado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

     // BORRAR CONTROLES
        public void limpiarControles()
        {
            foreach (Control c in this.Controls)
            {
                if (c is TextBox || c is NumericUpDown || c is ComboBox || c is DateTimePicker)
                {
                    c.ResetText();
                }
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            cargarAlbaranesLV();
        }



    }
}
