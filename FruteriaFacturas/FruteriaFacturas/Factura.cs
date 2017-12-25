using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FruteriaFacturas
{
    class Factura
    {

        /// <summary>
        ///  FK --> dni_cif del cliente
        /// </summary>
        
        private int idFactura;
        private String dni_cif;
        private DateTime fechaFactura;
        private double subtotal, total;

        public Factura() { }

        // CONSTRUCTOR SORECARGADO
        public Factura(int idFactura, DateTime fechaFactura, double subtotal, double total, String dni_cif)
        {
            this.idFactura = idFactura;
            this.fechaFactura = fechaFactura;
            this.subtotal = subtotal;
            this.total = total;
            this.dni_cif = dni_cif;
        }


        // METODOS GETTER Y SETTER
        public int getIdFactura()
        {
            return this.idFactura;
        }

        public DateTime getFechaFactura()
        {
            return this.fechaFactura;
        }

        public double getSubtotal()
        {
            return this.subtotal;
        }

        public double getTotal()
        {
            return this.total;
        }
        
        public String getDni_Cif()
        {
            return this.dni_cif;
        }

        
        //***

        public void setIdFactura(int idFactura)
        {
            this.idFactura = idFactura;
        }

        public void setFechaFactura(DateTime fechaFactura)
        {
            this.fechaFactura = fechaFactura;
        }

        public void setSubtotal(double subtotal)
        {
            this.subtotal = subtotal;
        }

        public void setTotal(double total)
        {
            this.total = total;
        }

        public void setDni_Cif(String dni_cif)
        {
            this.dni_cif = dni_cif;
        }


    }
}
