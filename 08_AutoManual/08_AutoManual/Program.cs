using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace _08_AutoManual
{
    class Program
    {
        static ManualResetEvent manualResetEvent;
        static AutoResetEvent autoResetEvent;

        static void Main(string[] args)
        {
            manualResetEvent = new ManualResetEvent(false);
            autoResetEvent = new AutoResetEvent(false);

            //Thread t1 = new Thread(Executa01);
            //t1.Start();

            Thread t2 = new Thread(Executa02);
            t2.Start();

            Thread.Sleep(5000);
            //manualResetEvent.Set();
            //manualResetEvent.Reset();
            autoResetEvent.Set();
            //manualResetEvent.Set();
            autoResetEvent.Set();
            Console.ReadKey();
        }

        static void Executa01()
        {
            Console.WriteLine("01 - Iniciado Executa01.");
            manualResetEvent.WaitOne();
            Console.WriteLine("02 - Em execução 01 Executa01.");
            Console.WriteLine("03 - Em execução 02 Executa01.");
            manualResetEvent.WaitOne();
            Console.WriteLine("04 - Finalizando Executa01");

        }

        static void Executa02()
        {
            Console.WriteLine("01 - Iniciado Executa02.");
            autoResetEvent.WaitOne();
            Console.WriteLine("02 - Em execução 01 Executa02.");
            Console.WriteLine("03 - Em execução 02 Executa02.");
            autoResetEvent.WaitOne();
            Console.WriteLine("04 - Finalizando Executa02");
        }
    }
}
