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
    public partial class Form1 : Form
    {

        Conexion conexion;
        ArrayList clientesArray;

    // CONSTRUCTOR
        public Form1()
        {
            InitializeComponent();
            
            conexion = new Conexion();

        //CARGO CLIENTES 
            cargarClientes();
            // MessageBox.Show(this.clientesArray.Count.ToString());
        }

    // CREACION DEL CLIENTE 
        private void clientesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CreacionCliente formCliente = new CreacionCliente(clientesArray);
            if (!formRepetido(formCliente))
            {
                this.pbfondoMDI.Visible = false;
                formCliente.MdiParent = this;
                formCliente.WindowState = System.Windows.Forms.FormWindowState.Maximized;
                formCliente.Show();

            }
        }

    // MODIFICACION Y CONSULTA CLIENTE 
        private void facturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultaCliente formConsultaCliente = new ConsultaCliente(clientesArray);
            if (!formRepetido(formConsultaCliente))
            {
                this.pbfondoMDI.Visible = false;
                formConsultaCliente.MdiParent = this;
                formConsultaCliente.WindowState = System.Windows.Forms.FormWindowState.Maximized;
                formConsultaCliente.Show();
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

    //TIMER PARA EL RELOJ
        private void timer1_Tick(object sender, EventArgs e)
        {
            this.tslHora.Text = DateTime.Now.ToString();
        }

    //METODO PARA CARGAR CLIENTES
        public void cargarClientes()
        {
            clientesArray = conexion.cargarClientes();
        }


        


    }
}
