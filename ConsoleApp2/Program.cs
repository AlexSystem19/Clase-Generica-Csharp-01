using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var precio_producto1 = new Precios<listaprecios>();
            precio_producto1.Precio = new Precio01
            {
                id = 1,
                nombre_producto = "A6"
            };


        }
    }
}
