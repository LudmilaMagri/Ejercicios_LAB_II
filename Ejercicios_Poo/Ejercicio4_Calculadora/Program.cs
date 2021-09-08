using System;

namespace Ejercicio4_Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculadora calculo = new Calculadora();
            
            int num1;
            int num2;
            char operando;
            bool respuesta;

            do
            {
                Console.WriteLine("Ingrese un numero");
                num1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese otro numero");
                num2 = int.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese operando");
                operando = char.Parse(Console.ReadLine());

                Console.Clear();


            } while (respuesta == true);
            


            


        }
    }
}
