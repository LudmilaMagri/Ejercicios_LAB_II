using System;

namespace Ejercicios
{
    class Program
    {
        static void Main(string[] args)
        {
          // VER  Alumno array = Alumno[4];

            Alumno alumno1 = new Alumno("Marcos", "Etchebest", 9, 10);
            Alumno alumno2 = new Alumno("Pepe", "Perez", 6, 8);
            Alumno alumno3 = new Alumno("Maria", "Lopez", 7, 5);

            Console.WriteLine($"Nota1 : " + alumno1.MostrarPromedio());
            Console.WriteLine($"Nota2 : " + alumno2.MostrarPromedio());
            Console.WriteLine($"Nota3 : " + alumno3.MostrarPromedio());
        }
    }
}
