using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Precios <T>
    {

        private T precio_producto01;

        private T precios_promocion ;

        public T Precio
        { 
         get { return precio_producto01; }
         set { precio_producto01 = value; }
        }

        public T PrecioPromocion
        {
            get { return precios_promocion; }
            set { precios_promocion = value; }
        }
    }
}
