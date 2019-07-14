using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _00_Biblioteca;
using System.IO;
using System.Xml.Serialization;

namespace _01_SerializarXML
{
    public class Program
    {
        static void Main(String[] args)
        {
            Usuario usuario = new Usuario() { Nome = "José Costa Silva", CPF = "222.222.222-22", Email = "jose@gmail.com" };

            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Usuario));
            //XmlSerializer xmlSerializer = new XmlSerializer(usuario.GetType());

            StreamWriter streamWriter = new StreamWriter(@"C:\Users\thiag\OneDrive\Área de Trabalho\Udemy\csharpavancado\01-Serializar-deserializar\01-Serializar.xml");
            xmlSerializer.Serialize(streamWriter, usuario);
        }
    }
}
