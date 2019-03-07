using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_VarDinamic
{
    class Program
    {
        static void Main(string[] args)
        {
            object t1 = "";
            object t2 = 123456;

            t2 = "";

            var v1 = "";
            var v2 = 123456;

            //ERRO: v2 = "";
            //ERRO var v3;

            dynamic d1 = new Usuario() { Name = "Maria" };

            Console.WriteLine(d1.Name);
            //ERRO DE EXECUÇÃo : Console.WriteLine(d1.Endereço);

            d1 = "";

            Console.ReadKey();

        }
    }
}
