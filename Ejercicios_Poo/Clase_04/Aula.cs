using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_04
{
    class Aula
    {
        string nombreAula;
        Alumno[] alumnado;

        private Aula()
        {
            alumnado = new Alumno[30];
        }
        public Aula(string nombreAula):this()
        {
            this.nombreAula = nombreAula;
        }
        public Aula(string nombreAula, Alumno[] alumnado):this(nombreAula)
        {
            this.alumnado = alumnado;
        }
        //este comunica al de arriba y asi

        /// <summary>
        ///  Este metodo agrega un alumno al aula siempre y cuando haya espacio
        /// </summary>
        /// <param name="auxAlum"></param>
        /// <returns></returns>
        public bool AgregarAlumnoAlAula(Alumno auxAlum)
        {
            //bool resultado = false;
            for (int i = 0; i < alumnado.Length; i++)
            {
                if (alumnado[i] == null)
                {
                    alumnado[i] = auxAlum;
                    return true;
                    //resultado = true;
                    //break;
                }
            }
            return false;
            //return resultado;
        }

        //sobrecarga del operador +

        //metodo de instancia : 
        //
        public static bool operator +(Aula auxAula, Alumno auxAlumno)
        {
            for (int i = 0; i < auxAula.alumnado.Length; i++)
            {
                if (auxAula.alumnado[i] == null)
                {
                    auxAula.alumnado[i] = auxAlumno;
                    return true;
                    //resultado = true;
                    //break;
                }
            }
            return false;
        }

    }
}
