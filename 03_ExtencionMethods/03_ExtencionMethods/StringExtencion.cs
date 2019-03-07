using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_ExtencionMethods
{
    public static class StringExtencion
    {
        public static string FirstToUper(this String str)
        {
            string primeira = str.Substring(0, 1);
           

            string segunda = str.Substring(1);

            return primeira.ToUpper() + segunda;

        }
    }
}
