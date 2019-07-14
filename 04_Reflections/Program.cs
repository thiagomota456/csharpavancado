using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _04_Reflections.Modelo;

namespace _04_Reflections
{
    class Program
    {
        static void Main(string[] args)
        {
            Usuario usuario = new Usuario()
            {
                Nome = "Jose",
                Email = "jose@gmail.com",
                Senha = "123456ab"
            };

            Log.GravarUsuario(usuario.Clone());

            usuario.Nome = "José Costa";

            Log.GravarUsuario(usuario.Clone());

            Carro carro = new Carro() { Marca = "FIAT", Modelo = "UNO" };

            Log.GravarUsuario(carro);

            Log.ApresentarLog();

            Console.WriteLine("Log gravado");

            Console.ReadKey();


        }
    }
}
