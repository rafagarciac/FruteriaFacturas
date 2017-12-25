using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FruteriaFacturas
{
    class Cliente
    {

        private String dni_cif, nombre, domicilio, poblacion;

        public Cliente() { }

    // CONSTRUCTOR SOBRECARGADO
        public Cliente(String dni_cif, String nombre, String domicilio, String poblacion)
        {
            this.dni_cif = dni_cif;
            this.nombre = nombre;
            this.domicilio = domicilio;
            this.poblacion = poblacion;
        }

    // METODOS GETTER Y SETTER
        public String getDni_Cif()
        {
            return this.dni_cif;
        }
        public String getNombre()
        {
            return this.nombre;
        }
        public String getDomicilio()
        {
            return this.domicilio;
        }
        public String getPoblacion()
        {
            return this.poblacion;
        }

        public void setDni_Cif(String dni_cif)
        {
            this.dni_cif = dni_cif;
        }

        public void setNombre(String nombre)
        {
            this.nombre = nombre;
        }
        public void setDomicilio(String domicilio)
        {
            this.domicilio = domicilio;
        }
        public void setPoblacion(String poblacion)
        {
            this.poblacion = poblacion;
        }


    }
}
