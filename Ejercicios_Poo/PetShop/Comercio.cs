using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShop
{//los atributos y metodos son staticos: se va a acceder a la clase desde memoria
    public static class Comercio
    {
        static string nombre;
        static string direccion;
        static long cuit;
        static string razonSocial;
        static Factura[] facturas;

        static Comercio()
        {
            nombre = "Pepito";
            direccion = "Calle falsa 1234";
            cuit = 345345353;
            razonSocial = "Patitas";
        }

        public static void SetNombre(string nombreNuevo)
        {
            
            Comercio.nombre = nombreNuevo;
        }
        public static string GetNombre()
        {
            return nombre;
        }

        public static string GetDireccion()
        {
            return direccion;
        }
        public static long GetCuit()
        {
            return cuit;
        }
        public static string GetRazonSocial()
        {
            return razonSocial;
        }
    }
}
