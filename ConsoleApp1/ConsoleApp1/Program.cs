#define MYTEST
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            #if DEBUG
                Console.WriteLine("Debug version");
            #endif

            #if (DEBUG && !MYTEST)
                Console.WriteLine("DEBUG is defined");
            #elif (!DEBUG && MYTEST)
                Console.WriteLine("MYTEST is defined");
            #elif (DEBUG && MYTEST)
                Console.WriteLine("DEBUG and MYTEST are defined");
            #else
                Console.WriteLine("DEBUG and MYTEST are not defined");
            #endif

            Console.ReadKey();
        }
    }
}
