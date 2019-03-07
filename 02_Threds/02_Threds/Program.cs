using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace _02_Threds
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread threadUm = new Thread(ThreadRepete);
            threadUm.Start();
            
            for (int i = 0; i < 1000; i++)
                Console.WriteLine("Número Main: " + i);

            Console.ReadKey();
        }

        static void ThreadRepete()
        {
            for (int i = 0; i < 1000; i++)
                Console.WriteLine("Número: " + i);
        }
    }
}
