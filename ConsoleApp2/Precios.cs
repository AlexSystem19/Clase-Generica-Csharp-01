using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Precios <T> where T : Precio01
    {

        private T Precio01f;

        public T Precio
        { 
         get { return Precio01f; }
         set { Precio01f = value; }
        }

    }
}


// clase generica que solo acepta una clase