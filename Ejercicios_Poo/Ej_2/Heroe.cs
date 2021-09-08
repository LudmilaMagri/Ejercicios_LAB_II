using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_2
{
    public class Heroe
    {
        string nombre;
        string poder;
        int nivelFuerza;
        bool esAyudante;

        public Heroe()
        {
            this.SetEsAyudante((this.GetNivelFuerza() < 50));
        }
        public Heroe(string nombre, string poder, int nivelFuerza)
        {
            this.SetNombre(nombre);
            this.SetPoder(poder);
            this.SetNivelFuerza(nivelFuerza);
            //si es menor a 50 me retorna un bool
        }

        public string GetNombre()
        {
            return this.nombre;
        }
        public bool SetNombre(string nombre)
        {
            if (string.IsNullOrEmpty(nombre))
                return false;

            this.nombre = nombre;
            return true;
        }
        public string GetPoder()
        {
            return this.poder;
        }
        public bool SetPoder(string poder)
        {
            if (!string.IsNullOrEmpty(poder))
                return false;
            
            this.poder = poder;
            return true;
        }
        public int GetNivelFuerza()
        {
            return this.nivelFuerza;
        }
        public void SetNivelFuerza(int? fuerza)
        {
        // int? variable que acepta nulos. 
            if (fuerza.HasValue && fuerza >= 0)
                this.nivelFuerza = fuerza.Value;
        }
        public bool GetEsAyudante()
        {
            return this.esAyudante;
        }
        public void SetEsAyudante(bool ayudante)
        {
            this.esAyudante = ayudante;
        }

        public string HeroeToString()
        {
            return $"Nombre: {this.GetNombre()}\nPoder: {this.GetPoder()}\nNivel fuerza: {this.GetNivelFuerza()}\nEs ayudante: {this.GetEsAyudante()}";
        }


    }


}
