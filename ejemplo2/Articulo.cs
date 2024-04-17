using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo2
{
    internal class Articulo
    {
        //-Codigo de articulo (3 digitos no correlativos)
        //-Precio
        //-Codigo de marca (1 a 10)


        //Para este caso, para poder manipular los atributos (en este caso el codigo de Articulo):

        //  ---> private int codArticulo;

        //Lo que se hara sera escribir: "prop" y tocar "TAB" para cambiar el tipo y "TAB" nuevamente para ponerle el nombre a
        //la propiedad. Es una manera reducida, simplificada, de crearla.

        public int CodigoArticulo { get; set; }

        // ---> private float precio;

        public float Precio { get; set; }

        //Tambien se podria crear una propiedad de "solo lectura", es decir, con una variable pre definida y sin un "SET" que
        //permitiese manipularla, quedando de esta manera:

        //public int codArticulo { get }

        //En este caso, el codArticulo sera una variable "constante" y la propiedad tendra UNICAMENTE un "GETTER" para poder leer
        //El valor de la misma sin ser modificada en ningun momento.
        
        //Estas propiedades ya pueden ser utilizadas como se requiera en el programa principal.
        //En este caso, por medio de esta manera corta se creara la "propiedad" mas no el "atributo" propiamente dicho.
        //Como limitación, al crear la propiedad de este modo, NO se podra manipular el "GETTER" y el "SETTER", es decir
        //no se le podran crear distintas acciones como si se podra realizar en el siguiente ejemplo con el codigo de marca:

        private int codMarca;

        public int CodMarca
        {
            get { return codMarca; }
            set 
            {   //teniendo en cuenta que la consigna pide un valor entre 1 y 10, se agregara una evaluación del value:
                if (value > 0 && value < 11)
                    codMarca = value;
                else
                    codMarca = -1;
                //si el número ingresado (value) es mayor a 1 y menor a 11, sera cargado en el codigo de marca
                //si estuviera fuera de ese rango, se cargara el valor -1, indicando que se ingreso un valor incorrecto
            }
        }

        //teniendo esta propiedad creada con esta validacion, se puede proceder a crear un vector de articulos para poder guardar
        //los codigos de marca que iran del 1 al 10 (ver MAIN)
    }
}
