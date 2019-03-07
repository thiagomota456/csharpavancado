using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace _04_ThradingBackgraund
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 5; i++)
            {
                Thread t1 = new Thread(ThredRepeticao);

                //Treds fica dependente da Threde principal

                t1.IsBackground = true;
                t1.Start();
            }

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
