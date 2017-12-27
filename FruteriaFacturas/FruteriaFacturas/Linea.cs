using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FruteriaFacturas
{
    class Linea
    {

        private double cantidad, precio_unitario;
        private String unidad, producto;

        public Linea() { }

        public Linea(double cantidad, String unidad, String producto, double precio_unitario)
        {
            this.cantidad = cantidad;
            this.unidad = unidad;
            this.producto = producto;
            this.precio_unitario = precio_unitario;
        }

        // METODOS GETTER / SETTER
        public double getCantidad()
        {
            return this.cantidad;
        }

        public String getUnidad()
        {
            return this.unidad;
        }

        public String getProducto()
        {
            return this.producto;
        }

        public double getPrecio_Unitario()
        {
            return this.precio_unitario;
        }

        public void setCantidad(double cantidad)
        {
            this.cantidad = cantidad;
        }

        public void setUnidad(String unidad)
        {
            this.unidad = unidad;
        }
        public void setProducto(String producto)
        {
            this.producto = producto;
        }
        public void setPrecio_Unitario(double precio_unitario)
        {
            this.precio_unitario = precio_unitario;
        }
    }
}
