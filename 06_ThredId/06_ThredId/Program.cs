using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace _06_ThredId
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 5; i++)
            {
                Thread t1 = new Thread(ThredRepeticao);
                t1.Start(i);
            }

            Console.ReadKey();
        }




        static void ThredRepeticao(object id)
        {
            for (int i = 0; i < 1000; i++)
            {
                Console.WriteLine("Thred_"+ id +"\tNum :" + i + " ID Interno: " + Thread.CurrentThread.ManagedThreadId);
            }
        }
    }
}
