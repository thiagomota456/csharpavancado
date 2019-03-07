﻿ using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _02_Delegates.Lib; 

namespace _02_Delegates
{
    class Program
    {
        static void Main(string[] args)
        {
            

            //Tela - Cadastro de Usuario: Thumb (Foto de Perfil)
            FotoProcessador.filtroHendler = new FotoFiltro().GerarThumb;
            Foto foto = new Foto { Nome = "Perfil.jpg", TamanhoX = 1920, TamanhoY = 1080 };
            FotoProcessador.Processar(foto);

            //Tela - Cadastro de Produtos: Colorir + TamanhoMed
            FotoProcessador.filtroHendler = new FotoFiltro().Colorir;
            FotoProcessador.filtroHendler += new FotoFiltro().RedimensionarTamMedio;
            Foto foto2 = new Foto { Nome = "Produto.jpg", TamanhoX = 1920, TamanhoY = 1080 };
            FotoProcessador.Processar(foto2);

            //Tela - Cadastro de Albuns do Usuario - Retro: Preto e Branco
            FotoProcessador.filtroHendler = new FotoFiltro().PretoBranco;
            Foto foto3 = new Foto { Nome = "Retro.jpg", TamanhoX = 1920, TamanhoY = 1080 };
            FotoProcessador.Processar(foto3);

            Console.ReadKey();
        }
    }
}
