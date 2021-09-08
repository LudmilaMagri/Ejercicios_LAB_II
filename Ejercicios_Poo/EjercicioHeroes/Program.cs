using System;

namespace EjercicioHeroes
{
    class Program
    {
        static void Main(string[] args)
        {
            Heroe h1 = new Heroe("Batman", "Fuerza", 100);
            Heroe h2 = new Heroe("Acuaman", "Nadar", 20);
            Heroe h3 = new Heroe("Flash", "Correr", 45);

           Universo universo = new Universo(3);
            /*
                        Universo universo;
                        Heroe miHeroe;

                        universo = h1;
                        bool salida = universo + h2;
                        salida = universo + h3;
                        universo = (Universo)6;
                        miHeroe = (Heroe)universo;
            */
            Console.WriteLine(h1.HeroeToString());
            Console.WriteLine(h2.HeroeToString());
            Console.WriteLine(h3.HeroeToString());

            Console.ReadLine();
        }
    }
}
