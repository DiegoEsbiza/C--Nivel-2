using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio1
{
    internal class Contacto
    {
        public Contacto(string nombre, string numeroTelefonico)
        {
            this.nombre = nombre;
            this.numeroTelefonico = numeroTelefonico;
        }

        private string nombre;
        private string numeroTelefonico;
        private string direccion;
        private string correo;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string NumeroTelefonico
        {
            get { return numeroTelefonico; }
            set { numeroTelefonico = value; }
        }

        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }

        public string Correo
        {
            get { return correo; }
            set { correo = value; }
        }

        public string contactar()
        {
            return "Llamando a " + nombre;
        }

        public string contactar(int opcion)
        {
            return "Enviando un mail a " + nombre;
        }
    }
}
