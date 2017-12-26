namespace FruteriaFacturas
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.creacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.facturaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.albaranToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.facturaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.borradoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.albaranToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.facturaToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.pbfondoMDI = new System.Windows.Forms.PictureBox();
            this.tsHoraActual = new System.Windows.Forms.ToolStrip();
            this.tslHora = new System.Windows.Forms.ToolStripLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbfondoMDI)).BeginInit();
            this.tsHoraActual.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.creacionToolStripMenuItem,
            this.modificacionToolStripMenuItem,
            this.borradoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(989, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // creacionToolStripMenuItem
            // 
            this.creacionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesToolStripMenuItem1,
            this.facturaToolStripMenuItem});
            this.creacionToolStripMenuItem.Name = "creacionToolStripMenuItem";
            this.creacionToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.creacionToolStripMenuItem.Text = "Clientes";
            // 
            // clientesToolStripMenuItem1
            // 
            this.clientesToolStripMenuItem1.Name = "clientesToolStripMenuItem1";
            this.clientesToolStripMenuItem1.Size = new System.Drawing.Size(196, 22);
            this.clientesToolStripMenuItem1.Text = "Alta";
            this.clientesToolStripMenuItem1.Click += new System.EventHandler(this.clientesToolStripMenuItem1_Click);
            // 
            // facturaToolStripMenuItem
            // 
            this.facturaToolStripMenuItem.Name = "facturaToolStripMenuItem";
            this.facturaToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.facturaToolStripMenuItem.Text = "Consulta/Modificacion";
            this.facturaToolStripMenuItem.Click += new System.EventHandler(this.facturaToolStripMenuItem_Click);
            // 
            // modificacionToolStripMenuItem
            // 
            this.modificacionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesToolStripMenuItem2,
            this.albaranToolStripMenuItem1,
            this.facturaToolStripMenuItem1});
            this.modificacionToolStripMenuItem.Name = "modificacionToolStripMenuItem";
            this.modificacionToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.modificacionToolStripMenuItem.Text = "Albaranes";
            // 
            // clientesToolStripMenuItem2
            // 
            this.clientesToolStripMenuItem2.Name = "clientesToolStripMenuItem2";
            this.clientesToolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.clientesToolStripMenuItem2.Text = "Nuevo Albaran";
            this.clientesToolStripMenuItem2.Click += new System.EventHandler(this.clientesToolStripMenuItem2_Click);
            // 
            // albaranToolStripMenuItem1
            // 
            this.albaranToolStripMenuItem1.Name = "albaranToolStripMenuItem1";
            this.albaranToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.albaranToolStripMenuItem1.Text = "Modificar Albaran";
            // 
            // facturaToolStripMenuItem1
            // 
            this.facturaToolStripMenuItem1.Name = "facturaToolStripMenuItem1";
            this.facturaToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.facturaToolStripMenuItem1.Text = "Consultar Albaranes";
            // 
            // borradoToolStripMenuItem
            // 
            this.borradoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesToolStripMenuItem3,
            this.albaranToolStripMenuItem2,
            this.facturaToolStripMenuItem2});
            this.borradoToolStripMenuItem.Name = "borradoToolStripMenuItem";
            this.borradoToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.borradoToolStripMenuItem.Text = "Facturas";
            // 
            // clientesToolStripMenuItem3
            // 
            this.clientesToolStripMenuItem3.Name = "clientesToolStripMenuItem3";
            this.clientesToolStripMenuItem3.Size = new System.Drawing.Size(116, 22);
            this.clientesToolStripMenuItem3.Text = "Clientes";
            // 
            // albaranToolStripMenuItem2
            // 
            this.albaranToolStripMenuItem2.Name = "albaranToolStripMenuItem2";
            this.albaranToolStripMenuItem2.Size = new System.Drawing.Size(116, 22);
            this.albaranToolStripMenuItem2.Text = "Albaran";
            // 
            // facturaToolStripMenuItem2
            // 
            this.facturaToolStripMenuItem2.Name = "facturaToolStripMenuItem2";
            this.facturaToolStripMenuItem2.Size = new System.Drawing.Size(116, 22);
            this.facturaToolStripMenuItem2.Text = "Factura";
            // 
            // pbfondoMDI
            // 
            this.pbfondoMDI.Image = ((System.Drawing.Image)(resources.GetObject("pbfondoMDI.Image")));
            this.pbfondoMDI.Location = new System.Drawing.Point(0, 27);
            this.pbfondoMDI.Name = "pbfondoMDI";
            this.pbfondoMDI.Size = new System.Drawing.Size(989, 499);
            this.pbfondoMDI.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbfondoMDI.TabIndex = 3;
            this.pbfondoMDI.TabStop = false;
            // 
            // tsHoraActual
            // 
            this.tsHoraActual.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tsHoraActual.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslHora});
            this.tsHoraActual.Location = new System.Drawing.Point(0, 501);
            this.tsHoraActual.Name = "tsHoraActual";
            this.tsHoraActual.Size = new System.Drawing.Size(989, 25);
            this.tsHoraActual.TabIndex = 5;
            this.tsHoraActual.Text = "toolStrip1";
            // 
            // tslHora
            // 
            this.tslHora.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tslHora.Name = "tslHora";
            this.tslHora.Size = new System.Drawing.Size(0, 22);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 526);
            this.Controls.Add(this.tsHoraActual);
            this.Controls.Add(this.pbfondoMDI);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbfondoMDI)).EndInit();
            this.tsHoraActual.ResumeLayout(false);
            this.tsHoraActual.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem creacionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificacionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem borradoToolStripMenuItem;
        private System.Windows.Forms.PictureBox pbfondoMDI;
        private System.Windows.Forms.ToolStripMenuItem facturaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem albaranToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem facturaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem albaranToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem facturaToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem3;
        private System.Windows.Forms.ToolStrip tsHoraActual;
        private System.Windows.Forms.ToolStripLabel tslHora;
        private System.Windows.Forms.Timer timer1;
    }
}

