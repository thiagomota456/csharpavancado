using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_LINK_JOIN
{
    class Livro
    {
        public int Id { get; set; }
        public int AutorId  { get; set; }
        public String Titulo { get; set;  }
        public String AnoDePublicacao { get; set; }
    }
}
