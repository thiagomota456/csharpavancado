using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using _00_Biblioteca;
using System.IO;

namespace _03_SerializarJSON
{
    class Program
    {
        static void Main(string[] args)
        {
            Usuario usuario = new Usuario() { Nome = "Maria Costa Silva", CPF = "333.333.33-00", Email = "maria.costa@gmail.com" };
            JavaScriptSerializer javaScriptSerializer = new JavaScriptSerializer();
            string objetoSerializado = javaScriptSerializer.Serialize(usuario);

            StreamWriter streamWriter = new StreamWriter(@"C:\Users\thiag\OneDrive\Área de Trabalho\Udemy\csharpavancado\01-Serializar-deserializar\02-Serializar.json");
            streamWriter.Write(objetoSerializado);
            streamWriter.Close();
        }
    }
}
