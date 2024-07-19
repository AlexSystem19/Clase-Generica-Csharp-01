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
            precio_producto1.Precio = new listaprecios
            {
                id = 1,
                nombre_producto = "alexis"
            };

            Console.Write(precio_producto1.Precio.nombre_producto);
            Console.WriteLine(precio_producto1.Precio.id);
            Console.ReadLine();

        }
    }
}
