using System;

namespace Clase_04
{
    class Program
    {
        static void Main(string[] args)
        {
            Aula aula1 = new Aula("2E");
            Alumno alumno1 = new Alumno("Juan", 23443);
            Alumno alumno2 = new Alumno("Juan", 23443);

           /* if(aula1.AgregarAlumnoAlAula(alumno1))
            {
                Console.WriteLine("Alumno agregado");
            }
            else
            {
                Console.WriteLine("alumno no agregado");
            }
           */

           //agregar una nueva funcionalidad a un metodo predefinido anteriormente

            //lograr que el alumno sea agregado al aula como hicimos en el for
            if (aula1+ alumno1)
            {
                Console.WriteLine("Alumno agregado");
            }
            else
            {
                Console.WriteLine("alumno no agregado");
            }

            if (alumno1 == alumno2)
            {
                Console.WriteLine("Alumno agregado");
            }
            else
            {
                Console.WriteLine("alumno no agregado");
            }

        }
    }
}
