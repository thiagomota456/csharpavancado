using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Eventos.Lib.Menssageiro
{
    public class Email
    {
        public void EnviarMensagem(Object sender, VideoEventArgs args)
        {
            Console.WriteLine("SMS enviar: " + args.Video.Nome);
        }
    }
}
