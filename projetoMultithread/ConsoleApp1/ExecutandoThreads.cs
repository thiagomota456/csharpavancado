using System.Threading;
namespace ConsoleApp2
{
    public class ExecutandoThreads
    {
        private Thread t;

        public void executar(string text)
        {
            t = new Thread(escreveTeste());
            escreveTeste(text);
        }

        public void escreveThiago()
        {
            Console.WriteLine("Thiago");
        }

        public void escreveTeste(string text)
        {
            Console.WriteLine(text);
        }
    }

}