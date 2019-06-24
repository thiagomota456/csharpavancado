using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            //LINK e LAMBADA

            int[] lista = { 3, 9, 4, 6, 20,  10, 60, 90, 80, 50, };

            //var listaSelecionada = lista.Where(a => a > 10).Select(a => a);
            var listaSelecionada = lista.Where(a => a > 10).OrderBy(a=>a).Select(a => a);

            foreach(var item in listaSelecionada)
            {
                Console.Write(item + " ");
            }

            Console.ReadKey();
        }
    }
}
