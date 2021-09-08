using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios
{
    class Alumno
    {
        string nombre;
        string apellido;
        float nota1;
        float nota2;

        public Alumno(string nombre, string apellido, float nota1, float nota2)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.nota1 = nota1;
            this.nota2 = nota2;
        }

        public float MostrarPromedio()
        {
            float resultado;
            resultado = (this.nota1 + this.nota2) / 2;
            return resultado;
        }
    }
}
