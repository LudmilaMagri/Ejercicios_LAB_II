using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_3
{
    class Cuenta
    {
        string titular;
        float cantidad;

        public Cuenta(string titular, float cantidad)
        {
            this.titular = titular;
            this.cantidad = cantidad;
        }

        public void Mostrar()
        {
            Console.WriteLine($"Titular: {this.titular} Cantidad: {this.cantidad}");
        }

        public void Ingresar(float auxCantidad)
        {
            if (auxCantidad > 0)
            {
                this.cantidad = this.cantidad + auxCantidad;
            }
        }

        public void Retirar(float auxCantidad)
        {
            if (this.cantidad>0)
            {
                this.cantidad = this.cantidad - auxCantidad;
            }
        }
        
    }
}
