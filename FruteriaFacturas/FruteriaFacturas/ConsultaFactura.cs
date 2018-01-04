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

            cargarFacturasLV();
        }

    // CARGO LAS FACTURAS EN EL LIST_VIEW
        public void cargarFacturasLV()
        {
            this.lvFacturas.Items.Clear();
            this.facturasArray.Clear();
            this.facturasArray = conexion.cargarFacturas();
            foreach (Factura fa in facturasArray)
            {
                ListViewItem item = this.lvFacturas.Items.Add("Factura", fa.getIdFactura().ToString(), 0);
                item.SubItems.Add(fa.getFechaFactura().ToShortDateString());
                item.SubItems.Add(fa.getSubtotal().ToString() + "€");
                item.SubItems.Add(fa.getTotal().ToString() + "€");
                item.SubItems.Add(fa.getDni_Cif());
            }
        }

        // CARGO EL COMBO_BOX DE CLIENTES
        public void cargarClientesCB()
        {
            foreach (Cliente cl in clientesArray)
            {
                String cliente = cl.getNombre().ToString() + " .- " + cl.getDni_Cif().ToString();
                this.cbClientes.Items.Add(cliente);
            }
        }

    // METODO QUE CORRESPONDE AL EVENTO DE CLICK EN LIST_VIEW
        private void lvFacturas_Click(object sender, EventArgs e)
        {
            ListViewItem itemSeleccionado = this.lvFacturas.SelectedItems[0];
            foreach (Factura fa in facturasArray)
            {
                // SI EL ITEM SELECCIONADO COINCIDE CON ALGUNA FACTURA DEL ARRAY LIST ENTRA
                if (fa.getIdFactura().ToString().Equals(itemSeleccionado.SubItems[0].Text))
                {
                    this.cbClientes.Items.Clear();
                    cargarClientesCB();
                    this.nudIdFactura.Value = fa.getIdFactura();
                    this.dtpFechaFactura.Value = fa.getFechaFactura();
                    this.txtSubtotal.Text = fa.getSubtotal().ToString();
                    this.txtTotal.Text = fa.getTotal().ToString();
                    this.cbClientes.Text = fa.getDni_Cif().ToString();
                }
                    
            }
        }

        public bool comprobarFK(Factura fa)
        {
            bool tieneFk = false;
            foreach (Albaran al in albaranesArray)
            {
                // SI LA FACTURA PASADA POR PARAMETROS TIENE FK 
                if (al.getIdFactura().ToString().Equals(fa.getIdFactura().ToString()))
                    tieneFk = true;
            }
            return tieneFk;
        }

    // BORRAR CONTROLES
        public void limpiarControles()
        {
            foreach (Control c in gbDatosFactura.Controls)
            {
                if (c is TextBox || c is NumericUpDown || c is ComboBox || c is DateTimePicker)
                {
                    c.ResetText();
                }
            }
        }

        private void btnBorrarFactura_Click(object sender, EventArgs e)
        {
            if (lvFacturas.SelectedItems.Count > 0)
            {
                ListViewItem itemSeleccionado = this.lvFacturas.SelectedItems[0];
                foreach (Factura fa in facturasArray)
                {
                    // SI EL ITEM SELECCIONADO COINCIDE CON ALGUNA FACTURA DEL ARRAY LIST ENTRA
                    if (fa.getIdFactura().ToString().Equals(itemSeleccionado.SubItems[0].Text))
                    {
                        if (!comprobarFK(fa))
                        {
                            conexion.borrarFactura(fa.getIdFactura().ToString());
                            limpiarControles();
                            this.lvFacturas.Items.Remove(itemSeleccionado);
                            MessageBox.Show("Factura Borrado Correctamente", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                            MessageBox.Show("Esta Factura no se puede Borrar porque contiene Albaranes Asociados", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }else
                MessageBox.Show("Selecciona una Factura en el Listado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }


    // BOTON MODIFICAR
        private void btnModificarFactura_Click(object sender, EventArgs e)
        {
            if (lvFacturas.SelectedItems.Count > 0)
            {
                ListViewItem itemSeleccionado = this.lvFacturas.SelectedItems[0];
                foreach (Factura fa in facturasArray)
                {
                    // SI EL ITEM SELECCIONADO COINCIDE CON ALGUNA FACTURA DEL ARRAY LIST ENTRA
                    if (fa.getIdFactura().ToString().Equals(itemSeleccionado.SubItems[0].Text))
                    {
                        if (!comprobarFK(fa))
                        {
                            // UPDATE Facturas SET fechaFactura = '03-01-2018', subtotal = 23.43, total = 95.43, dni_cif = '0022515F' WHERE idFactura = 14;
                            try
                            {
                                Cliente c = (Cliente)clientesArray[this.cbClientes.SelectedIndex];
                                String dni_cifFactura = c.getDni_Cif().ToString();

                                // ACTUALIZO EN ARRAYLIST
                                fa.setFechaFactura(dtpFechaFactura.Value);
                                fa.setSubtotal(Convert.ToDouble(this.txtSubtotal.Text.Replace('.', ',')));
                                fa.setTotal(Convert.ToDouble(this.txtTotal.Text.Replace('.', ',')));
                                fa.setDni_Cif(dni_cifFactura);

                                // ACTUALIZO EN LA BBDD
                                conexion.modificarFactura(fa.getIdFactura().ToString(), dtpFechaFactura.Value, this.txtSubtotal.Text.Replace(',', '.').Trim(), this.txtTotal.Text.Replace(',', '.').Trim(), dni_cifFactura);
                                

                                MessageBox.Show("Factura Modificado Correctamente", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            catch (ArgumentOutOfRangeException)
                            {
                                MessageBox.Show("Selecciona un Cliente en el Listado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            catch (FormatException)
                            {
                                MessageBox.Show("Error de Formato. Revisa los Valores Numericos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                            MessageBox.Show("Esta Factura no se puede Modificar porque contiene Albaranes Asociados", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                // ACTUALIOZO EL LISTVIEW
                cargarFacturasLV();
            }
            else
                MessageBox.Show("Selecciona una Factura en el Listado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnGenerarAlbaran_Click(object sender, EventArgs e)
        {
            if (lvFacturas.SelectedItems.Count > 0)
            {
                ListViewItem listItem = lvFacturas.SelectedItems[0];
                VistaReporte vista = new VistaReporte(null, "", listItem.SubItems[0].Text);
                vista.Show();
            }
            else
                MessageBox.Show("Selecciona una Factura en el Listado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

    }
}
