using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_2
{
    public class Universo
    {
        int cantidadHeroes;
        Heroe[] heroes;

        public Universo(int cantidadHeroes)
        {
            if(cantidadHeroes > 0)
                 this.cantidadHeroes = cantidadHeroes;
            this.heroes = new Heroe[cantidadHeroes];
        }

        //enfatizar casteo. explicit cuando enfatiza y hay perdida de datos. 
        //objeto mas grande al mas chico, hay atributos que se descargan y que queden en el program
        //casteo implicito
        public static implicit operator Universo (Heroe heroe)
        {
            Universo universo = new Universo(1);
            //bool resultado = universo + heroe;
            AgregarHeroe(universo, heroe);
            return universo;
        }

        public static explicit operator Heroe[](Universo universo)
        {
            return universo.heroes;
        }
        public static bool operator +( Universo universo, Heroe heroe)
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
        public static bool AgregarHeroe(Universo universo, Heroe heroe)
        {
           return universo + heroe;
        }
        public static string Enfrentar(int posicion, int posicion2, Universo universo)
        {
            if(posicion >universo.heroes.Length || posicion2 > universo.heroes.Length || posicion<0 || posicion2<0)
                return "";
            
            if(universo.heroes[posicion].GetEsAyudante() != universo.heroes[posicion2].GetEsAyudante())
            {
                if(universo.heroes[posicion].GetEsAyudante())
                {
                    return universo.heroes[posicion].GetNombre();
                }
                else
                {
                    return universo.heroes[posicion2].GetNombre();
                }
            }
            if (universo.heroes[posicion].GetNivelFuerza() > universo.heroes[posicion2].GetNivelFuerza())
            {
                return universo.heroes[posicion].GetNombre();
            }
            else
                return universo.heroes[posicion2].GetNombre();

        }
    }
}
