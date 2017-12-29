using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FruteriaFacturas
{
    public class Albaran
    {
        /// <summary>
        ///  FK --> idfactura y dni_cif
        /// </summary>
        
        private int idAlbaran, idFactura;
        private String dni_cif;
        private DateTime fechaAlbaran;
        private double subtotal, total;

        public Albaran() { }

        // CONSTRUCTOR SORECARGADO
        public Albaran(int idAlbaran, DateTime fechaAlbaran, int idFactura, String dni_cif, double subtotal, double total)
        {
            this.idAlbaran = idAlbaran;
            this.fechaAlbaran = fechaAlbaran;
            this.idFactura = idFactura;
            this.dni_cif = dni_cif;
            this.subtotal = subtotal;
            this.total = total;
        }


        // METODOS GETTER Y SETTER
        public int getIdAlbaran()
        {
            return this.idAlbaran;
        }

        public DateTime getFechaAlbaran()
        {
            return this.fechaAlbaran;
        }

        public int getIdFactura()
        {
            return this.idFactura;
        }

        public String getDni_Cif()
        {
            return this.dni_cif;
        }

        public double getSubtotal()
        {
            return this.subtotal;
        }

        public double getTotal()
        {
            return this.total;
        }

        //***

        public void setidAlbaran(int idAlbaran)
        {
            this.idAlbaran = idAlbaran;
        }

        public void setFechaAlbaran(DateTime fechaAlbaran)
        {
            this.fechaAlbaran = fechaAlbaran;
        }

        public void setIdFactura(int idFactura)
        {
            this.idFactura = idFactura;
        }

        public void setDni_Cif(String dni_cif)
        {
            this.dni_cif = dni_cif;
        }

        public void setSubtotal(double subtotal)
        {
            this.subtotal = subtotal;
        }

        public void setTotal(double total)
        {
            this.total = total;
        }

    }
}
