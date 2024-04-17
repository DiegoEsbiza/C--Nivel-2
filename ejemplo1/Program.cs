using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//programación orientada a objetos (POO):

//Es un paradigma de programación, que propone abordar problematicas mas amplias, de mayor magnitud o de poder
//presentar distinto tipo de soluciones o propuestas para aplicar a distintos escenarios con una mayor amplitud o
//alcance.
//una de las principales caracteristicas de la POO es la idea de representar la realidad y llevarla a lo digital
//mediante este paradigma y poder trabajar y administrar toda la información que vamos a poder obtener a partir 
//construir estos modelos

//Clases:

//Una clase, en su definición tecnica, es una plantilla o estructura que define un modelo u objeto.
//al definir una clase, lo que se escribe es un bloque de codigo que va  a definir una estructura de algo que se 
//buscara representar, un objeto o algo de la realidad que se diseñara digitalmente.
//En el nivel uno, se trabajaba con información ingresada mediante lotes de registro. De ahora en mas, se tomara la
//información de esos registros y se construiran un solo tipo de datos a partir de ellos.

//Ejemplo:
//Si quisiera construir una botella tendre que tener en cuenta todas sus caracteristicas y tomar nota de ellas para
//llevarlas a lo digital, caracteristicas como su nombre (botella) su formato (cilindrico, rectangular, cubico, etc)
//su capacidad, el material con el que esta construido, etc. A partir de estas caracteristicas, de ahora en mas
//llamados atributos, tendre distintos tipos de variables del tipo "botella" (clase botella) con distintos atributos
//para cada una de ellas:

//  *botellas cilindricas de metal de un litro de capacidad
//  *botellas rectangulares de vidrio con medio litro de capacidad.
//  *botellas conicas de plastico con un cuarto de litro de capacidad.

//Teniendo ya esta definicion de este objeto de la realidad, la botella con sus caracteristicas, podemos decir que
//tenemos ya la definició n de nuestra clase "botella". A partir de esta clase se podra generar distintos objetos
//o variables que permitiran tener distintos objetos que se digitalizaran en la aplicación.

namespace ejemplo1
{   
    internal class Program      //clase inicial
    {
        static void Main(string[] args)     //una clase puede tener una o varias funciones
        {
            //Persona: edad, sueldo, nombre. (estructura de la persona)

            int[] edades = new int[10];
            float[] sueldos = new float[10];
            string[] nombre = new string[10];

            Persona p1 = new Persona();  //clase Persona con objeto p1 (persona 1)

            //Encapsulamiento:
            //El encapsulamiento es una caracteristica de los atributos de una clase, este define que los miembros o atributos
            //de una clase no debe bajo niungun punto de vista, poder ser accedido desde el exterior de la misma directamente,
            //ya que se considera que dichos atributos son iformación sensible, por lo tanto, deben permanecer ocultos al exterior. 
            //para poder acceder se utilizaran los mecanismos "GET" y "SET"

            p1.setEdad(48);

            //El metodo "setEdad" fue creado en la clase "Persona" y, por tanto, le pertenece. Al invocar el metodo "setEdad()" y
            //agregar el número (48 en este caso) dentro de los parentesis, lo que ocurre es que al atributo "edad" derivado del 
            //objeto p1 (recordar que el objeto nace a partir del "molde" creado en la clase "Persona") se le esta asignando un
            //valor, en este caso, el entero "48"

            p1.getEdad();

            //En este caso, el metodo "getEdad" se limitara unicamente a recibir el valor del atributo edad retornado desde la
            //clase Persona


            //PROPIEDAD:
            //Si bien podriamos tener metodos "set" y "get" por cada atributo del objeto creado, C# ofrece una funcionalidad
            //alternativa llamada "propiedad". A modo de ejemplo, se creara una propiedad dentro de la clase "botella"

            Botella b1 = new Botella();
            b1.Capacidad = 250;

            //Lo que esta ocurriendo aca es que se creo un objeto botella llamado b1 y se le asigno un valor al atributo "capacidad"
            //a diferencia del caso anterior en el que al objeto p1 se le asigno el valor edad invocando el metodo "set.Edad()" 
            //introduciendo el valor dentro de los parentesis, gracias a la "propiedad" creada en el objeto botella, simplemente se
            //le asignara al objeto b1 el valor del atributo en cuestion (capacidad, en este caso) como se ve arriba:
            //(objeto.atributo = valor, (este valor sera el "value" recibido en la propiedad).

            //Por otro lado, si lo que se quisiera fuese leer u obtener el valor del atributo en cuestion, simplemente se invocara
            //el metodo.
            //a modo de ejemplo, se creara una variable en la que se guardara el valor del atributo.


            int ejemplo = b1.Capacidad; //La variable "ejemplo" leera el valor del atributo "capacidad" y lo guardara dentro

            //Objeto "Perro"

            Perro pe1 = new Perro();
            pe1.Nombre = "Firulais";
            pe1.Color = "marron";

            Console.WriteLine("El perro se llama " + pe1.getNombre() + " y es de color " + pe1.getColor());

            //Objeto "Articulo"

            Articulo art = new Articulo();


            Console.WriteLine("Ingrese el código del articulo: ");
            art.setCodigo(int.Parse(Console.ReadLine()));
            Console.WriteLine("Ingrese el precio");
            art.setPrecio(int.Parse(Console.ReadLine()));

            Console.WriteLine("El código ingresado es: " + art.getCodigo() + " Y su Precio es: $" + art.getPrecio());

            //Venta

            Venta ve1 = new Venta();

            Console.WriteLine("Se esta generando una nueva venta. Por favor, ingrese el código del articulo: ");
            ve1.CodigoArticulo = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la cantidad a vender");
            ve1.Cantidad = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el código del cliente");
            ve1.CodigoCliente = int.Parse(Console.ReadLine());

            Console.WriteLine("El cliente " + ve1.CodigoCliente + " Compro " + ve1.Cantidad + " unidades del articulo " + ve1.CodigoArticulo);

            Console.ReadKey();

        }
    }
}
