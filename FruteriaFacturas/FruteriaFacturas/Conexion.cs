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
                MessageBox.Show("Error al Modificar el Cliente" + e.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    // METODO MODIFICAR ALBARAN
        public void modificarAlbaran(DateTime fecha_Albaran, int idFactura, string dni_cifAlbaran, string subtotal, string total, String idAlbaran)
        {
            try
            {
                cmd = new SqlCommand("UPDATE Albaranes SET fechaAlbaran = '" + fecha_Albaran + "', idFactura = " + idFactura.ToString() + ", dni_cif = '" + dni_cifAlbaran + "', subtotal = " + subtotal + ", total = " + total + " WHERE idAlbaran = " + idAlbaran, conn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error al Modificar el Albaran" + e.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    // METODO MODIFICAR LINEA EN ALBARAN X
        public void modificarLinea(string cantidad, string unidad, string producto, string precio, string importe, string old_producto, string idAlbaran)
        {
            try
            {
                cmd = new SqlCommand("UPDATE Lineas SET cantidad = " + cantidad + ", unidad = '" + unidad + "', descripcion_producto = '" + producto + "', precio_unitario = " + precio + ", importe = " + importe + " WHERE descripcion_producto = '" + old_producto + "' AND idAlbaran = " + idAlbaran, conn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error al Modificar la linea: " + producto + "en Albaran " + idAlbaran + " " + e.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //METODO MODIFICAR SUBTOTAL Y TOTAL DE ALBARAN
        internal void modificarImporteAlbaran(string subtotal, string total, string idAlbaran)
        {
            try
            {
                cmd = new SqlCommand("UPDATE Albaranes SET subtotal = " + subtotal + ", total = " + total + " WHERE idAlbaran = " + idAlbaran, conn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error al Modificar el Albaran: " + idAlbaran + " " + e.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

    // METODO BORRAR ALBARAN
        public void borrarAlbaran(string idAlbaran)
        {
            try
            {
                cmd = new SqlCommand("DELETE FROM Albaranes WHERE idAlbaran = " + idAlbaran, conn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error al Borrar el Albaran" + e.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // METODO BORRAR LINEA DEL ALBARAN X
        internal void borrarLinea(string producto, string idAlbaran)
        {
            try
            {
                cmd = new SqlCommand("DELETE FROM Lineas WHERE descripcion_producto = '" + producto + "' AND idAlbaran = " + idAlbaran, conn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error al Borrar la linea: " + producto + "en Albaran " + idAlbaran + " " + e.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    // METODO INSERTAR ALBARAN
        internal void insertarAlbaran(int idAlbaran, DateTime fechaAlbaran, int idFactura, string dni_cifAlbaran, String subtotal, String total)
        {
            try{

                cmd = new SqlCommand("INSERT INTO Albaranes VALUES (" + idAlbaran + ", '" + fechaAlbaran + "', " + idFactura + ", '" + dni_cifAlbaran + "', " + subtotal + ", " + total + ")", conn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error al Insertar Albaran" + e.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    // METODO INSERTAR LINEAS
        public void insertarLinea(String cantidad, string unidad, string producto, String precio_unitario, String importe, int idAlbaran)
        {
            try
            {
                cmd = new SqlCommand("INSERT INTO Lineas VALUES (" + cantidad + ", '" + unidad + "', '" + producto + "', " + precio_unitario + ", " + importe + ", " + idAlbaran + ")", conn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error al Insertar Linea" + e.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        // CARGO LAS LINEAS DEL ALBARAN X
        public ArrayList cargarLineasAlbaran(String idAlbaran)
        {
            ArrayList lineas = new ArrayList();

            cmd = new SqlCommand("SELECT ln.* " +
                                 "FROM Albaranes al JOIN Lineas ln " +
                                 "ON al.idAlbaran = ln.idAlbaran " +
                                 "WHERE al.idAlbaran = " + idAlbaran , conn);
            dr = cmd.ExecuteReader();

            //SI TIENE FILAS LEELO
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    Linea linea = new Linea(dr.GetDouble(0), dr.GetString(1), dr.GetString(2), dr.GetDouble(3), dr.GetDouble(4));
                    lineas.Add(linea);
                }
            }
            dr.Close();
            return lineas;
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

    //   

    //METODO QUE SACA LA ULTIMA FACTURA 
        public int ultimaFactura()
        {
            int idFactura= 0;

            cmd = new SqlCommand("SELECT MAX(idFactura) FROM Facturas", conn);
            dr = cmd.ExecuteReader();

            //SI TIENE FILAS LEELO
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    idFactura = dr.GetInt32(0);
                }
            }
            dr.Close();

            return idFactura;
        }


    }
}
