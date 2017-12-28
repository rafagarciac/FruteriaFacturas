namespace FruteriaFacturas
{
    partial class ConsultaAlbaran
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultaAlbaran));
            this.lblListadoAlbaranes = new System.Windows.Forms.Label();
            this.lvListadoAlbaran = new System.Windows.Forms.ListView();
            this.chidAlbaran = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chFechaAlbaran = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chDniCliente = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chSubtotal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chTotal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chIdFactura = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblidAlbaran = new System.Windows.Forms.Label();
            this.lblFechaAlbaran = new System.Windows.Forms.Label();
            this.lblDni_CifCliente = new System.Windows.Forms.Label();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblIdFactura = new System.Windows.Forms.Label();
            this.nudIdAlbaran = new System.Windows.Forms.NumericUpDown();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.nudIdFactura = new System.Windows.Forms.NumericUpDown();
            this.dtpFechaAlbaran = new System.Windows.Forms.DateTimePicker();
            this.cbClientes = new System.Windows.Forms.ComboBox();
            this.btnModificarAlbaran = new System.Windows.Forms.Button();
            this.btnBorrarAlbaran = new System.Windows.Forms.Button();
            this.btnModificarLineas = new System.Windows.Forms.Button();
            this.btnGenerarAlbaran = new System.Windows.Forms.Button();
            this.lblEuroSubtotal = new System.Windows.Forms.Label();
            this.lblEuroTotal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudIdAlbaran)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudIdFactura)).BeginInit();
            this.SuspendLayout();
            // 
            // lblListadoAlbaranes
            // 
            this.lblListadoAlbaranes.AutoSize = true;
            this.lblListadoAlbaranes.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListadoAlbaranes.Location = new System.Drawing.Point(162, 27);
            this.lblListadoAlbaranes.Name = "lblListadoAlbaranes";
            this.lblListadoAlbaranes.Size = new System.Drawing.Size(247, 34);
            this.lblListadoAlbaranes.TabIndex = 4;
            this.lblListadoAlbaranes.Text = "LISTADO ALBARANES";
            // 
            // lvListadoAlbaran
            // 
            this.lvListadoAlbaran.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chidAlbaran,
            this.chFechaAlbaran,
            this.chDniCliente,
            this.chSubtotal,
            this.chTotal,
            this.chIdFactura});
            this.lvListadoAlbaran.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lvListadoAlbaran.Location = new System.Drawing.Point(12, 81);
            this.lvListadoAlbaran.Name = "lvListadoAlbaran";
            this.lvListadoAlbaran.Size = new System.Drawing.Size(586, 258);
            this.lvListadoAlbaran.TabIndex = 5;
            this.lvListadoAlbaran.UseCompatibleStateImageBehavior = false;
            this.lvListadoAlbaran.View = System.Windows.Forms.View.Details;
            this.lvListadoAlbaran.Click += new System.EventHandler(this.lvListadoAlbaran_Click);
            // 
            // chidAlbaran
            // 
            this.chidAlbaran.Text = "IdAlbaran";
            // 
            // chFechaAlbaran
            // 
            this.chFechaAlbaran.Text = "Fecha Albaran";
            this.chFechaAlbaran.Width = 101;
            // 
            // chDniCliente
            // 
            this.chDniCliente.Text = "Dni / Cif Cliente";
            this.chDniCliente.Width = 103;
            // 
            // chSubtotal
            // 
            this.chSubtotal.Text = "Subtotal";
            this.chSubtotal.Width = 99;
            // 
            // chTotal
            // 
            this.chTotal.Text = "Total";
            this.chTotal.Width = 75;
            // 
            // chIdFactura
            // 
            this.chIdFactura.Text = "Factura";
            this.chIdFactura.Width = 142;
            // 
            // lblidAlbaran
            // 
            this.lblidAlbaran.AutoSize = true;
            this.lblidAlbaran.Cursor = System.Windows.Forms.Cursors.Help;
            this.lblidAlbaran.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblidAlbaran.Location = new System.Drawing.Point(629, 81);
            this.lblidAlbaran.Name = "lblidAlbaran";
            this.lblidAlbaran.Size = new System.Drawing.Size(108, 19);
            this.lblidAlbaran.TabIndex = 6;
            this.lblidAlbaran.Text = "ID ALBARAN";
            // 
            // lblFechaAlbaran
            // 
            this.lblFechaAlbaran.AutoSize = true;
            this.lblFechaAlbaran.Cursor = System.Windows.Forms.Cursors.Help;
            this.lblFechaAlbaran.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaAlbaran.Location = new System.Drawing.Point(629, 129);
            this.lblFechaAlbaran.Name = "lblFechaAlbaran";
            this.lblFechaAlbaran.Size = new System.Drawing.Size(142, 19);
            this.lblFechaAlbaran.TabIndex = 7;
            this.lblFechaAlbaran.Text = "FECHA ALBARAN";
            // 
            // lblDni_CifCliente
            // 
            this.lblDni_CifCliente.AutoSize = true;
            this.lblDni_CifCliente.Cursor = System.Windows.Forms.Cursors.Help;
            this.lblDni_CifCliente.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDni_CifCliente.Location = new System.Drawing.Point(629, 176);
            this.lblDni_CifCliente.Name = "lblDni_CifCliente";
            this.lblDni_CifCliente.Size = new System.Drawing.Size(145, 19);
            this.lblDni_CifCliente.TabIndex = 8;
            this.lblDni_CifCliente.Text = "DNI_CIF CLIENTE";
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Cursor = System.Windows.Forms.Cursors.Help;
            this.lblSubtotal.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtotal.Location = new System.Drawing.Point(626, 229);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(92, 19);
            this.lblSubtotal.TabIndex = 9;
            this.lblSubtotal.Text = "SUBTOTAL";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Cursor = System.Windows.Forms.Cursors.Help;
            this.lblTotal.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(629, 275);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(61, 19);
            this.lblTotal.TabIndex = 10;
            this.lblTotal.Text = "TOTAL";
            // 
            // lblIdFactura
            // 
            this.lblIdFactura.AutoSize = true;
            this.lblIdFactura.Cursor = System.Windows.Forms.Cursors.Help;
            this.lblIdFactura.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdFactura.Location = new System.Drawing.Point(629, 320);
            this.lblIdFactura.Name = "lblIdFactura";
            this.lblIdFactura.Size = new System.Drawing.Size(105, 19);
            this.lblIdFactura.TabIndex = 11;
            this.lblIdFactura.Text = "ID FACTURA";
            // 
            // nudIdAlbaran
            // 
            this.nudIdAlbaran.Enabled = false;
            this.nudIdAlbaran.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudIdAlbaran.Location = new System.Drawing.Point(842, 80);
            this.nudIdAlbaran.Name = "nudIdAlbaran";
            this.nudIdAlbaran.Size = new System.Drawing.Size(120, 26);
            this.nudIdAlbaran.TabIndex = 12;
            this.nudIdAlbaran.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubtotal.Location = new System.Drawing.Point(797, 230);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.Size = new System.Drawing.Size(165, 26);
            this.txtSubtotal.TabIndex = 13;
            this.txtSubtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTotal
            // 
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(797, 271);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(165, 26);
            this.txtTotal.TabIndex = 14;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nudIdFactura
            // 
            this.nudIdFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudIdFactura.Location = new System.Drawing.Point(842, 320);
            this.nudIdFactura.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudIdFactura.Name = "nudIdFactura";
            this.nudIdFactura.Size = new System.Drawing.Size(120, 26);
            this.nudIdFactura.TabIndex = 15;
            this.nudIdFactura.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudIdFactura.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // dtpFechaAlbaran
            // 
            this.dtpFechaAlbaran.Location = new System.Drawing.Point(797, 129);
            this.dtpFechaAlbaran.Name = "dtpFechaAlbaran";
            this.dtpFechaAlbaran.Size = new System.Drawing.Size(165, 20);
            this.dtpFechaAlbaran.TabIndex = 16;
            // 
            // cbClientes
            // 
            this.cbClientes.FormattingEnabled = true;
            this.cbClientes.Location = new System.Drawing.Point(797, 177);
            this.cbClientes.Name = "cbClientes";
            this.cbClientes.Size = new System.Drawing.Size(165, 21);
            this.cbClientes.TabIndex = 17;
            // 
            // btnModificarAlbaran
            // 
            this.btnModificarAlbaran.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModificarAlbaran.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarAlbaran.Location = new System.Drawing.Point(814, 381);
            this.btnModificarAlbaran.Name = "btnModificarAlbaran";
            this.btnModificarAlbaran.Size = new System.Drawing.Size(148, 33);
            this.btnModificarAlbaran.TabIndex = 18;
            this.btnModificarAlbaran.Text = "MODIFICAR ";
            this.btnModificarAlbaran.UseVisualStyleBackColor = true;
            // 
            // btnBorrarAlbaran
            // 
            this.btnBorrarAlbaran.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBorrarAlbaran.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrarAlbaran.Location = new System.Drawing.Point(633, 381);
            this.btnBorrarAlbaran.Name = "btnBorrarAlbaran";
            this.btnBorrarAlbaran.Size = new System.Drawing.Size(148, 33);
            this.btnBorrarAlbaran.TabIndex = 19;
            this.btnBorrarAlbaran.Text = "BORRAR";
            this.btnBorrarAlbaran.UseVisualStyleBackColor = true;
            // 
            // btnModificarLineas
            // 
            this.btnModificarLineas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModificarLineas.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarLineas.Location = new System.Drawing.Point(630, 438);
            this.btnModificarLineas.Name = "btnModificarLineas";
            this.btnModificarLineas.Size = new System.Drawing.Size(332, 33);
            this.btnModificarLineas.TabIndex = 20;
            this.btnModificarLineas.Text = "MODIFICAR LINEAS";
            this.btnModificarLineas.UseVisualStyleBackColor = true;
            // 
            // btnGenerarAlbaran
            // 
            this.btnGenerarAlbaran.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGenerarAlbaran.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGenerarAlbaran.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerarAlbaran.Image = ((System.Drawing.Image)(resources.GetObject("btnGenerarAlbaran.Image")));
            this.btnGenerarAlbaran.Location = new System.Drawing.Point(189, 381);
            this.btnGenerarAlbaran.Name = "btnGenerarAlbaran";
            this.btnGenerarAlbaran.Size = new System.Drawing.Size(170, 58);
            this.btnGenerarAlbaran.TabIndex = 22;
            this.btnGenerarAlbaran.Text = "GENERAR PDF";
            this.btnGenerarAlbaran.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGenerarAlbaran.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGenerarAlbaran.UseVisualStyleBackColor = true;
            // 
            // lblEuroSubtotal
            // 
            this.lblEuroSubtotal.AutoSize = true;
            this.lblEuroSubtotal.BackColor = System.Drawing.Color.White;
            this.lblEuroSubtotal.Cursor = System.Windows.Forms.Cursors.Help;
            this.lblEuroSubtotal.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEuroSubtotal.Location = new System.Drawing.Point(940, 234);
            this.lblEuroSubtotal.Name = "lblEuroSubtotal";
            this.lblEuroSubtotal.Size = new System.Drawing.Size(17, 19);
            this.lblEuroSubtotal.TabIndex = 23;
            this.lblEuroSubtotal.Text = "€";
            // 
            // lblEuroTotal
            // 
            this.lblEuroTotal.AutoSize = true;
            this.lblEuroTotal.BackColor = System.Drawing.Color.White;
            this.lblEuroTotal.Cursor = System.Windows.Forms.Cursors.Help;
            this.lblEuroTotal.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEuroTotal.Location = new System.Drawing.Point(940, 275);
            this.lblEuroTotal.Name = "lblEuroTotal";
            this.lblEuroTotal.Size = new System.Drawing.Size(17, 19);
            this.lblEuroTotal.TabIndex = 24;
            this.lblEuroTotal.Text = "€";
            // 
            // ConsultaAlbaran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 481);
            this.Controls.Add(this.lblEuroTotal);
            this.Controls.Add(this.lblEuroSubtotal);
            this.Controls.Add(this.btnGenerarAlbaran);
            this.Controls.Add(this.btnModificarLineas);
            this.Controls.Add(this.btnBorrarAlbaran);
            this.Controls.Add(this.btnModificarAlbaran);
            this.Controls.Add(this.cbClientes);
            this.Controls.Add(this.dtpFechaAlbaran);
            this.Controls.Add(this.nudIdFactura);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtSubtotal);
            this.Controls.Add(this.nudIdAlbaran);
            this.Controls.Add(this.lblIdFactura);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblSubtotal);
            this.Controls.Add(this.lblDni_CifCliente);
            this.Controls.Add(this.lblFechaAlbaran);
            this.Controls.Add(this.lblidAlbaran);
            this.Controls.Add(this.lvListadoAlbaran);
            this.Controls.Add(this.lblListadoAlbaranes);
            this.Name = "ConsultaAlbaran";
            this.Text = "ConsultaAlbaran";
            ((System.ComponentModel.ISupportInitialize)(this.nudIdAlbaran)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudIdFactura)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblListadoAlbaranes;
        private System.Windows.Forms.ListView lvListadoAlbaran;
        private System.Windows.Forms.ColumnHeader chidAlbaran;
        private System.Windows.Forms.ColumnHeader chFechaAlbaran;
        private System.Windows.Forms.ColumnHeader chDniCliente;
        private System.Windows.Forms.ColumnHeader chSubtotal;
        private System.Windows.Forms.ColumnHeader chTotal;
        private System.Windows.Forms.ColumnHeader chIdFactura;
        private System.Windows.Forms.Label lblidAlbaran;
        private System.Windows.Forms.Label lblFechaAlbaran;
        private System.Windows.Forms.Label lblDni_CifCliente;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblIdFactura;
        private System.Windows.Forms.NumericUpDown nudIdAlbaran;
        private System.Windows.Forms.TextBox txtSubtotal;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.NumericUpDown nudIdFactura;
        private System.Windows.Forms.DateTimePicker dtpFechaAlbaran;
        private System.Windows.Forms.ComboBox cbClientes;
        private System.Windows.Forms.Button btnModificarAlbaran;
        private System.Windows.Forms.Button btnBorrarAlbaran;
        private System.Windows.Forms.Button btnModificarLineas;
        private System.Windows.Forms.Button btnGenerarAlbaran;
        private System.Windows.Forms.Label lblEuroSubtotal;
        private System.Windows.Forms.Label lblEuroTotal;
    }
}