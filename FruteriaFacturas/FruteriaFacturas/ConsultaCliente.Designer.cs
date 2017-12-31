namespace FruteriaFacturas
{
    partial class ConsultaCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultaCliente));
            this.lvListado = new System.Windows.Forms.ListView();
            this.chdni_cif = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chNombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chDomicilio = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chPoblacion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.lblListadoClientes = new System.Windows.Forms.Label();
            this.lblDatos = new System.Windows.Forms.Label();
            this.lblPoblacion = new System.Windows.Forms.Label();
            this.lblDomicilio = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lbldni_cif = new System.Windows.Forms.Label();
            this.rtxtDatos = new System.Windows.Forms.RichTextBox();
            this.txtPoblacion = new System.Windows.Forms.TextBox();
            this.txtDomicilio = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDni_Cif = new System.Windows.Forms.TextBox();
            this.btnBorrarCliente = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvListado
            // 
            this.lvListado.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chdni_cif,
            this.chNombre,
            this.chDomicilio,
            this.chPoblacion});
            this.lvListado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lvListado.LargeImageList = this.imageList1;
            this.lvListado.Location = new System.Drawing.Point(12, 100);
            this.lvListado.MultiSelect = false;
            this.lvListado.Name = "lvListado";
            this.lvListado.Size = new System.Drawing.Size(460, 258);
            this.lvListado.SmallImageList = this.imageList1;
            this.lvListado.TabIndex = 0;
            this.lvListado.UseCompatibleStateImageBehavior = false;
            this.lvListado.View = System.Windows.Forms.View.Details;
            this.lvListado.Click += new System.EventHandler(this.lvListado_Click);
            // 
            // chdni_cif
            // 
            this.chdni_cif.Text = "Dni / Cif";
            this.chdni_cif.Width = 86;
            // 
            // chNombre
            // 
            this.chNombre.Text = "Nombre";
            this.chNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chNombre.Width = 114;
            // 
            // chDomicilio
            // 
            this.chDomicilio.Text = "Domicilio";
            this.chDomicilio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chDomicilio.Width = 117;
            // 
            // chPoblacion
            // 
            this.chPoblacion.Text = "Poblacion";
            this.chPoblacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chPoblacion.Width = 139;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "cliente.png");
            // 
            // lblListadoClientes
            // 
            this.lblListadoClientes.AutoSize = true;
            this.lblListadoClientes.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListadoClientes.Location = new System.Drawing.Point(129, 37);
            this.lblListadoClientes.Name = "lblListadoClientes";
            this.lblListadoClientes.Size = new System.Drawing.Size(220, 34);
            this.lblListadoClientes.TabIndex = 3;
            this.lblListadoClientes.Text = "LISTADO CLIENTES";
            // 
            // lblDatos
            // 
            this.lblDatos.AutoSize = true;
            this.lblDatos.Cursor = System.Windows.Forms.Cursors.Help;
            this.lblDatos.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatos.Location = new System.Drawing.Point(563, 289);
            this.lblDatos.Name = "lblDatos";
            this.lblDatos.Size = new System.Drawing.Size(121, 19);
            this.lblDatos.TabIndex = 10;
            this.lblDatos.Text = "OTROS DATOS";
            // 
            // lblPoblacion
            // 
            this.lblPoblacion.AutoSize = true;
            this.lblPoblacion.Cursor = System.Windows.Forms.Cursors.Help;
            this.lblPoblacion.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPoblacion.Location = new System.Drawing.Point(563, 243);
            this.lblPoblacion.Name = "lblPoblacion";
            this.lblPoblacion.Size = new System.Drawing.Size(103, 19);
            this.lblPoblacion.TabIndex = 9;
            this.lblPoblacion.Text = "POBLACION";
            // 
            // lblDomicilio
            // 
            this.lblDomicilio.AutoSize = true;
            this.lblDomicilio.Cursor = System.Windows.Forms.Cursors.Help;
            this.lblDomicilio.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDomicilio.Location = new System.Drawing.Point(563, 193);
            this.lblDomicilio.Name = "lblDomicilio";
            this.lblDomicilio.Size = new System.Drawing.Size(100, 19);
            this.lblDomicilio.TabIndex = 8;
            this.lblDomicilio.Text = "DOMICILIO";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Cursor = System.Windows.Forms.Cursors.Help;
            this.lblNombre.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(563, 146);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(82, 19);
            this.lblNombre.TabIndex = 7;
            this.lblNombre.Text = "NOMBRE";
            // 
            // lbldni_cif
            // 
            this.lbldni_cif.AutoSize = true;
            this.lbldni_cif.Cursor = System.Windows.Forms.Cursors.Help;
            this.lbldni_cif.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldni_cif.Location = new System.Drawing.Point(563, 100);
            this.lbldni_cif.Name = "lbldni_cif";
            this.lbldni_cif.Size = new System.Drawing.Size(85, 19);
            this.lbldni_cif.TabIndex = 6;
            this.lbldni_cif.Text = "D.N.I/C.I.F";
            // 
            // rtxtDatos
            // 
            this.rtxtDatos.Location = new System.Drawing.Point(567, 314);
            this.rtxtDatos.Name = "rtxtDatos";
            this.rtxtDatos.Size = new System.Drawing.Size(375, 71);
            this.rtxtDatos.TabIndex = 18;
            this.rtxtDatos.Text = "";
            // 
            // txtPoblacion
            // 
            this.txtPoblacion.Location = new System.Drawing.Point(716, 241);
            this.txtPoblacion.Name = "txtPoblacion";
            this.txtPoblacion.Size = new System.Drawing.Size(207, 20);
            this.txtPoblacion.TabIndex = 17;
            // 
            // txtDomicilio
            // 
            this.txtDomicilio.Location = new System.Drawing.Point(716, 191);
            this.txtDomicilio.Name = "txtDomicilio";
            this.txtDomicilio.Size = new System.Drawing.Size(207, 20);
            this.txtDomicilio.TabIndex = 16;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(716, 144);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(207, 20);
            this.txtNombre.TabIndex = 15;
            // 
            // txtDni_Cif
            // 
            this.txtDni_Cif.Location = new System.Drawing.Point(716, 99);
            this.txtDni_Cif.Name = "txtDni_Cif";
            this.txtDni_Cif.Size = new System.Drawing.Size(207, 20);
            this.txtDni_Cif.TabIndex = 14;
            // 
            // btnBorrarCliente
            // 
            this.btnBorrarCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBorrarCliente.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrarCliente.Location = new System.Drawing.Point(612, 419);
            this.btnBorrarCliente.Name = "btnBorrarCliente";
            this.btnBorrarCliente.Size = new System.Drawing.Size(136, 33);
            this.btnBorrarCliente.TabIndex = 19;
            this.btnBorrarCliente.Text = "BORRAR CLIENTE";
            this.btnBorrarCliente.UseVisualStyleBackColor = true;
            this.btnBorrarCliente.Click += new System.EventHandler(this.btnBorrarCliente_Click);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(772, 419);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 33);
            this.button1.TabIndex = 20;
            this.button1.Text = "MODIFICAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(135, 394);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(170, 58);
            this.button2.TabIndex = 21;
            this.button2.Text = "GENERAR PDF";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ConsultaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1057, 516);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnBorrarCliente);
            this.Controls.Add(this.rtxtDatos);
            this.Controls.Add(this.txtPoblacion);
            this.Controls.Add(this.txtDomicilio);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtDni_Cif);
            this.Controls.Add(this.lblDatos);
            this.Controls.Add(this.lblPoblacion);
            this.Controls.Add(this.lblDomicilio);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lbldni_cif);
            this.Controls.Add(this.lblListadoClientes);
            this.Controls.Add(this.lvListado);
            this.Name = "ConsultaCliente";
            this.Text = "ConsultaCliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvListado;
        private System.Windows.Forms.Label lblListadoClientes;
        private System.Windows.Forms.ColumnHeader chdni_cif;
        private System.Windows.Forms.ColumnHeader chNombre;
        private System.Windows.Forms.ColumnHeader chDomicilio;
        private System.Windows.Forms.ColumnHeader chPoblacion;
        private System.Windows.Forms.Label lblDatos;
        private System.Windows.Forms.Label lblPoblacion;
        private System.Windows.Forms.Label lblDomicilio;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lbldni_cif;
        private System.Windows.Forms.RichTextBox rtxtDatos;
        private System.Windows.Forms.TextBox txtPoblacion;
        private System.Windows.Forms.TextBox txtDomicilio;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtDni_Cif;
        private System.Windows.Forms.Button btnBorrarCliente;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ImageList imageList1;
    }
}