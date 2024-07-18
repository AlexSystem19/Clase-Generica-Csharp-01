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
            var precio_producto1 = new Precios<string>();
            precio_producto1.Precio = "6800 soles";
            Console.WriteLine(precio_producto1.Precio);


            var precio_producto2 = new Precios<int>();
            precio_producto2.Precio = 6800;
            Console.WriteLine(precio_producto2.Precio);
            Console.ReadLine();


        }
    }
}
