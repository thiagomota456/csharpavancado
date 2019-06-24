using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_LINK_JOIN
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Autor> listaDeAutores = new List<Autor>();
            listaDeAutores.Add(new Autor() { Id = 1, Nome = "Leonardo" });
            listaDeAutores.Add(new Autor() { Id = 2, Nome = "Maria Maria" });
            listaDeAutores.Add(new Autor() { Id = 3, Nome = "Josef" });

            List<Livro> listaDeLivros = new List<Livro>();
            listaDeLivros.Add(new Livro() { Id = 1, AutorId = 2, Titulo = "Amor amado" });
            listaDeLivros.Add(new Livro() { Id = 2, AutorId = 2, Titulo = "Bem amado" });
            listaDeLivros.Add(new Livro() { Id = 3, AutorId = 3, Titulo = "Um espião em Washigton" });
            listaDeLivros.Add(new Livro() { Id = 4, AutorId = 1, Titulo = "A vida na terra" });

            var ListaJoin = from livros in listaDeLivros join autor in listaDeAutores on livros.AutorId equals autor.Id select new { livros, autor };

            foreach (var item in ListaJoin)
            {
                Console.WriteLine("Livro: "+ item.livros.Titulo + "\tAutor: " + item.autor.Nome);
            }
            Console.ReadKey();
        }
    }
}
