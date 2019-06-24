using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_LINQ
{
    class Program
    {
        static void Main(string[] args)
        {

            //LINK e LAMBADA
            //Sintaxe alternativa 

            int[] lista = { 3, 9, 4, 6, 20, 10, 60, 90, 80, 50, };

            //var listaSelecionada = lista.Where(a => a > 10).OrderBy(a => a).Select(a => a);
            var listaSelecionada = from a in lista where a > 10 orderby a select a; 

            Console.Write("ListaSelecionada: ");
            foreach (var item in listaSelecionada)
            {
                Console.Write(item + " ");
            }

            Console.ReadKey();
        }
    }
}
