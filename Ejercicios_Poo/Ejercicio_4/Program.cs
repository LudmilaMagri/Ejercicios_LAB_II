using System;

namespace Ejercicio_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Conductor conductor1 = new Conductor("PEPE");

            for (int i = 0; i < 7; i++)
            {
                Console.WriteLine($"Cargar dia numero {i + 1}");
                conductor1.CargarKm(400, 1);
            }
            conductor1.CargarKm(400, 1);
            conductor1.CargarKm(500, 2);
            conductor1.CargarKm(453, 3);
            conductor1.CargarKm(200, 4);


            /* int[] kmAux = new int[7];

             kmAux[0] = 200;
             kmAux[1] = 200;
             kmAux[2] = 200;
             kmAux[3] = 200;
             kmAux[4] = 200;
            */

            //int[] kmAux = { 300, 40, 20, 500, 600 };


          /*  int[] kmAux = new int[7]
            {
                300,500,200,50,10,45,3
            };
          */
        }


    }
}
