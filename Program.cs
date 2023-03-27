using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaConsola
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Creamos una lista para nuestra clase

            List<CPunto> listaPuntos = new List<CPunto>();

            listaPuntos.Add(new CPunto(5,3));
            listaPuntos.Add(new CPunto(7, 2));
            listaPuntos.Add(new CPunto(12, 1));
            listaPuntos.Add(new CPunto(6, 2));

            foreach (CPunto punto in listaPuntos)
            {
                Console.WriteLine(punto);
                
            }

            Console.ReadKey();

        }
    }
}
