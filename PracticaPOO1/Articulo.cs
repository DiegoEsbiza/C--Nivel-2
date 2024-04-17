using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaPOO1
{
    internal class Articulo
    {
        public Articulo(int codArticulo, int precio) // CONSTRUCTOR
        {
            this.codArticulo = codArticulo; //por medio del "puntero THIS", se esta especificando que "codArticulo" es el declarado
            this.precio = precio;           //como atributo del objeto y NO el que se recibe por parametro, ese sera el que se 
                                            //guardara dentro del atributo privado
        }

        private int codArticulo;
        private int precio;
        //- Código de Artículo(4 dígitos, no correlativos).
        //- Precio Unitario.

    }
}
