using System;

namespace Ejercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona persona1 = new Persona();
            Persona persona2 = new Persona();
            Persona persona3 = new Persona();

            persona1.SetNombre("Paula");
            persona1.SetDni(34222111);
            persona1.SetEdad(4);

            persona2.SetNombre("Laura");
            persona2.SetDni(23333222);
            persona2.SetEdad(33);

            persona3.SetNombre("Marina");
            persona3.SetDni(44667234);
            persona3.SetEdad(45);

            persona1.MostrarDatos();
            persona1.esMayorDeEdad(); 
            persona2.MostrarDatos();
            persona2.esMayorDeEdad();
            persona3.MostrarDatos();
            persona3.esMayorDeEdad();
            

        }
    }
}
