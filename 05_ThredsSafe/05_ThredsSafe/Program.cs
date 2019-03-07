
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace _05_ThredsSafe
{
    class Program
    {
        static int Rede = 0;
        static Object VariavelDEControle = 0;

        static void Main(string[] args)
        {
            for (int i = 0; i < 5; i++)
            {
                Thread t1 = new Thread(ThredRepeticao);
                t1.Start();
            }

            Console.ReadKey();
        }


        static void ThredRepeticao()
        {
            for (int i = 0; i < 1000; i++)
            {
                lock (VariavelDEControle)
                {
                    Console.WriteLine("Num :" + i);
                    Rede++;
                }
                
            }
        }
    }
}
