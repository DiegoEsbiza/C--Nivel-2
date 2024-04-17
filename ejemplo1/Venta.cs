using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo1
{
    internal class Venta
    {
        //Venta: código articulo, cantidad, código cliente
        int codigoArticulo;
        int cantidad;
        int codigoCliente;

        public int CodigoArticulo 
        {
            get { return codigoArticulo; }
            set { codigoArticulo = value; }
        }

        public int Cantidad
        {
            get { return cantidad; }
            set { cantidad = value; }
        }

        public int CodigoCliente
        {
            get { return codigoCliente; }
            set { codigoCliente = value; }
        }
    }
}
