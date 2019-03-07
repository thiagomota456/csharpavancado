using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Eventos.Lib.Menssageiro
{
    class SMS
    {
        public void EnviarMensagem(object sender, VideoEventArgs e)
        {
            Console.WriteLine("SMS enviar: " + e.Video.Nome);
        }
    }
}
