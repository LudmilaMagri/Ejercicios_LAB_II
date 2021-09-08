using System;
#region Ejercicio
/*1. Dentro de un proyecto de tipo Consola, agregar una clase propia llamada Héroe, y definirla
de la siguiente manera:
    class Heroe
    string nombre;
    string poder;
    int nivelFuerza;
    bool esAyudante;

a. Todos los atributos deben ser privados, crear métodos set para todos.
● Validar que las cadenas no estén vacías antes de asignarlas.
● Validar que los enteros no sean negativos antes de asignarlos.
b. Método constructor que reciba todos los parámetros menos el atributo esAyudante,
para determinar este último utilizar el atributo nivelFuerza, si este es menor a 50
esAyudante deberá ser inicializado en true.
c. Metodo HeroeToString(), deberá retornar una cadena con los datos del personaje.
d. Instanciar 3 héroes en el main, mostrarlos por consola.
2. Partiendo del ejercicio anterior, agregar la clase Universo:
class Universo
int cantidadHeroes;
Heroe[] heroes;
El método constructor de la clase Universo solo recibe por parámetro el entero cantidadHeroes,
utilizarlo para instanciar el array de Héroes.
a. Método estático AgregarHeroe, el mismo recibirá un objeto de tipo Héroe y lo
asignará en la primera posición libre del array heroes, validar también que no se exceda
el límite representado por cantidadHeroes.
b. Método estático Enfrentar, el mismo debe recibir dos ints randoms y retornar un string.
● Ambos enteros representan posiciones en el array de héroes.
● Se debe validar que estos enteros no sean negativos, ni más grandes que el
tamaño del array
● Obtener ambos objetos representados en estas posiciones, si alguno de los
dos es ayudante, se lo va a considerar perdedor. En caso de que ambos sean
ayudantes o no ayudantes, determinar el ganador basándose en el atributo
nivelFuerza.
● El método retorna el nombre del Heroe ganador (modificar la clase Heroe para
tener visibilidad del atributo nombre desde otra clase, generando su respectivo
método get).
● En caso de que ambos niveles de fuerza sean iguales, el método Enfrentar
retornara “empate”.
Agregar al Program el código necesario para probar la nueva clase Universo.
 */

#endregion
namespace Entidades
{
    class Program
    {
        static void Main(string[] args)
        {
            Heroe h1 = new Heroe("Batman", "Fuerza", 100);
            Heroe h2 = new Heroe("Acuaman", "Nadar", 20);
            Heroe h3 = new Heroe("Flash", "Correr", 45);

            Universo universo;
            Heroe[] miHeroe;

            universo = h1;
            miHeroe = (Heroe[])universo;
            universo = (Universo)6;


            Console.WriteLine(h1.HeroeToString());
            Console.WriteLine(h2.HeroeToString());
            Console.WriteLine(h3.HeroeToString());

            Console.ReadLine();
        }
    }
}
