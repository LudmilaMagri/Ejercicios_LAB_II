using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2
{
    class Persona
    {
        string nombre;
        int edad;
        int dni;

        //public Persona(string nombre, int edad, int dni)
        //{
        //    this.nombre = nombre;
        //    this.edad = edad;
        //    this.dni = dni;
        //}

        public string GetNombre ()
        {
            return this.nombre;
        }

        public int GetEdad()
        {
            return this.edad;
        }

        public int GetDni()
        {
            return this.dni;

        }
        public void SetNombre(string newName)
        {
            this.nombre = newName;
        }
        public void SetEdad(int newEdad)
        {
            if (newEdad>0)
            this.edad = newEdad;
        }
        public void SetDni (int newDni)
        {
            this.dni = newDni;
        }
       
        public void MostrarDatos()
        {
            Console.WriteLine($"Nombre: {this.nombre} Edad: {this.edad} Dni: {this.dni}");
        }

        public void esMayorDeEdad()
        {
            if (this.edad >= 18)
            {
                Console.WriteLine("Es mayor de edad\n");
            }
            else
            {
                Console.WriteLine("Es menor de edad\n");
            }

        }
    }
}
