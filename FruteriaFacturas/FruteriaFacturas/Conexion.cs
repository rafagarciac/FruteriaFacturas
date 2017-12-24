using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Collections;

namespace FruteriaFacturas
{
    
    class Conexion
    {

        SqlConnection conn;
        SqlCommand cmd;
        SqlDataReader dr;
        SqlDataAdapter da;
        DataTable dt;


    // CONTRUCTOR PARA INICIAR LA CONEXION
        public Conexion()
        {
            try
            {
                conn = new SqlConnection(Properties.Settings.Default.conexion);
                conn.Open();
            }
            catch (Exception e)
            {
                MessageBox.Show("No es posible conetarse a la Base de Datos: " + e.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
            }
        }

    //METODO INSERTAR CLIENTE
        public void insertarCliente(String dni_cif, String nombre, String domicilio, String poblacion)
        {

            try
            {
                cmd = new SqlCommand("INSERT INTO Clientes VALUES ('" + dni_cif + "', '" + nombre + "', '" + domicilio + "', '" + poblacion + "')", conn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error al insertar el cliente" + e.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    // CARGO LOS CLIENTES
        public ArrayList cargarClientes()
        {
            ArrayList clientes = new ArrayList();

            cmd = new SqlCommand("SELECT * FROM Clientes", conn);
            dr = cmd.ExecuteReader();

        //SI TIENE FILAS LEELO
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    Cliente cl = new Cliente(dr.GetString(0), dr.GetString(1), dr.GetString(2), dr.GetString(3));
                    clientes.Add(cl);
                }
            }
            return clientes;
        }


    }
}
