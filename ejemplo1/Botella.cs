using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo1
{
    internal class Botella
    {
        //Botella: capacidad, color, material.

        private int capacidad;
        private string color;
        private string material;

        //PROPIEDAD:
        //para la creación de una propiedad, realizaremos un metodo "public" del tipo entero y entre llaves se definirarn el 
        //"getter" y el "setter" de la (o las) propiedades en cuestion:
        
        public int Capacidad
        {
            get { return capacidad; }
            set { capacidad = value;  }
        }

        //el valor asignado directamente al nombre del atributo cual variable, en el "main" sera el valor o "value" que recibira 
        //el setter dentro de las llaves para dicho atributo (en este caso, capacidad). el getter, por su parte, se limitara a 
        //retornar el valor que dicho atributo tenga guardado para ser leido desde el exterior.
    }
}
