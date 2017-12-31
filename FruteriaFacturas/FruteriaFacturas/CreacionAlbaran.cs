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
    public partial class CreacionAlbaran : Form
    {
        Conexion conexion;
        ArrayList albaranesArray;
        ArrayList clientesArray;
        ArrayList lineasArray;
        ArrayList lineasNuevasArray;
        Albaran alModificar;

        double totalImporte = 0;
        const double iva = 0.4;
        bool formModificacion = false;
        
    // CONSTRUCTOR PARA INSERTAR NUEVOS ALBARANES
        public CreacionAlbaran(ArrayList albaranesArray, ArrayList clientesArray)
        {
            InitializeComponent();
            conexion = new Conexion();

            this.albaranesArray = albaranesArray;
            this.clientesArray = clientesArray;
            lineasArray = new ArrayList();

            // CARGAR CLIENTES EN EL COMBOBOX
            cargoClientesComboBox();
            this.lblNumeroAlbaran.Text = putNumeroAlbaran().ToString();

            formModificacion = false;

            // conexion.nuevoAlbaran();
            // MessageBox.Show(Convert.ToString(this.albaranesArray.Count + 1));
        }

    // CONSTRUCTOR PARA MODIFICAR LINEAS
        public CreacionAlbaran(Albaran albaran, String cliente)
        {
            InitializeComponent();
            conexion = new Conexion();

            //PONGO VALOR AL ALBARAN
            alModificar = albaran;

            lineasArray = conexion.cargarLineasAlbaran(albaran.getIdAlbaran().ToString());
            this.lineasNuevasArray = new ArrayList();

            //OCULTO COMPONENTES DE INSERTAR
            this.cbElegirClientes.Visible = false;
            this.lblNumeroAlbaran.Text = albaran.getIdAlbaran().ToString();
            this.btnBorrarLinea.Dispose();
            this.btnGuardarAlbaran.Dispose();
            this.txtImporte.Text = albaran.getSubtotal().ToString() + "€";
            String[] quitoEuro = this.txtImporte.Text.Split('€');

            //PONGO EL IMPORTE TOTAL Y CARGO LAS LINEAS
            totalImporte = Convert.ToDouble(quitoEuro[0].Trim());
            cargarLineasLV();
            
            // CREACION LABEL 
            Label lnDni = new Label();
            lnDni.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lnDni.Location = new System.Drawing.Point(700, 20);
            lnDni.Name = "lnDni";
            lnDni.Size = new System.Drawing.Size(120, 19);
            lnDni.Text = cliente;

            //CREACION BOTONES
            // boton borrar
            Button btnBorrar = new Button();
            btnBorrar.Cursor = System.Windows.Forms.Cursors.Hand;
            btnBorrar.Location = new System.Drawing.Point(27, 260);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new System.Drawing.Size(104, 32);
            btnBorrar.TabIndex = 0;
            btnBorrar.TabStop = false;
            btnBorrar.Text = "Borrar Linea";
            btnBorrar.Visible = true;
            btnBorrar.Click += new System.EventHandler(this.eventoBotonesModificar);

            //boton Modificar
            Button btnModificar = new Button();
            btnModificar.Cursor = System.Windows.Forms.Cursors.Hand;
            btnModificar.Location = new System.Drawing.Point(150, 260);
            btnModificar.Name = "btnModificarLinea";
            btnModificar.Size = new System.Drawing.Size(150, 32);
            btnModificar.TabIndex = 0;
            btnModificar.TabStop = false;
            btnModificar.Text = "Modificar Linea";
            btnModificar.Visible = true;
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += new System.EventHandler(this.eventoBotonesModificar);

            //boton ModificarAlbaran
            Button btnModificarLineasAlbaran = new Button();
            btnModificarLineasAlbaran.Cursor = System.Windows.Forms.Cursors.Hand;
            btnModificarLineasAlbaran.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnModificarLineasAlbaran.Location = new System.Drawing.Point(700, 253);
            btnModificarLineasAlbaran.Name = "btnModificarLineasAlbaran";
            btnModificarLineasAlbaran.Size = new System.Drawing.Size(183, 39);
            btnModificarLineasAlbaran.TabIndex = 0;
            btnModificarLineasAlbaran.TabStop = false;
            btnModificarLineasAlbaran.Text = "MODIFICAR ALBARAN";
            btnModificarLineasAlbaran.UseVisualStyleBackColor = true;
            btnModificarLineasAlbaran.Click += new System.EventHandler(this.eventoBotonesModificar);


            this.Controls.Add(lnDni);
            this.Controls.Add(btnBorrar);
            this.Controls.Add(btnModificar);
            this.Controls.Add(btnModificarLineasAlbaran);

            this.gbListadoLineas.Controls.Add(btnBorrar);
            this.gbListadoLineas.Controls.Add(btnModificar);
            this.gbListadoLineas.Controls.Add(btnModificarLineasAlbaran);

            formModificacion = true;

        }

    // BOTON AÑADIR PRODUCTO/LINEA
        private void btnAnnadir_Click(object sender, EventArgs e)
        {
            // COMPRUEBO QUE EL PRODUCTO NO SEA REPETIDO
                bool repetido = comprobarProductoRepetido(this.txtProducto.Text.ToUpper());

            try
            {
                if (!repetido)
                {

                    double importeLinea = 0;

                    importeLinea = Convert.ToDouble(this.txtCantidad.Text.Replace('.', ',')) * Convert.ToDouble(this.txtPrecio.Text.Replace('.', ','));
                    totalImporte += importeLinea;
                    this.txtImporte.Text = "";
                    this.txtImporte.Text = totalImporte.ToString() + " €";


                    // INSERTO EN LISTVIEW

                    ListViewItem item = this.lvLineas.Items.Add("linea", this.txtCantidad.Text.Replace('.',','), 1);
                    item.SubItems.Add(this.txtUnidad.Text.ToUpper());
                    item.SubItems.Add(this.txtProducto.Text.ToUpper());
                    item.SubItems.Add(this.txtPrecio.Text.Replace('.', ','));

                    // LO AÑADO EN EL ARRAYLIST
                    this.lineasArray.Add(new Linea(Convert.ToDouble(this.txtCantidad.Text.Replace('.', ',')), this.txtUnidad.Text.ToUpper(), this.txtProducto.Text.ToUpper(), Convert.ToDouble(this.txtPrecio.Text.Replace('.', ',')), importeLinea));
                    if (formModificacion)
                    {
                        calcularImporteAlbaran();
                        this.lineasNuevasArray.Add(new Linea(Convert.ToDouble(this.txtCantidad.Text.Replace('.', ',')), this.txtUnidad.Text.ToUpper(), this.txtProducto.Text.ToUpper(), Convert.ToDouble(this.txtPrecio.Text.Replace('.', ',')), importeLinea));
                    }
                }else
                    MessageBox.Show("Producto Repetido: " + this.txtProducto.Text.ToUpper(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (FormatException)
            {
                MessageBox.Show("Valores Introducidos No Validos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            limpiarTextbox();
        }

        // BOTON BORRAR LINEA
        private void btnBorrarLinea_Click(object sender, EventArgs e)
        {
            //RECOGO EL ITEM PULSADO
            if (lvLineas.SelectedItems.Count > 0)
            {
                ListViewItem listItem = lvLineas.SelectedItems[0];
                lvLineas.Items.Remove(listItem);

                Linea lnBorrada = new Linea();
                foreach (Linea ln in lineasArray)
                {
                    if (ln.getProducto().ToString().Equals(listItem.SubItems[2].Text))
                        lnBorrada = ln;
                }

                totalImporte -= Convert.ToDouble(lnBorrada.getCantidad()) * Convert.ToDouble(lnBorrada.getPrecio_Unitario());
                this.txtImporte.Text = "";
                this.txtImporte.Text = totalImporte.ToString() + " €";


                // BORRO DEL ARRAYLIST DE LINEAS
                lineasArray.Remove(lnBorrada);

                // OCULTO EL BOTON BORRAR
                this.btnBorrarLinea.Visible = false;

            }
            else
                MessageBox.Show("Selecciona una Linea/Producto en el Listado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }


    // BOTON GUARDAR ALBARANES
        private void button1_Click(object sender, EventArgs e)
        {
            if (this.cbElegirClientes.SelectedItem != null && this.lineasArray.Count > 0)
            {
            // 1º INSERTO EL ALBARAN
                int idAlbaran = putNumeroAlbaran();
                DateTime fechaAlbaran = DateTime.Now;
                int idFactura = conexion.ultimaFactura();
                Cliente c = (Cliente) clientesArray[this.cbElegirClientes.SelectedIndex];
                String dni_cifAlbaran = c.getDni_Cif().ToString();
                String[] quitoEuro = this.txtImporte.Text.Split('€');
                double subtotal = Convert.ToDouble(quitoEuro[0].Trim());
                double total = (subtotal *  iva) + subtotal; // APLICO EL IVA

                DialogResult resultAlbaran = MessageBox.Show(" ID ALBARAN: " + idAlbaran.ToString() + "\n FECHA CREACION ALBARAN: " + fechaAlbaran.ToShortDateString() + " \n ID FACTURA: " + idFactura.ToString() +
                                "\n DNI Y NOMBRE CLIENTE: " + dni_cifAlbaran + " " + c.getNombre() + "\n SUBTOTAL: " + subtotal.ToString() + "€\n TOTAL APLICADO EL " + iva.ToString() + "% DE IVA: " + total.ToString() + "€", "DATOS ALBARAN", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);

                if (resultAlbaran == DialogResult.OK)
                {
                    conexion.insertarAlbaran(idAlbaran, fechaAlbaran, idFactura, dni_cifAlbaran, subtotal.ToString().Replace(',', '.'), total.ToString().Replace(',', '.'));
                    albaranesArray.Add(new Albaran(idAlbaran, fechaAlbaran, idFactura, dni_cifAlbaran, subtotal, total));
                    refrescarPagina();

                // 2º INSERTO LAS LINEAS DENTRO DEL ALBARAN
                    String salidaLinea = "";
                    foreach (Linea ln in lineasArray)
                    {
                        salidaLinea += "CANTIDAD: " + ln.getCantidad().ToString() + " UNIDAD: " + ln.getUnidad() + " PRODUCTO: " + ln.getProducto() + " PRECIO_UNITARIO: " + ln.getPrecio_Unitario().ToString() + " IMPORTE: " + ln.getImporte().ToString() + "€\n";
                    }

                    DialogResult resultLineas = MessageBox.Show(salidaLinea, "DATOS LINEAS ALBARAN " + idAlbaran.ToString(), MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);

                    if (resultLineas == DialogResult.OK)
                    {
                        foreach (Linea ln in lineasArray)
                        {
                            conexion.insertarLinea(ln.getCantidad().ToString().Replace(',', '.'), ln.getUnidad().ToString(), ln.getProducto().ToString(), ln.getPrecio_Unitario().ToString().Replace(',', '.'), ln.getImporte().ToString().Replace(',', '.'), idAlbaran);
                        }

                        // MENSAJE INSERTO CORRECTAMENTE
                        MessageBox.Show("Albaran: " + idAlbaran + " y " + lineasArray.Count.ToString() + " Lineas Insertado/as Correctamente", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        //LIMPIO ARRAY DE LINEAS
                        this.lineasArray.Clear();
                    } 
                }

            

                // MessageBox.Show("Albaran y Lineas Insertadas Correctamente", "Ayuda", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("No se puede Generar el Albaran, Revisa el Cliente y las Lineas Insertadas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }


    //REFRESCAR PAGINA
        public void refrescarPagina()
        {
            this.albaranesArray = conexion.cargarAlbaranes();
            this.lblNumeroAlbaran.Text = putNumeroAlbaran().ToString();
            limpiarTextbox();
            this.lvLineas.Items.Clear();
            this.txtImporte.Text = "";
            this.cbElegirClientes.SelectedItem = null;
        }

    // PLACEHOLDER DE ENTRADA
        private void enterPlaceHolderTxt(object sender, EventArgs e)
        {
            TextBox txtPulsado = (TextBox) sender;
            txtPulsado.Text = "";
            txtPulsado.ForeColor = Color.Black;

        }

    // PLACEHOLDER DE SALIDA
        private void leavePlaceHolderText(object sender, EventArgs e)
        {
            TextBox txtPulsado = (TextBox)sender;

            if (txtPulsado != null)
            {
                //INICIO SWITCH
                switch (txtPulsado.Name)
                {
                    case "txtCantidad":
                        if (txtPulsado.Text.Equals(""))
                        {
                            txtPulsado.Text = "Cantidad";
                            txtPulsado.ForeColor = Color.Gray;
                        }
                        break;
                    case "txtUnidad":
                        if (txtPulsado.Text.Equals(""))
                        {
                            txtPulsado.Text = "Unidad";
                            txtPulsado.ForeColor = Color.Gray;
                        }
                        break;
                    case "txtProducto":
                        if (txtPulsado.Text.Equals(""))
                        {
                            txtPulsado.Text = "Producto";
                            txtPulsado.ForeColor = Color.Gray;
                        }
                        break;
                    case "txtPrecio":
                        if (txtPulsado.Text.Equals(""))
                        {
                            txtPulsado.Text = "Precio";
                            txtPulsado.ForeColor = Color.Gray;
                        }
                        break;
                }
                // FIN SWITCH
            }
            // ENTRA AQUI CUANDO LO LLAMO DESDE LIMPIARTEXTBOX()
            else
            {
                this.txtCantidad.Text = "Cantidad"; this.txtCantidad.ForeColor = Color.Gray;
                this.txtUnidad.Text = "Unidad"; this.txtUnidad.ForeColor = Color.Gray;
                this.txtProducto.Text = "Producto"; this.txtProducto.ForeColor = Color.Gray;
                this.txtPrecio.Text = "Precio"; this.txtPrecio.ForeColor = Color.Gray;
            }
        }

    // CARGO LOS CLIENTES EN EL COMBOBOX
        public void cargoClientesComboBox()
        {
            foreach (Cliente cl in clientesArray)
            {
                String cliente = cl.getNombre().ToString() + " .- " + cl.getDni_Cif().ToString();
                this.cbElegirClientes.Items.Add(cliente);
            }
        }

    // PONER NUMERO MAX + 1 DE ALBARAN
        public int putNumeroAlbaran()
        {
            return conexion.nuevoAlbaran();
        }

    // COMPROBACION DEL PRODUCTO REPETIDO
        public bool comprobarProductoRepetido(String producto)
        {
            bool repetido = false;

            foreach (Linea ln in lineasArray)
            {
                if (ln.getProducto().Equals(producto))
                    repetido = true;
            }
            return repetido;
        }

    // LIMPUIAR TEXTBOX
        public void limpiarTextbox()
        {
            foreach (Control c in this.Controls)
            {
                if (c is TextBox && !c.Name.Equals("txtImporte"))
                {
                    c.ResetText();
                    leavePlaceHolderText(null, null);
                }
            }
        }

    // METODO CLICK EN LISTVIEW (ELIGE LINEA)
        private void lvLineas_Click(object sender, EventArgs e)
        {
            // TRATAMIENTO DEPENDIENDO DE SU PROCEDENCIA
            if (!formModificacion)
            {
                this.btnBorrarLinea.Visible = true;
            }
            else
            {
                ListViewItem itemSeleccionado = lvLineas.SelectedItems[0];
                this.txtCantidad.Text = itemSeleccionado.SubItems[0].Text;
                this.txtUnidad.Text = itemSeleccionado.SubItems[1].Text;
                this.txtProducto.Text = itemSeleccionado.SubItems[2].Text;
                this.txtPrecio.Text = itemSeleccionado.SubItems[3].Text;
            }
        
        }

    // SI PULSAS ENTER
        private void CreacionAlbaran_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                btnAnnadir_Click(null, null);
            }
        }

    // SI PULSAS ENTER ESTANDO EN EL PRECIO
        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                btnAnnadir_Click(null, null);
            }
        }

    // CARGO LAS LINEAS PARA MODIFICARLAS
        public void cargarLineasLV()
        {
            this.lvLineas.Items.Clear();
            foreach (Linea ln in lineasArray)
            {
                ListViewItem item = this.lvLineas.Items.Add("linea", ln.getCantidad().ToString(), 1);
                item.SubItems.Add(ln.getUnidad());
                item.SubItems.Add(ln.getProducto());
                item.SubItems.Add(ln.getPrecio_Unitario().ToString());
            }
        }

    // CALCULAR IMPORTE_ALBARAN
        public void calcularImporteAlbaran()
        {
            totalImporte = 0;
            foreach (Linea ln in lineasArray)
            {
                totalImporte += ln.getImporte();
                this.txtImporte.Text = "";
                this.txtImporte.Text = totalImporte.ToString() + " €";
            }
        }

     // EVENTO BOTONES MODIFICAR
        public void eventoBotonesModificar(object sender, EventArgs e)
        {

            Button btnSeleccionado = (Button) sender;

            if (btnSeleccionado.Name.Equals("btnBorrar"))
            {
                if (lvLineas.SelectedItems.Count > 0)
                {
                    ListViewItem listItem = lvLineas.SelectedItems[0];
                    lvLineas.Items.Remove(listItem);

                    Linea lnBorrada = new Linea();
                    foreach (Linea ln in lineasArray)
                    {
                        if (ln.getProducto().ToString().Equals(listItem.SubItems[2].Text))
                            lnBorrada = ln;
                    }

                    totalImporte -= Convert.ToDouble(lnBorrada.getCantidad()) * Convert.ToDouble(lnBorrada.getPrecio_Unitario());
                    this.txtImporte.Text = "";
                    this.txtImporte.Text = totalImporte.ToString() + " €";

                    //calcularImporteAlbaran();


                    // BORRO DEL ARRAYLIST DE LINEAS
                    lineasArray.Remove(lnBorrada);

                    // BORRO DE LA BBDD
                    // DELETE FROM Lineas WHERE descripcion_producto = 'MANZANAS' AND idAlbaran = 12;
                    conexion.borrarLinea(listItem.SubItems[2].Text, alModificar.getIdAlbaran().ToString());

                    limpiarTextbox();

                    MessageBox.Show("Linea " + listItem.SubItems[2].Text + " Borrado/a Correctamente en el Albaran " + alModificar.getIdAlbaran().ToString(), "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // PROBLEMA PREGUNTAR SI QUIERES MODIFICAR EL IMPORTE UNA VEZ BORRADA LA LINEA

                }
                else
                    MessageBox.Show("Selecciona una Linea/Producto en el Listado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (btnSeleccionado.Name.Equals("btnModificarLinea"))
            {
                if (lvLineas.SelectedItems.Count > 0)
                {
                    ListViewItem listItem = lvLineas.SelectedItems[0];
                    
                    // CODIGO PARA MODIFICAR LINEA
                    // COMPRUEBO QUE EL PRODUCTO NO SEA REPETIDO

                    try
                    {

                        foreach (Linea ln in lineasArray)
                        {
                            if (ln.getProducto().Equals(listItem.SubItems[2].Text))
                            {
                                ln.setCantidad(Convert.ToDouble(this.txtCantidad.Text.Replace('.', ',')));
                                ln.setUnidad(this.txtUnidad.Text);
                                ln.setProducto(this.txtProducto.Text.ToUpper());
                                ln.setPrecio_Unitario(Convert.ToDouble(this.txtPrecio.Text.Replace('.', ',')));
                                ln.setImporte(Convert.ToDouble(this.txtCantidad.Text.Replace('.', ',')) * Convert.ToDouble(this.txtPrecio.Text.Replace('.', ',')));


                                //UPDATE Lineas SET cantidad = 2.3, unidad = 'GR', descripcion_producto = 'MANZANAS', precio_unitario = 0.50, importe = 23 WHERE descripcion_producto = 'ÑOKIS' AND idAlbaran = 12;
                                conexion.modificarLinea(this.txtCantidad.Text.Replace(',', '.'), this.txtUnidad.Text.ToUpper(), this.txtProducto.Text.ToUpper(), this.txtPrecio.Text.Replace(',', '.'), Convert.ToString(Convert.ToDouble(this.txtCantidad.Text.Replace('.', ',')) * Convert.ToDouble(this.txtPrecio.Text.Replace('.', ','))).Replace(',', '.'), listItem.SubItems[2].Text, alModificar.getIdAlbaran().ToString());

                                calcularImporteAlbaran();
                                cargarLineasLV();
                            }
                        }
                    }
                    catch (FormatException)
                    {
                        MessageBox.Show("Valores Introducidos No Validos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                else
                    MessageBox.Show("Selecciona una Linea/Producto en el Listado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (btnSeleccionado.Name.Equals("btnModificarLineasAlbaran"))
            {
                String salidaLinea = "";
                foreach (Linea ln in lineasNuevasArray)
                {
                    salidaLinea += "CANTIDAD: " + ln.getCantidad().ToString() + " UNIDAD: " + ln.getUnidad() + " PRODUCTO: " + ln.getProducto() + " PRECIO_UNITARIO: " + ln.getPrecio_Unitario().ToString() + " IMPORTE: " + ln.getImporte().ToString() + "€\n";
                }

                DialogResult resultLineas = MessageBox.Show(salidaLinea, "DATOS LINEAS ALBARAN " + alModificar.getIdAlbaran().ToString(), MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);

                if (resultLineas == DialogResult.OK)
                {
                    foreach (Linea ln in lineasNuevasArray)
                    {
                        conexion.insertarLinea(ln.getCantidad().ToString().Replace(',', '.'), ln.getUnidad().ToString(), ln.getProducto().ToString(), ln.getPrecio_Unitario().ToString().Replace(',', '.'), ln.getImporte().ToString().Replace(',', '.'), alModificar.getIdAlbaran());
                    }

                    // MENSAJE INSERTO CORRECTAMENTE
                    MessageBox.Show("Albaran: " + alModificar.getIdAlbaran().ToString() + " y " + lineasNuevasArray.Count.ToString() + " Lineas Insertado/as Correctamente", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

        }

    // METODO QUE RESPONDE AL EVVENTO DE CERRAR LA VENTANA
        private void CreacionAlbaran_FormClosing(object sender, FormClosingEventArgs e)
        {

            if (formModificacion)
            {
                DialogResult result = MessageBox.Show("Quieres Guardar el Importe del Albaran?", "Informacion", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

                if (result == DialogResult.OK)
                {
                    String subtotal = totalImporte.ToString().Replace(',', '.'); 
                    String total = Convert.ToString((totalImporte * 0.4) + totalImporte).Replace(',', '.');
                    String idAlbaran = alModificar.getIdAlbaran().ToString();
                    conexion.modificarImporteAlbaran(subtotal, total, idAlbaran);
                    MessageBox.Show("Albaran: " + idAlbaran + " Se ha actualizado con un Subtotal de: " + subtotal.ToString().Replace('.', ',') + " y un Total de: " + total.ToString().Replace('.', ','), "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
