using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Task_Mult
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Task> lista = new List<Task>();

            lista.Add(Task.Factory.StartNew(Metodo01));
            lista.Add(Task.Factory.StartNew(Metodo01));
            lista.Add(Task.Factory.StartNew(Metodo01));
            lista.Add(Task.Factory.StartNew(Metodo01));

            Task.WaitAll();

            Console.WriteLine("End");
            Console.ReadKey();
        }

        static void Metodo01()
        {
            for (int i = 0; i < 1000; i++)
            {
                Console.WriteLine("Valor: " + i + " Task Id: " + Task.CurrentId);
            }
        }
    }
}
