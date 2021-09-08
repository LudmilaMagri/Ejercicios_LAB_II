using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sobrecargas
{
    class Usuario
    {
        string nombre;
        string contra;
        int dni;

        //constructor : es lo que se necesita para que el objeto exista
        //siempre prioriza el constructor que pusiste despues del : this
        //hay que ponerlo en privado el constructor para que no se pueda acceder desde otra clase(program)
        //constructor encapsulado

        // : this () -> busca por tipo de dato. En el constructor

        public Usuario(string nombre, string contra, int dni)
        {
            this.nombre = nombre;
            this.contra = contra;
            this.dni = dni;
        }

        public string UsuarioToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre usuario - {this.nombre}");
            sb.AppendLine($"Contra - {this.contra}");
        }


    }
}
