using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Telefono t1 = new Telefono("k40 S", "LG");

            t1.NumeroTelefonico = "1131880274";
            t1.CodigoOperador = 1;

            Console.WriteLine("El teléfono creado es: ");
            Console.WriteLine("Modelo " + t1.Modelo + " de la marca " + t1.Marca);
            Console.WriteLine("El número de teléfono es: " + t1.NumeroTelefonico);
            Console.WriteLine("su código de operador es: " + t1.CodigoOperador);

            Console.WriteLine("Se realizara una llamada: ");
            Console.WriteLine(t1.llamar());
            Console.WriteLine("Se realizara otra llamada: ");
            Console.WriteLine(t1.llamar("Bubu"));

            Console.WriteLine("Llamadas finalizadas");

            Contacto angel = new Contacto("Angel", "1144558899");

            Console.WriteLine("Nuevo contacto Creado: " + angel.Nombre);

            angel.Nombre = "Angelito";
            Console.WriteLine("Nombre de contacto modificado, nuevo nombre: " + angel.Nombre);

            angel.Direccion = "Salvador soreda 6371";
            Console.WriteLine("Direccion agregada, " + angel.Nombre + " vive en: " + angel.Direccion);

            angel.Correo = "angelito@correo.com";
            Console.WriteLine("Correo agregado, el mail de " + angel.Nombre + " es: " + angel.Correo);

            Console.WriteLine(angel.contactar());

            Console.WriteLine(angel.contactar(1));

            Console.ReadKey();
        }
    }
}
