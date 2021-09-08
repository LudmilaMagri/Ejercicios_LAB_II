using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_4
{
    public class Conductor
    {
        string nombre;
        int[] kms;

        /*public Conductor(string nombre)
        {
            this.nombre = nombre;
            kms = new int[7];
        }*/
        public Conductor(string nombre, int[] kmsCargados)
        {
            this.nombre = nombre;
            this.kms = kmsCargados;
        }
        public void CargarKm(int km, int dia)
        {
            kms[dia - 1] = km; //en la posicion 0 carga el dia 1 y asi
        }
        
    }
}
