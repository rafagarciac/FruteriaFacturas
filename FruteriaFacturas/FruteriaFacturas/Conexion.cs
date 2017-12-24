using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Data.Sql;

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

        public String insertarCliente(String dni_cif, String nombre, String domicilio, String poblacion)
        {

            String salida = "Se ha Insertado Correctamente";

            try
            {
                cmd = new SqlCommand("INSERT INTO Clientes VALUES ('" + dni_cif + "', '" + nombre + "', '" + domicilio + "', '" + poblacion + "')", conn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                salida = "Error de Insercion: " + e.ToString();
                // MessageBox.Show("No se puede insertar cliente " + e.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return salida;

        }


    }
}
