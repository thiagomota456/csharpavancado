using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Delegates
{
    class Program
    {
        delegate int Cacula(int a, int b);

        static void Main(string[] args)
        {
            Cacula calc0 = new Cacula(Sum);
            var sum = calc0(10, 20);

            Cacula calc1 = new Cacula(Sub);
            var sub = calc1(20, 10);
            
            /*
            * var sum = Sum(10, 20);
            * var sub = Sub(20, 10);
            */

            Console.WriteLine("Sum = " + sum);
            Console.WriteLine("Sub = " + sub);

            Console.ReadKey();
        }
        
        static int Sum(int num1, int num2)
        {
            return num1 + num2;
        }
        static int Sub(int num1, int num2)
        {
            return num1 - num2;
        }
    }
}
