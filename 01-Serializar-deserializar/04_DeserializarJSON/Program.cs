using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using _00_Biblioteca;
using System.IO;

namespace _04_DeserializarJSON
{
    class Program
    {
        static void Main(string[] args)
        {

            StreamReader streamReader = new StreamReader(@"C:\Users\thiag\OneDrive\Área de Trabalho\Udemy\csharpavancado\01-Serializar-deserializar\02-Serializar.json");
            string DadosDoObjeto = streamReader.ReadToEnd();
            JavaScriptSerializer javaScriptSerializer = new JavaScriptSerializer();
            Usuario usuario = (Usuario)javaScriptSerializer.Deserialize(DadosDoObjeto, typeof(Usuario));

            Console.WriteLine("Usuario : {0}, CPF : {1}, Email : {2}", usuario.Nome, usuario.CPF, usuario.Email);
            Console.ReadKey();
        }
    }
}