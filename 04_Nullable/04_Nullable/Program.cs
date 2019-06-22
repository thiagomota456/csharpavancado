using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Nullable
{
    class Program
    {
        static void Main(string[] args)
        {
            //Struct - Por valor
            //int i = null; (ERRO)

            //Classe - Por referencia 
            object o = null;

            // Banco de dado que contem funções opicionais ou que você não tenha 
            //Ex.: Idade
            //A solução é usar o Nullable
            Nullable<int> idade = null;
            //Ou

            int? Idade2 = null;



        }
    }
}
