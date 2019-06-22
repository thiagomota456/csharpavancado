using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _00_Biblioteca;
using System.IO;
using System.Xml.Serialization;

namespace O2_Deserializar
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Usuario));

            StreamReader streamReader = new StreamReader(@"C:\Users\thiag\OneDrive\Área de Trabalho\Udemy\csharpavancado\01-Serializar-deserializar\01-Serializar.xml");

            Usuario usuario = (Usuario)xmlSerializer.Deserialize(streamReader);

            Console.WriteLine("Usuario : {0}, CPF : {1}, Email : {2}", usuario.Nome, usuario.CPF, usuario.Email);
            Console.ReadKey();

        }
    }
}
