using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_LINQ_OBJ
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Usuario> usuarios = new List<Usuario>();
            usuarios.Add(new Usuario() { Nome = "Jósé", Email = "jose@yahoo.com.br" });
            usuarios.Add(new Usuario() { Nome = "Maria", Email = "maria@gmail.com" });
            usuarios.Add(new Usuario() { Nome = "João", Email = "joao@gmail.com" });
            usuarios.Add(new Usuario() { Nome = "Felipe", Email = "felipe@outlook.com" });
            usuarios.Add(new Usuario() { Nome = "Elias", Email = "elias@gmail.com" });

            var listaFiltrada = usuarios.Where(a => a.Email.Contains("@gmail.com")).OrderBy(a=>a.Nome).Select(a => a);

            foreach (var a in listaFiltrada)
                Console.WriteLine(a.Nome +" "+ a.Email);

            Console.ReadKey();
        }
    }
}
