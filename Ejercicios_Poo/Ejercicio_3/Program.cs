using System;

namespace Ejercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Cuenta cuenta1 = new Cuenta("Tito", 450);

            Console.WriteLine("Ingrese cantidad");
            cuenta1.Ingresar = Convert.ToDouble(Console.ReadLine());


        }
    }
}
