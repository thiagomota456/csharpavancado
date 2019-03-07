using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace _07_ThredingMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inicio Do Programa");

            //Paralisa Thread atual em milissegundos

            Thread t1 = new Thread(ThredRepeticao);
            t1.Start();

            Thread.Sleep(3000);

            Console.WriteLine("Meio do programa");

            //Faz com que Thred principal aguade ate que a t1 finalize.

            Thread t2 = new Thread(ThredRepeticao);
            t2.Start();
            t2.Join();

            Console.WriteLine("Fim do programa");

            Console.ReadKey();
        }

        static void ThredRepeticao()
        {
            for (int i = 0; i < 1000; i++)
            {
                Console.WriteLine("Num :" + i);
            }
        }
    }
}
