using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Primer lote con 10 registros de productos, cada producto tiene:

                //-Código de articulo (3 digitos no correlativos)
                //-Precio
                //-Código de marca (1 a 10)
            
            //Segundo lote con las ventas de la semana, cada venta tiene:

                //-Código de artículo
                //-Cantidad
                //-Código de cliente
            
            //Este lote corta con codigo de cliente = 0 (CERO)

            //mediante el metodo corto de creación de propiedad, se podran cargar valores como ya se vio anteriormente y tambien
            //leerlos
            Articulo art1 = new Articulo();

            //Al articulo recien creado se le "seteara" el valor 15
            //art1.codigoArticulo = 15;

            //Como la consigna indica, tendremos 10 artículos cada uno con su propio código de marca que ira del 1 al 10.
            //Para guardar los 10 códigos de marca que corresponden a cada artículo, se creara un vector de artículos

            Articulo[] articulos = new Articulo[10]; //Este vector reservara el espacio en memoria, pero estara vacio

            //de esta manera se podra manipular cada uno de los artículos segun su indice:

            articulos[6].CodMarca = 3; //al indice 6 del codigo de marca se le asignara el número 6, el artículo del indice 6
                                       //es el artículo número 6

            //Ahora bien, si quisira cargar este vector de articulos, seria necesario hacerlo con un ciclo "FOR" como se ha hecho
            //Anteriormente, con la diferencia es que aqui se cargaran los objetos con todas y cada una de sus propiedades, como
            //se vera a continuación:

            for (int x = 0; x < 10; x++)
            {
                articulos[x] = new Articulo(); //una vez creado el vecor "articulos" es necesario generar dentro suyo un vector
                                               //nuevo por cada uno de los articulos a ingresar, de esta manera quedaran cargados
                                               //cada uno de los articulos individuales con sus propiedades dentro del articulo
                                               //general

                Console.WriteLine("Ingrese los datos del producto: ");
                Console.WriteLine("Código de artículo: ");
                articulos[x].CodigoArticulo = int.Parse(Console.ReadLine());
                Console.WriteLine("Precio: " );
                articulos[x].Precio = float.Parse(Console.ReadLine());  
                Console.WriteLine("Código de marca: ");
                articulos[x].CodMarca = int.Parse(Console.ReadLine());
            }

            //Con este ciclo el vector ya quedaria cargado con cada uno de los articulos y sus correspondientes atributos

            Venta venta = new Venta();

            Console.WriteLine("Se esta generando una nueva venta");
            Console.WriteLine("Ingrese el código de cliente: ");
            venta.CodigoCliente = int.Parse(Console.ReadLine());

            while (venta.CodigoCliente != 0)
            {
                Console.WriteLine("Ingrese el código de artículo: ");
                venta.CodigoArticulo = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese la cantidad de articulos a vender: ");
                venta.Cantidad = int.Parse(Console.ReadLine());

                //proceso.... si lo hubiere...

                Console.WriteLine("Ingrese un nuevo código de cliente para generar nueva venta o 0 para finalizar");
                
            }

        }
    }
}
