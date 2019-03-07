using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _01_Generics.Modelos;
namespace _01_Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            Carros carros = new Carros() { Marca = "FIAT", Modelo = "Uno" };
            Casa casa = new Casa() {Cidade = "Brasilia", Endereco = "QSQ 400" };
            Usuario usuario = new Usuario() { Nome = "Maria", Email = "maria@gmail.com", Senha = "123456" };

            Serealizar.serealizar(carros);
            Serealizar.serealizar(casa);
            Serealizar.serealizar(usuario);

            Carros carros2 = Serealizar.deserializar<Carros>();
            Casa casa2 = Serealizar.deserializar<Casa>();
            Usuario usuario2 = Serealizar.deserializar<Usuario>();

            Console.WriteLine("Carro2:" + carros2.Marca + " - " + carros2.Modelo);
            Console.WriteLine("Casa2:" + casa2.Cidade + " - " + casa2.Endereco);
            Console.WriteLine("Usuario2:" + usuario2.Nome + " - " + usuario2.Email);

            Console.ReadKey();
        }
    }
}
