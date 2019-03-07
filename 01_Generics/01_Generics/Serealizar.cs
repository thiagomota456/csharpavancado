using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.IO;

namespace _01_Generics
{
    class Serealizar
    {
        public static void serealizar(object obj)
        {
            StreamWriter streamWriter = new StreamWriter(@"C:\Users\Casa\Desktop\Estágio\Curso C# avançado\Arquivo c# avançado\" + obj.GetType() + ".txt");
            JavaScriptSerializer javaScriptSerializer = new JavaScriptSerializer();

            string objSerealizado = javaScriptSerializer.Serialize(obj);

            streamWriter.Write(objSerealizado);
            streamWriter.Close();

        }

        public static T deserializar<T>()
        {
            StreamReader streamReader = new StreamReader(@"C:\Users\Casa\Desktop\Estágio\Curso C# avançado\Arquivo c# avançado\_01_Generics.Modelos." + typeof(T).Name + ".txt");
            string conteudo = streamReader.ReadToEnd();

            JavaScriptSerializer javaScriptSerializer = new JavaScriptSerializer();
            return javaScriptSerializer.Deserialize<T>(conteudo);
        }
    }
}
