using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo1
{
    internal class Articulo
    {
        //Artículo: código, precio
        private int codigo;
        private float precio;
        
        public void setCodigo (int cod)
        {
            codigo = cod;
        }

        public int getCodigo () 
        { 
            return codigo;
        }

        public void setPrecio(int precio)
        {
            this.precio = precio;
        }

        public float getPrecio() 
        {
            return precio;
        }

    }
}
