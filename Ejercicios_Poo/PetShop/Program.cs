using System;

/*
 * C
 
 */

namespace PetShop
{
    class Program
    {
        static void Main(string[] args)
        {
            int cantidad = 0;

            Console.WriteLine("Ingrese la cantidad de items\n");
            string cantidadString = Console.ReadLine();

            int.TryParse(cantidadString, out cantidad);
            Factura[] factura = new Factura[3];
            DetalleFactura[] detalles = new DetalleFactura[cantidad];


            for (int i = 0; i < cantidad; i++)
            {
                Console.WriteLine("\nIngrese el nombre del producto\n");
                string nombre = Console.ReadLine();
                Console.WriteLine("\nIngrese la cantidad del producto\n");
                string cantProducto = Console.ReadLine();
                Console.WriteLine("\nIngrese el precio del producto\n");
                string precioUnit = Console.ReadLine();

                detalles[i] = new DetalleFactura(int.Parse(cantProducto), nombre, float.Parse(precioUnit));
            }

            factura[0] = new Factura(new DateTime(), detalles);
            factura[1] = new Factura(new DateTime(), detalles);
            factura[2] = new Factura(new DateTime(), detalles);

            //

            Console.WriteLine(factura[0].RetornarFactura());
            Console.WriteLine(factura[1].RetornarFactura());
            Console.WriteLine(factura[2].RetornarFactura());

            Console.ReadLine();
        }
    }
}
