using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_1
{
    internal class Persona
    {
        public Persona(string nombre, string fechaNacimiento, string chocolate, string tipo, string color, string numero)
        {
            this.nombre = nombre;
            this.fechaNacimiento = fechaNacimiento;
            this.chocolate = chocolate;
            this.tipo = tipo;
            this.color = color;
            this.numero = numero;
        }
        public string nombre { get; set; }
        public string fechaNacimiento { get; set; }
        public string chocolate { get; set; }
        public string tipo { get; set; }
        public string color { get; set; }
        public string numero { get; set; }

    }
}
