using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo1
{
    internal class Persona
    {
        //Persona: edad, sueldo, nombre.

        //Persona: edad, sueldo, nombre. (estructura de la persona)
        //atributos o miembros

        //datos que conforman a la "Persona"
        private int edad;
        private float sueldo;
        private string nombre;

        //modificadores de visbilidad: Son palabras reservadas que permiten calificar un atributo, clase o funcion
        //como "privado", "publico", "protegido", "internal", etc. siendo los principales "publico" y "privado".

        //Mediante los metodos "set" (setear/asignar/modificar) y "get" (obtener) se crearan a continuación los metodos para
        //poder asignarle, indirectamente, un valor a los atributos anteriormente creados (en este caso, el metodo "setEdad") y a
        //continuación, otro metodo para poder obtener/leer el valor del mismo (en este caso, el metodo sera "getEdad")
        public void setEdad(int e)//se crea una función "publica" para que pueda ser accedida desde el exterior, del tipo "void"
        {                         //porque se trata de una función/metodo que no retornara ningun valor, se pedira como argumento
            edad = e;             //un entero "e" (edad), y dentro de las llaves se le asignara directamente el valor a la
                                  //variable edad (en este caso, se le asignara el entero "e" en referencia a la "edad").
                                  //el valor "e" llegara enviado desde el exterior, en este caso, el "main".
        }   

        public int getEdad()//Se crea una función pulica del tipo "int" con el nombre getEdad(), sin agregar ningun tipo de dato
        {                   //ya que este metodo se limitara exclusivamente a retornar el valor entero solicitado.
            return edad;
        }
    }
}
