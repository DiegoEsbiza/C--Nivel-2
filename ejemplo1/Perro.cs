using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo1
{
    internal class Perro
    {
        //perro: nombre, color, origen

        private string nombre;
        private string color;
        private string origen;

        //metodos get / set 

        public void setNombre(string n)
        {
            nombre = n;
        }

        public string getNombre()
        {
            return nombre;
        }

        public void setColor(string c) 
        {
            color = c;
        }

        public string getColor() 
        {
            return color;    
        }

        public void setOrigen(string o)
        {
            origen = o;
        }

        public string getOrigen()
        {
            return origen;
        }


        //propiedad

        public string Nombre
        {
            get  { return nombre; }
            set  { nombre = value; }
        }

        public string Color
        {
            get { return color; }
            set { color = value; }
        }

        public string Origen
        {
            get { return origen; }
            set { color = value; }
        }

    }

}
