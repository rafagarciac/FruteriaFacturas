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

        //METODO MODIFICAR CLIENTE
        public void modificarCliente(String dni_cifOld, String dni_cifNew, String nombre, String domicilio, String poblacion)
        {

            try
            {
                cmd = new SqlCommand("UPDATE Clientes SET dni_cif = '" + dni_cifNew + "', nombre = '" + nombre + "', domicilio = '" + domicilio + "', poblacion = '" + poblacion + "' WHERE dni_cif like '" + dni_cifOld + "'", conn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error al Modificar el cliente" + e.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    //METODO BORRAR CLIENTE
        public void borrarCliente(String dni_cif)
        {
            try
            {
                cmd = new SqlCommand("DELETE FROM Clientes WHERE dni_cif like '" + dni_cif + "'", conn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error al Borrar el cliente" + e.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            dr.Close();
            return clientes;
        }

    // CARGO LOS ALBARANES
        public ArrayList cargarAlbaranes()
        {
            ArrayList albaranes = new ArrayList();

            cmd = new SqlCommand("SELECT * FROM Albaranes", conn);
            dr = cmd.ExecuteReader();

            //SI TIENE FILAS LEELO
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    Albaran albaran = new Albaran(dr.GetInt32(0), dr.GetDateTime(1), dr.GetInt32(2), dr.GetString(3), dr.GetDouble(4), dr.GetDouble(5));
                    albaranes.Add(albaran);
                }
            }
            dr.Close();
            return albaranes;
        }

        // CARGO LAS FACTURAS
        public ArrayList cargarFacturas()
        {
            ArrayList facturas = new ArrayList();

            cmd = new SqlCommand("SELECT * FROM Facturas", conn);
            dr = cmd.ExecuteReader();

            //SI TIENE FILAS LEELO
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    Factura factura = new Factura(dr.GetInt32(0), dr.GetDateTime(1), dr.GetDouble(2), dr.GetDouble(3), dr.GetString(4));
                    facturas.Add(factura);
                }
            }
            dr.Close();
            return facturas;
        }

    //LISTO LOS CLIENTES EN EL GRIDVIEW ALTACLIENTE
        public void listarClientesGridView(DataGridView dgv)
        {
            try
            {

                da = new SqlDataAdapter("SELECT * FROM Clientes", conn);
                dt = new DataTable();

                //Lleno el DataTable
                da.Fill(dt);

                //Lleno el DataGridView
                dgv.DataSource = dt;

            }
            catch (Exception e)
            {
                MessageBox.Show("Error al listar: " + e.ToString());
            }
        }
        /*
    // LISTO LAS LINEAS DEL Nº ALBARAN PASADO POR PARAMETROS
        public void listarClientesGridView(int n_Albaran, DataGridView dgv)
        {
            try
            {

                da = new SqlDataAdapter("SELECT ln.* " + 
                                        "FROM Albaranes al JOIN Lineas ln " + 
                                        "ON al.idAlbaran = ln.idAlbaran " +
                                        "WHERE al.idAlbaran = " + n_Albaran, conn);
                dt = new DataTable();

                //Lleno el DataTable
                da.Fill(dt);

                //Lleno el DataGridView
                dgv.DataSource = dt;

            }
            catch (Exception e)
            {
                MessageBox.Show("Error al listar: " + e.ToString());
            }
        }
         * */

        //METODO QUE SACA EL ULTIMO ALBARAN Y LO INCREMENTA 
        public int nuevoAlbaran()
        {
            int nuevo = 0;

            cmd = new SqlCommand("SELECT MAX(idAlbaran) FROM Albaranes", conn);
            dr = cmd.ExecuteReader();

            //SI TIENE FILAS LEELO
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    nuevo = dr.GetInt32(0);
                }
            }
            dr.Close();

            // INCREMENTO EL idAlbaran 
            nuevo++;
            // MessageBox.Show(nuevo.ToString());

            return nuevo;
        }

    }
}
