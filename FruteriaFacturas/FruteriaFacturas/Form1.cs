using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

    // CREACION DEL CLIENTE 
        private void clientesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CreacionCliente formCLiente = new CreacionCliente();
            if (!formRepetido(formCLiente))
            {
                this.pbfondoMDI.Visible = false;
                formCLiente.MdiParent = this;
                formCLiente.WindowState = System.Windows.Forms.FormWindowState.Maximized;
                formCLiente.Show();

            }
        }

    //METODO DE VERIFICACION DE FORMULARIOS REPETIDOS
        public bool formRepetido(Form form)
        {
            bool repetido = false;
            foreach (Form frm in Application.OpenForms)
            {
                if (frm.Name.Equals(form.Name))
                {
                    repetido = true;
                }
            }
            return repetido;
        }


    }
}
