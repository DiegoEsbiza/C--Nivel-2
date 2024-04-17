using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaPOO1
{
    internal class Venta
    {
        //- Número de Cliente(1 a 300).
        //- Código de Artículo(4 dígitos no correlativos).
        //- Mes(1 a 12).
        //- Día(1 a 31).
        //- Cantidad vendida.

        public int NumCliente { get; set; }

        public int CodArticulo { get; set; }
        public int Mes { get; set; }
        public int Dia { get; set; }
        public int Cantidad { get; set; }

    }
}
