namespace FruteriaFacturas
{
    partial class CreacionAlbaran
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreacionAlbaran));
            this.lblProducto = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.txtUnidad = new System.Windows.Forms.TextBox();
            this.txtProducto = new System.Windows.Forms.TextBox();
            this.txtImporte = new System.Windows.Forms.TextBox();
            this.btnAnnadir = new System.Windows.Forms.Button();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.gbListadoLineas = new System.Windows.Forms.GroupBox();
            this.btnBorrarLinea = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lvLineas = new System.Windows.Forms.ListView();
            this.chCantidad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chUnidad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chProducto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chPrecio = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.lblAlbaran = new System.Windows.Forms.Label();
            this.lblNumeroAlbaran = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.cbElegirClientes = new System.Windows.Forms.ComboBox();
            this.gbListadoLineas.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblProducto
            // 
            this.lblProducto.AutoSize = true;
            this.lblProducto.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProducto.Location = new System.Drawing.Point(12, 44);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(151, 19);
            this.lblProducto.TabIndex = 1;
            this.lblProducto.Text = "PRODUCTO/LINEA";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidad.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtCantidad.Location = new System.Drawing.Point(19, 106);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(128, 26);
            this.txtCantidad.TabIndex = 2;
            this.txtCantidad.Text = "Cantidad";
            this.txtCantidad.Enter += new System.EventHandler(this.enterPlaceHolderTxt);
            this.txtCantidad.Leave += new System.EventHandler(this.leavePlaceHolderText);
            // 
            // txtUnidad
            // 
            this.txtUnidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUnidad.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtUnidad.Location = new System.Drawing.Point(197, 106);
            this.txtUnidad.Name = "txtUnidad";
            this.txtUnidad.Size = new System.Drawing.Size(128, 26);
            this.txtUnidad.TabIndex = 3;
            this.txtUnidad.Text = "Unidad";
            this.txtUnidad.Enter += new System.EventHandler(this.enterPlaceHolderTxt);
            this.txtUnidad.Leave += new System.EventHandler(this.leavePlaceHolderText);
            // 
            // txtProducto
            // 
            this.txtProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProducto.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtProducto.Location = new System.Drawing.Point(364, 106);
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.Size = new System.Drawing.Size(128, 26);
            this.txtProducto.TabIndex = 4;
            this.txtProducto.Text = "Producto";
            this.txtProducto.Enter += new System.EventHandler(this.enterPlaceHolderTxt);
            this.txtProducto.Leave += new System.EventHandler(this.leavePlaceHolderText);
            // 
            // txtImporte
            // 
            this.txtImporte.Enabled = false;
            this.txtImporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtImporte.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtImporte.Location = new System.Drawing.Point(716, 106);
            this.txtImporte.Name = "txtImporte";
            this.txtImporte.Size = new System.Drawing.Size(128, 26);
            this.txtImporte.TabIndex = 6;
            this.txtImporte.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnAnnadir
            // 
            this.btnAnnadir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAnnadir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnnadir.Location = new System.Drawing.Point(873, 98);
            this.btnAnnadir.Name = "btnAnnadir";
            this.btnAnnadir.Size = new System.Drawing.Size(91, 44);
            this.btnAnnadir.TabIndex = 0;
            this.btnAnnadir.Text = "AÑADIR";
            this.btnAnnadir.UseVisualStyleBackColor = true;
            this.btnAnnadir.Click += new System.EventHandler(this.btnAnnadir_Click);
            // 
            // txtPrecio
            // 
            this.txtPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecio.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtPrecio.Location = new System.Drawing.Point(539, 106);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(128, 26);
            this.txtPrecio.TabIndex = 5;
            this.txtPrecio.Text = "Precio";
            this.txtPrecio.Enter += new System.EventHandler(this.enterPlaceHolderTxt);
            this.txtPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecio_KeyPress);
            this.txtPrecio.Leave += new System.EventHandler(this.leavePlaceHolderText);
            // 
            // gbListadoLineas
            // 
            this.gbListadoLineas.Controls.Add(this.btnBorrarLinea);
            this.gbListadoLineas.Controls.Add(this.button1);
            this.gbListadoLineas.Controls.Add(this.lvLineas);
            this.gbListadoLineas.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbListadoLineas.Location = new System.Drawing.Point(16, 162);
            this.gbListadoLineas.Name = "gbListadoLineas";
            this.gbListadoLineas.Size = new System.Drawing.Size(919, 298);
            this.gbListadoLineas.TabIndex = 0;
            this.gbListadoLineas.TabStop = false;
            this.gbListadoLineas.Text = "LISTA PRODUCTOS EN ALBARAN";
            // 
            // btnBorrarLinea
            // 
            this.btnBorrarLinea.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBorrarLinea.Location = new System.Drawing.Point(27, 260);
            this.btnBorrarLinea.Name = "btnBorrarLinea";
            this.btnBorrarLinea.Size = new System.Drawing.Size(104, 32);
            this.btnBorrarLinea.TabIndex = 0;
            this.btnBorrarLinea.TabStop = false;
            this.btnBorrarLinea.Text = "Borrar Linea";
            this.btnBorrarLinea.UseVisualStyleBackColor = true;
            this.btnBorrarLinea.Visible = false;
            this.btnBorrarLinea.Click += new System.EventHandler(this.btnBorrarLinea_Click);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(700, 253);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(183, 39);
            this.button1.TabIndex = 0;
            this.button1.TabStop = false;
            this.button1.Text = "GUARDAR ALBARAN";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lvLineas
            // 
            this.lvLineas.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chCantidad,
            this.chUnidad,
            this.chProducto,
            this.chPrecio});
            this.lvLineas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lvLineas.LargeImageList = this.imageList1;
            this.lvLineas.Location = new System.Drawing.Point(27, 36);
            this.lvLineas.Name = "lvLineas";
            this.lvLineas.Size = new System.Drawing.Size(858, 211);
            this.lvLineas.SmallImageList = this.imageList1;
            this.lvLineas.StateImageList = this.imageList1;
            this.lvLineas.TabIndex = 0;
            this.lvLineas.TabStop = false;
            this.lvLineas.UseCompatibleStateImageBehavior = false;
            this.lvLineas.View = System.Windows.Forms.View.Details;
            this.lvLineas.Click += new System.EventHandler(this.lvLineas_Click);
            // 
            // chCantidad
            // 
            this.chCantidad.Text = "Cantidad";
            this.chCantidad.Width = 191;
            // 
            // chUnidad
            // 
            this.chUnidad.Text = "Unidad";
            this.chUnidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chUnidad.Width = 174;
            // 
            // chProducto
            // 
            this.chProducto.Text = "Producto";
            this.chProducto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chProducto.Width = 303;
            // 
            // chPrecio
            // 
            this.chPrecio.Text = "Precio";
            this.chPrecio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chPrecio.Width = 183;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "cesta-icono.png");
            this.imageList1.Images.SetKeyName(1, "cesta-icono.png");
            // 
            // lblAlbaran
            // 
            this.lblAlbaran.AutoSize = true;
            this.lblAlbaran.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlbaran.Location = new System.Drawing.Point(12, 9);
            this.lblAlbaran.Name = "lblAlbaran";
            this.lblAlbaran.Size = new System.Drawing.Size(142, 19);
            this.lblAlbaran.TabIndex = 0;
            this.lblAlbaran.Text = "Nº DE ALBARAN: ";
            // 
            // lblNumeroAlbaran
            // 
            this.lblNumeroAlbaran.AutoSize = true;
            this.lblNumeroAlbaran.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroAlbaran.Location = new System.Drawing.Point(160, 9);
            this.lblNumeroAlbaran.Name = "lblNumeroAlbaran";
            this.lblNumeroAlbaran.Size = new System.Drawing.Size(0, 19);
            this.lblNumeroAlbaran.TabIndex = 0;
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.Location = new System.Drawing.Point(535, 20);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(83, 19);
            this.lblCliente.TabIndex = 0;
            this.lblCliente.Text = "CLIENTE:";
            // 
            // cbElegirClientes
            // 
            this.cbElegirClientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbElegirClientes.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbElegirClientes.FormattingEnabled = true;
            this.cbElegirClientes.Location = new System.Drawing.Point(653, 21);
            this.cbElegirClientes.Name = "cbElegirClientes";
            this.cbElegirClientes.Size = new System.Drawing.Size(220, 21);
            this.cbElegirClientes.TabIndex = 0;
            this.cbElegirClientes.TabStop = false;
            // 
            // CreacionAlbaran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 472);
            this.Controls.Add(this.cbElegirClientes);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.lblNumeroAlbaran);
            this.Controls.Add(this.lblAlbaran);
            this.Controls.Add(this.gbListadoLineas);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.btnAnnadir);
            this.Controls.Add(this.txtImporte);
            this.Controls.Add(this.txtProducto);
            this.Controls.Add(this.txtUnidad);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.lblProducto);
            this.Name = "CreacionAlbaran";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CreacionAlbaran_KeyPress);
            this.gbListadoLineas.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.TextBox txtUnidad;
        private System.Windows.Forms.TextBox txtProducto;
        private System.Windows.Forms.TextBox txtImporte;
        private System.Windows.Forms.Button btnAnnadir;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.GroupBox gbListadoLineas;
        private System.Windows.Forms.Label lblAlbaran;
        private System.Windows.Forms.Label lblNumeroAlbaran;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.ComboBox cbElegirClientes;
        private System.Windows.Forms.ListView lvLineas;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ColumnHeader chCantidad;
        private System.Windows.Forms.ColumnHeader chUnidad;
        private System.Windows.Forms.ColumnHeader chProducto;
        private System.Windows.Forms.ColumnHeader chPrecio;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btnBorrarLinea;
    }
}