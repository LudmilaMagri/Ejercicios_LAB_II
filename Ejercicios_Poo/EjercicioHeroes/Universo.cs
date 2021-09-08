using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioHeroes
{
    class Universo
    {
        int cantidadHeroes;
        Heroe[] heroes;

        public Universo(int cantidadHeroes)
        {
            if(cantidadHeroes>0)
             this.cantidadHeroes = cantidadHeroes;
            this.heroes = new Heroe[cantidadHeroes];
        }

        public static bool AgregarHeroe(Heroe heroe, Universo universo)
        {
            for (int i = 0; i < universo.heroes.Length; i++)
            {
                if (universo.heroes[i] is null)
                {
                    universo.heroes[i] = heroe;
                    break;
                }
            }
            return false;
        }

        public static string Enfrentar(int posicion1, int posicion2, Universo universo)
        {
            if (posicion1 > universo.heroes.Length || posicion2 > universo.heroes.Length || posicion1 < 0 || posicion2 < 0)
                return "";

            if (universo.heroes[posicion1].GetEsAyudante() != universo.heroes[posicion2].GetEsAyudante())
            {
                if(universo.heroes[posicion1].GetEsAyudante())
                {
                    return universo.heroes[posicion1].GetNombre();
                }
                else
                {
                    return universo.heroes[posicion2].GetNombre();
                }
            }

            if(universo.heroes[posicion1].GetNivelFuerza() > universo.heroes[posicion2].GetNivelFuerza())
            {
                return universo.heroes[posicion1].GetNombre();
            }
            else
            {
                return universo.heroes[posicion2].GetNombre();
            }
        }
            
    }
}
