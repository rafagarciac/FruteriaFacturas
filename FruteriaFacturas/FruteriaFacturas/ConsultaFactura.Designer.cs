namespace FruteriaFacturas
{
    partial class ConsultaFactura
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultaFactura));
            this.lblListadoFacturas = new System.Windows.Forms.Label();
            this.lvFacturas = new System.Windows.Forms.ListView();
            this.chIdFactura = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chFechaFactura = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chSubtotal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chTotal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chDni_Cif = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.gbDatosFactura = new System.Windows.Forms.GroupBox();
            this.lblEuroSubTotal = new System.Windows.Forms.Label();
            this.lblEuroTotal = new System.Windows.Forms.Label();
            this.cbClientes = new System.Windows.Forms.ComboBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.dtpFechaFactura = new System.Windows.Forms.DateTimePicker();
            this.nudIdFactura = new System.Windows.Forms.NumericUpDown();
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.lblFechaFactura = new System.Windows.Forms.Label();
            this.lblIdFactura = new System.Windows.Forms.Label();
            this.btnBorrarFactura = new System.Windows.Forms.Button();
            this.btnModificarFactura = new System.Windows.Forms.Button();
            this.btnGenerarAlbaran = new System.Windows.Forms.Button();
            this.gbDatosFactura.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudIdFactura)).BeginInit();
            this.SuspendLayout();
            // 
            // lblListadoFacturas
            // 
            this.lblListadoFacturas.AutoSize = true;
            this.lblListadoFacturas.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListadoFacturas.Location = new System.Drawing.Point(355, 35);
            this.lblListadoFacturas.Name = "lblListadoFacturas";
            this.lblListadoFacturas.Size = new System.Drawing.Size(234, 34);
            this.lblListadoFacturas.TabIndex = 5;
            this.lblListadoFacturas.Text = "LISTADO FACTURAS";
            // 
            // lvFacturas
            // 
            this.lvFacturas.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chIdFactura,
            this.chFechaFactura,
            this.chSubtotal,
            this.chTotal,
            this.chDni_Cif});
            this.lvFacturas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lvFacturas.LargeImageList = this.imageList1;
            this.lvFacturas.Location = new System.Drawing.Point(12, 122);
            this.lvFacturas.Name = "lvFacturas";
            this.lvFacturas.Size = new System.Drawing.Size(553, 277);
            this.lvFacturas.SmallImageList = this.imageList1;
            this.lvFacturas.StateImageList = this.imageList1;
            this.lvFacturas.TabIndex = 6;
            this.lvFacturas.UseCompatibleStateImageBehavior = false;
            this.lvFacturas.View = System.Windows.Forms.View.Details;
            this.lvFacturas.Click += new System.EventHandler(this.lvFacturas_Click);
            // 
            // chIdFactura
            // 
            this.chIdFactura.Text = "Id Factura";
            this.chIdFactura.Width = 80;
            // 
            // chFechaFactura
            // 
            this.chFechaFactura.Text = "Fecha Factura";
            this.chFechaFactura.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chFechaFactura.Width = 110;
            // 
            // chSubtotal
            // 
            this.chSubtotal.Text = "Subtotal";
            this.chSubtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chSubtotal.Width = 89;
            // 
            // chTotal
            // 
            this.chTotal.Text = "Total";
            this.chTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chTotal.Width = 87;
            // 
            // chDni_Cif
            // 
            this.chDni_Cif.Text = "Dni / Cif Cliente";
            this.chDni_Cif.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chDni_Cif.Width = 122;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "factura.png");
            // 
            // gbDatosFactura
            // 
            this.gbDatosFactura.Controls.Add(this.lblEuroSubTotal);
            this.gbDatosFactura.Controls.Add(this.lblEuroTotal);
            this.gbDatosFactura.Controls.Add(this.cbClientes);
            this.gbDatosFactura.Controls.Add(this.txtTotal);
            this.gbDatosFactura.Controls.Add(this.txtSubtotal);
            this.gbDatosFactura.Controls.Add(this.dtpFechaFactura);
            this.gbDatosFactura.Controls.Add(this.nudIdFactura);
            this.gbDatosFactura.Controls.Add(this.lblCliente);
            this.gbDatosFactura.Controls.Add(this.lblTotal);
            this.gbDatosFactura.Controls.Add(this.lblSubtotal);
            this.gbDatosFactura.Controls.Add(this.lblFechaFactura);
            this.gbDatosFactura.Controls.Add(this.lblIdFactura);
            this.gbDatosFactura.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDatosFactura.Location = new System.Drawing.Point(580, 122);
            this.gbDatosFactura.Name = "gbDatosFactura";
            this.gbDatosFactura.Size = new System.Drawing.Size(386, 277);
            this.gbDatosFactura.TabIndex = 7;
            this.gbDatosFactura.TabStop = false;
            this.gbDatosFactura.Text = "Datos Factura";
            // 
            // lblEuroSubTotal
            // 
            this.lblEuroSubTotal.AutoSize = true;
            this.lblEuroSubTotal.BackColor = System.Drawing.Color.White;
            this.lblEuroSubTotal.Cursor = System.Windows.Forms.Cursors.Help;
            this.lblEuroSubTotal.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEuroSubTotal.Location = new System.Drawing.Point(341, 131);
            this.lblEuroSubTotal.Name = "lblEuroSubTotal";
            this.lblEuroSubTotal.Size = new System.Drawing.Size(17, 19);
            this.lblEuroSubTotal.TabIndex = 26;
            this.lblEuroSubTotal.Text = "€";
            // 
            // lblEuroTotal
            // 
            this.lblEuroTotal.AutoSize = true;
            this.lblEuroTotal.BackColor = System.Drawing.Color.White;
            this.lblEuroTotal.Cursor = System.Windows.Forms.Cursors.Help;
            this.lblEuroTotal.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEuroTotal.Location = new System.Drawing.Point(341, 176);
            this.lblEuroTotal.Name = "lblEuroTotal";
            this.lblEuroTotal.Size = new System.Drawing.Size(17, 19);
            this.lblEuroTotal.TabIndex = 25;
            this.lblEuroTotal.Text = "€";
            // 
            // cbClientes
            // 
            this.cbClientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbClientes.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbClientes.FormattingEnabled = true;
            this.cbClientes.Location = new System.Drawing.Point(182, 214);
            this.cbClientes.Name = "cbClientes";
            this.cbClientes.Size = new System.Drawing.Size(177, 23);
            this.cbClientes.TabIndex = 20;
            // 
            // txtTotal
            // 
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(182, 172);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(176, 26);
            this.txtTotal.TabIndex = 19;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubtotal.Location = new System.Drawing.Point(182, 127);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.Size = new System.Drawing.Size(176, 26);
            this.txtSubtotal.TabIndex = 18;
            this.txtSubtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dtpFechaFactura
            // 
            this.dtpFechaFactura.CalendarFont = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaFactura.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaFactura.Location = new System.Drawing.Point(182, 85);
            this.dtpFechaFactura.Name = "dtpFechaFactura";
            this.dtpFechaFactura.Size = new System.Drawing.Size(176, 22);
            this.dtpFechaFactura.TabIndex = 17;
            // 
            // nudIdFactura
            // 
            this.nudIdFactura.Enabled = false;
            this.nudIdFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudIdFactura.Location = new System.Drawing.Point(194, 39);
            this.nudIdFactura.Name = "nudIdFactura";
            this.nudIdFactura.Size = new System.Drawing.Size(120, 26);
            this.nudIdFactura.TabIndex = 13;
            this.nudIdFactura.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.Location = new System.Drawing.Point(6, 214);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(85, 24);
            this.lblCliente.TabIndex = 4;
            this.lblCliente.Text = "Cliente: ";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(6, 172);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(67, 24);
            this.lblTotal.TabIndex = 3;
            this.lblTotal.Text = "Total: ";
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtotal.Location = new System.Drawing.Point(6, 127);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(97, 24);
            this.lblSubtotal.TabIndex = 2;
            this.lblSubtotal.Text = "Subtotal: ";
            // 
            // lblFechaFactura
            // 
            this.lblFechaFactura.AutoSize = true;
            this.lblFechaFactura.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaFactura.Location = new System.Drawing.Point(6, 81);
            this.lblFechaFactura.Name = "lblFechaFactura";
            this.lblFechaFactura.Size = new System.Drawing.Size(155, 24);
            this.lblFechaFactura.TabIndex = 1;
            this.lblFechaFactura.Text = "Fecha Factura: ";
            // 
            // lblIdFactura
            // 
            this.lblIdFactura.AutoSize = true;
            this.lblIdFactura.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdFactura.Location = new System.Drawing.Point(6, 38);
            this.lblIdFactura.Name = "lblIdFactura";
            this.lblIdFactura.Size = new System.Drawing.Size(117, 24);
            this.lblIdFactura.TabIndex = 0;
            this.lblIdFactura.Text = "Id Factura: ";
            // 
            // btnBorrarFactura
            // 
            this.btnBorrarFactura.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBorrarFactura.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrarFactura.Location = new System.Drawing.Point(603, 426);
            this.btnBorrarFactura.Name = "btnBorrarFactura";
            this.btnBorrarFactura.Size = new System.Drawing.Size(148, 33);
            this.btnBorrarFactura.TabIndex = 21;
            this.btnBorrarFactura.Text = "BORRAR";
            this.btnBorrarFactura.UseVisualStyleBackColor = true;
            this.btnBorrarFactura.Click += new System.EventHandler(this.btnBorrarFactura_Click);
            // 
            // btnModificarFactura
            // 
            this.btnModificarFactura.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModificarFactura.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarFactura.Location = new System.Drawing.Point(784, 426);
            this.btnModificarFactura.Name = "btnModificarFactura";
            this.btnModificarFactura.Size = new System.Drawing.Size(148, 33);
            this.btnModificarFactura.TabIndex = 20;
            this.btnModificarFactura.Text = "MODIFICAR ";
            this.btnModificarFactura.UseVisualStyleBackColor = true;
            this.btnModificarFactura.Click += new System.EventHandler(this.btnModificarFactura_Click);
            // 
            // btnGenerarAlbaran
            // 
            this.btnGenerarAlbaran.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGenerarAlbaran.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGenerarAlbaran.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerarAlbaran.Image = ((System.Drawing.Image)(resources.GetObject("btnGenerarAlbaran.Image")));
            this.btnGenerarAlbaran.Location = new System.Drawing.Point(208, 413);
            this.btnGenerarAlbaran.Name = "btnGenerarAlbaran";
            this.btnGenerarAlbaran.Size = new System.Drawing.Size(170, 58);
            this.btnGenerarAlbaran.TabIndex = 23;
            this.btnGenerarAlbaran.Text = "GENERAR PDF";
            this.btnGenerarAlbaran.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGenerarAlbaran.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGenerarAlbaran.UseVisualStyleBackColor = true;
            this.btnGenerarAlbaran.Click += new System.EventHandler(this.btnGenerarAlbaran_Click);
            // 
            // ConsultaFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 483);
            this.Controls.Add(this.btnGenerarAlbaran);
            this.Controls.Add(this.btnBorrarFactura);
            this.Controls.Add(this.btnModificarFactura);
            this.Controls.Add(this.gbDatosFactura);
            this.Controls.Add(this.lvFacturas);
            this.Controls.Add(this.lblListadoFacturas);
            this.Name = "ConsultaFactura";
            this.Text = "ConsultaFactura";
            this.gbDatosFactura.ResumeLayout(false);
            this.gbDatosFactura.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudIdFactura)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblListadoFacturas;
        private System.Windows.Forms.ListView lvFacturas;
        private System.Windows.Forms.GroupBox gbDatosFactura;
        private System.Windows.Forms.ColumnHeader chIdFactura;
        private System.Windows.Forms.ColumnHeader chFechaFactura;
        private System.Windows.Forms.ColumnHeader chSubtotal;
        private System.Windows.Forms.ColumnHeader chTotal;
        private System.Windows.Forms.ColumnHeader chDni_Cif;
        private System.Windows.Forms.Label lblIdFactura;
        private System.Windows.Forms.Label lblFechaFactura;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.NumericUpDown nudIdFactura;
        private System.Windows.Forms.DateTimePicker dtpFechaFactura;
        private System.Windows.Forms.ComboBox cbClientes;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtSubtotal;
        private System.Windows.Forms.Label lblEuroSubTotal;
        private System.Windows.Forms.Label lblEuroTotal;
        private System.Windows.Forms.Button btnBorrarFactura;
        private System.Windows.Forms.Button btnModificarFactura;
        private System.Windows.Forms.Button btnGenerarAlbaran;
        private System.Windows.Forms.ImageList imageList1;
    }
}