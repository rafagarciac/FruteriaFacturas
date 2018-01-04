namespace FruteriaFacturas
{
    partial class CreacionFactura
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreacionFactura));
            this.lblListadoAlbaranes = new System.Windows.Forms.Label();
            this.lvAlbaranesFacturas = new System.Windows.Forms.ListView();
            this.chIdAlbaran = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chFecha = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chDni_Cif_Cliente = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chSubtotal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chTotal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.lblFacturaN = new System.Windows.Forms.Label();
            this.lblNumeroFactura = new System.Windows.Forms.Label();
            this.btnAnnadir = new System.Windows.Forms.Button();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.btnAnnadirTodos = new System.Windows.Forms.Button();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnCrearFactura = new System.Windows.Forms.Button();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.cbElegirClientes = new System.Windows.Forms.ComboBox();
            this.lblCliente = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lvAlbaranesSeleccionados = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnQuitarTodos = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblListadoAlbaranes
            // 
            this.lblListadoAlbaranes.AutoSize = true;
            this.lblListadoAlbaranes.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListadoAlbaranes.Location = new System.Drawing.Point(15, 19);
            this.lblListadoAlbaranes.Name = "lblListadoAlbaranes";
            this.lblListadoAlbaranes.Size = new System.Drawing.Size(240, 34);
            this.lblListadoAlbaranes.TabIndex = 5;
            this.lblListadoAlbaranes.Text = "CREACIÓN FACTURA";
            // 
            // lvAlbaranesFacturas
            // 
            this.lvAlbaranesFacturas.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chIdAlbaran,
            this.chFecha,
            this.chDni_Cif_Cliente,
            this.chSubtotal,
            this.chTotal});
            this.lvAlbaranesFacturas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lvAlbaranesFacturas.LargeImageList = this.imageList1;
            this.lvAlbaranesFacturas.Location = new System.Drawing.Point(6, 26);
            this.lvAlbaranesFacturas.Name = "lvAlbaranesFacturas";
            this.lvAlbaranesFacturas.Size = new System.Drawing.Size(522, 294);
            this.lvAlbaranesFacturas.SmallImageList = this.imageList1;
            this.lvAlbaranesFacturas.StateImageList = this.imageList1;
            this.lvAlbaranesFacturas.TabIndex = 6;
            this.lvAlbaranesFacturas.UseCompatibleStateImageBehavior = false;
            this.lvAlbaranesFacturas.View = System.Windows.Forms.View.Details;
            // 
            // chIdAlbaran
            // 
            this.chIdAlbaran.Text = "IdAlbaran";
            this.chIdAlbaran.Width = 68;
            // 
            // chFecha
            // 
            this.chFecha.Text = "Fecha Albaran";
            this.chFecha.Width = 93;
            // 
            // chDni_Cif_Cliente
            // 
            this.chDni_Cif_Cliente.Text = "Dni/Cif ";
            this.chDni_Cif_Cliente.Width = 69;
            // 
            // chSubtotal
            // 
            this.chSubtotal.Text = "Subtotal";
            this.chSubtotal.Width = 82;
            // 
            // chTotal
            // 
            this.chTotal.Text = "Total";
            this.chTotal.Width = 74;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "albaran_icono.png");
            // 
            // lblFacturaN
            // 
            this.lblFacturaN.AutoSize = true;
            this.lblFacturaN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFacturaN.Location = new System.Drawing.Point(18, 71);
            this.lblFacturaN.Name = "lblFacturaN";
            this.lblFacturaN.Size = new System.Drawing.Size(100, 16);
            this.lblFacturaN.TabIndex = 7;
            this.lblFacturaN.Text = "FACTURA Nº";
            // 
            // lblNumeroFactura
            // 
            this.lblNumeroFactura.AutoSize = true;
            this.lblNumeroFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroFactura.Location = new System.Drawing.Point(115, 71);
            this.lblNumeroFactura.Name = "lblNumeroFactura";
            this.lblNumeroFactura.Size = new System.Drawing.Size(0, 16);
            this.lblNumeroFactura.TabIndex = 8;
            // 
            // btnAnnadir
            // 
            this.btnAnnadir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAnnadir.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnnadir.Location = new System.Drawing.Point(593, 160);
            this.btnAnnadir.Name = "btnAnnadir";
            this.btnAnnadir.Size = new System.Drawing.Size(50, 45);
            this.btnAnnadir.TabIndex = 9;
            this.btnAnnadir.Text = ">";
            this.btnAnnadir.UseVisualStyleBackColor = true;
            this.btnAnnadir.Click += new System.EventHandler(this.btnAnnadir_Click);
            // 
            // btnQuitar
            // 
            this.btnQuitar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQuitar.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitar.Location = new System.Drawing.Point(593, 221);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(50, 45);
            this.btnQuitar.TabIndex = 10;
            this.btnQuitar.Text = "<";
            this.btnQuitar.UseVisualStyleBackColor = true;
            this.btnQuitar.Click += new System.EventHandler(this.btnAnnadir_Click);
            // 
            // btnAnnadirTodos
            // 
            this.btnAnnadirTodos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAnnadirTodos.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnnadirTodos.Location = new System.Drawing.Point(593, 282);
            this.btnAnnadirTodos.Name = "btnAnnadirTodos";
            this.btnAnnadirTodos.Size = new System.Drawing.Size(50, 45);
            this.btnAnnadirTodos.TabIndex = 11;
            this.btnAnnadirTodos.Text = ">>";
            this.btnAnnadirTodos.UseVisualStyleBackColor = true;
            this.btnAnnadirTodos.Click += new System.EventHandler(this.btnAnnadir_Click);
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtotal.Location = new System.Drawing.Point(700, 402);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(88, 16);
            this.lblSubtotal.TabIndex = 12;
            this.lblSubtotal.Text = "SUBTOTAL";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(850, 402);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(57, 16);
            this.lblTotal.TabIndex = 13;
            this.lblTotal.Text = "TOTAL";
            // 
            // btnCrearFactura
            // 
            this.btnCrearFactura.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCrearFactura.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearFactura.Location = new System.Drawing.Point(749, 98);
            this.btnCrearFactura.Name = "btnCrearFactura";
            this.btnCrearFactura.Size = new System.Drawing.Size(148, 33);
            this.btnCrearFactura.TabIndex = 20;
            this.btnCrearFactura.Text = "CREAR FACTURA";
            this.btnCrearFactura.UseVisualStyleBackColor = true;
            this.btnCrearFactura.Click += new System.EventHandler(this.btnCrearFactura_Click);
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Enabled = false;
            this.txtSubtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubtotal.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtSubtotal.Location = new System.Drawing.Point(687, 444);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.Size = new System.Drawing.Size(101, 26);
            this.txtSubtotal.TabIndex = 21;
            this.txtSubtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtTotal.Location = new System.Drawing.Point(830, 444);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(109, 26);
            this.txtTotal.TabIndex = 22;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cbElegirClientes
            // 
            this.cbElegirClientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbElegirClientes.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbElegirClientes.FormattingEnabled = true;
            this.cbElegirClientes.Location = new System.Drawing.Point(687, 35);
            this.cbElegirClientes.Name = "cbElegirClientes";
            this.cbElegirClientes.Size = new System.Drawing.Size(220, 21);
            this.cbElegirClientes.TabIndex = 23;
            this.cbElegirClientes.TabStop = false;
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.Location = new System.Drawing.Point(569, 34);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(83, 19);
            this.lblCliente.TabIndex = 24;
            this.lblCliente.Text = "CLIENTE:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 16);
            this.label1.TabIndex = 25;
            this.label1.Text = "Lista Albaranes";
            // 
            // lvAlbaranesSeleccionados
            // 
            this.lvAlbaranesSeleccionados.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader4,
            this.columnHeader5});
            this.lvAlbaranesSeleccionados.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lvAlbaranesSeleccionados.LargeImageList = this.imageList1;
            this.lvAlbaranesSeleccionados.Location = new System.Drawing.Point(687, 150);
            this.lvAlbaranesSeleccionados.Name = "lvAlbaranesSeleccionados";
            this.lvAlbaranesSeleccionados.Size = new System.Drawing.Size(252, 231);
            this.lvAlbaranesSeleccionados.SmallImageList = this.imageList1;
            this.lvAlbaranesSeleccionados.StateImageList = this.imageList1;
            this.lvAlbaranesSeleccionados.TabIndex = 26;
            this.lvAlbaranesSeleccionados.UseCompatibleStateImageBehavior = false;
            this.lvAlbaranesSeleccionados.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "IdAlbaran";
            this.columnHeader1.Width = 68;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Subtotal";
            this.columnHeader4.Width = 82;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Total";
            this.columnHeader5.Width = 74;
            // 
            // btnQuitarTodos
            // 
            this.btnQuitarTodos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQuitarTodos.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitarTodos.Location = new System.Drawing.Point(593, 338);
            this.btnQuitarTodos.Name = "btnQuitarTodos";
            this.btnQuitarTodos.Size = new System.Drawing.Size(50, 45);
            this.btnQuitarTodos.TabIndex = 27;
            this.btnQuitarTodos.Text = "<<";
            this.btnQuitarTodos.UseVisualStyleBackColor = true;
            this.btnQuitarTodos.Click += new System.EventHandler(this.btnAnnadir_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lvAlbaranesFacturas);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(21, 123);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(546, 328);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // CreacionFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 482);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnQuitarTodos);
            this.Controls.Add(this.lvAlbaranesSeleccionados);
            this.Controls.Add(this.cbElegirClientes);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtSubtotal);
            this.Controls.Add(this.btnCrearFactura);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblSubtotal);
            this.Controls.Add(this.btnAnnadirTodos);
            this.Controls.Add(this.btnQuitar);
            this.Controls.Add(this.btnAnnadir);
            this.Controls.Add(this.lblNumeroFactura);
            this.Controls.Add(this.lblFacturaN);
            this.Controls.Add(this.lblListadoAlbaranes);
            this.Name = "CreacionFactura";
            this.Text = "CreacionFactura";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblListadoAlbaranes;
        private System.Windows.Forms.ListView lvAlbaranesFacturas;
        private System.Windows.Forms.Label lblFacturaN;
        private System.Windows.Forms.Label lblNumeroFactura;
        private System.Windows.Forms.Button btnAnnadir;
        private System.Windows.Forms.Button btnQuitar;
        private System.Windows.Forms.Button btnAnnadirTodos;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnCrearFactura;
        private System.Windows.Forms.TextBox txtSubtotal;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.ComboBox cbElegirClientes;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader chIdAlbaran;
        private System.Windows.Forms.ColumnHeader chFecha;
        private System.Windows.Forms.ColumnHeader chDni_Cif_Cliente;
        private System.Windows.Forms.ColumnHeader chSubtotal;
        private System.Windows.Forms.ColumnHeader chTotal;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ListView lvAlbaranesSeleccionados;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button btnQuitarTodos;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}