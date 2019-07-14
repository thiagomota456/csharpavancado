using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace _03_ValidacaoCustomizada
{
    class Program
    {
        static void Main(string[] args)
        {

            Usuario usuario = new Usuario() { Nome = "José", Email = "thiago@gmail.com", Senha = "123456" };

            ValidationContext validationContext = new ValidationContext(usuario);

            List<ValidationResult> validationResults = new List<ValidationResult>();

            if (Validator.TryValidateObject(usuario, validationContext, validationResults, true) == false)
            {
                foreach (var erro in validationResults)
                {
                    Console.WriteLine(erro.ErrorMessage);
                }
            }
            Console.ReadKey();
        }
    }
}
