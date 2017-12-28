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

        ArrayList albaranesArray;
        ArrayList clientesArray;
        ArrayList facturasArray;

        public ConsultaAlbaran(ArrayList albaranesArray, ArrayList clientesArray, ArrayList facturasArray)
        {
            InitializeComponent();
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
            foreach(Albaran al in albaranesArray){

                ListViewItem item = lvListadoAlbaran.Items.Add(al.getIdAlbaran().ToString(), "albaran");
                item.SubItems.Add(al.getFechaAlbaran().ToShortDateString());
                item.SubItems.Add(al.getDni_Cif().ToString());
                item.SubItems.Add(al.getSubtotal().ToString() + " €");
                item.SubItems.Add(al.getTotal().ToString() + " €");
                item.SubItems.Add(al.getIdAlbaran().ToString());

            }
        }

        public void cargarClientesComboBox()
        {
            foreach (Cliente cl in clientesArray)
            {
                this.cbClientes.Items.Add(cl.getNombre() + " .- " + cl.getDni_Cif());
            }
        }



    }
}
